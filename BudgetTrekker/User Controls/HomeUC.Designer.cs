namespace BudgetTrekker
{
    partial class HomeUC
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.UC_name = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.balancePanel = new System.Windows.Forms.Panel();
            this.accountsPanel = new System.Windows.Forms.Panel();
            this.budgetsPanel = new System.Windows.Forms.Panel();
            this.spendingPanel = new System.Windows.Forms.Panel();
            this.balPanel1 = new System.Windows.Forms.Panel();
            this.incomePanel = new System.Windows.Forms.Panel();
            this.balPanel2 = new System.Windows.Forms.Panel();
            this.accPanel2 = new System.Windows.Forms.Panel();
            this.accPanel1 = new System.Windows.Forms.Panel();
            this.incPanel1 = new System.Windows.Forms.Panel();
            this.incPanel2 = new System.Windows.Forms.Panel();
            this.incPanel3 = new System.Windows.Forms.Panel();
            this.incPanel4 = new System.Windows.Forms.Panel();
            this.spePanel4 = new System.Windows.Forms.Panel();
            this.spePanel3 = new System.Windows.Forms.Panel();
            this.spePanel2 = new System.Windows.Forms.Panel();
            this.spePanel1 = new System.Windows.Forms.Panel();
            this.budPanel2 = new System.Windows.Forms.Panel();
            this.budPanel1 = new System.Windows.Forms.Panel();
            this.budPanel3 = new System.Windows.Forms.Panel();
            this.incPanel5 = new System.Windows.Forms.Panel();
            this.spePanel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.balancePanel.SuspendLayout();
            this.accountsPanel.SuspendLayout();
            this.budgetsPanel.SuspendLayout();
            this.spendingPanel.SuspendLayout();
            this.incomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.incomePanel);
            this.mainPanel.Controls.Add(this.spendingPanel);
            this.mainPanel.Controls.Add(this.budgetsPanel);
            this.mainPanel.Controls.Add(this.accountsPanel);
            this.mainPanel.Controls.Add(this.balancePanel);
            this.mainPanel.Controls.Add(this.UC_name);
            this.mainPanel.Controls.Add(this.minimize_btn);
            this.mainPanel.Controls.Add(this.exit_btn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1155, 793);
            this.mainPanel.TabIndex = 3;
            // 
            // UC_name
            // 
            this.UC_name.AutoSize = true;
            this.UC_name.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UC_name.Location = new System.Drawing.Point(477, 5);
            this.UC_name.Name = "UC_name";
            this.UC_name.Size = new System.Drawing.Size(145, 45);
            this.UC_name.TabIndex = 3;
            this.UC_name.Text = "Обзор";
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize_btn.ForeColor = System.Drawing.Color.Black;
            this.minimize_btn.Location = new System.Drawing.Point(1037, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(59, 50);
            this.minimize_btn.TabIndex = 2;
            this.minimize_btn.Text = "-";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(1096, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(59, 50);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // balancePanel
            // 
            this.balancePanel.BackColor = System.Drawing.Color.LightGray;
            this.balancePanel.Controls.Add(this.label1);
            this.balancePanel.Controls.Add(this.balPanel2);
            this.balancePanel.Controls.Add(this.balPanel1);
            this.balancePanel.Location = new System.Drawing.Point(12, 66);
            this.balancePanel.Name = "balancePanel";
            this.balancePanel.Size = new System.Drawing.Size(537, 201);
            this.balancePanel.TabIndex = 4;
            // 
            // accountsPanel
            // 
            this.accountsPanel.BackColor = System.Drawing.Color.MistyRose;
            this.accountsPanel.Controls.Add(this.label2);
            this.accountsPanel.Controls.Add(this.accPanel2);
            this.accountsPanel.Controls.Add(this.accPanel1);
            this.accountsPanel.Location = new System.Drawing.Point(12, 276);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(537, 211);
            this.accountsPanel.TabIndex = 5;
            // 
            // budgetsPanel
            // 
            this.budgetsPanel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.budgetsPanel.Controls.Add(this.label3);
            this.budgetsPanel.Controls.Add(this.budPanel3);
            this.budgetsPanel.Controls.Add(this.budPanel2);
            this.budgetsPanel.Controls.Add(this.budPanel1);
            this.budgetsPanel.Location = new System.Drawing.Point(12, 498);
            this.budgetsPanel.Name = "budgetsPanel";
            this.budgetsPanel.Size = new System.Drawing.Size(537, 283);
            this.budgetsPanel.TabIndex = 5;
            // 
            // spendingPanel
            // 
            this.spendingPanel.BackColor = System.Drawing.Color.LightCoral;
            this.spendingPanel.Controls.Add(this.label5);
            this.spendingPanel.Controls.Add(this.spePanel5);
            this.spendingPanel.Controls.Add(this.spePanel4);
            this.spendingPanel.Controls.Add(this.spePanel3);
            this.spendingPanel.Controls.Add(this.spePanel2);
            this.spendingPanel.Controls.Add(this.spePanel1);
            this.spendingPanel.Location = new System.Drawing.Point(585, 437);
            this.spendingPanel.Name = "spendingPanel";
            this.spendingPanel.Size = new System.Drawing.Size(550, 344);
            this.spendingPanel.TabIndex = 7;
            // 
            // balPanel1
            // 
            this.balPanel1.BackColor = System.Drawing.Color.White;
            this.balPanel1.Location = new System.Drawing.Point(3, 43);
            this.balPanel1.Name = "balPanel1";
            this.balPanel1.Size = new System.Drawing.Size(531, 73);
            this.balPanel1.TabIndex = 0;
            // 
            // incomePanel
            // 
            this.incomePanel.BackColor = System.Drawing.Color.LightGreen;
            this.incomePanel.Controls.Add(this.label4);
            this.incomePanel.Controls.Add(this.incPanel5);
            this.incomePanel.Controls.Add(this.incPanel4);
            this.incomePanel.Controls.Add(this.incPanel3);
            this.incomePanel.Controls.Add(this.incPanel2);
            this.incomePanel.Controls.Add(this.incPanel1);
            this.incomePanel.Location = new System.Drawing.Point(585, 66);
            this.incomePanel.Name = "incomePanel";
            this.incomePanel.Size = new System.Drawing.Size(550, 337);
            this.incomePanel.TabIndex = 8;
            // 
            // balPanel2
            // 
            this.balPanel2.BackColor = System.Drawing.Color.White;
            this.balPanel2.Location = new System.Drawing.Point(3, 123);
            this.balPanel2.Name = "balPanel2";
            this.balPanel2.Size = new System.Drawing.Size(531, 73);
            this.balPanel2.TabIndex = 1;
            // 
            // accPanel2
            // 
            this.accPanel2.BackColor = System.Drawing.Color.White;
            this.accPanel2.Location = new System.Drawing.Point(3, 125);
            this.accPanel2.Name = "accPanel2";
            this.accPanel2.Size = new System.Drawing.Size(531, 73);
            this.accPanel2.TabIndex = 3;
            // 
            // accPanel1
            // 
            this.accPanel1.BackColor = System.Drawing.Color.White;
            this.accPanel1.Location = new System.Drawing.Point(3, 45);
            this.accPanel1.Name = "accPanel1";
            this.accPanel1.Size = new System.Drawing.Size(531, 73);
            this.accPanel1.TabIndex = 2;
            // 
            // incPanel1
            // 
            this.incPanel1.BackColor = System.Drawing.Color.White;
            this.incPanel1.Location = new System.Drawing.Point(6, 45);
            this.incPanel1.Name = "incPanel1";
            this.incPanel1.Size = new System.Drawing.Size(541, 52);
            this.incPanel1.TabIndex = 1;
            // 
            // incPanel2
            // 
            this.incPanel2.BackColor = System.Drawing.Color.White;
            this.incPanel2.Location = new System.Drawing.Point(6, 103);
            this.incPanel2.Name = "incPanel2";
            this.incPanel2.Size = new System.Drawing.Size(541, 52);
            this.incPanel2.TabIndex = 2;
            // 
            // incPanel3
            // 
            this.incPanel3.BackColor = System.Drawing.Color.White;
            this.incPanel3.Location = new System.Drawing.Point(6, 161);
            this.incPanel3.Name = "incPanel3";
            this.incPanel3.Size = new System.Drawing.Size(541, 52);
            this.incPanel3.TabIndex = 2;
            // 
            // incPanel4
            // 
            this.incPanel4.BackColor = System.Drawing.Color.White;
            this.incPanel4.Location = new System.Drawing.Point(6, 219);
            this.incPanel4.Name = "incPanel4";
            this.incPanel4.Size = new System.Drawing.Size(541, 52);
            this.incPanel4.TabIndex = 2;
            // 
            // spePanel4
            // 
            this.spePanel4.BackColor = System.Drawing.Color.White;
            this.spePanel4.Location = new System.Drawing.Point(3, 225);
            this.spePanel4.Name = "spePanel4";
            this.spePanel4.Size = new System.Drawing.Size(544, 52);
            this.spePanel4.TabIndex = 4;
            // 
            // spePanel3
            // 
            this.spePanel3.BackColor = System.Drawing.Color.White;
            this.spePanel3.Location = new System.Drawing.Point(3, 167);
            this.spePanel3.Name = "spePanel3";
            this.spePanel3.Size = new System.Drawing.Size(544, 52);
            this.spePanel3.TabIndex = 5;
            // 
            // spePanel2
            // 
            this.spePanel2.BackColor = System.Drawing.Color.White;
            this.spePanel2.Location = new System.Drawing.Point(3, 109);
            this.spePanel2.Name = "spePanel2";
            this.spePanel2.Size = new System.Drawing.Size(544, 52);
            this.spePanel2.TabIndex = 6;
            // 
            // spePanel1
            // 
            this.spePanel1.BackColor = System.Drawing.Color.White;
            this.spePanel1.Location = new System.Drawing.Point(3, 51);
            this.spePanel1.Name = "spePanel1";
            this.spePanel1.Size = new System.Drawing.Size(544, 52);
            this.spePanel1.TabIndex = 3;
            // 
            // budPanel2
            // 
            this.budPanel2.BackColor = System.Drawing.Color.White;
            this.budPanel2.Location = new System.Drawing.Point(6, 124);
            this.budPanel2.Name = "budPanel2";
            this.budPanel2.Size = new System.Drawing.Size(528, 73);
            this.budPanel2.TabIndex = 5;
            // 
            // budPanel1
            // 
            this.budPanel1.BackColor = System.Drawing.Color.White;
            this.budPanel1.Location = new System.Drawing.Point(6, 44);
            this.budPanel1.Name = "budPanel1";
            this.budPanel1.Size = new System.Drawing.Size(528, 73);
            this.budPanel1.TabIndex = 4;
            // 
            // budPanel3
            // 
            this.budPanel3.BackColor = System.Drawing.Color.White;
            this.budPanel3.Location = new System.Drawing.Point(6, 203);
            this.budPanel3.Name = "budPanel3";
            this.budPanel3.Size = new System.Drawing.Size(528, 73);
            this.budPanel3.TabIndex = 6;
            // 
            // incPanel5
            // 
            this.incPanel5.BackColor = System.Drawing.Color.White;
            this.incPanel5.Location = new System.Drawing.Point(6, 277);
            this.incPanel5.Name = "incPanel5";
            this.incPanel5.Size = new System.Drawing.Size(541, 52);
            this.incPanel5.TabIndex = 3;
            // 
            // spePanel5
            // 
            this.spePanel5.BackColor = System.Drawing.Color.White;
            this.spePanel5.Location = new System.Drawing.Point(3, 283);
            this.spePanel5.Name = "spePanel5";
            this.spePanel5.Size = new System.Drawing.Size(544, 52);
            this.spePanel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Баланс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Счета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Бюджеты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(209, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Доходы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(209, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расходы";
            // 
            // HomeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1155, 793);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.balancePanel.ResumeLayout(false);
            this.balancePanel.PerformLayout();
            this.accountsPanel.ResumeLayout(false);
            this.accountsPanel.PerformLayout();
            this.budgetsPanel.ResumeLayout(false);
            this.budgetsPanel.PerformLayout();
            this.spendingPanel.ResumeLayout(false);
            this.spendingPanel.PerformLayout();
            this.incomePanel.ResumeLayout(false);
            this.incomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label UC_name;
        private System.Windows.Forms.Panel spendingPanel;
        private System.Windows.Forms.Panel budgetsPanel;
        private System.Windows.Forms.Panel accountsPanel;
        private System.Windows.Forms.Panel balancePanel;
        private System.Windows.Forms.Panel incomePanel;
        private System.Windows.Forms.Panel incPanel5;
        private System.Windows.Forms.Panel incPanel4;
        private System.Windows.Forms.Panel incPanel3;
        private System.Windows.Forms.Panel incPanel2;
        private System.Windows.Forms.Panel incPanel1;
        private System.Windows.Forms.Panel spePanel5;
        private System.Windows.Forms.Panel spePanel4;
        private System.Windows.Forms.Panel spePanel3;
        private System.Windows.Forms.Panel spePanel2;
        private System.Windows.Forms.Panel spePanel1;
        private System.Windows.Forms.Panel budPanel3;
        private System.Windows.Forms.Panel budPanel2;
        private System.Windows.Forms.Panel budPanel1;
        private System.Windows.Forms.Panel accPanel2;
        private System.Windows.Forms.Panel accPanel1;
        private System.Windows.Forms.Panel balPanel2;
        private System.Windows.Forms.Panel balPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
