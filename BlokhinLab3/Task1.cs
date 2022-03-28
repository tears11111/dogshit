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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void result1Button_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            double z0 = 100 + 4 * p + 3 * q + 1;
            double currentSumCase1 = z0, currentSumCase2 = z0;
            double resultSum1 = z0, resultSum2 = z0;
            double additionalSum = 0;
            int i = (int)p + (int)q + 1;
            int t1 = 1, t2 = 0;

            StringBuilder sb = new StringBuilder();

            string[,] table = new string[20000, 4];
            table[0, 0] = "N1";
            table[0, 1] = "1 case";
            table[0, 2] = "N2";
            table[0, 3] = "2 case";

            sb.Append(table[0, 0] + '\t');
            sb.Append(table[0, 1] + '\t');
            sb.Append(table[0, 2] + '\t');
            sb.Append(table[0, 3] + '\n');

            chart.Series.Clear();
            chart.Series.Add("График функции y1(x)");
            chart.Series.Add("График функции y2(x)");
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Color = Color.Red;
            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[1].Color = Color.Blue;

            //z0 x2
            for (t1 = 1; resultSum1 < z0 * 2; t1++)
            {
                while (resultSum2 < z0 * 5)
                {
                    resultSum1 += currentSumCase1 * (i * 0.01);
                    resultSum2 += currentSumCase2 * (i * 0.01) + additionalSum;
                    currentSumCase1 = resultSum1;
                    currentSumCase2 = resultSum2;
                    additionalSum = z0 * 0.1 * t1;

                    table[t1, 0] = t1.ToString();
                    table[t1, 1] = resultSum1.ToString("#.##");
                    table[t1, 2] = t1.ToString();
                    table[t1, 3] = resultSum2.ToString("#.##");
                    sb.Append(table[t1, 0] + "\t");
                    sb.Append(table[t1, 1] + "\t");
                    sb.Append(table[t1, 2] + "\t");
                    sb.Append(table[t1, 3] + "\n");
                    t1++;
                    chart.Series[0].Points.AddXY(t1, resultSum1);
                    chart.Series[1].Points.AddXY(t1, resultSum2);
                }
                resultSum1 += currentSumCase1 * (i * 0.01);
                currentSumCase1 = resultSum1;
                table[t1, 0] = t1.ToString();
                table[t1, 1] = resultSum1.ToString("#.##");
                table[t1, 2] = "\t";
                table[t1, 3] = "\n";

                sb.Append(table[t1, 0] + "\t");
                sb.Append(table[t1, 1] + "\t");
                sb.Append(table[t1, 2] + "\t");
                sb.Append(table[t1, 3]);

                chart.Series[0].Points.AddXY(t1, resultSum1);
            }

            //z0 x5
            for (t2 = 1; resultSum2 < z0 * 5; t2++)
            {

            }

            resultTextBox.Text = sb.ToString();
        }

        private void result2Button_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            double z0 = 100 + 4 * p + 3 * q + 1;
            double currentSumCase1 = z0, currentSumCase2 = z0;
            double resultSum1 = z0, resultSum2 = z0;
            int i = (int)p + (int)q + 1;
        }
    }
}
