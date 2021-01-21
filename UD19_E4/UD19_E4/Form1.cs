using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD19_E4
{
    public partial class Form1 : Form
    {
        bool ComaUtilizada = false;
        bool PantallaLimpia = true;
        double NumMemoria = 0;
        int operacion = 0;
        string resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (PantallaLimpia)
            {
                textBox1.Text = "1";
                PantallaLimpia = false;
            }
            else
            {
                textBox1.Text += "1";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (PantallaLimpia)
            {
                textBox1.Text = "2";
                PantallaLimpia = false;
            }
            else
            {
                textBox1.Text += "2";
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (ComaUtilizada == false)
            {
                ComaUtilizada = true;
                if (PantallaLimpia)
                {
                    textBox1.Text = "0.";
                    PantallaLimpia = false;
                }
                else
                {
                    textBox1.Text += ".";
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (PantallaLimpia)
            {
                textBox1.Text = "3";
                PantallaLimpia = false;
            }
            else
            {
                textBox1.Text += "3";
            }
        }
    

        private void button8_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        textBox1.Text = "4";
                        PantallaLimpia = false;
                    }
                    else
                    {
                        textBox1.Text += "4";
                    }
        }

        private void button7_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        textBox1.Text = "5";
                        PantallaLimpia = false;
                    }
                    else
                    {
                        textBox1.Text += "5";
                    }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        textBox1.Text = "6";
                        PantallaLimpia = false;
                    }
                    else
                    {
                        textBox1.Text += "6";
                    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        textBox1.Text = "7";
                        PantallaLimpia = false;
                    }
                    else
                    {
                        textBox1.Text += "7";
                    }
                }

        private void button1_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        textBox1.Text = "8";
                        PantallaLimpia = false;
                    }
                    else
                    {
                        textBox1.Text += "8";
                    }
                }

        private void button2_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        textBox1.Text = "9";
                        PantallaLimpia = false;
                    }
                    else
                    {
                        textBox1.Text += "9";
                    }
                }

        private void button16_Click(object sender, EventArgs e)
        {
                    if (PantallaLimpia)
                    {
                        
                    }
                    else
                    {
                        textBox1.Text += "0";
                    }
                }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operacion != 0)
            {
                switch (operacion)
                {
                    case 1:
                        resultado = Convert.ToString(NumMemoria + Convert.ToDouble(textBox1.Text));
                        textBox1.Text = resultado;
                        NumMemoria = 0;
                        PantallaLimpia = true;
                        break;
                    case 2:
                        resultado = Convert.ToString(NumMemoria - Convert.ToDouble(textBox1.Text));
                        textBox1.Text = resultado;
                        NumMemoria = 0;
                        PantallaLimpia = true;
                        break;
                    case 3:
                        resultado = Convert.ToString(NumMemoria * Convert.ToDouble(textBox1.Text));
                        textBox1.Text = resultado;
                        NumMemoria = 0;
                        PantallaLimpia = true;
                        break;
                    case 4:
                        if (textBox1.Text != "0")
                        {
                            resultado = Convert.ToString(NumMemoria / Convert.ToDouble(textBox1.Text));
                            textBox1.Text = resultado;
                            NumMemoria = 0;
                            PantallaLimpia = true;
                        }
                        else
                        {
                            MessageBox.Show("No dividas entre zero!");
                        }
                        
                        break;
                }
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            PantallaLimpia = true;
            NumMemoria = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion = 1; //suma
            NumMemoria = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            PantallaLimpia = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacion = 2; //resta
            NumMemoria = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            PantallaLimpia = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operacion = 3; //producto
            NumMemoria = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            PantallaLimpia = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operacion = 4; //div
            NumMemoria = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            PantallaLimpia = true;
        }
    }
}
