using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Replace With Alphabet Position

//Welcome.

//In this kata you are required to, given a string, replace every letter with its position in the alphabet.

//If anything in the text isn't a letter, ignore it and don't return it.

//a being 1, b being 2, etc.

//As an example:

//Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
//Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" as a string.

//best solution:
//using System.Linq;
//public static class Kata
//{
//    public static string AlphabetPosition(string text)
//    {
//        return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
//    }
//}


namespace Codewars_ReplaceWithAlphabetPosition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string AlphabetPosition(string text)
        {
            text = text.ToUpper();
            string new_text = string.Empty;
            List<char> Alphabet = new List<char> {'A','B', 'C','D', 'E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            for(int i=0; i<text.Length;i++)
            {
                char ch = Convert.ToChar(text.Substring(i, 1));
                if (Alphabet.Contains(ch))
                {
                    new_text += Convert.ToString(Alphabet.IndexOf(ch) + 1) + " "; 
                }           
            }

            return new_text.TrimEnd();
        }


        private void button_convert_Click(object sender, EventArgs e)
        {
            richTextBox_output.Text = AlphabetPosition(richTextBox_input.Text);
        }
    }
}
