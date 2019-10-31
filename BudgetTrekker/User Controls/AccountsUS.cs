using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrekker.User_Controls
{
    public  partial class AccountsUS : UserControl
    {

        private Panel panel_test;

        public AccountsUS()
        {
            InitializeComponent();

            GlobalFunctions.SetColorChildPanels(Color.FromArgb(255, 224, 204), ref mainPanel);
                       
            tableLayoutPanel1.AutoScroll = true;

            TableElementsInit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // Открывает панель настроек
            if (((Button)sender).Text != "x")
            {
                foreach (var i in tableLayoutPanel1.Controls)
                {
                    if (i.GetType() == typeof(Panel))
                    {
                        // TODO: Добавить на панель все нужные для настроек элементы
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Text = "Settings: ";
                        label.ForeColor = Color.Black;
                        label.Font = new Font("Century Gothic", 18, FontStyle.Regular);
                        label.Location = new Point(25, 200);


                        Button testBtn = GetChildButton(((Panel)i));

                        if ((Button)sender == testBtn)
                        {
                            ((Panel)i).Controls.Add(label);
                            ((Button)sender).Text = "x";
                        }
                    }
                }
            }
            // Закрывает панель настроек
            else
            {
                foreach (var i in tableLayoutPanel1.Controls)
                {
                    if (i.GetType() == typeof(Panel))
                    {
                        // TODO: Добавить на панель все обычные элементы, это нажатие закрывает настройки
                        
                        Button testBtn = GetChildButton(((Panel)i));

                        if ((Button)sender == testBtn)
                        {
                            ((Panel)i).Controls.Remove(GetChildLabelWithText(((Panel)i)));
                            ((Button)sender).Text = "⋮";
                        }
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // TODO: исправить нарушение нумерации
            int number = tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel1.ColumnCount++;
            TableElementsAdd(tableLayoutPanel1.ColumnCount);
        }



        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////


        
        private void TableElementsInit()
        {
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                TableElementsAdd(i);
            }
        }

        private void TableElementsAdd(int number)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(255, 224, 204);
            panel.Size = new Size(300, 632);

            Label label = new Label();
            label.AutoSize = true;

            // TODO: добавить название счета
            label.Text = (number + 1).ToString() + ". Название счета";

            label.ForeColor = Color.Black;
            label.Font = new Font("Century Gothic", 18, FontStyle.Regular);
            label.Location = new Point(25, 5);

            panel.Controls.Add(label);

            Button button = new Button();
            //button.Size = new Size(50, 50);
            button.FlatStyle = FlatStyle.Flat;
            button.AutoSize = true;
            button.Location = new Point(100, 550);

            //button.BackColor = Color.FromArgb(235, 194, 175);
            button.BackColor = Color.FromArgb(218, 189, 171);

            button.Font = new Font("Century Gothic", 23);
            button.Text = "⋮";
            button.Click += new EventHandler(SettingsButton_Click);

            panel.Controls.Add(button);

            panel_test = panel;

            tableLayoutPanel1.Controls.Add(panel, number, 0);
        }
   
        
        private Button GetChildButton(Panel parentPanel)
        {
            var controlsArray = (GlobalFunctions.GetAllChildControls(parentPanel, typeof(Button))).ToArray();

            foreach (var i in controlsArray)
            {
                if (((Button)i).Text == "x" || ((Button)i).Text == "⋮")
                {
                    return (Button)i;
                }
            }

            return null;
        }

        private Control GetChildLabelWithText(Panel parentPanel)
        {
            var controlsArray = (GlobalFunctions.GetAllChildControls(parentPanel, typeof(Label))).ToArray();

            foreach (var i in controlsArray)
            {
                if (((Label)i).Text == "Settings: ")
                {
                    return i;
                }                
            }

            return null;
        }
    }
}
