using DevProLauncher.Helpers;
using DevProLauncher.Network.Data;
using DevProLauncher.Network.Enums;
using ServiceStack.Text;
using System;
using System.Windows.Forms;

namespace DevProLauncher.Windows.MessageBoxs
{
    public partial class Recover_frm : Form
    {
        public Recover_frm()
        {
            InitializeComponent();
            ApplyTranslation();
            Program.ChatServer.RecoverReply += RecoverResponse;
            Program.ChatServer.ResetReply += ResetResponse;
            usernameLbl.KeyDown += UsernameInput_KeyDown;
            FormClosing += ResetEvents;
        }

        public void ApplyTranslation()
        {
            if (Program.LanguageManager.Loaded)
            {
                usernameLbl.Text = Program.LanguageManager.Translation.RecoverLbUser;
                codeLbl.Text = Program.LanguageManager.Translation.RecoverLbCode;
                submitBtn.Text = Program.LanguageManager.Translation.RecoverBtnSubmit;
                cancelBtn.Text = Program.LanguageManager.Translation.RecoverBtnCancel;
                resendBtn.Text = Program.LanguageManager.Translation.RecoverBtnResend;
            }
        }

        private void UsernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void ResetResponse(DevClientPackets packet)
        {
            if (!IsDisposed)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<DevClientPackets>(ResetResponse), packet);
                    return;
                }
                if (packet == DevClientPackets.ResetAccept)
                {
                    if (MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbAccept) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                else if (packet == DevClientPackets.ResetFailed)
                {
                    MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbFailed);
                }
                submitBtn.Enabled = true;
            }
        }

        private void RecoverResponse(DevClientPackets packet)
        {
            if (!IsDisposed)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<DevClientPackets>(RecoverResponse), packet);
                    return;
                }
                if (packet == DevClientPackets.RecoverAccept)
                {
                    if (MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbResendOK) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                if (packet == DevClientPackets.RecoverFailed)
                {
                    if (MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbResendFail) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                submitBtn.Enabled = true;
            }
        }

        private void ResetEvents(object sender, EventArgs e)
        {
            Program.ChatServer.RecoverReply -= RecoverResponse;
            Program.ChatServer.ResetReply -= ResetResponse;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbUsername);
                return;
            }
            if (string.IsNullOrEmpty(emailInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbEmail);
                return;
            }
            if (string.IsNullOrEmpty(codeInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbCode);
                return;
            }
            Program.ChatServer.SendPacket(DevServerPackets.Reset, JsonSerializer.SerializeToString(
                new ResetRequest
                {
                    Username = usernameInput.Text,
                    Email = emailInput.Text,
                    Code = codeInput.Text,
                    UID = LauncherHelper.GetUID(),
                    Version = Convert.ToInt32(Program.Version),
                    HID = HardwareIdEditor.GetId()
                }));
            submitBtn.Enabled = false;
        }

        private void resendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbUsername);
                return;
            }
            if (string.IsNullOrEmpty(emailInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.RecoverMsbEmail);
                return;
            }
            Program.ChatServer.SendPacket(DevServerPackets.Recover, JsonSerializer.SerializeToString(
              new RecoverRequest
              {
                  Username = usernameInput.Text,
                  Email = emailInput.Text,
                  UID = LauncherHelper.GetUID(),
                  Version = Convert.ToInt32(Program.Version),
                  HID = HardwareIdEditor.GetId()
              }));
            resendBtn.Enabled = false;
        }
    }
}