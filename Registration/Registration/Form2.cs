using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            studnum.Text = StudentInformationClass.SetStudentNo.ToString();
            FullName.Text = StudentInformationClass.SetFullName;
            progcbx.Text = StudentInformationClass.SetProgram;
            bday.Text = StudentInformationClass.SetBirthDay;
            gendercbx.Text = StudentInformationClass.SetGender;
            contact.Text = StudentInformationClass.SetContactNo.ToString();
            age.Text = StudentInformationClass.SetAge.ToString();
        }
    }
}
