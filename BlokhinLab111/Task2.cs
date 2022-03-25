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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(qValue.Value);
            double p = Convert.ToDouble(pValue.Value);

            double a = -(2 * p + q + 2);
            double b = p + q - 1;
            double h = 0.2;
            int counter = 0;
            StringBuilder sb = new StringBuilder();

            if (a < b)
            {
                for (double x = a; x <= b; x += h)
                {
                    counter++;
                    double y = 0.25 * (p + 0.4) * Math.Pow(x, 2) - 0.35 * (q - p + 1) * Math.Pow(Math.Abs(x), 1.5);
                    sb.Append(counter.ToString() + ": ");
                    sb.Append(y.ToString());
                    sb.Append('\n');
                }
            }
            else if (a > b)
            {
                for (double x = a; x >= b; x -= h)
                {
                    counter++;
                    double y = 0.25 * (p + 0.4) * Math.Pow(x, 2) - 0.35 * (q - p + 1) * Math.Pow(Math.Abs(x), 1.5);
                    sb.Append(counter.ToString() + ": ");
                    sb.Append(y.ToString());
                    sb.Append('\n');
                }
            }
            else if (a == b)
            {
                counter = 1;
            }
            sb.Append("Количество точек: ");
            sb.Append(counter.ToString());
            resultValue.Text = sb.ToString();
        }
    }
}
