using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace RegistrationTextForm
{
    public partial class frmFileName : Form
    {
        public static string setFileName;
        public frmFileName()
        {
            InitializeComponent();
        }
        public string SetFileName(string frmFileName)
        {
            if (Regex.IsMatch(frmFileName, @"^[a-zA-Z]+$"))
            {
                return frmFileName;
            }
            else
            {
                throw new ArgumentException("Filename must contain only letters (A-Z, a-z).");
            }
        }
        private void okaybtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filenametxt.Text))
            {
                MessageBox.Show("Please Enter a Legitimate File.", "FILENAME IS MISSING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            setFileName = filenametxt.Text.Trim() + ".txt";
            frmRegistration regForm = new frmRegistration(); 
            regForm.ShowDialog();
            this.Close();
        }
    }
}
