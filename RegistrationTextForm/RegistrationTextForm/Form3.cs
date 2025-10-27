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
namespace RegistrationTextForm
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
            gendercbx.Items.AddRange(new string[]
            {
                "Male",
                "Female",
                "Prefer not to say"
            });
        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studnotxt.Text))
            {
                MessageBox.Show("Please Enter your Student Number.", "MISSING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentNo = studnotxt.Text.Trim();
            string[] lines = new string[]
            {
            "Student No: " + studentNo,
            "Full Name: " + lnametxt.Text.Trim() + ", " + fnametxt.Text.Trim() + ", " + middletxt.Text.Trim() + ".",
            "Program: " + programcbx.Text.Trim(),
            "Gender: " +  gendercbx.Text.Trim(),
            "Age: " + agetxt.Text.Trim(),
            "Birthdate: " + bdaypicker.Text.Trim(),
            "Contact No.: " + contacttxt.Text.Trim(),
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, studentNo + ".txt");

            try
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                }

                MessageBox.Show($"Information Registered! Saved into {fullPath}", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Failed: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS in Computer Science",
                "BS in Information Technology",
                "BS in Information Systems",
                "BS in Software Engineering",
                "BS in Cybersecurity",
                "BS in Data Science",
                "BS in Artificial Intelligence",
                "BS in Computer Engineering",
                "BS in Electronics Engineering",
                "BS in Civil Engineering",
                "BS in Mechanical Engineering",
                "BS in Electrical Engineering",
                "BS in Industrial Engineering",
                "BS in Architecture",
                "BS in Mathematics",
                "BS in Statistics",
                "BS in Physics",
                "BS in Chemistry",
                "BS in Biology",
                "BS in Environmental Science",
                "BS in Nursing",
                "BS in Psychology",
                "BS in Accountancy",
                "BS in Business Administration"
            };
            for (int i = 0; i < ListOfProgram.Length; i++)
            {
                programcbx.Items.Add(ListOfProgram[i]);
            }
        }
    }
}
