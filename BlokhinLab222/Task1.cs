using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;

namespace BlokhinLab222
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            int totalYears = 5;
            double y1, y2;
            double income1 = 0, income2 = 0, amount1 = 0, amount2 = 0;
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            double firstPercentage = p + q + 1;

            StringBuilder sb = new StringBuilder();

            double[] yearIncome1 = { firstPercentage, 1.2 * firstPercentage, 1.3 * firstPercentage, 1.25 * firstPercentage, 1.2 * firstPercentage };
            double[] yearIncome2 = { p + q + 4, 1.1 * (p + q + 2), 1.2 * (p + q + 3), 1.24 * (p + q + 1), 1.2 * (p + q + 6) };
            string[,] table = new string[7, 5];
            table[0, 0] = "t";
            table[0, 1] = "Объем 1";
            table[0, 2] = "Объем 2";
            table[0, 3] = "Прибыль 1";
            table[0, 4] = "Прибыль 2";

            sb.Append(table[0, 0] + '\t');
            sb.Append(table[0, 1] + "\t\t");
            sb.Append(table[0, 2] + "\t\t");
            sb.Append(table[0, 3] + '\t');
            sb.Append(table[0, 4] + '\n');

            chart.Series.Clear();
            chart.Series.Add("График функции y1(x)");
            chart.Series.Add("График функции y2(x)");
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Color = Color.Red;
            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[1].Color = Color.Blue;


            for (int t = 1; t <= totalYears; t++)
            {
                y1 = (1 + p) + (1 + q) * t + Math.Pow(t, 2);
                y2 = Math.Pow((1.2 + p + q), t);
                income1 += yearIncome1[t - 1] * y1;
                income2 += yearIncome2[t - 1] * y2;
                amount1 += y1;
                amount2 += y2;
                table[t, 0] = t.ToString();
                table[t, 1] = y1.ToString("#.##");
                table[t, 2] = y2.ToString("#.##");
                table[t, 3] = (yearIncome1[t - 1] * y1).ToString("#.##");
                table[t, 4] = (yearIncome2[t - 1] * y2).ToString("#.##");

                sb.Append(table[t, 0] + '\t');
                sb.Append(table[t, 1] + "\t\t");
                sb.Append(table[t, 2] + "\t\t");
                sb.Append(table[t, 3] + "\t\t");
                sb.Append(table[t, 4] + '\n');

                chart.Series[0].Points.AddXY(t, yearIncome1[t - 1] * y1);
                chart.Series[1].Points.AddXY(t, yearIncome2[t - 1] * y2);
            }

            sb.Append("Всего" + '\t');
            sb.Append(amount1.ToString("#.##") + "\t\t");
            sb.Append(amount2.ToString("#.##") + "\t\t");
            sb.Append(income1.ToString("#.##") + "\t\t");
            sb.Append(income2.ToString("#.##"));

            resultTextBox.Text = sb.ToString();
        }
    }
}
