using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class mainFrm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;
        private const int VK_LWIN = 0x5B;
        private const int VK_D = 0x44;
        private const int VK_LCONTROL = 0xA2;
        private const int VK_LMENU = 0xA4;
        private const int VK_TAB = 0x09;

        public mainFrm()
        {
            InitializeComponent();
            winDBtn.Click += WinDBtn_Click;
            taskmgrBtn.Click += TaskmgrBtn_Click;
        }

        private void TaskmgrBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "C:\\Windows\\System32\\cmd.exe";
            psi.Arguments = "/c taskmgr";
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void WinDBtn_Click(object sender, EventArgs e)
        {
            keybd_event(VK_LWIN, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            keybd_event(VK_D, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            keybd_event(VK_D, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            keybd_event(VK_LWIN, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
