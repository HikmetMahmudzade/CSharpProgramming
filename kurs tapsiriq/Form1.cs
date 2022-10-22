using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs_tapsiriq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if(eded>0)
            {
                netice = "musbet";
            }
            else if(eded<0)
            {
                netice = "menfi";
            }
            else
            {
                netice = "sifir";
            }
            label1.Text = netice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if(eded == 0)
            {
                netice = "ne tekdir,ne cut";
            }
            else if (eded%2==0)
            {
                netice = "cut";
            }
            else
            {
                netice = "tek";
            }
            label1.Text = netice;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (eded%3==0||eded%4==0)
            {
             netice="bolunur";

            }
            else
            {
              netice="bolunmur";
            }
            label1.Text = netice;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (eded % 4 == 0 && eded % 6 == 0)
            {
             netice="bolunur";

            }
            else
            {
             netice="bolunmur";
            }
            label1.Text = netice;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (eded>=0&&eded<=100) {
                if (eded > 0 && eded <= 50)
                {
                    netice = "f";
                }
                else if (eded >= 51 && eded <= 60)
                {
                    netice = "e";
                }
                else if (eded >= 61 && eded <= 70)
                {
                    netice = "d";
                }
                else if (eded >= 71 && eded <= 80)
                {
                    netice = "c";
                }
                else if (eded >= 81 && eded <= 90)
                {
                    netice = "b";
                }
                else if (eded >= 91 && eded <= 100)
                {
                    netice = "a";
                }
            }
            else
            {
                netice = "bele netice yoxdur";
            }
            
            
            label1.Text = netice;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double qiymet = Convert.ToDouble(textBox1.Text);
            double endirim = 0;
            double ferq = 0;
            if (qiymet > 0 && qiymet <= 300)
            {
                ferq = qiymet * 5 / 100;
            }
            else if (qiymet >= 301 && qiymet <= 500)
            {
                ferq = qiymet * 10 / 100;
            }
            else if (qiymet >= 501 && qiymet <= 700)
            {
                ferq = qiymet * 15 / 100;
            }
            else if (qiymet >= 701)
            {
                ferq = qiymet * 20 / 100;
            }
            endirim = qiymet - ferq;
            label1.Text = endirim.ToString();
        }
    }
    }

