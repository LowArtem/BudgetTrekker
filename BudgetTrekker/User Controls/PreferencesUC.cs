using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTrekker.Models;

namespace BudgetTrekker.User_Controls
{
    public partial class PreferencesUC : UserControl
    {
        private bool isTB1 = false;
        private bool isTB2 = false;
        private bool isTB3 = false;
        private bool isTB4 = false;
        private bool isTB5 = false;
        private bool isTB6 = false;

        private TextBox NameTextBox1;
        private TextBox NameTextBox2;
        private TextBox NameTextBox3;
        private TextBox NameTextBox4;
        private TextBox NameTextBox5;
        private TextBox NameTextBox6;

        private TextBox CurrentSumTextBox1;
        private TextBox CurrentSumTextBox2;
        private TextBox CurrentSumTextBox3;
        private TextBox CurrentSumTextBox4;
        private TextBox CurrentSumTextBox5;
        private TextBox CurrentSumTextBox6;

        private TextBox EndSumTextBox1;
        private TextBox EndSumTextBox2;
        private TextBox EndSumTextBox3;
        private TextBox EndSumTextBox4;
        private TextBox EndSumTextBox5;
        private TextBox EndSumTextBox6;

        public PreferencesUC()
        {
            InitializeComponent();
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(253, 211, 206), ref infoPanel);

            // Получение данных бюджетов
            DBInit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }


