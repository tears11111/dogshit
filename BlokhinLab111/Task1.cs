using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokhinLab111
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(qValue.Value);
            double p = Convert.ToDouble(qValue.Value);

            double u = 2 * p - 3 * q + 4;
            double d = 1 + p * q;
            double v = p + q / 2 - 1;
            double s = p + q + 2;

            const int k = 10;
            double sum = 0;

            for (int i = 1; i <= k; i++)
            {
                sum += (p + (2 * i)) * (u + ((i - 1) * d)) + ((3 * q) + 1) * (v * Math.Pow(s, i - 1));
            }
            result.Text = sum.ToString();
        }

        private void qValue_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
