namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public interface IEmployees
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Department { get; set; }
            string Job_Title { get; set; }
            double Basic_Salary { get; set; }
            void computeSalary(int hoursWorked, double ratePerHour);
        }
        public class PartTimeEmployee : IEmployees
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            public string Job_Title { get; set; }
            public double Basic_Salary { get; set; } 
            public PartTimeEmployee(string fname, string lname, string dept, string job)
            {
                FirstName = fname;
                LastName = lname;
                Department = dept;
                Job_Title = job;
            }
            public void computeSalary(int hoursWorked, double ratePerHour)
            {
                Basic_Salary = hoursWorked * ratePerHour;
            }
            public double getSalary() => Basic_Salary;
        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            PartTimeEmployee emp = new PartTimeEmployee(fnametxt.Text, lnametxt.Text, deptxt.Text, titletxt.Text);
            emp.FirstName = fnametxt.Text;
            emp.LastName = lnametxt.Text;
            emp.Department = deptxt.Text;
            emp.Job_Title = titletxt.Text;
            string rate = ratetxt.Text;
            string hours = hourstxt.Text;
            emp.computeSalary(int.Parse(hours), double.Parse(rate));
            emp.getSalary();
            fnamelbltxt.Text = emp.FirstName;
            lnamelbltxt.Text = emp.LastName;
            salarytxt.Text = emp.getSalary().ToString();
        }
    }
}