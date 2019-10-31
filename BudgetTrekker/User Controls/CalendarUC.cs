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
    public partial class CalendarUC : UserControl
    {
        public CalendarUC()
        {
            InitializeComponent();

            BackColorControl();

            dateLb.Text = DateTime.Now.Date.ToString("dd.MM.yyyy") + " — " + GetDayOfWeek(DateTime.Now.DayOfWeek);

            deleteBtn_ToolTip.SetToolTip(this.deleteBtn, "Удалить все выполненные задания?");
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }


        // TODO: дописать удаление элемента и из БД
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                    checkedListBox1.Items.RemoveAt(i);
            }
        }

        // TODO: сделать так, чтобы при выборе определенной даты были ыидны определенные задачи
        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateLb.Text = monthCalendar1.SelectionStart.Date.ToString("dd.MM.yyyy") + " — " + GetDayOfWeek(monthCalendar1.SelectionStart.Date.DayOfWeek);


        }



        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////


        private void BackColorControl()
        {
            infoPanel.BackColor = Color.FromArgb(186, 213, 245);
        }

        private string GetDayOfWeek(DayOfWeek day)
        {
            if (day == DayOfWeek.Monday)
                return "Понедельник";

            else if (day == DayOfWeek.Tuesday)
                return "Вторник";

            else if (day == DayOfWeek.Wednesday)
                return "Среда";

            else if (day == DayOfWeek.Thursday)
                return "Четверг";

            else if (day == DayOfWeek.Friday)
                return "Пятница";

            else if (day == DayOfWeek.Saturday)
                return "Суббота";

            else if (day == DayOfWeek.Sunday)
                return "Воскресенье";

            else
                return "Ошибка";
        }
    }
}
