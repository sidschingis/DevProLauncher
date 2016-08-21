﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevProLauncher.Windows;
using DevProLauncher.Network;
using DevProLauncher.Network.Data;
using DevProLauncher.Config;
using System.IO;
using System.Xml.Serialization;
using System.Net;
using System.Diagnostics;
using DevProLauncher.Windows.MessageBoxs;
using DevProLauncher.Helpers;

namespace DevProLauncher
{
    static class Program
    {
        public const string Version = "210411";
        public static Configuration Config;
        public static LanguageManager LanguageManager;
        public static ChatClient ChatServer;
        public static UserData UserInfo;
        public static int LoginKey = 0;
#if DEBUG
        public const string ConfigurationFilename = "launcher_debug.conf";
#else
        public const string ConfigurationFilename = "launcher.conf";
#endif
        // official servers
        public static Dictionary<string, ServerInfo> ServerList = new Dictionary<string, ServerInfo>();
        // 3rd party servers
        public static Dictionary<string, ServerInfo> ServerList3P = new Dictionary<string, ServerInfo>();
        public static MainFrm MainForm;
        public static ServerInfo Server;
        public static Dictionary<string,ServerInfo> CheckmateServerList = new Dictionary<string,ServerInfo>();
        public static Random Rand = new Random();        

        [STAThread]
        static void Main()
        {
            LoadConfig(ConfigurationFilename);
#if !DEBUG
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
#endif
            //new update server - Forced change to prevent reseting a users config
            Config.UpdaterAddress = "/launcher/version.php";
            Config.ServerInfoAddress = "/launcher/server.php";

            LanguageManager = new LanguageManager();  
            LanguageManager.Load(Config.Language);
#if !DEBUG
            if (LauncherHelper.CheckInstance())
                if (MessageBox.Show(LanguageManager.Translation.pmsbProgRun) == DialogResult.OK)
                    return;
#endif
            ChatServer = new ChatClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CheckmateServerList.Add("Checkmate USA+CN", new ServerInfo("Checkmate USA+CN", "173.224.211.158", 21001));
            CheckmateServerList.Add("Checkmate EU",new ServerInfo("Checkmate EU", "94.247.40.146", 7980));

            if (LauncherHelper.TestConnection())
            {
#if !DEBUG
                
                if (NewUpdateCheck())
                    return;
                if (!CheckServerInfo("http://158.69.116.140"))
                    CheckServerInfo("http://en.ygodevpro.com/");
                 
#endif
            }
            else MessageBox.Show("An internet connection is required to play online.");
#if DEBUG
            //Config.ServerAddress = "158.69.116.140";
            //Config.ChatPort = 9933;
            Server = new ServerInfo("DevPro", "127.0.0.1", 3333);
#endif
            MainForm = new MainFrm();
            Application.Run(MainForm);
        }

        public static void SaveConfig(string filename, Configuration config)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                TextWriter textWriter = new StreamWriter(filename);
                serializer.Serialize(textWriter, config);
                textWriter.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Saving " + filename);
            }
        }

        public static void LoadConfig(string filename)
        {
            if (!File.Exists(filename))
            {
                Config = new Configuration();
                SaveConfig(filename, Config);
            }
            else
            {
                try
                {
                    var deserializer = new XmlSerializer(typeof(Configuration));
                    TextReader textReader = new StreamReader(filename);
                    Config = (Configuration)deserializer.Deserialize(textReader);
                    textReader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Loading " + filename);
                }
            }
        }

        public static bool NewUpdateCheck()
        {
            switch(CheckUpdates(Program.Config.ServerAddress))
            {
                case 0:
                    return (CheckUpdates(Program.Config.ServerAddress) == 2);
                case 2:
                    return true;
                default:
                    return false;
            }
        }

        public static int CheckUpdates(string url)
        {
            string updateLink = Config.UpdaterAddress;
            const string updaterName = "YgoUpdater.exe";
            const string dllName = "ICSharpCode.SharpZipLib.dll";
            var client = new WebClient { Proxy = null };
            string result;
            try
            {
                string downloadlink ="http://"+ url + updateLink + "?v=" + Version;
                result = client.DownloadString(downloadlink);
            }
            catch
            {
                return 0;
            }


            if (result.Equals("OK"))
                return 1;

            if (result.Equals("KO"))
            {
                if(MessageBox.Show(LanguageManager.Translation.pMsbOldVers,
"Update DevPro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                { Process.Start("https://en.ygodevpro.com/"); };
            }

            if (!result.StartsWith("KO"))
            {
                return 0;
            }

            if (result.Contains("|"))
            {
                string updaterPath = Path.GetTempPath();
                Config.NewUpdate = true;
                SaveConfig(ConfigurationFilename, Config);

                string[] data = result.Split(new [] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                File.WriteAllBytes(Path.Combine(updaterPath, updaterName), Properties.Resources.YgoUpdater);
                File.WriteAllBytes(Path.Combine(updaterPath, dllName), Properties.Resources.ICSharpCode_SharpZipLib);

                var updateProcess = new Process
                    {
                        StartInfo =
                            {
                                FileName = Path.Combine(updaterPath, updaterName),
                                Arguments =
                                    data[1] + " " +
                                    System.Reflection.Assembly.GetExecutingAssembly().Location
                            }
                    };
                updateProcess.Start();
            }

            return 2;
        }

        public static bool CheckServerInfo(string url)
        {
            string updateLink = Config.ServerInfoAddress;
            var client = new WebClient { Proxy = null };
            string result;
            try
            {
                result = client.DownloadString(url + updateLink + "?v=" + Version);
            }
            catch
            {
                return false;
            }
            if (result.Equals("KO"))
                return false;

            if (!result.StartsWith("OK"))
                return false;

            try
            {
                
                string[] serverinfo = result.Split(new [] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                Config.ServerAddress = serverinfo[1];
                Config.ChatPort = int.Parse(serverinfo[2]);
                Config.GamePort = int.Parse(serverinfo[3]);
                Server = new ServerInfo("DevPro",serverinfo[1],int.Parse(serverinfo[4]));
                //CheckmateServerList.Clear();
                //if(!CheckmateServerList.ContainsKey("Checkmate"))
                //    CheckmateServerList.Add("Checkmate",new ServerInfo("Checkmate", serverinfo[5], int.Parse(serverinfo[6])));
            }
            catch
            {
                MessageBox.Show("Incorrect server string format");
                return false;
            }

            return true;
        }

        public static void ChangeUsername(string username)
        {
            UserInfo.username = username;
            MainForm.UpdateUsername();
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception ?? new Exception();

            File.WriteAllText("crash_" + DateTime.UtcNow.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt", exception.ToString());

            var error = new ErrorReportFrm(exception);
            error.ShowDialog();

            Console.WriteLine(exception.ToString());
            Process.GetCurrentProcess().Kill();
        }

    }
}
