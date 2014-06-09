using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DevProLauncher.Network.Data;
using DevProLauncher.Network.Enums;
using DevProLauncher.Windows.MessageBoxs;
using DevProLauncher.Config;
using ServiceStack.Text;

namespace DevProLauncher.Windows
{
    public sealed partial class RankingFrm : UserControl
    {
        public delegate void ServerResponse(string message);
        public ServerResponse Ranking;
        private string rankings="";
        public RankingFrm()
        {
            InitializeComponent();

            ApplyTranslation();
            ApplyRankingSettings();

            Dock = DockStyle.Fill;
            Visible = true;

            SingleRankingListBox.DrawItem += GameListBox_DrawItem;
            MatchRankingListBox.DrawItem += GameListBox_DrawItem;

            SingleRankingListBox.DoubleClick += ShowProfile;
            MatchRankingListBox.DoubleClick += ShowProfile;

        }
        public void ApplyTranslation()
        {
            LanguageInfo info = Program.LanguageManager.Translation;

            SingleRankingGroupBox.Text = info.RankingSingleGb;
            SingleRankLbl.Text      = info.RankingRank;
            SingleUsernameLbl.Text  = info.RankingUsername;
            SingleEloLbl.Text       = info.RankingElo;
            SingleWinLbl.Text       = info.RankingWin;
            SingleLossLbl.Text      = info.RankingLoss;
            SingleDrawLbl.Text      = info.RankingDraw;
            SingleTeamLbl.Text      = info.RankingTeam;

            MatchRankingGroupBox.Text = info.RankingMatchGb;
            MatchRankLbl.Text = info.RankingRank;
            MatchUsernameLbl.Text  = info.RankingUsername;
            MatchEloLbl.Text       = info.RankingElo;
            MatchWinLbl.Text       = info.RankingWin;
            MatchLossLbl.Text      = info.RankingLoss;
            MatchDrawLbl.Text      = info.RankingDraw;
            MatchTeamLbl.Text      = info.RankingTeam;

            loadBtn.Text = info.RankingLoadBtn;
            Color1Btn.Text = info.RankingColor1Btn;
            Color2Btn.Text = info.RankingColor2Btn;
        }
        private void GameListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var list = (ListBox)sender;
            e.DrawBackground();

            if (e.Index == -1)
                return;
            var index = e.Index;
            var parts = list.Items[index].ToString();
            var selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            var g = e.Graphics;

            string[] playerparts = parts.Split(',');
            string playername = playerparts[0];
            string playerelo = playerparts[1];
            string playerwins = playerparts[2];
            string playerloses = playerparts[3];
            string playerdraws = playerparts[4];
            string playerteam = playerparts[5];

            SolidBrush backgroundcolor;
            if (index % 2 == 1)
                backgroundcolor = new SolidBrush(Program.Config.RankingColor1.ToColor());
            else
                backgroundcolor = new SolidBrush(Program.Config.RankingColor2.ToColor());

            var bounds = list.GetItemRectangle(index);
            var playersSize = e.Graphics.MeasureString(playername, e.Font);

            var offset = new Size(bounds.X+5, 5);
            var Nameoffset  = new Size((int)(bounds.Width * 0.1), 5);
            var Elooffset   = new Size((int)(bounds.Width * 0.3), 5);
            var Winoffset   = new Size((int)(bounds.Width * 0.45), 5);
            var Loseoffset  = new Size((int)(bounds.Width * 0.55), 5);
            var Drawoffset  = new Size((int)(bounds.Width * 0.65), 5);
            var Teamoffset  = new Size((int)(bounds.Width * 0.75), 5);

            //draw item
            g.FillRectangle(backgroundcolor, e.Bounds);
            g.DrawLines((selected) ? new Pen(Brushes.Purple, 3) : new Pen(Brushes.Black, 3),
                new[] { new Point(bounds.X, bounds.Y), new Point(bounds.X + bounds.Width, bounds.Y), new Point(bounds.X + bounds.Width, bounds.Y + bounds.Height), new Point(bounds.X, bounds.Y + bounds.Height), new Point(bounds.X, bounds.Y) });
            //Rank
            g.DrawString((index+1).ToString(), e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + offset);
            //Name
            g.DrawString(playername, e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + Nameoffset);
            //Elo
            g.DrawString(playerelo, e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + Elooffset);
            //Win
            g.DrawString(playerwins, e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + Winoffset);
            //Lose
            g.DrawString(playerloses, e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + Loseoffset);
            //Draw
            g.DrawString(playerdraws, e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + Drawoffset);
            //Team
            g.DrawString(playerteam, e.Font, Brushes.Black,
                list.GetItemRectangle(index).Location + Teamoffset);
            e.DrawFocusRectangle();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (rankings.Equals("")) { 
                Program.ChatServer.Ranking += UpdateRanking;
                Program.ChatServer.SendPacket(DevServerPackets.GetRanking, JsonSerializer.SerializeToString(
                new RankingRequest(
                    )));
            } else {
                UpdateRanking(rankings);
            }
        }
        private void ApplyNewColor(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var selectcolor = new ColorDialog
            {
                Color = button.BackColor,
                AllowFullOpen = true
            };

            if (selectcolor.ShowDialog() == DialogResult.OK)
            {
                switch (button.Name)
                {
                    case "Color1Btn":
                        Program.Config.RankingColor1 = new SerializableColor(selectcolor.Color);
                        break;
                    case "Color2Btn":
                        Program.Config.RankingColor2 = new SerializableColor(selectcolor.Color);
                        break;
                }

                button.BackColor = selectcolor.Color;
                Program.SaveConfig(Program.ConfigurationFilename, Program.Config);
                ApplyRankingSettings();
            }
        }
        public void ApplyRankingSettings()
        {
            Color1Btn.BackColor = Program.Config.RankingColor1.ToColor();
            Color2Btn.BackColor = Program.Config.RankingColor2.ToColor();
        }
        private void UpdateRanking(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<String>(UpdateRanking), message);
                return;
            }

            if (rankings.Equals(""))
                rankings = message;

            string[] parts = message.Split('&');

            string[] singleparts = parts[0].Split('|');
            SingleRankingListBox.Items.Clear();

            for (int i = 0; i < singleparts.Length; i++)
            {
                //do stuff
                SingleRankingListBox.Items.Add(singleparts[i]);
            }

            string[] matchparts = parts[1].Split('|');
            MatchRankingListBox.Items.Clear();

            for (int i = 0; i < matchparts.Length; i++)
            {
                //do stuff
                MatchRankingListBox.Items.Add(matchparts[i]);
            }
        }
        public void ShowProfile(object sender, EventArgs e)
        {
            var player = (ListBox)sender;
            if (player.SelectedIndex == -1)
                return;

            string []parts = player.Text.Split(',');
            string name = parts[0];

            var profile = new ProfileFrm(name);
            profile.ShowDialog();
        }
    }
}
