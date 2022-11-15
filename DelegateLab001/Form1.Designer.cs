namespace DelegateLab001
{
    partial class Form1
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
            this.labelPrintFile = new System.Windows.Forms.Label();
            this.buttonShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrintFile
            // 
            this.labelPrintFile.AutoSize = true;
            this.labelPrintFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrintFile.Location = new System.Drawing.Point(3, 9);
            this.labelPrintFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrintFile.Name = "labelPrintFile";
            this.labelPrintFile.Size = new System.Drawing.Size(87, 25);
            this.labelPrintFile.TabIndex = 0;
            this.labelPrintFile.Text = " * * * * *";
            // 
            // buttonShowResult
            // 
            this.buttonShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowResult.Location = new System.Drawing.Point(704, 42);
            this.buttonShowResult.Name = "buttonShowResult";
            this.buttonShowResult.Size = new System.Drawing.Size(131, 83);
            this.buttonShowResult.TabIndex = 2;
            this.buttonShowResult.Text = "Найти почту в файле";
            this.buttonShowResult.UseVisualStyleBackColor = true;
            this.buttonShowResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowResult_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 320);
            this.Controls.Add(this.buttonShowResult);
            this.Controls.Add(this.labelPrintFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrintFile;
        private System.Windows.Forms.Button buttonShowResult;
    }
}

