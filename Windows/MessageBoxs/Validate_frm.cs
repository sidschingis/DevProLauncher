using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevProLauncher.Network.Enums;
using DevProLauncher.Network.Data;
using ServiceStack.Text;
using DevProLauncher.Helpers;

namespace DevProLauncher.Windows.MessageBoxs
{
    public partial class Validate_frm : Form
    {
        public Validate_frm()
        {
            InitializeComponent();
            ApplyTranslation();
            Program.ChatServer.ValidateReply += ValidateResponse;
            Program.ChatServer.ResendReply += ResendResponse;
            usernameLbl.KeyDown += UsernameInput_KeyDown;
            FormClosing += ResetEvents;
        }

        public void ApplyTranslation()
        {
            if (Program.LanguageManager.Loaded)
            {
                usernameLbl.Text = Program.LanguageManager.Translation.ValidateLbUser;
                codeLbl.Text = Program.LanguageManager.Translation.ValidateLbCode;
                submitBtn.Text = Program.LanguageManager.Translation.ValidateBtnSubmit;
                cancelBtn.Text = Program.LanguageManager.Translation.ValidateBtnCancel;
                resendBtn.Text = Program.LanguageManager.Translation.ValidateBtnResend;
            }
        }
        private void UsernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }
         private void ValidateResponse(DevClientPackets packet)
        {
            if (!IsDisposed)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<DevClientPackets>(ValidateResponse),packet);
                    return;
                }
                if (packet == DevClientPackets.ValidateAccept)
                {
                    if (MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbAccept) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                else if (packet == DevClientPackets.ValidateFailed)
                {
                    MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbFailed);
                }
                submitBtn.Enabled = true;
            }

        }
         private void ResendResponse(DevClientPackets packet)
         {
             if (!IsDisposed)
             {
                 if (InvokeRequired)
                 {
                     Invoke(new Action<DevClientPackets>(ResendResponse), packet);
                     return;
                 }
                 if (packet == DevClientPackets.ResendAccept)
                 {
                     if (MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbResendOK) == DialogResult.OK)
                     {
                         DialogResult = DialogResult.OK;
                     }
                 }
                 if (packet == DevClientPackets.ResendFailed)
                 {
                     if (MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbResendFail) == DialogResult.OK)
                     {
                         DialogResult = DialogResult.OK;
                     }
                 }
                 submitBtn.Enabled = true;
             }

         }

        private void ResetEvents(object sender, EventArgs e)
        {
            Program.ChatServer.ValidateReply -= ValidateResponse;
            Program.ChatServer.ResendReply -= ResendResponse;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbUsername);
                return;
            } if (string.IsNullOrEmpty(emailInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbEmail);
                return;
            }
            if (string.IsNullOrEmpty(codeInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbCode);
                return;
            }
            Program.ChatServer.SendPacket(DevServerPackets.Validate, JsonSerializer.SerializeToString(
                new ValidateRequest
                {
                    Username = usernameInput.Text,
                    Email = emailInput.Text,
                    Code = codeInput.Text,
                    UID = LauncherHelper.GetUID(),
                    Version = Convert.ToInt32(Program.Version),
                }));
            submitBtn.Enabled = false;
        }

        private void resendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbUsername);
                return;
            }
            if (string.IsNullOrEmpty(emailInput.Text))
            {
                MessageBox.Show(Program.LanguageManager.Translation.ValidateMsbEmail);
                return;
            }
            Program.ChatServer.SendPacket(DevServerPackets.Resend, JsonSerializer.SerializeToString(
              new ResendRequest
              {
                  Username = usernameInput.Text,
                  Email = emailInput.Text,
                  UID = LauncherHelper.GetUID(),
                  Version = Convert.ToInt32(Program.Version),
              }));
            resendBtn.Enabled = false;
        }
    }
}
