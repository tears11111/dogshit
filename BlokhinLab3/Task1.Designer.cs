namespace BlokhinLab3
{
    partial class Task1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.enterP = new System.Windows.Forms.Label();
            this.enterQ = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.result1Button = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result2Button = new System.Windows.Forms.Button();
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
            this.enterP.Size = new System.Drawing.Size(80, 20);
            this.enterP.TabIndex = 0;
            this.enterP.Text = "Vvedite P:";
            // 
            // enterQ
            // 
            this.enterQ.AutoSize = true;
            this.enterQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterQ.Location = new System.Drawing.Point(12, 38);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(82, 20);
            this.enterQ.TabIndex = 1;
            this.enterQ.Text = "Vvedite Q:";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(98, 9);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(120, 20);
            this.pValue.TabIndex = 2;
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(100, 41);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(120, 20);
            this.qValue.TabIndex = 3;
            // 
            // result1Button
            // 
            this.result1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result1Button.Location = new System.Drawing.Point(709, 499);
            this.result1Button.Name = "result1Button";
            this.result1Button.Size = new System.Drawing.Size(130, 38);
            this.result1Button.TabIndex = 4;
            this.result1Button.Text = "Результат 1";
            this.result1Button.UseVisualStyleBackColor = true;
            this.result1Button.Click += new System.EventHandler(this.result1Button_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(16, 87);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(332, 391);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.Text = "";
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(383, 87);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(609, 391);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // result2Button
            // 
            this.result2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result2Button.Location = new System.Drawing.Point(862, 497);
            this.result2Button.Name = "result2Button";
            this.result2Button.Size = new System.Drawing.Size(130, 40);
            this.result2Button.TabIndex = 7;
            this.result2Button.Text = "Результат 2";
            this.result2Button.UseVisualStyleBackColor = true;
            this.result2Button.Click += new System.EventHandler(this.result2Button_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 557);
            this.Controls.Add(this.result2Button);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.result1Button);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.enterP);
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
        private System.Windows.Forms.Button result1Button;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button result2Button;
    }
}

