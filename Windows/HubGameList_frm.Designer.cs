using DevProLauncher.Helpers;

namespace DevProLauncher.Windows
{
    sealed partial class HubGameList_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchRequest_Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.unrankedLbl = new System.Windows.Forms.Label();
            this.rankedLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.joinBtn = new System.Windows.Forms.Button();
            this.qJoinBtn = new System.Windows.Forms.Button();
            this.unrankedLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.Quick_Btn = new System.Windows.Forms.Button();
            this.Host_btn = new System.Windows.Forms.Button();
            this.rankedLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserFilter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.maxEloTxtBox = new System.Windows.Forms.TextBox();
            this.maxEloLbl = new System.Windows.Forms.Label();
            this.minEloLbl = new System.Windows.Forms.Label();
            this.minEloTxtBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Format = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GameType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BanList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeLimit = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveGames = new System.Windows.Forms.CheckBox();
            this.lockedChk = new System.Windows.Forms.CheckBox();
            this.IllegalGames = new System.Windows.Forms.CheckBox();
            this.SpectateBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.DeckSelect = new System.Windows.Forms.ComboBox();
            this.DevBotBtn = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.QueueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchReset = new System.Windows.Forms.Timer(this.components);
            this.GameListUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SpectateTimer = new System.Windows.Forms.Timer(this.components);
            this.QueueTimer = new System.Windows.Forms.Timer(this.components);
            this.DevBotTimer = new System.Windows.Forms.Timer(this.components);
            this.RankedList = new DevProLauncher.Windows.Components.DoubleBufferedListBox();
            this.UnrankedList = new DevProLauncher.Windows.Components.DoubleBufferedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.rankedLayoutPnl.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.unrankedLayoutPnl.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UpdateLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.QueueLabel, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(668, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 524);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 405);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SpectateBtn, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 386);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.SearchRequest_Btn, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 244);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(226, 109);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // SearchRequest_Btn
            // 
            this.SearchRequest_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchRequest_Btn.Location = new System.Drawing.Point(3, 87);
            this.SearchRequest_Btn.Name = "SearchRequest_Btn";
            this.SearchRequest_Btn.Size = new System.Drawing.Size(220, 19);
            this.SearchRequest_Btn.TabIndex = 1;
            this.SearchRequest_Btn.Text = "Search";
            this.SearchRequest_Btn.UseVisualStyleBackColor = true;
            this.SearchRequest_Btn.Click += new System.EventHandler(this.SearchRequest_Btn_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel11.Controls.Add(this.unrankedLbl, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.rankedLayoutPnl, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.unrankedLayoutPnl, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.rankedLbl, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(220, 78);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // unrankedLbl
            // 
            this.unrankedLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unrankedLbl.AutoSize = true;
            this.unrankedLbl.Location = new System.Drawing.Point(154, 0);
            this.unrankedLbl.Name = "unrankedLbl";
            this.unrankedLbl.Size = new System.Drawing.Size(54, 12);
            this.unrankedLbl.TabIndex = 3;
            this.unrankedLbl.Text = "Unranked";
            // 
            // rankedLayoutPnl
            // 
            this.rankedLayoutPnl.ColumnCount = 1;
            this.rankedLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rankedLayoutPnl.Controls.Add(this.leaveBtn, 0, 1);
            this.rankedLayoutPnl.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.rankedLayoutPnl.Location = new System.Drawing.Point(3, 15);
            this.rankedLayoutPnl.Name = "rankedLayoutPnl";
            this.rankedLayoutPnl.RowCount = 2;
            this.rankedLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rankedLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rankedLayoutPnl.Size = new System.Drawing.Size(137, 60);
            this.rankedLayoutPnl.TabIndex = 0;
            // 
            // leaveBtn
            // 
            this.leaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaveBtn.Enabled = false;
            this.leaveBtn.Location = new System.Drawing.Point(3, 35);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(131, 22);
            this.leaveBtn.TabIndex = 1;
            this.leaveBtn.Text = "Leave";
            this.leaveBtn.UseVisualStyleBackColor = true;
            this.leaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.joinBtn, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.qJoinBtn, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(131, 26);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // joinBtn
            // 
            this.joinBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinBtn.Location = new System.Drawing.Point(3, 3);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(59, 20);
            this.joinBtn.TabIndex = 0;
            this.joinBtn.Text = "Join";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // qJoinBtn
            // 
            this.qJoinBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qJoinBtn.Location = new System.Drawing.Point(68, 3);
            this.qJoinBtn.Name = "qJoinBtn";
            this.qJoinBtn.Size = new System.Drawing.Size(60, 20);
            this.qJoinBtn.TabIndex = 2;
            this.qJoinBtn.Text = "Quick";
            this.qJoinBtn.UseVisualStyleBackColor = true;
            this.qJoinBtn.Click += new System.EventHandler(this.qJoinBtn_Click);
            // 
            // unrankedLayoutPnl
            // 
            this.unrankedLayoutPnl.ColumnCount = 1;
            this.unrankedLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unrankedLayoutPnl.Controls.Add(this.Quick_Btn, 0, 1);
            this.unrankedLayoutPnl.Controls.Add(this.Host_btn, 0, 0);
            this.unrankedLayoutPnl.Location = new System.Drawing.Point(146, 15);
            this.unrankedLayoutPnl.Name = "unrankedLayoutPnl";
            this.unrankedLayoutPnl.RowCount = 2;
            this.unrankedLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.unrankedLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.unrankedLayoutPnl.Size = new System.Drawing.Size(71, 60);
            this.unrankedLayoutPnl.TabIndex = 1;
            // 
            // Quick_Btn
            // 
            this.Quick_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Quick_Btn.Location = new System.Drawing.Point(3, 33);
            this.Quick_Btn.Name = "Quick_Btn";
            this.Quick_Btn.Size = new System.Drawing.Size(65, 24);
            this.Quick_Btn.TabIndex = 1;
            this.Quick_Btn.Text = "Quick";
            this.Quick_Btn.UseVisualStyleBackColor = true;
            this.Quick_Btn.Click += new System.EventHandler(this.Quick_Btn_Click);
            // 
            // Host_btn
            // 
            this.Host_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Host_btn.Location = new System.Drawing.Point(3, 3);
            this.Host_btn.Name = "Host_btn";
            this.Host_btn.Size = new System.Drawing.Size(65, 24);
            this.Host_btn.TabIndex = 0;
            this.Host_btn.Text = "Host";
            this.Host_btn.UseVisualStyleBackColor = true;
            this.Host_btn.Click += new System.EventHandler(this.Host_btn_Click);
            // 
            // rankedLbl
            // 
            this.rankedLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rankedLbl.AutoSize = true;
            this.rankedLbl.Location = new System.Drawing.Point(49, 0);
            this.rankedLbl.Name = "rankedLbl";
            this.rankedLbl.Size = new System.Drawing.Size(45, 12);
            this.rankedLbl.TabIndex = 2;
            this.rankedLbl.Text = "Ranked";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.UserFilter, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.2F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.4F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.774436F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(226, 235);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Filter";
            // 
            // UserFilter
            // 
            this.UserFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFilter.Location = new System.Drawing.Point(3, 165);
            this.UserFilter.Name = "UserFilter";
            this.UserFilter.Size = new System.Drawing.Size(220, 20);
            this.UserFilter.TabIndex = 3;
            this.UserFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54546F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45454F));
            this.tableLayoutPanel10.Controls.Add(this.maxEloTxtBox, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.maxEloLbl, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.minEloLbl, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.minEloTxtBox, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 187);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.5F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(220, 45);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // maxEloTxtBox
            // 
            this.maxEloTxtBox.Location = new System.Drawing.Point(110, 22);
            this.maxEloTxtBox.Margin = new System.Windows.Forms.Padding(1, 3, 0, 3);
            this.maxEloTxtBox.Name = "maxEloTxtBox";
            this.maxEloTxtBox.Size = new System.Drawing.Size(106, 20);
            this.maxEloTxtBox.TabIndex = 3;
            // 
            // maxEloLbl
            // 
            this.maxEloLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxEloLbl.AutoSize = true;
            this.maxEloLbl.Location = new System.Drawing.Point(112, 3);
            this.maxEloLbl.Name = "maxEloLbl";
            this.maxEloLbl.Size = new System.Drawing.Size(41, 13);
            this.maxEloLbl.TabIndex = 1;
            this.maxEloLbl.Text = "maxElo";
            // 
            // minEloLbl
            // 
            this.minEloLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minEloLbl.AutoSize = true;
            this.minEloLbl.Location = new System.Drawing.Point(3, 3);
            this.minEloLbl.Name = "minEloLbl";
            this.minEloLbl.Size = new System.Drawing.Size(38, 13);
            this.minEloLbl.TabIndex = 0;
            this.minEloLbl.Text = "minElo";
            // 
            // minEloTxtBox
            // 
            this.minEloTxtBox.Location = new System.Drawing.Point(0, 22);
            this.minEloTxtBox.Margin = new System.Windows.Forms.Padding(0, 3, 1, 3);
            this.minEloTxtBox.Name = "minEloTxtBox";
            this.minEloTxtBox.Size = new System.Drawing.Size(108, 20);
            this.minEloTxtBox.TabIndex = 2;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(220, 137);
            this.tableLayoutPanel13.TabIndex = 5;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.Format, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.GameType, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.BanList, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.TimeLimit, 1, 4);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(214, 101);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Format";
            // 
            // Format
            // 
            this.Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Format.FormattingEnabled = true;
            this.Format.Items.AddRange(new object[] {
            "All",
            "OCG",
            "TCG",
            "OCG/TCG"});
            this.Format.Location = new System.Drawing.Point(110, 3);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(101, 21);
            this.Format.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game Type";
            // 
            // GameType
            // 
            this.GameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameType.FormattingEnabled = true;
            this.GameType.Items.AddRange(new object[] {
            "All",
            "Single",
            "Match",
            "Tag"});
            this.GameType.Location = new System.Drawing.Point(110, 28);
            this.GameType.Name = "GameType";
            this.GameType.Size = new System.Drawing.Size(101, 21);
            this.GameType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banlist";
            // 
            // BanList
            // 
            this.BanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BanList.FormattingEnabled = true;
            this.BanList.Items.AddRange(new object[] {
            "All"});
            this.BanList.Location = new System.Drawing.Point(110, 53);
            this.BanList.Name = "BanList";
            this.BanList.Size = new System.Drawing.Size(101, 21);
            this.BanList.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time Limit";
            // 
            // TimeLimit
            // 
            this.TimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeLimit.FormattingEnabled = true;
            this.TimeLimit.Items.AddRange(new object[] {
            "All",
            "3 minutes",
            "5 minutes"});
            this.TimeLimit.Location = new System.Drawing.Point(110, 78);
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.Size = new System.Drawing.Size(101, 21);
            this.TimeLimit.TabIndex = 9;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 3;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel14.Controls.Add(this.ActiveGames, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.lockedChk, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.IllegalGames, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(214, 24);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // ActiveGames
            // 
            this.ActiveGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveGames.AutoSize = true;
            this.ActiveGames.Location = new System.Drawing.Point(77, 3);
            this.ActiveGames.Name = "ActiveGames";
            this.ActiveGames.Size = new System.Drawing.Size(59, 18);
            this.ActiveGames.TabIndex = 0;
            this.ActiveGames.Text = "Active\r\nGames";
            this.ActiveGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActiveGames.UseVisualStyleBackColor = true;
            // 
            // lockedChk
            // 
            this.lockedChk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lockedChk.AutoSize = true;
            this.lockedChk.Location = new System.Drawing.Point(147, 3);
            this.lockedChk.Name = "lockedChk";
            this.lockedChk.Size = new System.Drawing.Size(62, 18);
            this.lockedChk.TabIndex = 10;
            this.lockedChk.Text = "Locked\r\nGames";
            this.lockedChk.UseVisualStyleBackColor = true;
            // 
            // IllegalGames
            // 
            this.IllegalGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IllegalGames.AutoSize = true;
            this.IllegalGames.Location = new System.Drawing.Point(6, 3);
            this.IllegalGames.Name = "IllegalGames";
            this.IllegalGames.Size = new System.Drawing.Size(59, 18);
            this.IllegalGames.TabIndex = 1;
            this.IllegalGames.Text = "Illegal \r\nGames";
            this.IllegalGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IllegalGames.UseVisualStyleBackColor = true;
            // 
            // SpectateBtn
            // 
            this.SpectateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectateBtn.Location = new System.Drawing.Point(3, 359);
            this.SpectateBtn.Name = "SpectateBtn";
            this.SpectateBtn.Size = new System.Drawing.Size(226, 24);
            this.SpectateBtn.TabIndex = 2;
            this.SpectateBtn.Text = "Random Spectate";
            this.SpectateBtn.UseVisualStyleBackColor = true;
            this.SpectateBtn.Click += new System.EventHandler(this.SpectateBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DevBotBtn, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 67);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.91597F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.08403F));
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.DeckSelect, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(232, 29);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Default Deck";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeckSelect
            // 
            this.DeckSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeckSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeckSelect.FormattingEnabled = true;
            this.DeckSelect.Location = new System.Drawing.Point(95, 4);
            this.DeckSelect.Name = "DeckSelect";
            this.DeckSelect.Size = new System.Drawing.Size(134, 21);
            this.DeckSelect.TabIndex = 1;
            // 
            // DevBotBtn
            // 
            this.DevBotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevBotBtn.Location = new System.Drawing.Point(3, 38);
            this.DevBotBtn.Name = "DevBotBtn";
            this.DevBotBtn.Size = new System.Drawing.Size(232, 26);
            this.DevBotBtn.TabIndex = 5;
            this.DevBotBtn.Text = "Duel DevBot";
            this.DevBotBtn.UseVisualStyleBackColor = true;
            this.DevBotBtn.Click += new System.EventHandler(this.Duel_DevBot_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(69, 76);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(106, 13);
            this.UpdateLabel.TabIndex = 2;
            this.UpdateLabel.Text = "Status: Not Updating";
            // 
            // QueueLabel
            // 
            this.QueueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QueueLabel.AutoSize = true;
            this.QueueLabel.Location = new System.Drawing.Point(49, 507);
            this.QueueLabel.Name = "QueueLabel";
            this.QueueLabel.Size = new System.Drawing.Size(146, 13);
            this.QueueLabel.TabIndex = 6;
            this.QueueLabel.Text = "Queue Status: Not Searching";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(659, 524);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RankedList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(332, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 518);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ranked";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnrankedList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 518);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unranked";
            // 
            // SearchReset
            // 
            this.SearchReset.Interval = 1000;
            // 
            // GameListUpdateTimer
            // 
            this.GameListUpdateTimer.Interval = 1000;
            // 
            // SpectateTimer
            // 
            this.SpectateTimer.Interval = 1000;
            // 
            // QueueTimer
            // 
            this.QueueTimer.Interval = 1000;
            // 
            // DevBotTimer
            // 
            this.DevBotTimer.Interval = 1000;
            // 
            // RankedList
            // 
            this.RankedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankedList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RankedList.FormattingEnabled = true;
            this.RankedList.IntegralHeight = false;
            this.RankedList.ItemHeight = 50;
            this.RankedList.Location = new System.Drawing.Point(3, 16);
            this.RankedList.Name = "RankedList";
            this.RankedList.Size = new System.Drawing.Size(318, 499);
            this.RankedList.TabIndex = 0;
            // 
            // UnrankedList
            // 
            this.UnrankedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnrankedList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UnrankedList.FormattingEnabled = true;
            this.UnrankedList.IntegralHeight = false;
            this.UnrankedList.ItemHeight = 50;
            this.UnrankedList.Location = new System.Drawing.Point(3, 16);
            this.UnrankedList.Name = "UnrankedList";
            this.UnrankedList.Size = new System.Drawing.Size(317, 499);
            this.UnrankedList.TabIndex = 0;
            // 
            // HubGameList_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HubGameList_frm";
            this.Text = "HubGameList_frm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.rankedLayoutPnl.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.unrankedLayoutPnl.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox3;
        private Components.DoubleBufferedListBox RankedList;
        private System.Windows.Forms.GroupBox groupBox1;
        private Components.DoubleBufferedListBox UnrankedList;
        private System.Windows.Forms.Timer SearchReset;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Timer GameListUpdateTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Host_btn;
        private System.Windows.Forms.Button Quick_Btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DeckSelect;
        private System.Windows.Forms.Timer SpectateTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Format;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GameType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BanList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserFilter;
        private System.Windows.Forms.CheckBox ActiveGames;
        private System.Windows.Forms.CheckBox IllegalGames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TimeLimit;
        private System.Windows.Forms.CheckBox lockedChk;
        private System.Windows.Forms.Label QueueLabel;
        private System.Windows.Forms.Timer QueueTimer;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Button leaveBtn;
        private System.Windows.Forms.Button SearchRequest_Btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label unrankedLbl;
        private System.Windows.Forms.TableLayoutPanel rankedLayoutPnl;
        private System.Windows.Forms.TableLayoutPanel unrankedLayoutPnl;
        private System.Windows.Forms.Label rankedLbl;
        private System.Windows.Forms.Button SpectateBtn;
        private System.Windows.Forms.Button qJoinBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox maxEloTxtBox;
        private System.Windows.Forms.Label maxEloLbl;
        private System.Windows.Forms.Label minEloLbl;
        private System.Windows.Forms.TextBox minEloTxtBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button DevBotBtn;
        private System.Windows.Forms.Timer DevBotTimer;
    }
}