using DevProLauncher.Config;
using DevProLauncher.Helpers;
using DevProLauncher.Network.Data;
using DevProLauncher.Network.Enums;
using ServiceStack.Text;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DevProLauncher.Windows.MessageBoxs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            Program.ChatServer.ChangeReply += ChangeResponse;

            Username.Text = Program.Config.DefaultUsername;
            FormClosing += ResetEvents;

            Antialias.Text = Program.Config.Antialias.ToString(CultureInfo.InvariantCulture);
            EnableMusic.Checked = Program.Config.EnableMusic;
            EnableSound.Checked = Program.Config.EnableSound;
            EnableLauncherSound.Checked = Program.Config.EnableLauncherSound;
            Enabled3d.Checked = Program.Config.Enabled3D;
            GameFont.Text = Program.Config.GameFont;
            FontSize.Value = Program.Config.FontSize;
            AutoPlacing.Checked = Program.Config.AutoPlacing;
            RandomPlacing.Checked = Program.Config.RandomPlacing;
            AutoChain.Checked = Program.Config.AutoChain;
            NoDelay.Checked = Program.Config.NoChainDelay;
            EnableSleeveLoading.Checked = Program.Config.EnableCustomSleeves;
            MuteOpp.Checked = Program.Config.MuteOpponent;
            MuteSpectators.Checked = Program.Config.MuteSpectators;
            SaveReplay.Checked = Program.Config.SaveReplay;
            MouseMode.Checked = Program.Config.MouseMode;
            HideSetname.Checked = Program.Config.HideSetname;
            ChainButtons.Checked = Program.Config.ChainButtons;
            old_replay_mode.Checked = Program.Config.old_replay_mode;

            MusicVolume.Enabled = EnableMusic.Checked;
            MusicVolume.Value = Program.Config.MusicVolume;

            SoundVolume.Enabled = EnableSound.Checked;
            SoundVolume.Value = Program.Config.SoundVolume;

            if (Directory.Exists(Program.Config.LauncherDir + "skins/"))
            {
                string[] folders = Directory.GetDirectories(Path.Combine(Program.Config.LauncherDir, "skins\\"));
                foreach (var folder in folders)
                    SkinList.Items.Add(Path.GetFileName(folder));
            }

            if (SkinList.Items.Count > Program.Config.Skin + 1)
                SkinList.SelectedIndex = Program.Config.Skin + 1;

            if (Directory.Exists(Program.Config.LauncherDir + "deck/"))
            {
                string[] decks = Directory.GetFiles(Program.Config.LauncherDir + "deck/");
                foreach (string deck in decks)
                    DefualtDeck.Items.Add(Path.GetFileNameWithoutExtension(deck));
            }
            DefualtDeck.Text = Program.Config.DefaultDeck;

            if (Program.UserInfo == null)
                accountTab.Enabled = false;

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            if (Program.LanguageManager.Loaded)
            {
                LanguageInfo info = Program.LanguageManager.Translation;

                this.Text = info.optionTitle;
                GameTab.Text = info.optionGameTab;
                groupBox1.Text = info.optionGb1;
                groupBox2.Text = info.optionGb2;
                groupBox3.Text = info.optionGb3;
                groupBox4.Text = info.optionGb4;
                groupBox5.Text = info.optionGb5;
                label1.Text = info.optionUser;
                label5.Text = info.optionDeck;
                label6.Text = info.optionAntialias;
                EnableSound.Text = info.optionCbSound;
                EnableMusic.Text = info.optionCbMusic;
                EnableLauncherSound.Text = info.optionCbLauncherSound;
                Enabled3d.Text = info.optionCbDirect;
                label2.Text = info.optionTexts;
                label3.Text = info.optionTextf;
                QuickSettingsBtn.Text = info.optionBtnQuick;
                SaveBtn.Text = info.optionBtnSave;
                CancelBtn.Text = info.optionBtnCancel;
                AutoPlacing.Text = info.optionCbAutoPlacing;
                RandomPlacing.Text = info.optionCbRandomPlacing;
                AutoChain.Text = info.optionCbAutoChain;
                NoDelay.Text = info.optionCbNoChainDelay;
                EnableSleeveLoading.Text = info.optionCbEnableSleeves;
                MuteOpp.Text = info.optionMuteOpp;
                MuteSpectators.Text = info.optionMuteSpec;
                SaveReplay.Text = info.optionSaveReplay;
                MouseMode.Text = info.optionMouseMode;
                HideSetname.Text = info.optionHideSetname;
                ChainButtons.Text = info.optionChainButtons;
                old_replay_mode.Text = info.optionOldReplay;

                accountTab.Text = info.optionAccountTab;
                label7.Text = info.optionCurrentPW;
                label8.Text = info.optionNewPW;
                label9.Text = info.optionConfirmPW;
                emailLbl.Text = info.optionEmail;
                confirmEmailLbl.Text = info.optionconfirmEmail;
                UpdateBtn.Text = info.optionUpdatePW;

                LanguageInfo lang = info;

                RequestSettingsbtn.Text = lang.chatoptionsBtnRequestSettings;
                SaveBtn.Text = lang.chatoptionsBtnSave;
                CancelBtn.Text = lang.chatoptionsBtnCancel;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Program.Config.DefaultDeck = DefualtDeck.Text;
            Program.Config.DefaultUsername = Username.Text;
            Program.Config.Antialias = Convert.ToInt32(Antialias.Text);
            Program.Config.EnableSound = EnableSound.Checked;
            Program.Config.EnableLauncherSound = EnableLauncherSound.Checked;
            Program.Config.SoundVolume = SoundVolume.Value;
            Program.Config.EnableMusic = EnableMusic.Checked;
            Program.Config.MusicVolume = MusicVolume.Value;
            Program.Config.Enabled3D = Enabled3d.Checked;
            Program.Config.FontSize = (int)FontSize.Value;
            Program.Config.GameFont = GameFont.Text;
            Program.Config.Skin = SkinList.SelectedIndex == -1 ? -1 : SkinList.SelectedIndex - 1;
            Program.Config.AutoPlacing = AutoPlacing.Checked;
            Program.Config.RandomPlacing = RandomPlacing.Checked;
            Program.Config.AutoChain = AutoChain.Checked;
            Program.Config.NoChainDelay = NoDelay.Checked;
            Program.Config.EnableCustomSleeves = EnableSleeveLoading.Checked;
            Program.Config.MuteOpponent = MuteOpp.Checked;
            Program.Config.MuteSpectators = MuteSpectators.Checked;
            Program.Config.SaveReplay = SaveReplay.Checked;
            Program.Config.MouseMode = MouseMode.Checked;
            Program.Config.HideSetname = HideSetname.Checked;
            Program.Config.ChainButtons = ChainButtons.Checked;
            Program.Config.old_replay_mode = old_replay_mode.Checked;

            Program.SaveConfig(Program.ConfigurationFilename, Program.Config);
            DialogResult = DialogResult.OK;
        }

        private void QuickSettingsBtn_Click(object sender, EventArgs e)
        {
            var form = new Host(false)
            {
                Text = Program.LanguageManager.Translation.QuickHostSetting,
                HostBtn = { Text = Program.LanguageManager.Translation.QuickHostBtn }
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                Program.Config.CardRules = form.CardRules.Text;
                Program.Config.Mode = form.Mode.Text;
                Program.Config.EnablePrority = form.Priority.Checked;
                Program.Config.DisableCheckDeck = form.CheckDeck.Checked;
                Program.Config.DisableShuffleDeck = form.ShuffleDeck.Checked;
                Program.Config.Lifepoints = form.LifePoints.Text;
                Program.Config.BanList = form.BanList.Text;
                Program.Config.TimeLimit = form.TimeLimit.Text;
                Program.Config.EnablePrerelease = form.Prerelease.Checked;
            }
        }

        private void RequestSettingsbtn_Click(object sender, EventArgs e)
        {
            var form = new Host
            {
                Text = Program.LanguageManager.Translation.chatoptionsRequestFormText,
                HostBtn = { Text = Program.LanguageManager.Translation.chatoptionsBtnSave },
                ShuffleDeck = { Enabled = false },
                CheckDeck = { Enabled = false },
                Priority = { Enabled = true },
                LifePoints = { Enabled = false }
            };
            form.Mode.Items.Remove("Tag");

            if (form.ShowDialog() == DialogResult.OK)
            {
                Program.Config.chtCardRules = form.CardRules.Text;
                Program.Config.chtMode = form.Mode.Text;
                Program.Config.chtEnablePrority = form.Priority.Checked;
                Program.Config.chtDisableCheckDeck = form.CheckDeck.Checked;
                Program.Config.chtDisableShuffleDeck = form.ShuffleDeck.Checked;
                Program.Config.chtLifepoints = form.LifePoints.Text;
                Program.Config.chtBanList = form.BanList.Text;
                Program.Config.chtTimeLimit = form.TimeLimit.Text;
                Program.Config.EnablePrerelease = form.Prerelease.Checked;
            }
        }

        private void UpdatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPassword.Text) || string.IsNullOrEmpty(newPassword.Text) && string.IsNullOrEmpty(emailInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.optionEmptyMsg);
                return;
            }

            if (!string.IsNullOrEmpty(newPassword.Text))
            {
                if (newPassword.Text != confirmPassword.Text)
                {
                    MessageBox.Show("New password does not match the confirm password.");
                    return;
                }

                Program.ChatServer.SendPacket(DevServerPackets.UpdatePassword,
                    JsonSerializer.SerializeToString(
                    new LoginRequest()
                    {
                        Username = Program.UserInfo.username,
                        Password = LauncherHelper.EncodePassword(currentPassword.Text),
                        UID = LauncherHelper.EncodePassword(newPassword.Text)
                    }));
            }
            if (!string.IsNullOrEmpty(emailInput.Text))
            {
                if (emailInput.Text != confirmEmailInput.Text)
                {
                    MessageBox.Show("New email does not match the confirm email.");
                    return;
                }

                Program.ChatServer.SendPacket(DevServerPackets.UpdateEmail,
                    JsonSerializer.SerializeToString(
                    new EmailRequest()
                    {
                        Username = Program.UserInfo.username,
                        Password = LauncherHelper.EncodePassword(currentPassword.Text),
                        Email = emailInput.Text,
                        UID = LauncherHelper.GetUID()
                    }));
            }
            UpdateBtn.Enabled = false;
        }

        private void ChangeResponse(DevClientPackets packet)
        {
            if (!IsDisposed)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<DevClientPackets>(ChangeResponse), packet);
                    return;
                }
                if (packet == DevClientPackets.ChangeAccept)
                {
                    if (MessageBox.Show(Program.LanguageManager.Translation.ChangeAccept) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                else if (packet == DevClientPackets.ChangeFailed)
                {
                    MessageBox.Show(Program.LanguageManager.Translation.ChangeFailed);
                }
                UpdateBtn.Enabled = true;
            }
        }

        private void ResetEvents(object sender, EventArgs e)
        {
            Program.ChatServer.ChangeReply -= ChangeResponse;
        }

        private void EnableMusic_CheckedChanged(object sender, EventArgs e)
        {
            MusicVolume.Enabled = EnableMusic.Checked;
        }

        private void EnableSound_CheckedChanged(object sender, EventArgs e)
        {
            SoundVolume.Enabled = EnableSound.Checked;
        }
    }
}