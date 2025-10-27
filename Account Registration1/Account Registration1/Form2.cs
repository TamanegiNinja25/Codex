using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration1
{
    public partial class Form2 : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudentNo;
        public Form2()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            progout.Text = DelProgram(StudentInfoClass.Program);
            lnameout.Text = DelLastName(StudentInfoClass.LastName);
            fnameout.Text = DelFirstName(StudentInfoClass.FirstName);
            mnameout.Text = DelMiddleName(StudentInfoClass.MiddleName);
            addressout.Text = DelAddress(StudentInfoClass.Address);
            ageout.Text = DelNumAge(StudentInfoClass.Age).ToString();
            contactout.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            studnoout.Text = DelStudentNo(StudentInfoClass.StudentNo).ToString();
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credentials Submitted! Thank you!");
            this.DialogResult = DialogResult.OK;
        }
    }
}
