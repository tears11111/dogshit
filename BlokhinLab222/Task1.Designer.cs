namespace BlokhinLab222
{
    partial class Task1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.enterP = new System.Windows.Forms.Label();
            this.enterQ = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // enterP
            // 
            this.enterP.AutoSize = true;
            this.enterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterP.Location = new System.Drawing.Point(12, 9);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(93, 20);
            this.enterP.TabIndex = 0;
            this.enterP.Text = "Введите p:";
            // 
            // enterQ
            // 
            this.enterQ.AutoSize = true;
            this.enterQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterQ.Location = new System.Drawing.Point(12, 42);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(93, 20);
            this.enterQ.TabIndex = 1;
            this.enterQ.Text = "Введите q:";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(111, 12);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(120, 20);
            this.pValue.TabIndex = 2;
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(111, 45);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(120, 20);
            this.qValue.TabIndex = 3;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(414, 383);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(135, 39);
            this.result.TabIndex = 8;
            this.result.Text = "Посчитать";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(16, 108);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(450, 241);
            this.resultTextBox.TabIndex = 9;
            this.resultTextBox.Text = "";
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(497, 108);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(509, 241);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.enterP);
            this.Controls.Add(this.result);
            this.Name = "Task1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterP;
        private System.Windows.Forms.Label enterQ;
        private System.Windows.Forms.NumericUpDown pValue;
        private System.Windows.Forms.NumericUpDown qValue;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

