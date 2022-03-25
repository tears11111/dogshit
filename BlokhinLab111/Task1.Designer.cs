namespace BlokhinLab111
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
            this.enterP = new System.Windows.Forms.Label();
            this.enterQ = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).BeginInit();
            this.SuspendLayout();
            // 
            // enterP
            // 
            this.enterP.AutoSize = true;
            this.enterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterP.Location = new System.Drawing.Point(12, 35);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(93, 20);
            this.enterP.TabIndex = 0;
            this.enterP.Text = "Введите p:";
            // 
            // enterQ
            // 
            this.enterQ.AutoSize = true;
            this.enterQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterQ.Location = new System.Drawing.Point(12, 63);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(93, 20);
            this.enterQ.TabIndex = 1;
            this.enterQ.Text = "Введите q:";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(111, 35);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(45, 20);
            this.pValue.TabIndex = 2;
            this.pValue.ValueChanged += new System.EventHandler(this.pValue_ValueChanged);
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(111, 63);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(45, 20);
            this.qValue.TabIndex = 3;
            this.qValue.ValueChanged += new System.EventHandler(this.qValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(111, 94);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 5;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(220, 172);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(102, 27);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Посчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.enterP);
            this.Name = "Task1";
            this.Text = "Лабораторная №1";
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterP;
        private System.Windows.Forms.Label enterQ;
        private System.Windows.Forms.NumericUpDown pValue;
        private System.Windows.Forms.NumericUpDown qValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button calculate;
    }
}

