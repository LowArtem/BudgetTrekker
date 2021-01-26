namespace BudgetTrekker.User_Controls
{
    partial class AccountPanel
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
            this.accountNameLbl = new System.Windows.Forms.Label();
            this.accountSumLbl = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.lastTransactionNameLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lastTransactionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.errorTransactionLbl = new System.Windows.Forms.Label();
            this.lastTransactionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNameLbl
            // 
            this.accountNameLbl.AutoSize = true;
            this.accountNameLbl.Location = new System.Drawing.Point(7, 9);
            this.accountNameLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.accountNameLbl.Name = "accountNameLbl";
            this.accountNameLbl.Size = new System.Drawing.Size(154, 30);
            this.accountNameLbl.TabIndex = 0;
            this.accountNameLbl.Text = "1. Название";
            // 
            // accountSumLbl
            // 
            this.accountSumLbl.AutoSize = true;
            this.accountSumLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountSumLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.accountSumLbl.Location = new System.Drawing.Point(7, 58);
            this.accountSumLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.accountSumLbl.Name = "accountSumLbl";
            this.accountSumLbl.Size = new System.Drawing.Size(73, 25);
            this.accountSumLbl.TabIndex = 1;
            this.accountSumLbl.Text = "0 руб";
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Location = new System.Drawing.Point(101, 558);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(90, 46);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.Text = "⋮";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // lastTransactionNameLbl
            // 
            this.lastTransactionNameLbl.AutoSize = true;
            this.lastTransactionNameLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastTransactionNameLbl.Location = new System.Drawing.Point(33, 105);
            this.lastTransactionNameLbl.Name = "lastTransactionNameLbl";
            this.lastTransactionNameLbl.Size = new System.Drawing.Size(242, 22);
            this.lastTransactionNameLbl.TabIndex = 4;
            this.lastTransactionNameLbl.Text = "Последние транзакции: ";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.BackgroundImage = global::BudgetTrekker.Properties.Resources.trash;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(239, 42);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(58, 47);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // lastTransactionsPanel
            // 
            this.lastTransactionsPanel.AutoScroll = true;
            this.lastTransactionsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lastTransactionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(217)))));
            this.lastTransactionsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.lastTransactionsPanel.ColumnCount = 1;
            this.lastTransactionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.lastTransactionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.lastTransactionsPanel.Controls.Add(this.errorTransactionLbl, 0, 0);
            this.lastTransactionsPanel.Location = new System.Drawing.Point(12, 130);
            this.lastTransactionsPanel.Name = "lastTransactionsPanel";
            this.lastTransactionsPanel.RowCount = 2;
            this.lastTransactionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lastTransactionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lastTransactionsPanel.Size = new System.Drawing.Size(276, 400);
            this.lastTransactionsPanel.TabIndex = 1;
            // 
            // errorTransactionLbl
            // 
            this.errorTransactionLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.errorTransactionLbl.AutoSize = true;
            this.errorTransactionLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorTransactionLbl.ForeColor = System.Drawing.Color.Red;
            this.errorTransactionLbl.Location = new System.Drawing.Point(16, 155);
            this.errorTransactionLbl.Name = "errorTransactionLbl";
            this.errorTransactionLbl.Size = new System.Drawing.Size(244, 44);
            this.errorTransactionLbl.TabIndex = 2;
            this.errorTransactionLbl.Text = "Нет данных о последних \r\nтранзакциях";
            this.errorTransactionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lastTransactionsPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.lastTransactionNameLbl);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.accountSumLbl);
            this.Controls.Add(this.accountNameLbl);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AccountPanel";
            this.Size = new System.Drawing.Size(300, 632);
            this.lastTransactionsPanel.ResumeLayout(false);
            this.lastTransactionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountNameLbl;
        private System.Windows.Forms.Label accountSumLbl;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label lastTransactionNameLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ToolTip deleteBtnToolTip;
        private System.Windows.Forms.TableLayoutPanel lastTransactionsPanel;
        private System.Windows.Forms.Label errorTransactionLbl;
    }
}
