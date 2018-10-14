using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number1 = double.Parse(this.textBox1.Text);
            var number2 = double.Parse(this.textBox2.Text);
            var result = number1 + number2;
            this.textBox3.Text = result.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var number3 = double.Parse(this.textBox5.Text);
            var number4 = double.Parse(this.textBox6.Text);
            var result2 = number3 - number4;
            this.textBox4.Text = result2.ToString();
        }
    }
}