        // Обработка нажатий кнопок настроек
        #region Button 1-6 Click()
        private void Button2_Click(object sender, EventArgs e)
        {
            SettingsTBController(ref NameTextBox1, ref label2, ref panel1, ref isTB1, ref CurrentSumTextBox1, ref EndSumTextBox1, ref label6, ref label7, ref button2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SettingsTBController(ref NameTextBox2, ref label3, ref panel2, ref isTB2, ref CurrentSumTextBox2, ref EndSumTextBox2, ref label8, ref label11, ref button1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SettingsTBController(ref NameTextBox3, ref label4, ref panel3, ref isTB3, ref CurrentSumTextBox3, ref EndSumTextBox3, ref label9, ref label12, ref button3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SettingsTBController(ref NameTextBox4, ref label5, ref panel4, ref isTB4, ref CurrentSumTextBox4, ref EndSumTextBox4, ref label10, ref label13, ref button4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SettingsTBController(ref NameTextBox5, ref label21, ref panel5, ref isTB5, ref CurrentSumTextBox5, ref EndSumTextBox5, ref label20, ref label19, ref button5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SettingsTBController(ref NameTextBox6, ref label25, ref panel6, ref isTB6, ref CurrentSumTextBox6, ref EndSumTextBox6, ref label24, ref label23, ref button6);
        }
        #endregion

        // Обработка ввода в текстбоксы
        private void SumTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Back & e.KeyChar != (Char)Keys.Delete)
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }



        
        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////




        // Действия при нажатии на кнопку настройки
        private void SettingsTBController(ref TextBox NametextBox, ref Label label, ref Panel panel, ref bool isTB,
                                          ref TextBox CurrentSumTextBox, ref TextBox EndSumTextBox, ref Label CurrentSumLabel,
                                          ref Label EndSumLabel, ref Button clicked_Btn)
        {
            if (!isTB)
            {
                isTB = true;

                NametextBox = new TextBox();
                NametextBox.Text = label.Text;
                NametextBox.Parent = panel;
                NametextBox.Location = label.Location;
                NametextBox.Size = label.Size;
                NametextBox.Font = label.Font;

                CurrentSumTextBox = new TextBox();
                CurrentSumTextBox.KeyPress += SumTextBoxes_KeyPress;
                CurrentSumTextBox.Text = CurrentSumLabel.Text;
                CurrentSumTextBox.Parent = panel;
                CurrentSumTextBox.Location = CurrentSumLabel.Location;
                CurrentSumTextBox.Size = CurrentSumLabel.Size;
                CurrentSumTextBox.Font = CurrentSumLabel.Font;

                EndSumTextBox = new TextBox();
                EndSumTextBox.KeyPress += SumTextBoxes_KeyPress;
                EndSumTextBox.Text = EndSumLabel.Text;
                EndSumTextBox.Parent = panel;
                EndSumTextBox.Location = EndSumLabel.Location;
                EndSumTextBox.Size = EndSumLabel.Size;
                EndSumTextBox.Font = EndSumLabel.Font;


                label.Visible = false;
                CurrentSumLabel.Visible = false;
                EndSumLabel.Visible = false;
                NametextBox.Visible = true;
                CurrentSumTextBox.Visible = true;
                EndSumTextBox.Visible = true;
                NametextBox.Focus();
            }
            else
            {
                label.Text = NametextBox.Text;
                CurrentSumLabel.Text = CurrentSumTextBox.Text;
                CurrentSumTextBox.Dispose();
                EndSumLabel.Text = EndSumTextBox.Text;
                EndSumTextBox.Dispose();
                NametextBox.Dispose();
                label.Visible = true;
                CurrentSumLabel.Visible = true;
                EndSumLabel.Visible = true;
                isTB = false;

                SavePreferencesDataManager(ref clicked_Btn);
            }
        }

        private void PrintPreferencesDataManager(PreferenceData data_element)
        {
            switch (data_element.ID)
            {
                case 1:
                    PrintPreferencesData(data_element, ref label2, ref label6, ref label7, ref progressBar1, ref label14);
                    break;
                case 2:
                    PrintPreferencesData(data_element, ref label3, ref label8, ref label11, ref progressBar2, ref label15);
                    break;
                case 3:
                    PrintPreferencesData(data_element, ref label4, ref label9, ref label12, ref progressBar3, ref label16);
                    break;
                case 4:
                    PrintPreferencesData(data_element, ref label5, ref label10, ref label13, ref progressBar4, ref label17);
                    break;
                case 5:
                    PrintPreferencesData(data_element, ref label21, ref label20, ref label19, ref progressBar5, ref label18);
                    break;
                case 6:
                    PrintPreferencesData(data_element, ref label25, ref label24, ref label23, ref progressBar6, ref label22);
                    break;
            }
        }

        private void PrintPreferencesData(PreferenceData data_element, ref Label nameLbl, ref Label currentLbl, ref Label maxLbl, ref ProgressBar progressBar, ref Label progressLbl)
        {
            nameLbl.Text = data_element.Name;
            currentLbl.Text = data_element.CurrentSum.ToString();
            maxLbl.Text = data_element.MaxSum.ToString();
            try
            {
                progressBar.Value = data_element.GetPercentCurrentToMax();
            }
            catch (ArgumentOutOfRangeException)
            {
                progressBar.Value = progressBar.Maximum;
            }
            progressLbl.Text = data_element.GetPercentCurrentToMax() + "%";
        }

        private void SavePreferencesDataManager(ref Button btn)
        {
            DbManager db = new DbManager();

            var data = db.Preferences.ToList();
            PreferenceData data_element = null;

            if (btn.Name == "button2")
            {
                data_element = data[0];
                SavePreferencesData(ref data_element, ref label2, ref label6, ref label7);
            }
            else if (btn.Name == "button1")
            {
                data_element = data[1];
                SavePreferencesData(ref data_element, ref label3, ref label8, ref label11);
            }
            else if (btn.Name == "button3")
            {
                data_element = data[2];
                SavePreferencesData(ref data_element, ref label4, ref label9, ref label12);
            }
            else if (btn.Name == "button4")
            {
                data_element = data[3];
                SavePreferencesData(ref data_element, ref label5, ref label10, ref label13);
            }
            else if (btn.Name == "button5")
            {
                data_element = data[4];
                SavePreferencesData(ref data_element, ref label21, ref label20, ref label19);
            }
            else if (btn.Name == "button6")
            {
                data_element = data[5];
                SavePreferencesData(ref data_element, ref label25, ref label24, ref label23);
            }

            db.SaveChanges();
            db.Dispose();

            PrintPreferencesDataManager(data_element);
        }

        private void SavePreferencesData(ref PreferenceData data_element, ref Label nameLbl, ref Label currentLbl, ref Label maxLbl)
        {
            data_element.Name = nameLbl.Text;
            data_element.CurrentSum = Convert.ToDouble(currentLbl.Text);
            data_element.MaxSum = Convert.ToDouble(maxLbl.Text);
        }

        public void DBInit()
        {
            using (DbManager db = new DbManager())
            {
                var data = db.Preferences.ToList();

                if (data.Count != 0)
                {
                    foreach (var data_element in data)
                    {
                        PrintPreferencesDataManager(data_element);
                    }
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        var preferenceData = new PreferenceData("PreferenceName" + (i + 1).ToString(), 0, 0, DateTime.Now);
                        preferenceData.ID = i + 1;
                        db.Preferences.Add(preferenceData);
                    }

                    db.SaveChanges();

                    var data1 = db.Preferences.ToList();
                    foreach (var data_element in data1)
                    {
                        PrintPreferencesDataManager(data_element);
                    }
                }
            }
        }
    }
}
