using System.Collections;
using System.Text;
using System;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private string selectedWord = "";
        private string maskedWord = "";
        private List<string> wrongGuesses = new List<string>();
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            GenerateRandomString();
        }
        private void GenerateRandomString()
        {
            string[] words = { "Apocalypse", "Science", "Application", "Gaming", "Keyboard", "Monitor", "Shazam", "Volcano" };
            Random rand = new Random();
            string selectedWord = words[rand.Next(words.Length)];
            StringBuilder maskedWord = new StringBuilder(selectedWord);
            for (int i = 0; i < maskedWord.Length; i++)
            {
                if (rand.NextDouble() < 0.7)
                {
                    maskedWord[i] = '?';
                }
            }
            randomtxt.Text = maskedWord.ToString();
        }
        private void guessbtn_Click(object sender, EventArgs e)
        {
            string guess = guesstxt.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(guess))
            {
                MessageBox.Show("Please enter a valid guess!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (guess == selectedWord.ToUpper())
            {
                MessageBox.Show("Correct! You guessed the word!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateRandomString();
            }
            else
            {
                if (!WrongGuessList.Items.Contains(guess))
                {
                    WrongGuessList.Items.Add(guess);
                }
                MessageBox.Show("Wrong guess! Try again.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            guesstxt.Text = "";

        }

        private void randomize_Click(object sender, EventArgs e)
        {
            GenerateRandomString();
            guesstxt.Text = "";
            wrongGuesses.Clear();
            WrongGuessList.Items.Clear();
            /*string input = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a valid string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string shuffledString = ShuffleString(input);
            string modifiedString = ReplaceWithQuestionMark(shuffledString);
            randomtxt.Text = "Modified: " + modifiedString;*/
        }
        /*private string ShuffleString(string str)
        {
            ArrayList charList = new ArrayList(str.ToCharArray());
            Random random = new Random();
            StringBuilder shuffledString = new StringBuilder();
            while (charList.Count > 0)
            {
                int randomIndex = random.Next(charList.Count);
                shuffledString.Append(charList[randomIndex]);
                charList.RemoveAt(randomIndex);
            }
            return shuffledString.ToString();
        }
        private string ReplaceWithQuestionMark(string str)
        {
            StringBuilder modifiedString = new StringBuilder(str);
            Random random = new Random();

            int replaceCount = (int)Math.Ceiling(str.Length * 0.3);
            for (int i = 0; i < replaceCount; i++)
            {
                int index = random.Next(str.Length);
                modifiedString[index] = '?';
            }
            return modifiedString.ToString();
        }*/

    }
}
