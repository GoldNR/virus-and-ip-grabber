using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string word = "number";
        StringBuilder sb = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Guess the Word";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(word))
            {
                MessageBox.Show("Correct guess!");
                label1.Text = word;
            }
            else
            {
                if (!(sb.ToString().Contains(textBox2.Text)))
                {
                    sb.AppendLine(textBox2.Text);
                }
                wrongGuesses.Text = sb.ToString();
                textBox2.Clear();
                MessageBox.Show("Wrong guess!\nTry again.");
            }
        }
    }
}