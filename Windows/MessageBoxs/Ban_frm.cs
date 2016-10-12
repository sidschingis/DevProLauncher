using System;
using System.Windows.Forms;

namespace DevProLauncher.Windows.MessageBoxs
{
    public partial class BanFrm : Form
    {
        public BanFrm(string title, string message, string input1Lbl, string input2Lbl, string confirmbtn, string cancelbtn)
        {
            InitializeComponent();
            Text = title;
            msglabel.Text = message;
            inputLbl1.Text = input1Lbl;
            inputLbl2.Text = input2Lbl;
            Confirmbtn.Text = confirmbtn;
            Cancelbtn.Text = cancelbtn;
            inputBox1.KeyPress += KeyPress_Enter;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputBox1.Text)) MessageBox.Show("Input box is empty.", "Error", MessageBoxButtons.OK);
            else
                DialogResult = DialogResult.OK;
        }

        private void KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (String.IsNullOrEmpty(inputBox1.Text))
                    return;

                DialogResult = DialogResult.OK;
            }
        }
    }
}