namespace BudgetTrekker.User_Controls
{
    partial class CalendarUC
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.deleteBtn_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addBtn_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.showallBtn_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.monthCalendar1);
            this.mainPanel.Controls.Add(this.infoPanel);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.minimize_btn);
            this.mainPanel.Controls.Add(this.exit_btn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1155, 793);
            this.mainPanel.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 5);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.Location = new System.Drawing.Point(955, 66);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.infoPanel.Controls.Add(this.show_all_btn);
            this.infoPanel.Controls.Add(this.addBtn);
            this.infoPanel.Controls.Add(this.deleteBtn);
            this.infoPanel.Controls.Add(this.checkedListBox1);
            this.infoPanel.Controls.Add(this.dateLb);
            this.infoPanel.Location = new System.Drawing.Point(16, 66);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(927, 700);
            this.infoPanel.TabIndex = 4;
            // 
            // show_all_btn
            // 
            this.show_all_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.show_all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.show_all_btn.BackgroundImage = global::BudgetTrekker.Properties.Resources.visible1;
            this.show_all_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_all_btn.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_all_btn.Location = new System.Drawing.Point(42, 22);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(55, 42);
            this.show_all_btn.TabIndex = 5;
            this.show_all_btn.UseVisualStyleBackColor = false;
            this.show_all_btn.Click += new System.EventHandler(this.Show_all_btn_Click_1);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(772, 22);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(55, 42);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteBtn.BackgroundImage = global::BudgetTrekker.Properties.Resources.trash;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(833, 22);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(55, 42);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Отдать долг 200 руб Васе",
            "Стрясти 1000 руб с Пети"});
            this.checkedListBox1.Location = new System.Drawing.Point(28, 65);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(860, 595);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox1_ItemCheck);
            this.checkedListBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedListBox1_MouseDown);
            // 
            // dateLb
            // 
            this.dateLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLb.AutoSize = true;
            this.dateLb.BackColor = System.Drawing.Color.White;
            this.dateLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLb.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLb.ForeColor = System.Drawing.Color.Red;
            this.dateLb.Location = new System.Drawing.Point(266, 2);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(411, 37);
            this.dateLb.TabIndex = 0;
            this.dateLb.Text = "00.00.0000 — Понедельник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(477, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Календарь";
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
            // deleteBtn_ToolTip
            // 
            this.deleteBtn_ToolTip.ToolTipTitle = "Удалить все выполненные события";
            // 
            // addBtn_ToolTip
            // 
            this.addBtn_ToolTip.ToolTipTitle = "Добавить новое событие";
            // 
            // CalendarUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CalendarUC";
            this.Size = new System.Drawing.Size(1155, 793);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ToolTip deleteBtn_ToolTip;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ToolTip addBtn_ToolTip;
        private System.Windows.Forms.Button show_all_btn;
        private System.Windows.Forms.ToolTip showallBtn_ToolTip;
    }
}
