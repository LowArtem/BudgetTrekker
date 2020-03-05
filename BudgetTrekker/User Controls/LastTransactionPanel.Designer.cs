namespace BudgetTrekker.User_Controls
{
    partial class LastTransactionPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryLbl1 = new System.Windows.Forms.Label();
            this.priceLbl1 = new System.Windows.Forms.Label();
            this.dateLbl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(217)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.categoryLbl1);
            this.panel1.Controls.Add(this.priceLbl1);
            this.panel1.Controls.Add(this.dateLbl1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.MaximumSize = new System.Drawing.Size(250, 100);
            this.panel1.MinimumSize = new System.Drawing.Size(250, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 1;
            // 
            // categoryLbl1
            // 
            this.categoryLbl1.AutoSize = true;
            this.categoryLbl1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLbl1.Location = new System.Drawing.Point(6, 65);
            this.categoryLbl1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.categoryLbl1.Name = "categoryLbl1";
            this.categoryLbl1.Size = new System.Drawing.Size(102, 21);
            this.categoryLbl1.TabIndex = 1;
            this.categoryLbl1.Text = "Категория";
            // 
            // priceLbl1
            // 
            this.priceLbl1.AutoSize = true;
            this.priceLbl1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLbl1.ForeColor = System.Drawing.Color.Green;
            this.priceLbl1.Location = new System.Drawing.Point(0, 29);
            this.priceLbl1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.priceLbl1.Name = "priceLbl1";
            this.priceLbl1.Size = new System.Drawing.Size(88, 25);
            this.priceLbl1.TabIndex = 0;
            this.priceLbl1.Text = "+0 руб";
            // 
            // dateLbl1
            // 
            this.dateLbl1.AutoSize = true;
            this.dateLbl1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl1.Location = new System.Drawing.Point(0, 0);
            this.dateLbl1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dateLbl1.Name = "dateLbl1";
            this.dateLbl1.Size = new System.Drawing.Size(141, 19);
            this.dateLbl1.TabIndex = 0;
            this.dateLbl1.Text = "31.12.2020 00:00:00";
            // 
            // LastTransactionPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximumSize = new System.Drawing.Size(250, 100);
            this.MinimumSize = new System.Drawing.Size(250, 100);
            this.Name = "LastTransactionPanel";
            this.Size = new System.Drawing.Size(250, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label categoryLbl1;
        private System.Windows.Forms.Label priceLbl1;
        private System.Windows.Forms.Label dateLbl1;
    }
}
