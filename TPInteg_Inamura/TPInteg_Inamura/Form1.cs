using System.Collections;
using System.Drawing;

namespace TPInteg_Inamura
{
    public partial class Form1 : Form
    {
        private ArrayList prog;
        private OpenFileDialog openFileDialog;
        private PictureBox pictureBox;
        public Form1()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            for (int i = 1; i <= 31; i++)
            {
                daycbx.Items.Add(i);
            }
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                monthcbx.Items.Add(month);
            }
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                yearcbx.Items.Add(i);
            }
            prog = new ArrayList()
            {
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Business Administration",
                "Bachelor of Science in Engineering",
                "Bachelor of Science in Accountancy",
                "Bachelor of Science in Hospitality Management",
                "Bachelor of Science in Tourism Management",
                "Bachelor of Science in Nursing",
                "Bachelor of Science in Pharmacy",
                "Bachelor of Science in Mechanical Engineering"
            };
            foreach (string programs in prog)
            {
                cbxProgram.Items.Add(programs);
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string firstname = fntxt.Text;
            string lastname = lntxt.Text;
            string middlename = mitxt.Text;
            string bday = monthcbx.Text + " " + daycbx.Text + ", " + yearcbx.Text;
            string program = cbxProgram.Text;
            string gender = mrbtn.Checked ? "Male" : (frbtn.Checked ? "Female" : "Unspecified");
            if (!string.IsNullOrWhiteSpace(middlename) && !string.IsNullOrWhiteSpace(gender) && daycbx.SelectedIndex >= 0 && monthcbx.SelectedIndex >= 0 && yearcbx.SelectedIndex >= 0)
            {
                DisplayInfo(firstname, middlename, lastname, gender, bday, program);
            }
            else if (!string.IsNullOrWhiteSpace(middlename))
            {
                DisplayInfo(firstname, middlename, lastname, program);
            }
            else
            {
                DisplayInfo(firstname, lastname, program);
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    pictureBox.Image = img;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
        private void DisplayInfo(string fname, string mname, string lname, string gender, string bday, string program)
        {
            MessageBox.Show("Student name: " + fname + " " + mname + " " + lname +
                            "\nGender: " + gender +
                            "\nDate of birth: " + bday +
                            "\nProgram: " + program);
        }
        private void DisplayInfo(string fname, string mname, string lname, string program)
        {
            MessageBox.Show("Student name: " + fname + " " + mname + " " + lname +
                            "\nProgram: " + program);
        }
        private void DisplayInfo(string fname, string lname, string program)
        {
            MessageBox.Show("Student name: " + fname + " " + lname +
                            "\nProgram: " + program);
        }
        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
