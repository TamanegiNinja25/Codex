using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using CashierApplication;


namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private readonly Cashier _user;
        public Cashier LoggedInCashier { get; private set; }
        public frmLoginAccount()
        {
            InitializeComponent();
            _user = new Cashier("Karuro Inamura", "Secretary of Defense", "vipuser123", "admin123");
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (_user.ValidateLogin(usertxt.Text, passtxt.Text))
            {
                LoggedInCashier = _user;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password.","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                passtxt.Clear();
                usertxt.Focus();
            }
        }
    }
}
