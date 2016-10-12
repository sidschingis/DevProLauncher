using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevProLauncher.Windows.Components
{
    internal class FixedTabControl : TabControl
    {
        public delegate bool PreRemoveTab(int indx);

        public PreRemoveTab PreRemoveTabPage;

        public FixedTabControl()
        {
            PreRemoveTabPage = null;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(Handle, "", "");
            base.OnHandleCreated(e);
        }

        [DllImportAttribute("uxtheme.dll")]
        private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);
    }
}