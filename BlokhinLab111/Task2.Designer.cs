namespace BlokhinLab111
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
            this.enterP = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.enterQ = new System.Windows.Forms.Label();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultValue = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).BeginInit();
            this.SuspendLayout();
            // 
            // enterP
            // 
            this.enterP.AutoSize = true;
            this.enterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterP.Location = new System.Drawing.Point(12, 21);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(93, 20);
            this.enterP.TabIndex = 0;
            this.enterP.Text = "Введите p:";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(111, 24);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(42, 20);
            this.pValue.TabIndex = 1;
            // 
            // enterQ
            // 
            this.enterQ.AutoSize = true;
            this.enterQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterQ.Location = new System.Drawing.Point(12, 55);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(93, 20);
            this.enterQ.TabIndex = 2;
            this.enterQ.Text = "Введите q:";
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(111, 55);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(42, 20);
            this.qValue.TabIndex = 3;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(213, 268);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(109, 31);
            this.result.TabIndex = 4;
            this.result.Text = "Посчитать";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результат:";
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(111, 89);
            this.resultValue.Name = "resultValue";
            this.resultValue.ReadOnly = true;
            this.resultValue.Size = new System.Drawing.Size(211, 173);
            this.resultValue.TabIndex = 6;
            this.resultValue.Text = "";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.enterP);
            this.Name = "Task2";
            this.Text = "Лабораторная № 2";
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterP;
        private System.Windows.Forms.NumericUpDown pValue;
        private System.Windows.Forms.Label enterQ;
        private System.Windows.Forms.NumericUpDown qValue;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultValue;
    }
}