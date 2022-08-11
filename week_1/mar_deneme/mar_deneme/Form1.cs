using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mar_deneme
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = ("0 + ");
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
                Operation = "+";
                label1.Text = FirstNumber.ToString() + " +";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = ("0 - ");
            }
            else {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
                Operation = "-";
                label1.Text = FirstNumber.ToString() + " -";
            }
            
        
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label1.Text = ("0 x ");
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
                Operation = "*";
                label1.Text = FirstNumber.ToString() + " x";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label1.Text = ("0 / ");
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
                Operation = "/";
                label1.Text = FirstNumber.ToString() + " /";
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            if (textBox1.Text == "")
            {
                label1.Text = ("0 ");
            }
            else
            {
                SecondNumber =
                    Convert.ToDouble(textBox1.Text);
                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    label1.Text = FirstNumber.ToString();
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    label1.Text = FirstNumber.ToString();
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    label1.Text = FirstNumber.ToString();
                }
                if (Operation == "/")
                    if (SecondNumber == 0)
                    {
                        textBox1.Text = "0'a bölünemez!";
                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                        label1.Text = FirstNumber.ToString();
                    }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Text = null;
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = null;
            }
            else 
            { 
            string sil;

            sil = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            textBox1.Text = sil;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.button10.BackColor = Color.Teal;
                this.button14.BackColor = Color.Teal;
                this.button11.BackColor = Color.Teal;
                this.button12.BackColor = Color.Teal;
                this.button15.BackColor = Color.Teal;
                this.button17.BackColor = Color.Teal;
                this.button19.BackColor = Color.Teal;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                this.button10.BackColor = Color.Orange;
                this.button14.BackColor = Color.Orange;
                this.button11.BackColor = Color.Orange;
                this.button12.BackColor = Color.Orange;
                this.button15.BackColor = Color.Orange;
                this.button17.BackColor = Color.Orange;
                this.button19.BackColor = Color.Orange;

            }
        }
    }
}
