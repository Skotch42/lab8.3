using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        double[] count_prob = new double[5];

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            Random generator = new Random();
            int[] number = new int[(int)numericUpDown5.Value];

            for (int j = 0; j < (int)numericUpDown5.Value; j++)
            {
                number[j] = generator.Next(1, 100);
            }

            for (int j = 0; j < (int)numericUpDown5.Value; j++)
            {
                int i = 0;
                int[] prob = new int[5];
                prob[0] = (int)numericUpDown1.Value;
                prob[1] = (int)numericUpDown2.Value;
                prob[2] = (int)numericUpDown3.Value;
                prob[3] = (int)numericUpDown4.Value;
                prob[4] = 100 - prob[0] - prob[1] - prob[2] - prob[3];

                do
                {
                    number[j] -= prob[i];
                    i++;

                } while (number[j] > 0);


                i--;
                count_prob[i]++;


            }

            for (int j = 0; j < 5; j++)
            {
                count_prob[j] = count_prob[j] / (int)numericUpDown5.Value * 100;
                Math.Round(count_prob[j]);
            }

            chart1.Series[0].Points.AddXY("Prob1", count_prob[0]);
            chart1.Series[0].Points.AddXY("Prob2", count_prob[1]);
            chart1.Series[0].Points.AddXY("Prob3", count_prob[2]);
            chart1.Series[0].Points.AddXY("Prob4", count_prob[3]);
            chart1.Series[0].Points.AddXY("Prob5", count_prob[4]);

            for (int j = 0; j < 5; j++)
            {
                count_prob[j] = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
