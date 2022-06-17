namespace SnilsCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this.snilsTB = new System.Windows.Forms.TextBox();
            this.checkSnilsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "СНИЛС";
            // 
            // snilsTB
            // 
            this.snilsTB.Location = new System.Drawing.Point(52, 25);
            this.snilsTB.Name = "snilsTB";
            this.snilsTB.Size = new System.Drawing.Size(145, 20);
            this.snilsTB.TabIndex = 1;
            // 
            // checkSnilsBtn
            // 
            this.checkSnilsBtn.Location = new System.Drawing.Point(52, 63);
            this.checkSnilsBtn.Name = "checkSnilsBtn";
            this.checkSnilsBtn.Size = new System.Drawing.Size(145, 23);
            this.checkSnilsBtn.TabIndex = 2;
            this.checkSnilsBtn.Text = "ПРОВЕРИТЬ";
            this.checkSnilsBtn.UseVisualStyleBackColor = true;
            this.checkSnilsBtn.Click += new System.EventHandler(this.checkSnilsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 93);
            this.Controls.Add(this.checkSnilsBtn);
            this.Controls.Add(this.snilsTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Snils Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox snilsTB;
        private System.Windows.Forms.Button checkSnilsBtn;
    }
}

