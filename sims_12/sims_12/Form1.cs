using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        double[] lambda = new double[2] { 0.5, 0.3 };
        double[] date = new double[2];
        double[] now = new double[2];
        double[] time = new double[2];
        double alpha;
        int n = 0, s=0;
        int money = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i<2; i++)
            {
                if (now[i] != time[i])
                {
                    date[i]++;
                    now[i] = date[i] / 10;

                }
                else
                {
                    if(i==0)
                    {
                        n++;
                        label_clients.Text = "All clients: " + n;
                        change(10);
                        time_to_next(i, 1);
                    }
                    if (i == 1 && (n-s>0))
                    {
                        s++;
                        label_out.Text = "Insurance: " + s;
                        change(-20);
                        time_to_next(i, (n-s));
                    }
                }
            }
            
        }

        private void change(int v)
        {
            money += v;
            label_money.Text = "Money: " + money;
            label_now.Text = "Clients now: " + (n - s);
            if (money<0)
            {
                end();
            }
        }

        private void end()
        {
            timer1.Enabled = false;
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    time_to_next(i, 1);
                }

               else
                {
                    time_to_next(i, (n-s));
                }
            }
                button1.Enabled = false;
                timer1.Enabled = true;
        }

        private void time_to_next(int i, int k)
        {
   
            alpha = rnd.NextDouble();
            date[i] = 0;
            now[i] = 0;
            if (k!=0)
            {
                time[i] = Math.Round((-Math.Log(alpha) / lambda[i]*k), 1);
            }
            else
            {
                time[i] = 5.0;
            }
        }
    }
}
