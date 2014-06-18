using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sinhala;

namespace SinhalaAPI_Ex01
{
    public partial class Form1 : Form
    {
        Singlish singlish; //making a variable for singlish object

        public Form1()
        {
            InitializeComponent();
            singlish = new Singlish(); //initializing the variable
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = singlish.toSinhala(textBox1.Text); //converting to sinhala
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = singlish.toSinglish(textBox3.Text); //converting to singlish
        }
    }
}
