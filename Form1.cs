using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        bool check=false;
        bool dotVal1Check = false;
        bool dotVal2Check = false;
        string operater = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string firstValue = textBox1.Text;
            string secondValue = textBox2.Text;
            double result = 0.0;
            if(operater == "+")
            {
                result = double.Parse(firstValue) + double.Parse(secondValue);
                textBox3.Text = result.ToString();
            }
            else if(operater == "-")
            {
                result = double.Parse(firstValue) - double.Parse(secondValue);
                textBox3.Text = result.ToString();
            }
            else if (operater == "/")
            {
                if(double.Parse(secondValue) != 0)
                {
                    result = double.Parse(firstValue) / double.Parse(secondValue);
                    textBox3.Text = result.ToString();
                }
                else
                {
                    textBox3.Text = "Divided by zero.";
                }
            }
            else if (operater == "*")
            {
                result = double.Parse(firstValue) * double.Parse(secondValue);
                textBox3.Text = result.ToString();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(check==false && textBox1.Text.Length<10)
            {
                textBox1.Text += "1";
            }
            else if(check== true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "2";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "3";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "4";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "5";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "6";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "7";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "8";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "9";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (check == false && textBox1.Text.Length < 10)
            {
                textBox1.Text += "0";
            }
            else if (check == true && textBox2.Text.Length < 10)
            {
                textBox2.Text += "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)   //+ button pressed
        {
            if(textBox1.Text.Length > 0)
            {
                check = true;
                operater = "+";
                textBox4.Text = "+";
            }
        }

        private void button14_Click(object sender, EventArgs e)    //- button pressed
        {
            if (textBox1.Text.Length > 0)
            {
                check = true;
                operater = "-";
                textBox4.Text = "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)     //* button pressed
        {
            if (textBox1.Text.Length > 0)
            {
                check = true;
                operater = "*";
                textBox4.Text = "*";
            }
        }

        private void button16_Click(object sender, EventArgs e)     //(/)divide button pressed
        {
            if (textBox1.Text.Length > 0)
            {
                check = true;
                operater = "/";
                textBox4.Text = "/";
            }
        }

        private void button10_Click(object sender, EventArgs e)    //. button pressed
        {
            if (check == false && textBox1.Text.Length < 10 && dotVal1Check==false)
            {
                if(textBox1.Text.Length==0)
                {
                    textBox1.Text += "0";
                }
                textBox1.Text += ".";
                dotVal1Check = true;
            }
            else if (check == true && textBox2.Text.Length < 10 && dotVal2Check == false)
            {
                if (textBox2.Text.Length == 0)
                {
                    textBox2.Text += "0";
                }
                textBox2.Text += ".";
                dotVal2Check = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)   //AC BUTTON pressed
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            check = false;
            operater = "";
            dotVal1Check = false;
            dotVal2Check = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
