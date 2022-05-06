namespace BlokhinLab4
{
    partial class Form1
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
            this.enterP = new System.Windows.Forms.Label();
            this.enterQ = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterP
            // 
            this.enterP.AutoSize = true;
            this.enterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterP.Location = new System.Drawing.Point(10, 9);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(66, 20);
            this.enterP.TabIndex = 0;
            this.enterP.Text = "Enter P:";
            // 
            // enterQ
            // 
            this.enterQ.AutoSize = true;
            this.enterQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterQ.Location = new System.Drawing.Point(8, 40);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(68, 20);
            this.enterQ.TabIndex = 1;
            this.enterQ.Text = "Enter Q:";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(82, 9);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(120, 20);
            this.pValue.TabIndex = 2;
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(82, 40);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(120, 20);
            this.qValue.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 77);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(492, 232);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.Text = "";
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(1007, 624);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(126, 38);
            this.resultButton.TabIndex = 5;
            this.resultButton.Text = "Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(552, 77);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(490, 507);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 674);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.enterP);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterP;
        private System.Windows.Forms.Label enterQ;
        private System.Windows.Forms.NumericUpDown pValue;
        private System.Windows.Forms.NumericUpDown qValue;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

