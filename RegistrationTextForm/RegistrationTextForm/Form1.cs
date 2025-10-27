using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace RegistrationTextForm
{
    public partial class frmLab1 : Form
    {
        public static string setFileName;
        public frmLab1()
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
        private void createbtn_Click(object sender, EventArgs e)
        {
            frmFileName fileNameDialog = new frmFileName();
            fileNameDialog.ShowDialog(); 

            string getInput = inputtxt.Text;

            if (string.IsNullOrWhiteSpace(frmFileName.setFileName))
            {
                MessageBox.Show("File Name not Provided. File was not Created.", "CANCELLED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(docPath, frmFileName.setFileName);

                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    outputFile.WriteLine(getInput);
                }

                Console.WriteLine("Wrote: " + getInput);
                MessageBox.Show($"File Successfully Created:\n{fullPath}", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Created Resulted in ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
