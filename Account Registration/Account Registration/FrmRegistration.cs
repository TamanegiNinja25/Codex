namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
    }
    class StudentInfoClass
    {
        public static class StudentInfo
        {
            public static string FirstName = " ";
            public static string LastName = " ";
            public static string MiddleName = " ";
            public static string Address = " ";
            public static string Program = " ";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;
        }
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);
        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;
    }
}
