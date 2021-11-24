using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class mainFrm : Form
    {
        public Screen[] availableScreens = Screen.AllScreens;
        public int targetScreenIndex = 0;
        public mainFrm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.targetScreenIndex == this.availableScreens.Length - 1)
            {
                this.targetScreenIndex = 0;
            }
            else
            {
                this.targetScreenIndex++;
            }
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Location = this.availableScreens[this.targetScreenIndex].Bounds.Location;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
