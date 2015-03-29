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
                savePassCheckBox.Text = Program.LanguageManager.Translation.LoginSavePass;
            }
        }
        private void ShowAd()
        {
            try
            {

                //PatchNotes.Navigate("http://ygopro.de/launcher/indexlauncher.php", false);

                //string loc = LauncherHelper.GetLocation();

                //if (!LauncherHelper.IsEuropeanLocation(loc))
                //    return;
                Image image;
                Image image1;

                switch (Program.Config.Language.ToLower())
                {
                    case "german":
                        image = Properties.Resources.cardmarketDE;
                        image1 = Properties.Resources.HEX_DE1;
                        break;
                    case "spanish":
                        image = Properties.Resources.cardmarketES;
                        image1 = Properties.Resources.HEX_EN1;
                        break;
                    case "french":
                        image = Properties.Resources.cardmarketFR;
                        image1 = Properties.Resources.HEX_FR1;
                        break;
                    case "italian":
                        image = Properties.Resources.cardmarketIT;
                        image1 = Properties.Resources.HEX_EN1;
                        break;
                    default:
                        image = Properties.Resources.cardmarketEN;
                        image1 = Properties.Resources.HEX_EN1;
                        break;
                }      
            
                this.BeginInvoke((MethodInvoker) delegate {
                   var item = new Banner("tcgmarket", "http://ygopro.de/launcher/werbung/linktrackercheck.php?tcgmarket=bannerheader" , image);
                   item.Dock = DockStyle.Right;
                   AdPanel.Controls.Add(item, 0, 0);
                });
                this.BeginInvoke((MethodInvoker)delegate
                {
                   var item1 = new Banner("hex", "http://ygopro.de/launcher/werbung/Gameforge/tracker.php", image1); 
                   item1.Dock = DockStyle.Right;
                   AdPanel1.Controls.Add(item1, 0, 0);
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
                if (!webbrowser.StatusText.StartsWith("http://ygopro.de"))
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
                                        ? "http://ygopro.de/en/category/"
                                        : "http://ygopro.de/en/category/patch-notes/");
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

            if (type == DevClientPackets.Banned)
            {
                MessageBox.Show(Program.LanguageManager.Translation.LoginBanned);
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
            else if (type == DevClientPackets.InvalidTemp)
            {
                loginBtn.Enabled = true;
                if (Program.LanguageManager.language=="German")
                    MessageBox.Show("Bitte validiere deinen Account bis zum 14. Februar 2015 oder er wird gelöscht.");
                else
                    MessageBox.Show("Remember to validate your account until the 14th February 2015 or your account will be deleted.");
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

        private void CheckmateBtn_Click(object sender, EventArgs e)
        {
            LauncherHelper.chkmate_btn_Click(sender, e);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadBtn.Visible = false;
            LoadBtn.Enabled = false;
            PatchNotes.Navigate(languageSelect.SelectedItem.ToString() == "German"
                        ? "http://ygopro.de/en/category/"
                        : "http://ygopro.de/en/category/patch-notes/");
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
