using System;
using System.Globalization;
using System.Windows.Forms;
using DevProLauncher.Helpers;
using System.Collections.Generic;

namespace DevProLauncher.Windows.MessageBoxs
{
    public partial class Host : Form
    {
        public string GameName;

        public Host(bool isranked)
        {
            InitializeComponent();
            ApplyTranslation();

            TimeLimit.SelectedItem = Program.Config.TimeLimit;
            BanList.SelectedItem = Program.Config.BanList;
            Mode.SelectedItem = Program.Config.Mode;
            GameName = LauncherHelper.GenerateString().Substring(0, 5);
            CardRules.SelectedItem = Program.Config.CardRules;
            Prerelease.Checked = Program.Config.EnablePrerelease;
            Priority.Checked = Program.Config.EnablePrority;
            ShuffleDeck.Checked = Program.Config.DisableShuffleDeck;
            CheckDeck.Checked = Program.Config.DisableCheckDeck;
            BanList.Items.AddRange(LauncherHelper.GetBanListArray());
            BanList.SelectedItem = Program.Config.BanList;
            if (BanList.SelectedItem == null && BanList.Items.Count > 0)
                BanList.SelectedIndex = 0;
         
            Mode.SelectedIndexChanged += DuelModeChanged;

            LifePoints.Text = (Mode.SelectedItem.ToString() == "Tag") ? "16000" : "8000";
            if(isranked)
            {
                Prerelease.Enabled = false;
                BanList.Enabled = false;
                Priority.Enabled = false;
                ShuffleDeck.Enabled = false;
                CheckDeck.Enabled = false;
                LifePoints.Enabled = false;
                TimeLimit.Enabled = false;
                PasswordInput.Enabled = false;
            }
                //CardRules.SelectedIndexChanged += CardRulesChanged;
        }

        public Host()
        {
            InitializeComponent();
            ApplyTranslation();

            TimeLimit.SelectedItem = Program.Config.chtTimeLimit;
            Prerelease.Checked = Program.Config.EnablePrerelease;
            BanList.SelectedItem = Program.Config.chtBanList;
            Mode.SelectedItem = Program.Config.chtMode;
            GameName = LauncherHelper.GenerateString().Substring(0,5);
            CardRules.SelectedItem = Program.Config.chtCardRules;
            Priority.Checked = Program.Config.chtEnablePrority;
            ShuffleDeck.Checked = Program.Config.chtDisableShuffleDeck;
            CheckDeck.Checked = Program.Config.chtDisableCheckDeck;
            BanList.Items.AddRange(LauncherHelper.GetBanListArray());
            if (BanList.Items.Count > 0)
            {
                if (BanList.Items.Contains(Program.Config.chtBanList))
                {
                    BanList.SelectedItem = Program.Config.chtBanList;
                }
            }

            Mode.SelectedIndexChanged += DuelModeChanged;

        }

        public void ApplyTranslation()
        {
            if (Program.LanguageManager.Loaded)
            {
                groupBox1.Text = Program.LanguageManager.Translation.hostGb1;
                groupBox2.Text = Program.LanguageManager.Translation.hostGb2;
                label6.Text = Program.LanguageManager.Translation.hostTimeLimit;
                TimeLimit.Items.Clear();
                TimeLimit.Items.AddRange(new object[] {
                "2 "+Program.LanguageManager.Translation.GameMinutes,
                "1 "+Program.LanguageManager.Translation.GameMinutes});

                label5.Text = Program.LanguageManager.Translation.hostBanlist;
                label3.Text = Program.LanguageManager.Translation.hostRules;

                label4.Text = Program.LanguageManager.Translation.hostMode;
                Mode.Items.Clear();
                Mode.Items.AddRange(new object[] {
                Program.LanguageManager.Translation.GameSingle,
                Program.LanguageManager.Translation.GameTag,
                Program.LanguageManager.Translation.GameMatch
                });

                Priority.Text = Program.LanguageManager.Translation.hostPrio;
                Prerelease.Text = Program.LanguageManager.Translation.hostPrerelease;
                CheckDeck.Text = Program.LanguageManager.Translation.hostCheckDeck;
                ShuffleDeck.Text = Program.LanguageManager.Translation.hostShuffle;
                label1.Text = Program.LanguageManager.Translation.hostLifep;
                HostBtn.Text = Program.LanguageManager.Translation.hostBtnHost;
                CancelBtn.Text = Program.LanguageManager.Translation.hostBtnCancel;
                label2.Text = Program.LanguageManager.Translation.hostpassword;
            }
        }

        private void CardRulesChanged(object sender, EventArgs e)
        {
            if (CardRules.SelectedIndex >= 3)
            {
                BanList.SelectedIndex = 2;
                BanList.Enabled = false;
            }
            else
            {
                BanList.Enabled = true;
                BanList.SelectedItem = Program.Config.BanList;
            }
        }

        public void FormatChanged(object sender, EventArgs e)
        {
            if (CardRules.SelectedItem.ToString() == "TCG")
            {
                if (BanList.Items.Count > 0)
                    BanList.SelectedIndex = 0;
            }
            else
            {
                if (BanList.Items.Count > 1)
                    BanList.SelectedIndex = 1;
            }


        }

        private void DuelModeChanged(object sender, EventArgs e)
        {
            LifePoints.Text = (Mode.SelectedItem.ToString() == "Tag") ? "16000" : "8000";
        }

        public string GenerateURI(bool isranked)
        {
            string gamestring;
            int rules = 0;

            Dictionary<string, int> rulesDict = new Dictionary<string, int>() { 
               {"OCG" , 0}
               ,{"TCG" , 1}
               ,{"OCG/TCG" , 2}
               ,{"2099" , 8}
            };

            rules = rulesDict[CardRules.Text];

            if(Prerelease.Checked)
                rules  |= 0x4;
            gamestring = rules.ToString();
            if (Mode.Text == "Single")
                gamestring = gamestring + "0";
            else if (Mode.Text == "Match")
                gamestring = gamestring + "1";
            else
                gamestring = gamestring + "2";

            gamestring += (TimeLimit.SelectedIndex == -1 ? "0" : TimeLimit.SelectedIndex.ToString(CultureInfo.InvariantCulture));

            if ((Priority.Checked))
                gamestring = gamestring + "T";
            else
                gamestring = gamestring + "O";
            if ((CheckDeck.Checked))
                gamestring = gamestring + "T";
            else
                gamestring = gamestring + "O";
            if ((ShuffleDeck.Checked))
                gamestring = gamestring + "T";
            else
                gamestring = gamestring + "O";

            int banlistvalue = BanList.SelectedItem == null ? 0 : LauncherHelper.GetBanListValue(BanList.SelectedItem.ToString());

            gamestring = gamestring + LifePoints.Text + "," + banlistvalue + ",5,1," + (isranked ? "R" : "U") + (PasswordInput.Text == "" ? "" : "L") + "," + (PasswordInput.Text == "" ? GameName : PasswordInput.Text);

            return gamestring;
        }
    }
}
