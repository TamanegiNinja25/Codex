using System;
using System.Windows.Forms;

namespace CashierApplication 
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new frmLoginAccount())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Pass the logged-in cashier to the main window
                    Application.Run(new CashierApplication());
                }
            }
        }
    }
}