using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registration
{
    public partial class Form1 : Form
    {
        private long _StudentNo;
        private long _ContactNo;
        private int _Age;
        private string _FullName;
        public long StudentNumber(string studNum)
        {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            return _ContactNo;
        }
        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }
        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }
        public Form1()
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
            try
            {
                StudentInformationClass.SetFullName = FullName(lnametxt.Text, fnametxt.Text, middletxt.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(studtxt.Text);
                StudentInformationClass.SetProgram = progcbx.Text;
                StudentInformationClass.SetGender = gendercbx.Text;
                StudentInformationClass.SetContactNo = ContactNo(contacttxt.Text);
                StudentInformationClass.SetAge = Age(agetxt.Text);
                StudentInformationClass.SetBirthDay = bday.Value.ToString("yyyy-MM-dd");
                Form2 frm = new Form2();
                frm.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error: " + ex.Message, "ERROR! ERROR! ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Missing value: " + ex.Message, "ERROR! ERROR! ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Value out of range: " + ex.Message, "ERROR! ERROR! ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Number too large or too small: " + ex.Message, "ERROR! ERROR! ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                progcbx.Items.Add(ListOfProgram[i]);
            }
        }
}
}
