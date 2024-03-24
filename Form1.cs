using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text=textBox1.Text.Trim(); 
            String key=textBox2.Text.Trim();
            VigenerCipher vigenerCipher = new VigenerCipher();
            String cipher=vigenerCipher.EncryptVigenere(text, key);
            label8.Text = cipher;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   String cipher=textBox4.Text.Trim();
            String key=textBox3.Text.Trim();
            VigenerCipher vigenerCipher = new VigenerCipher();
            String text=vigenerCipher.DecryptVigenere(cipher,key);
            label9.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
