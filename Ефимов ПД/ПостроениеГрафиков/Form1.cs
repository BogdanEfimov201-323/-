using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace ПостроениеГрафиков
{
    public partial class Form1 : Form
    {
        static double G(double X, double Y, double YP)
        {
            X = (2 * 3.14159265358979) * (2 * 3.14159265358979) * Y;
            Y = (2 * 3.14159265358979) * (2 * 3.14159265358979) * Y;
            YP = (2 * 3.14159265358979) * (2 * 3.14159265358979) * Y;
            return YP;
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void label14_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void label25_Click(object sender, EventArgs e)
        {
        }
        private void label13_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
                    double A, B, C, D, E, F, H, O, P, Q, R, S, T, U, V, W, X, Y, Z, OMEGA, OMEGA2, Y0, YP0, Y1=0, YS1=0, YP1=0, YP=0, YS=0;
                    OMEGA = Convert.ToDouble(textBox9.Text);
                    OMEGA2 = OMEGA * OMEGA;
                    Y0 = Convert.ToDouble(textBox8.Text);
                    YP0 = Convert.ToDouble(textBox7.Text);
                    A = 1 / 6;
                    T = 1 / 2;
                    H = Convert.ToDouble(textBox6.Text);
                    X = 0;
                    Y = Y0;
                    YP = YP0;
                    YS = G(X, Y, YP);
                    for (int I = 1; I <= 10; I++)
                    {
                        V = Math.Cos(OMEGA * X);
                        E = Math.Abs(V - Y) / V;
                        YS1 = YS;
                        Y1 = Y + H * YP + 0.5 * H * H * (A * YS1 + (1 - A) * YS);
                        YP1 = YP + H * (T * YS1 + (1 - T) * YS);
                        YS1 = G(X + H, Y1, YP1);
                        Y1 = Y + H * YP + 0.5 * H * H * (A * YS1 + (1 - A) * YS);
                        YP1 = YP + H * (T * YS1 + (1 - T) * YS);
                        YS1 = G(X + H, Y1, YP1);
                        Y1 = Y + H * YP + 0.5 * H * H * (A * YS1 + (1 - A) * YS);
                        YP1 = YP + H * (T * YS1 + (1 - T) * YS);
                        X = X + H;
                        Y = Y1;
                        YP = YP1;
                        YS = G(X, Y, YP);
                    }
            textBox1.Text = Convert.ToString(Y1);
            textBox13.Text = Convert.ToString(YP1);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
