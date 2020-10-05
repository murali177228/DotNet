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
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }


      

        private void n1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }
        private void n2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void n3_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }
        private void n4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

       

       

        private void n7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "/";
            lblDisplay.Text = FirstNumber + Operation;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "*";
            lblDisplay.Text = FirstNumber + Operation;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "-";
            lblDisplay.Text = FirstNumber + Operation;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "+";
            lblDisplay.Text = FirstNumber + Operation;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtResult.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                lblDisplay.Text = FirstNumber + Operation + SecondNumber;
                txtResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
                
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtResult.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtResult.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void nDot_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }
    }
}
