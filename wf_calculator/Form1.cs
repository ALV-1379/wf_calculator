using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);
            double answer = num1 + num2;
            MessageBox.Show($"jam do adad = {answer}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);
            double answer = num1 * num2;
            MessageBox.Show($"zarb do adad = {answer}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);
            double answer = num1 - num2;
            MessageBox.Show($"menhaye do adad = {answer}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);
            double answer = num1 / num2;
            MessageBox.Show($"taghsim do adad = {answer}");
        }
    }
}
