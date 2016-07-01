using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevProLauncher.Helpers;
using System.Diagnostics;
using System.IO;
using DevProLauncher.Config;
using DevProLauncher.Network.Enums;
using DevProLauncher.Network.Data;
using ServiceStack.Text;
using DevProLauncher.Windows.MessageBoxs;
using DevProLauncher.Windows.Components;
using System.Drawing;
using System.Threading;

namespace DevProLauncher.Windows
{
    public sealed partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            Visible = true;

            Program.ChatServer.LoginReply += LoginResponse; 
            //Program.ChatServer.ValidateReply += ValidateResponse;

            usernameInput.Text = Program.Config.DefaultUsername;

            if (Directory.Exists(LanguageManager.Path))
            {
                string[] languages = Directory.GetDirectories(LanguageManager.Path);
                foreach (string language in languages)
                {
                    string[] split = language.Split('/');
                    if (split.Length > 1)
                        languageSelect.Items.Add(split[1]);
                }

                languageSelect.SelectedItem = Program.Config.Language;
                languageSelect.SelectedIndexChanged += LanguageSelect_SelectedIndexChanged;
            }
            else
            {
                languageSelect.Items.Add("English");
                languageSelect.SelectedIndex = 0;
            }

            usernameInput.KeyDown += UsernameInput_KeyDown;
            passwordInput.KeyDown += PasswordInput_KeyDown;

            PatchNotes.ScriptErrorsSuppressed = true;
            //PatchNotes.Dock = DockStyle.Fill;

            Thread adthread = new Thread(ShowAd) { IsBackground = true };
            adthread.Start();

            ApplyTranslation();

