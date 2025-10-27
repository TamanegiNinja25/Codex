using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration1
{
    public partial class Form1 : Form
    {
        private DelegateText textGetter;
        private DelegateNumber numberGetter;
        public Form1()
        {
            InitializeComponent();
            progcbx.Items.AddRange(new string[] {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Software Engineering",
                "Bachelor of Science in Cybersecurity",
                "Bachelor of Science in Data Science",
                "Bachelor of Science in Artificial Intelligence",
                "Bachelor of Science in Computer Engineering",
                "Bachelor of Science in Electronics Engineering",
                "Bachelor of Science in Civil Engineering",
                "Bachelor of Science in Mechanical Engineering",
                "Bachelor of Science in Electrical Engineering",
                "Bachelor of Science in Industrial Engineering",
                "Bachelor of Science in Architecture",
                "Bachelor of Science in Mathematics",
                "Bachelor of Science in Statistics",
                "Bachelor of Science in Physics",
                "Bachelor of Science in Chemistry",
                "Bachelor of Science in Biology",
                "Bachelor of Science in Environmental Science",
                "Bachelor of Science in Nursing",
                "Bachelor of Science in Psychology",
                "Bachelor of Science in Accountancy",
                "Bachelor of Science in Business Administration"});
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(studnotxt.Text, out var studentNo))
            {
                MessageBox.Show("Student No. must contain a Number!");
                studnotxt.Focus();
                return;
            }
            if (!long.TryParse(agetxt.Text, out var age))
            {
                MessageBox.Show("Age must be a number!");
                agetxt.Focus();
                return;
            }
            if (!long.TryParse(contactnotxt.Text, out var contactNo))
            {
                MessageBox.Show("Contact No. must be a number!");
                contactnotxt.Focus();
                return;
            }
            StudentInfoClass.Program = progcbx.Text;
            StudentInfoClass.LastName = lnametxt.Text;
            StudentInfoClass.FirstName = fnametxt.Text;
            StudentInfoClass.MiddleName = mnametxt.Text;
            StudentInfoClass.Address = addresstxt.Text;
            StudentInfoClass.StudentNo = long.Parse(studnotxt.Text);
            StudentInfoClass.Age = long.Parse(agetxt.Text);
            StudentInfoClass.ContactNo = long.Parse(contactnotxt.Text);
            textGetter = StudentInfoClass.GetFirstName;
            StudentInfoClass.FirstName = textGetter(fnametxt.Text);
            textGetter = StudentInfoClass.GetMiddleName;
            StudentInfoClass.MiddleName = textGetter(mnametxt.Text);
            textGetter = StudentInfoClass.GetLastName;
            StudentInfoClass.LastName = textGetter(lnametxt.Text);
            textGetter = StudentInfoClass.GetAddress;
            StudentInfoClass.Address = textGetter(addresstxt.Text);
            textGetter = StudentInfoClass.GetProgram;
            StudentInfoClass.Program = textGetter(progcbx.Text);  
            numberGetter = StudentInfoClass.GetStudentNo;
            StudentInfoClass.StudentNo = numberGetter(studentNo);
            numberGetter = StudentInfoClass.GetAge;
            StudentInfoClass.Age = numberGetter(age);
            numberGetter = StudentInfoClass.GetContactNo;
            StudentInfoClass.ContactNo = numberGetter(contactNo);
            MessageBox.Show("Student Credentials is Acquired!");
            MessageBox.Show("Proceed to the NEXT STEP!");
            Form2 confirmForm = new Form2();
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                studnotxt.Clear();
                fnametxt.Clear();
                mnametxt.Clear();
                lnametxt.Clear();
                agetxt.Clear();
                contactnotxt.Clear();
                addresstxt.Clear();
                progcbx.SelectedIndex = -1;
            }
        }
    }
}
