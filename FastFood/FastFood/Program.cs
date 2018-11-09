using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    static class Program
    {
        public static Shared.frmMain _frmMain;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _Start();
            Application.Run(_frmMain);
        }

        public static void _Start()
        {
            _frmMain = new Shared.frmMain();
        }
    }
}