            if (Program.Config.SavePassword && !string.IsNullOrEmpty(Program.Config.EncodedPassword))
            {
                savePassCheckBox.Checked = true;
                passwordInput.Text = Program.Config.EncodedPassword;
                usernameInput.Text = Program.Config.SavedUsername;
            }

        }

        public bool Connect()
        {
            return Program.ChatServer.Connect(Program.Config.ServerAddress, Program.Config.ChatPort);

        }

        public void ApplyTranslation()
        {
            if (Program.LanguageManager.Loaded)
            {
                label1.Text = Program.LanguageManager.Translation.LoginUserName;
                label2.Text = Program.LanguageManager.Translation.LoginPassWord;
                label3.Text = Program.LanguageManager.Translation.LoginLanguage;
                loginBtn.Text = Program.LanguageManager.Translation.LoginLoginButton;
                registerBtn.Text = Program.LanguageManager.Translation.LoginRegisterButton;
                validateBtn.Text = Program.LanguageManager.Translation.LoginValidateButton;
                recoverBtn.Text = Program.LanguageManager.Translation.LoginRecoverButton;
                savePassCheckBox.Text = Program.LanguageManager.Translation.LoginSavePass;
            }
        }
        private void ShowAd()
        {
            try
            {

                //PatchNotes.Navigate("http://en.ygodevpro.com/launcher/indexlauncher.php", false);

                //string loc = LauncherHelper.GetLocation();

                //if (!LauncherHelper.IsEuropeanLocation(loc))
                //    return;
                Image image;
                string lang;
                switch (Program.Config.Language.ToLower())
                {
                    case "german":
                        image = Properties.Resources.cardmarketDE;
                        lang = "de";
                        break;
                    case "spanish":
                        image = Properties.Resources.cardmarketES;
                        lang = "es";
                        break;
                    case "french":
                        image = Properties.Resources.cardmarketFR;
                        lang = "fr";
                        break;
                    case "italian":
                        image = Properties.Resources.cardmarketIT;
                        lang = "it";
                        break;
                    default:
                        image = Properties.Resources.cardmarketEN;
                        lang = "en";
                        break;
                }      
            
                this.BeginInvoke((MethodInvoker) delegate {
                    var item = new Banner("tcgmarket", "http://158.69.116.140/web-devpro/linktracker.php?lang="+lang, image);
                    item.Dock = DockStyle.Right;
                    AdPanel.Controls.Add(item, 0, 0);
                });
                
            }
            catch 
            {

            }
        }

        /*deprecated*/
        private void WebRedirect(object sender, CancelEventArgs e)
        {
            try
            {
                var webbrowser = (WebBrowser) sender;
                if(!webbrowser.StatusText.StartsWith("http://en.ygodevpro.com/"))
                {
                    e.Cancel = true;
                    Process.Start(webbrowser.StatusText);
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void UsernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void LanguageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Config.Language = languageSelect.SelectedItem.ToString();
            Program.SaveConfig(Program.ConfigurationFilename, Program.Config);
            Program.LanguageManager.Load(languageSelect.SelectedItem.ToString());
            if (!LoadBtn.Enabled)
            {
                PatchNotes.Navigate(languageSelect.SelectedItem.ToString() == "German"
                                        ? "http://de.ygodevpro.com/category/patch-notes/"
                                        : "http://en.ygodevpro.com/category/patch-notes/");
            }
            ApplyTranslation();
            Program.MainForm.ReLoadLanguage();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!Program.ChatServer.Connected())
            {
                if (!Connect())
                {
                    MessageBox.Show(Program.LanguageManager.Translation.pMsbErrorToServer);
                    return;
                }
            }

            loginBtn.Enabled = false;
            if (usernameInput.Text == "")
            {
                MessageBox.Show(Program.LanguageManager.Translation.LoginMsb2);
                return;
            }
            if (passwordInput.Text == "")
            {
                MessageBox.Show(Program.LanguageManager.Translation.LoginMsb3);
                return;
            }

            bool encoded = (!string.IsNullOrEmpty(Program.Config.EncodedPassword) &&
                            passwordInput.Text == Program.Config.EncodedPassword &&
                            savePassCheckBox.Checked);
            Program.ChatServer.SendPacket(DevServerPackets.Login,
            JsonSerializer.SerializeToString(
            new LoginRequest { Username = usernameInput.Text, Password = (encoded ? passwordInput.Text:LauncherHelper.EncodePassword(passwordInput.Text)), UID = LauncherHelper.GetUID(), Version = Convert.ToInt32(Program.Version)}));
        }
        private void ValidateResponse(DevClientPackets type, LoginData data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<DevClientPackets, LoginData>(ValidateResponse), type, data);
                return;
            }
        }
        private void LoginResponse(DevClientPackets type, LoginData data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<DevClientPackets, LoginData>(LoginResponse), type, data);
                return;
            }
            else if (type == DevClientPackets.LoginFailed)
            {
                loginBtn.Enabled = true;
                MessageBox.Show(Program.LanguageManager.Translation.LoginFailed);
            }
            else if (type == DevClientPackets.Invalid)
            {
                loginBtn.Enabled = true;
                MessageBox.Show(Program.LanguageManager.Translation.LoginInvalid);
            }
            else
            {
                if (Program.UserInfo == null)
                {
                    Program.UserInfo = new UserData
                        {
                            rank = data.UserRank,
                            username = data.Username,
                            team = data.Team,
                            teamRank = data.TeamRank
                        };
                    Program.LoginKey = data.LoginKey;
                    Program.MainForm.Login();
                    
                    if (savePassCheckBox.Checked)
                    {
                        if (!Program.Config.SavePassword || Program.Config.SavedUsername != usernameInput.Text)
                        {
                            Program.Config.SavePassword = true;
                            Program.Config.SavedUsername = usernameInput.Text;
                            Program.Config.EncodedPassword = LauncherHelper.EncodePassword(passwordInput.Text);
                            Program.SaveConfig(Program.ConfigurationFilename, Program.Config);
                        }
                    }
                    else
                    {
                        if (Program.Config.SavePassword)
                        {
                            Program.Config.SavePassword = false;
                            Program.Config.EncodedPassword = string.Empty;
                            Program.SaveConfig(Program.ConfigurationFilename, Program.Config);
                        }
                    }
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!Program.ChatServer.Connected())
            {
                if (!Connect())
                {
                    MessageBox.Show(Program.LanguageManager.Translation.pMsbErrorToServer);
                    return;
                }
            }

            var form = new RegisterFrm();
            form.ShowDialog();
        }

        private void PasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (loginBtn.Enabled)
                    loginBtn_Click(sender, null);
                else
                    MessageBox.Show("Not connected to server.");
        }


        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadBtn.Visible = false;
            LoadBtn.Enabled = false;
            PatchNotes.Navigate(languageSelect.SelectedItem.ToString() == "German"
                        ? "http://de.ygodevpro.com/category/patch-notes/"
                        : "http://en.ygodevpro.com/category/patch-notes/");
            //PatchNotes.Navigating += WebRedirect;
            adBox.Visible = false;
            //AdPanel.Visible = false;
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            if (!Program.ChatServer.Connected())
            {
                if (!Connect())
                {
                    MessageBox.Show(Program.LanguageManager.Translation.pMsbErrorToServer);
                    return;
                }
            }

            var form = new Validate_frm();
            form.ShowDialog();
        }

        private void recoverBtn_Click(object sender, EventArgs e)
        {
            if (!Program.ChatServer.Connected())
            {
                if (!Connect())
                {
                    MessageBox.Show(Program.LanguageManager.Translation.pMsbErrorToServer);
                    return;
                }
            }

            var form = new Recover_frm();
            form.ShowDialog();
        }

    }
}
