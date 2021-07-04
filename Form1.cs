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
    public partial class CALCULATOR : Form
    {
        double val = 0;
        double val1 = 0;
        string text = "";
        bool operator_pres = false;
        public CALCULATOR()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            if((output.Text == "0") || (operator_pres))
            {
                output.Clear();
            }
            operator_pres = false;
            Button button = (Button)sender;
            output.Text = output.Text + button.Text;

        }

        private void button_19_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void operator_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = double.Parse(output.Text);
            operator_pres = true;
        }

        private void operators(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    output.Text = (val + double.Parse(output.Text)).ToString(); break;
                case "-":
                    output.Text = (val - double.Parse(output.Text)).ToString(); break;
                case "÷":
                    output.Text = (val / double.Parse(output.Text)).ToString(); break;
                case "x":
                    output.Text = (val * double.Parse(output.Text)).ToString(); break;
                case "%":
                    output.Text = (val % double.Parse(output.Text)).ToString(); break;

                default:
                    break;
            }
            operator_pres = false;
        }

        private void butt(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = double.Parse(output.Text);
            double x = 1 / val;
            output.Text = Convert.ToString(x);
        }

        private void clear(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            output.Clear();
            val = 0;
        }

        private void butt_clr(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(output.TextLength > 0)
            {
                output.Text = output.Text.Remove(output.TextLength - 1);
            }
            
            }

        private void butt_sqr(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (output.TextLength != 0)
            {
                val = double.Parse(output.Text);
                output.Text = (val * val).ToString();
            }
        }

        private void butt_sqrt(object sender, EventArgs e)
        {
            if(output.TextLength != 0)
            {
                val = double.Parse(output.Text);
                output.Text = Math.Sqrt(val).ToString();
            }
        }

        private void butt_change(object sender, EventArgs e)
        {
            if(output.TextLength != 0)
                    {
                          val = double.Parse(output.Text);
                           output.Text = (val * (-1)).ToString();
                      }    
             }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

