namespace BlokhinLab222
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.enterP = new System.Windows.Forms.Label();
            this.enterQ = new System.Windows.Forms.Label();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(111, 9);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(120, 20);
            this.pValue.TabIndex = 0;
            // 
            // enterP
            // 
            this.enterP.AutoSize = true;
            this.enterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterP.Location = new System.Drawing.Point(12, 9);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(93, 20);
            this.enterP.TabIndex = 1;
            this.enterP.Text = "Введите p:";
            // 
            // enterQ
            // 
            this.enterQ.AutoSize = true;
            this.enterQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterQ.Location = new System.Drawing.Point(12, 44);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(93, 20);
            this.enterQ.TabIndex = 2;
            this.enterQ.Text = "Введите q:";
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(111, 44);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(120, 20);
            this.qValue.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(16, 93);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(417, 273);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.Text = "";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(458, 96);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(739, 269);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart1";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(387, 382);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(123, 35);
            this.result.TabIndex = 6;
            this.result.Text = "Посчитать";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.enterP);
            this.Controls.Add(this.pValue);
            this.Name = "Task2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pValue;
        private System.Windows.Forms.Label enterP;
        private System.Windows.Forms.Label enterQ;
        private System.Windows.Forms.NumericUpDown qValue;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button result;
    }
}