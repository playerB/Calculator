using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int val_in = 0, sum = 0;
        String recent_op = "+";
        public void operate()
        {
            if (recent_op == "+")
            {
                if (int.TryParse(input.Text, out val_in))
                {
                    sum += val_in;
                }
            }
            else if (recent_op == "-")
            {
                if (int.TryParse(input.Text, out val_in))
                {
                    sum -= val_in;
                }
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
            sum = 0; val_in = 0;
        }
        private void equal_Click(object sender, EventArgs e)
        {
            operate();
            input.Text = sum.ToString();
            output.Text = "";
            sum = 0; val_in = 0; recent_op = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input.Text, out val_in))
            {
                operate();
                output.Text += input.Text + "-";
                input.Text = "";
                recent_op = "-";
            }
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input.Text, out val_in))
            {
                operate();
                output.Text += input.Text + "+";
                input.Text = "";
                recent_op = "+";
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            if (input.Text != "0") input.Text += "0";
            else if (input.Text == "") input.Text = "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")  input.Text = "1";
            else input.Text += "1";
        }
        private void two_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "2";
            else input.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "3";
            else input.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "4";
            else input.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "5";
            else input.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")  input.Text = "6";
            else input.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "7";
            else input.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "8";
            else input.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (input.Text == "0") input.Text = "9";
            else input.Text += "9";
        }
    }
}
