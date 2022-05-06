using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokhinLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int k = 8;
            double p = Convert.ToDouble(pValue.Value);
            double q = Convert.ToDouble(qValue.Value);
            double e1 = 2 * (p + q) + 20;
            double e2 = 2 * (p + q) + 3;
            double e3 = 3 * (p + q) + 8;
            double e4 = 8 * (p + q) + 39;
            double i1, i2, i3, i4, i5, i6, i7, i8;
            double e1Used = e1 * 0.8; double e2Used = e2 * 0.8; double e3Used = e3 * 0.8;
            double[] rk = new double[k];
            double[,] a = new double[8, 3];
            double[] b = new double[a.GetLength(0)];
            double[] x = new double[8];
 
            for (int i = 1; i <= k; i++)
            {
                rk[i - 1] = p + q + i;
            }

            a[0, 0] = 1;
            a[0, 1] = 1;
            a[0, 2] = 1;

            a[1, 0] = -1;
            a[1, 1] = -1;
            a[1, 2] = 1;

            a[2, 0] = 1;
            a[2, 1] = -1;
            a[2, 2] = 1;

            a[3, 0] = 1;
            a[3, 1] = -1;
            a[3, 2] = 1;

            a[4, 0] = 1 * rk[0];
            a[4, 1] = -(1 * rk[4]);
            a[4, 2] = 1 * rk[4];

            a[5, 0] = 1 * rk[1];
            a[5, 1] = 1 * rk[5];
            a[5, 2] = -(1 * rk[6]);

            a[6, 0] = 1 * rk[2];
            a[6, 1] = 1 * rk[6];
            a[6, 2] = -(1 * rk[7]);

            a[7, 0] = 1 * rk[3];
            a[7, 1] = -(1 * rk[4]);
            a[7, 2] = 1 * rk[7];

            b[0] = 0; b[1] = 0; b[2] = 0; b[3] = 0; b[4] = e1; b[5] = e2; b[6] = e3; b[7] = e4;
            //b[3] = e4;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                    resultTextBox.Text += a[i, j] + "\t";
                resultTextBox.Text += Math.Round(b[i], 2);
                resultTextBox.Text += "\n";
            }
            resultTextBox.Text += "\n";

            SolveGauss(a, b, x);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                    resultTextBox.Text += a[i, j] + " " + Math.Round(x[j], 2) + "\t";
                resultTextBox.Text += Math.Round(b[i], 2);
                resultTextBox.Text += "\n";
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    resultTextBox.Text += $"x{i + 1}: " + x[i] + "\n";
            //}
        }

        bool SolveGauss(double[,] a, double[] b, double[] x)
        {
            double det = 1;
            double e;
            int n = a.GetLength(1);

            // прямой ход
            for (int j = 0; j < n; j++)
            {
                // находим ведущий элемент
                e = a[j, j];
                a[j, j] = 1.0;
                // уточняем значение определителя
                det *= e;
                // делим все элементы строки на ведущий элемент
                for (int k = j + 1; k < n - 1; k++)
                    a[j, k] /= e;
                b[j] /= e;

                // выполняем исключение для всех элементов
                // ниже ведущего в столбце j
                // и уточням значение в правой части
                for (int i = j + 1; i < n; i++)
                {
                    e = a[i, j];
                    a[i, j] = 0;
                    for (int k = j + 1; k < n; k++)
                    {
                        a[i, k] = a[i, k] - a[j, k] * e;
                    }
                    b[i] = b[i] - b[j] * e;
                }
            }
            // проверка равенства определителя нулю
            if (Math.Abs(det) < 1e-15)
                return false;
            // обратный ход
            double sum;
            x[n - 1] = b[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                sum = 0;
                for (int j = i + 1; j < n; j++)
                    sum += a[i, j] * x[j];
                x[i] = b[i] - sum;
            }
            return true;
        }
    }
}