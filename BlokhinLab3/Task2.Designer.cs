namespace BlokhinLab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.NumericUpDown();
            this.qValue = new System.Windows.Forms.NumericUpDown();
            this.resultButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startSum = new System.Windows.Forms.TextBox();
            this.finalSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vvedite P:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vvedite Q:";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(100, 9);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(120, 20);
            this.pValue.TabIndex = 2;
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(100, 35);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(120, 20);
            this.qValue.TabIndex = 3;
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(61, 406);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(130, 32);
            this.resultButton.TabIndex = 5;
            this.resultButton.Text = "Выполнить";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начальная сумма:\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Искомая сумма:";
            // 
            // startSum
            // 
            this.startSum.Location = new System.Drawing.Point(145, 93);
            this.startSum.Name = "startSum";
            this.startSum.ReadOnly = true;
            this.startSum.Size = new System.Drawing.Size(62, 20);
            this.startSum.TabIndex = 8;
            // 
            // finalSum
            // 
            this.finalSum.Location = new System.Drawing.Point(129, 125);
            this.finalSum.Name = "finalSum";
            this.finalSum.ReadOnly = true;
            this.finalSum.Size = new System.Drawing.Size(62, 20);
            this.finalSum.TabIndex = 9;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 450);
            this.Controls.Add(this.finalSum);
            this.Controls.Add(this.startSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pValue;
        private System.Windows.Forms.NumericUpDown qValue;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startSum;
        private System.Windows.Forms.TextBox finalSum;
    }
}