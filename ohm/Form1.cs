using System;
using System.Drawing;
using System.Windows.Forms;

namespace ohm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        evaluation eva = new evaluation();
        public int x, y; public double C, T;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    button1.BackColor = Color.Black;
                    x = 0;
                    break;
                case 1:
                    button1.BackColor = Color.Brown;
                    x = 1;
                    break;
                case 2:
                    button1.BackColor = Color.Red;
                    x = 2;
                    break;
                case 3:
                    button1.BackColor = Color.Orange;
                    x = 3;
                    break;
                case 4:
                    button1.BackColor = Color.Yellow;
                    x = 4;
                    break;
                case 5:
                    button1.BackColor = Color.Green;
                    x = 5;
                    break;
                case 6:
                    button1.BackColor = Color.Blue;
                    x = 6;
                    break;
                case 7:
                    button1.BackColor = Color.Purple;
                    x = 7;
                    break;
                case 8:
                    button1.BackColor = Color.Gray;
                    x = 8;
                    break;
                case 9:
                    button1.BackColor = Color.White;
                    x = 9;
                    break;
                case 10:
                    button1.BackColor = Color.Gold;
                    break;
                case 11:
                    button1.BackColor = Color.Silver;
                    break;
                case 12:
                    button1.BackColor = Color.Navy;
                    break;
                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    button2.BackColor = Color.Black;
                    y = 0;
                    break;
                case 1:
                    button2.BackColor = Color.Brown;
                    y = 1;
                    break;
                case 2:
                    button2.BackColor = Color.Red;
                    y = 2;
                    break;
                case 3:
                    button2.BackColor = Color.Orange;
                    y = 3;
                    break;
                case 4:
                    button2.BackColor = Color.Yellow;
                    y = 4;
                    break;
                case 5:
                    button2.BackColor = Color.Green;
                    y = 5;
                    break;
                case 6:
                    button2.BackColor = Color.Blue;
                    y = 6;
                    break;
                case 7:
                    button2.BackColor = Color.Purple;
                    y = 7;
                    break;
                case 8:
                    button2.BackColor = Color.Gray;
                    y = 8;
                    break;
                case 9:
                    button2.BackColor = Color.White;
                    y = 9;
                    break;
                case 10:
                    button2.BackColor = Color.Gold;
                    break;
                case 11:
                    button2.BackColor = Color.Silver;
                    break;
                case 12:
                    button2.BackColor = Color.Navy;
                    break;
                default:
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    button3.BackColor = Color.Black;
                    C = 10;
                    break;
                case 1:
                    button3.BackColor = Color.Brown;
                    C = 100;
                    break;
                case 2:
                    button3.BackColor = Color.Red;
                    C = 1000;
                    break;
                case 3:
                    button3.BackColor = Color.Orange;
                    C = 10000;
                    break;
                case 4:
                    button3.BackColor = Color.Yellow;
                    C = 100000;
                    break;
                case 5:
                    button3.BackColor = Color.Green;
                    C = 1000000;
                    break;
                case 6:
                    button3.BackColor = Color.Blue;
                    C = 10000000;
                    break;
                case 7:
                    button3.BackColor = Color.Purple;
                    C = (100000000);
                    break;
                case 8:
                    button3.BackColor = Color.Gray;
                    C = (1000000000);
                    break;
                case 9:
                    button3.BackColor = Color.White;
                    C = (10000000000);
                    break;
                case 10:
                    button3.BackColor = Color.Gold;
                    C = (1);
                    break;
                case 11:
                    button3.BackColor = Color.Silver;
                    C = (-10);
                    break;
                case 12:
                    button3.BackColor = Color.Navy;
                    break;
                default:
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    button4.BackColor = Color.Black;
                    break;
                case 1:
                    button4.BackColor = Color.Brown;
                    T = (1);
                    break;
                case 2:
                    button4.BackColor = Color.Red;
                    T = (2);
                    break;
                case 3:
                    button4.BackColor = Color.Orange;
                    break;
                case 4:
                    button4.BackColor = Color.Yellow;
                    break;
                case 5:
                    button4.BackColor = Color.Green;
                    T = (0.5);
                    break;
                case 6:
                    button4.BackColor = Color.Blue;
                    T = (0.25);
                    break;
                case 7:
                    button4.BackColor = Color.Purple;
                    T = (0.1);
                    break;
                case 8:
                    button4.BackColor = Color.Gray;
                    T = (0.05);
                    break;
                case 9:
                    button4.BackColor = Color.White;
                    break;
                case 10:
                    button4.BackColor = Color.Gold;
                    T = (5);
                    break;
                case 11:
                    button4.BackColor = Color.Silver;
                    T = (10);
                    break;
                case 12:
                    button4.BackColor = Color.Navy;
                    T = (20);
                    break;
                default:
                    break;
            }
            ABC();
        }

        void ABC()
        {
            object a = evo.product(x,y,C,T);
            a = string.Format("{0:#,0}", a);
            Result.Text = b + "K" + "Ω" + "±" + "%" + T;
        }
    }
}
