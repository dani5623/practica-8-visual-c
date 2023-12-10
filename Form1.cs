using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_8_visual__c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592; 
            double radio1, area1, volumen1; 
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3); 
            textBox2.Text = area1.ToString();
            textBox3.Text = volumen1.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            double Base, area, Altura;
           Base = double.Parse(textBox4.Text);
            Altura = double.Parse(textBox5.Text);
            area = Base*Altura/2;
            textBox6.Text = area.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a, area, volumen;
            a = double.Parse(textBox7.Text);
            volumen = a*a*a;
            area = 6*a*a;
            textBox8.Text = area.ToString();
            textBox9.Text = volumen.ToString();
           


        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1,altura, area1, volumen1;
            radio1 = double.Parse(textBox10.Text);
            altura=double.Parse(textBox11.Text);
            area1 = (2*pi*radio1*altura)+(pi*pi*radio1*radio1);
            volumen1 = pi*radio1*radio1*altura;
            textBox12.Text = area1.ToString();
            textBox13.Text = volumen1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double D, d,area;
            D = double.Parse(textBox14.Text);
            d = double.Parse(textBox15.Text);
            area = D*d/2;
            textBox16.Text = area.ToString();
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a, volumen, area;
            a = double.Parse(textBox17.Text);
            volumen =1.4/3*a*a*a;
            area = 2 * 1.73 * a * a;
            textBox18.Text = area.ToString();
            textBox19.Text = volumen.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
