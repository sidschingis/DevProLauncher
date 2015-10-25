namespace DevProLauncher.Windows
{
    sealed partial class SupportFrm
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftItems = new System.Windows.Forms.TableLayoutPanel();
            this.RightItems = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DevPointCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.donateBrowser = new System.Windows.Forms.WebBrowser();
            this.supportTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 494);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.LeftItems, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.RightItems, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(754, 488);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // LeftItems
            // 
            this.LeftItems.AutoScroll = true;
            this.LeftItems.ColumnCount = 1;
            this.LeftItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.LeftItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftItems.Location = new System.Drawing.Point(3, 3);
            this.LeftItems.Name = "LeftItems";
            this.LeftItems.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LeftItems.RowCount = 2;
            this.LeftItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.LeftItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.LeftItems.Size = new System.Drawing.Size(371, 482);
            this.LeftItems.TabIndex = 0;
            // 
            // RightItems
            // 
            this.RightItems.AutoScroll = true;
            this.RightItems.ColumnCount = 1;
            this.RightItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.RightItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightItems.Location = new System.Drawing.Point(380, 3);
            this.RightItems.Name = "RightItems";
            this.RightItems.RowCount = 2;
            this.RightItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.RightItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.RightItems.Size = new System.Drawing.Size(371, 482);
            this.RightItems.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.donateBrowser, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(763, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(172, 488);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supportTxt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Support DevPro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DevPointCount);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 50);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Balance";
            // 
            // DevPointCount
            // 
            this.DevPointCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevPointCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevPointCount.Location = new System.Drawing.Point(3, 16);
            this.DevPointCount.Name = "DevPointCount";
            this.DevPointCount.Size = new System.Drawing.Size(160, 31);
            this.DevPointCount.TabIndex = 0;
            this.DevPointCount.Text = "0";
            this.DevPointCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel6.Controls.Add(this.refreshbtn, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.transferBtn, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(166, 33);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshbtn.Location = new System.Drawing.Point(85, 3);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(78, 27);
            this.refreshbtn.TabIndex = 1;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferBtn.Location = new System.Drawing.Point(3, 3);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(76, 27);
            this.transferBtn.TabIndex = 2;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // refreshtimer
            // 
            this.refreshtimer.Interval = 2000;
            // 
            // donateBrowser
            // 
            this.donateBrowser.AllowNavigation = false;
            this.donateBrowser.AllowWebBrowserDrop = false;
            this.donateBrowser.IsWebBrowserContextMenuEnabled = false;
            this.donateBrowser.Location = new System.Drawing.Point(3, 159);
            this.donateBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.donateBrowser.Name = "donateBrowser";
            this.donateBrowser.ScriptErrorsSuppressed = true;
            this.donateBrowser.ScrollBarsEnabled = false;
            this.donateBrowser.Size = new System.Drawing.Size(166, 72);
            this.donateBrowser.TabIndex = 0;
            this.donateBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // supportTxt
            // 
            this.supportTxt.BackColor = System.Drawing.SystemColors.Control;
            this.supportTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supportTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supportTxt.Location = new System.Drawing.Point(3, 16);
            this.supportTxt.Multiline = true;
            this.supportTxt.Name = "supportTxt";
            this.supportTxt.Size = new System.Drawing.Size(160, 36);
            this.supportTxt.TabIndex = 0;
            // 
            // SupportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupportFrm";
            this.Text = "Support_frm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label DevPointCount;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Timer refreshtimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel LeftItems;
        private System.Windows.Forms.TableLayoutPanel RightItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.WebBrowser donateBrowser;
        private System.Windows.Forms.TextBox supportTxt;
    }
}