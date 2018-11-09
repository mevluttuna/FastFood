using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.Shared
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool status = false;
        Point location;
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
            location = e.Location;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (status)
            {
                this.Left = this.Left + e.Location.X - (location.X);
                this.Top = this.Top + e.Location.Y - (location.Y);
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Classes.Page.AddPage(new Forms.UC.UC_MainPage());
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Classes.Page.AddPage(new Forms.UC.UC_MainPage());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Classes.Page.AddPage(new Forms.UC.UC_Users());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classes.Page.AddPage(new Forms.UC.UC_Menu());
        }
    }
}
