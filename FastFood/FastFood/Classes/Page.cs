using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.Classes
{
    public class Page
    {
        static Timer t;
        static byte speed = 8;
        public static void AddPage(UserControl uc)
        {
            speed = 8;
            uc.Left = 160;
            uc.Top = 0;
            Program._frmMain.pnlContainer.Controls.Clear();
            Program._frmMain.pnlContainer.Controls.Add(uc);

            if (t != null)
            {
                t.Dispose();
                t = new Timer();
            }
            else
            {
                t = new Timer();
            }
            t.Interval = 1;
            t.Tick += delegate
            {
                uc.Left -= speed;
                if (uc.Left <= 70) speed = 4;
                if (uc.Left <= 30) speed = 2;
                if (uc.Left <= 10) speed = 1;
                if (uc.Left <= 0)
                {
                    t.Stop();
                    uc.Left = 0;
                }
            };
            t.Start();
        }
    }
}
