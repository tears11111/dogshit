using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokhinLab3
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            int t = 5;
            double requiredSum = 10 * (100 + 4 * p + 3 * q + 1);
            int i = (int)p + (int)q + 1;
            double z0 = 0;

            startSum.Text = requiredSum.ToString("#.##");

            for (int j = t; j >= 1; j--)
            {
                z0 = requiredSum - requiredSum * (i * 0.01);
                requiredSum = z0;
            }

            finalSum.Text = z0.ToString("#.##");
        }
    }
}
