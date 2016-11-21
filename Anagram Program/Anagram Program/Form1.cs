using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagram_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == textBox2.Text)
            {
                label3.Text = "These strings are anagrams";
            }

            else if (textBox1.TextLength != textBox2.TextLength)
            {
                label3.Text = "These strings are not anagrams";
            }

            else if (textBox1.TextLength == textBox2.TextLength)
            {
                string TextBox1 = textBox1.Text;
                string TextBox2 = textBox2.Text;

                char[] StrTB1 = TextBox1.ToLower().ToCharArray();
                char[] StrTB2 = TextBox2.ToLower().ToCharArray();

                

                Array.Sort(StrTB1);
                Array.Sort(StrTB2);

                string NewStrTB1 = new string(StrTB1);
                string NewStrTB2 = new string(StrTB2);

                label4.Text = NewStrTB1;

                if (NewStrTB1 == NewStrTB2)
                {
                    label3.Text = "These strings are anagrams";
                }
                else
                {
                    label3.Text = "These strings are not anagrams";
                }
            }
        }
    }
}
