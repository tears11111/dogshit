using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokhinLab222
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            double y1 = 0, y2 = 0;
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            int a = 0, b = (int)p + (int)q + 1;

            StringBuilder sb = new StringBuilder();

            string[,] table = new string[b + 1, 3];
            table[0, 0] = "№";
            table[0, 1] = "y1";
            table[0, 2] = "y2";

            sb.Append(table[0, 0] + '\t');
            sb.Append(table[0, 1] + '\t');
            sb.Append(table[0, 2] + '\n');

            chart.Series.Clear();
            chart.Series.Add("График функции y1(x)");
            chart.Series.Add("График функции y2(x)");
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Color = Color.Red;
            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[1].Color = Color.Blue;

            for (int x = a; x <= b; x++)
            {
                y1 = (6 * p + 4 * q + 1) / (x + 1);
                y2 = (p + q + 1) * Math.Sqrt(x) + p;

                table[x, 0] = (x + 1).ToString();
                table[x, 1] = y1.ToString("#.##");
                table[x, 2] = y2.ToString("#.##");

                sb.Append(table[x, 0] + '\t');
                sb.Append(table[x, 1] + '\t');
                sb.Append(table[x, 2] + '\n');

                chart.Series[0].Points.AddXY(x + 1, y1);
                chart.Series[1].Points.AddXY(x + 1, y2);
            }

            resultTextBox.Text = sb.ToString();
        }
    }
}
