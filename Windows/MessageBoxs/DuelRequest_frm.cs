using System;
using System.Globalization;
using System.Windows.Forms;

namespace DevProLauncher.Windows.MessageBoxs
{
    public partial class DuelRequestFrm : Form
    {
        public DuelRequestFrm(string requesttext, bool enabletimer = false)
        {
            InitializeComponent();
            RequestText.Text = requesttext;
            ResponseTimer.Tick += ResetResponse;
            ResponseTimer.Enabled = enabletimer;
            TimerLbl.Visible = enabletimer;
        }
        private void ResetResponse(object sender, EventArgs e)
        {
                if (InvokeRequired)
                {
                    Invoke(new Action<object, EventArgs>(ResetResponse), sender, e);
                    return;
                }

                if (TimerLbl.Text == "1")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    int value = Int32.Parse(TimerLbl.Text);
                    TimerLbl.Text = (value - 1).ToString(CultureInfo.InvariantCulture);
                }
        }
    }
}
