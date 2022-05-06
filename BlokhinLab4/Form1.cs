using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokhinLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int t = 5;
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            double x11, x12, x13, x21, x22, x23, x31, x32, x33;
            double c1, c2, c3;
            double b1, b2, b3;
            double deltaCommon, delta1, delta2, delta3;
            double volumeProduction1, volumeProduction2;
            double pogrMax, priblMax;
            double pogrSchema, priblSchema;
            double[] monthlyVolume = new double[t + 1];
            double[] linearTrend = new double[t];
            string[,] tableOfVolume = new string[6, 7];
            double[] futures1 = new double[t + 1];
            double[] futures2 = new double[t + 1];
            double[] pogrSchemaArray = new double[t + 1];
            double[] priblSchemaArray = new double[t + 1];

            chart1.Series.Clear();
            chart1.Series.Add("Реальный объем выпуска");
            chart1.Series.Add("Линейный тренд");
            chart1.Series.Add("Квадратичный тренд");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Color = Color.Blue;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].Color = Color.Green;

            StringBuilder sb = new StringBuilder();

            tableOfVolume[0, 0] = "Месяц";
            tableOfVolume[1, 0] = "Объем выпуска тыс. шт.";
            tableOfVolume[2, 0] = "Линейный тренд";
            tableOfVolume[3, 0] = "Квадратичный тренд";
            tableOfVolume[4, 0] = "Погрешность лин тренда";
            tableOfVolume[5, 0] = "Погрешность квадр тренда";

            sb.Append(tableOfVolume[0, 0] + "\t\t\t");
            

            for (int i = 1; i <= t + 1; i++)
            {
                tableOfVolume[0, i] = $"{i}";
                sb.Append(tableOfVolume[0, i] + "\t");
            }

            sb.Append("\n");
            sb.Append(tableOfVolume[1, 0] + "\t");

            for (int i = 1; i <= t; i++)
            {
                monthlyVolume[i - 1] = 10 + 0.05 * (p + 2 * q + 1) * i + 
                    0.01 * (p + q + 1) * Math.Pow(i, 2) + 0.02 * (2 * p + q + 1) * Math.Pow(-1, i);
                tableOfVolume[1, i] = monthlyVolume[i - 1].ToString(".##");
                sb.Append(tableOfVolume[1, i] + "\t");
                chart1.Series[0].Points.AddXY(i, monthlyVolume[i - 1]);
            }
            monthlyVolume[5] = 10 + 0.05 * (p + 2 * q + 1) * 6 +
                    0.01 * (p + q + 1) * Math.Pow(6, 2) + 0.02 * (2 * p + q + 1) * Math.Pow(-1, 6);
            sb.Append("-");
            sb.Append("\n");

            x11 = 5; x12 = 15; x13 = 55; x21 = x12; x22 = 55; x23 = 225; x31 = x13; x32 = x23; x33 = 979;
            b1 = monthlyVolume[0] + monthlyVolume[1] + monthlyVolume[2] + monthlyVolume[3] + monthlyVolume[4];
            b2 = monthlyVolume[0] * 1 + monthlyVolume[1] * 2 + monthlyVolume[2] * 3
                + monthlyVolume[3] * 4 + monthlyVolume[4] * 5;
            b3 = Math.Pow(1, 2) * monthlyVolume[0] + Math.Pow(2, 2) * monthlyVolume[1] + Math.Pow(3, 2) *monthlyVolume[2]
                + Math.Pow(4, 2) * monthlyVolume[3] + Math.Pow(5, 2) * monthlyVolume[4];

            //2x2
            deltaCommon = CalculateDet2x2(x11, x12, x21, x22);
            delta1 = CalculateDet2x2(b1, x12, b2, x22);
            delta2 = CalculateDet2x2(x11, b1, x21, b2);
            c1 = delta1 / deltaCommon;
            c2 = delta2 / deltaCommon;

            sb.Append(tableOfVolume[2, 0] + "\t\t");
            pogrMax = Math.Round((Math.Abs((c1 + c2 * 1) - monthlyVolume[0]) / monthlyVolume[0]) * 100, 2);
            for (int i = 1; i <= t; i++)
            {
                volumeProduction1 = c1 + c2 * i;
                futures1[i - 1] = volumeProduction1;
                pogrSchema = Math.Round((Math.Abs(volumeProduction1 - monthlyVolume[i - 1]) / monthlyVolume[i - 1]) * 100, 2);
                if (pogrSchema > pogrMax) pogrMax = pogrSchema;
                pogrSchemaArray[i - 1] = pogrSchema;
                sb.Append(futures1[i - 1].ToString(".##") + "\t");
                chart1.Series[1].Points.AddXY(i, futures1[i - 1]);
            }
            volumeProduction1 = c1 + c2 * 6;
            futures1[5] = volumeProduction1;
            sb.Append(futures1[5].ToString(".##") + "\n");

            //3x3
            deltaCommon = CalculateDet3x3(x11, x12, x13, x21, x22, x23, x31, x32, x33);
            delta1 = CalculateDet3x3(b1, x12, x13, b2, x22, x23, b3, x32, x33);
            delta2 = CalculateDet3x3(x11, b1, x13, x21, b2, x23, x31, b3, x33);
            delta3 = CalculateDet3x3(x11, x12, b1, x21, x22, b2, x31, x32, b3);
            c1 = delta1 / deltaCommon;
            c2 = delta2 / deltaCommon;
            c3 = delta3 / deltaCommon;

            sb.Append(tableOfVolume[3, 0] + "\t");
            priblMax = Math.Round((Math.Abs((c1 + c2 * 1 + c3 * Math.Pow(1, 2)) - monthlyVolume[0]) / monthlyVolume[0]) * 100, 2);
            for (int i = 1; i <= t; i++)
            {
                volumeProduction2 = c1 + c2 * i + c3 * Math.Pow(i, 2);
                futures2[i - 1] = volumeProduction2;
                priblSchema = Math.Round((Math.Abs(volumeProduction2 - monthlyVolume[i - 1]) / monthlyVolume[i - 1]) * 100, 2);
                if (priblSchema > priblMax) priblMax = priblSchema;
                priblSchemaArray[i - 1] = priblSchema;
                sb.Append(futures2[i - 1].ToString(".##") + "\t");
                chart1.Series[2].Points.AddXY(i, futures2[i - 1]);
            }
            volumeProduction2 = c1 + c2 * 6 + c3 * Math.Pow(6, 2);
            futures2[5] = volumeProduction2;
            sb.Append(futures2[5].ToString(".##") + "\n");

            sb.Append(tableOfVolume[4, 0] + "\t");
            for (int i = 0; i < t; i++) sb.Append(pogrSchemaArray[i].ToString() + "\t");
            sb.Append(pogrMax + "\n");

            sb.Append(tableOfVolume[5, 0] + "\t");
            for (int i = 0; i < t; i++) sb.Append(priblSchemaArray[i].ToString() + "\t");
            sb.Append(priblMax);

            resultTextBox.Text = sb.ToString();
        }

        double CalculateDet2x2(double a11, double a12, double a21, double a22)
        {
            double res = a11 * a22 - a21 * a12;
            return res;
        }

        double CalculateDet3x3(double a11, double a12, double a13,
                double a21, double a22, double a23,
                double a31, double a32, double a33)
        {
            double det1 = a11 * CalculateDet2x2(a22, a23, a32, a33);
            double det2 = -a21 * CalculateDet2x2(a12, a13, a32, a33);
            double det3 = a31 * CalculateDet2x2(a12, a13, a22, a23);
            double det = det1 + det2 + det3;
            return det;
        }
    }
}
