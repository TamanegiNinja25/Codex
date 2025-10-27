namespace QuizInteg_Inamura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblnamebtn_Click(object sender, EventArgs e)
        {
            string[] classmates = { "John Leo Pineda", "John Paul Melitante", "Wendel Derraco", "Mhyzel Larowa", "Karuro Inamura", "Marc Benedict Fajardo" };
            Name_Collection.Items.Clear();
            foreach (string name in classmates)
            {
                Name_Collection.Items.Add(name);
            }
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
            char[,] letters = { { 'A', 'B', 'C' }, { 'D', 'E', 'F' }, { 'G', 'H', 'I' } , { 'J', 'K', 'L' } };
            twodtxt.Text = $"[{letters[0, 0]}, {letters[0, 1]}, {letters[0, 2]}]\n" +
                            $"[{letters[1, 0]}, {letters[1, 1]}, {letters[1, 2]}]\n" +
                            $"[{letters[2, 0]}, {letters[2, 1]}, {letters[2, 2]}]\n" +
                            $"[{letters[3, 0]}, {letters[3, 1]}, {letters[3, 2]}]";
        }

        private void msgbtn_Click(object sender, EventArgs e)
        {
            string message = msgtxt.Text.ToLower();
            if (message.Contains("hello"))
            {
                resulttxt.Text = "The message contains 'hello'!";
            }
            else
            {
                resulttxt.Text = "The message does NOT contain 'hello'.";
            }
        }
    }
}
