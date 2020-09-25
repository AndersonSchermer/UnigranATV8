using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC_Unigran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = ((float.Parse(textBox2.Text)/(float.Parse(textBox1.Text)*(float.Parse(textBox1.Text))))*10000).ToString("0.00");
        }
    }
}
