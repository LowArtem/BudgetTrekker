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
    public partial class CalendarUC : UserControl
    {
        private static bool isShowingAllTasks = false; // включен ли показ всех задач в календаре


        public CalendarUC()
        {
            InitializeComponent();

            BackColorControl();

            dateLb.Text = DateTime.Now.Date.ToString("dd.MM.yyyy") + " — " + GetDayOfWeek(DateTime.Now.DayOfWeek);

            deleteBtn_ToolTip.SetToolTip(this.deleteBtn, "Все выполненные события будут удалены без возможности восстановления");
            addBtn_ToolTip.SetToolTip(this.addBtn, "Так же это возможно по нажатия правой кнопки мыши в пустом месте");
            showallBtn_ToolTip.SetToolTip(this.show_all_btn, "Показать/скрыть все задачи вне зависимости от даты");

            DayTaskPrint();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        // Удаление выполненных событий
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    using (DbManager db = new DbManager())
                    {
                        var all_tasks = db.Tasks.ToList();
                        foreach (var task in all_tasks)
                        {
                            if (task.IsComplete)
                            {
                                db.Tasks.Remove(task);
                            }                                                    
                        }

                        var calendars = db.Calendars.ToList();
                        foreach (var calendar in calendars)
                        {
                            if (calendar.Tasks == null || calendar.Tasks.Count == 0)
                            {
                                db.Calendars.Remove(calendar);
                            }
                        }

                        db.SaveChanges();
                    }

                    checkedListBox1.Items.RemoveAt(i);
                }
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (isShowingAllTasks)
                AllTaskPrint();
            else
                DayTaskPrint();
        }

        // Добавление нового события в календарь 
        // Окно с полным текстом события
        private void CheckedListBox1_MouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Right)
            {
                // Окно с полным текстом события
                int index = checkedListBox1.IndexFromPoint(e.Location);
                if (index != CheckedListBox.NoMatches)
                {
                    FullCalendarEventTextForm eventTextForm = new FullCalendarEventTextForm();
                    eventTextForm.EventText = checkedListBox1.Items[index].ToString();

                    // Текст события изменен
                    if (eventTextForm.ShowDialog() == DialogResult.OK)
                    {
                        string oldEventText = checkedListBox1.Items[index].ToString();
                        checkedListBox1.Items[index] = eventTextForm.EventText;
                        eventTextForm.Dispose();

                        using (DbManager db = new DbManager())
                        {
                            var data = db.Calendars.ToList();
                            foreach (var data_element in data)
                            {
                                List<TaskData> tasks;
                                if (data_element.Time.ToShortDateString() == monthCalendar1.SelectionStart.Date.ToShortDateString())
                                {
                                    tasks = data_element.Tasks.ToList();
                                    foreach (var task_item in tasks)
                                    {
                                        if (task_item.TaskText == oldEventText)
                                        {
                                            task_item.TaskText = checkedListBox1.Items[index].ToString();
                                            break;
                                        }
                                    }
                                }
                            }

                            db.SaveChanges();
                        }
                    }
                    // Текст события не изменен
                    else
                    {
                        eventTextForm.Dispose();
                    }
                }
                // Добавление нового события в календарь 
                else
                {
                    AddBtn_Click(sender, new EventArgs());
                }
            }
        }

        // Добавление нового события
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string newEventText = "";
            NewCalendarEventForm eventForm = new NewCalendarEventForm();
            if (eventForm.ShowDialog() == DialogResult.OK)
            {
                newEventText = eventForm.EventText;
                checkedListBox1.Items.Add(newEventText, false);

                using (DbManager db = new DbManager())
                {
                    var data = db.Calendars.ToList();
                    bool isAdded = false;

                    foreach (var data_element in data)
                    {
                        if (data_element.Time.ToShortDateString() == monthCalendar1.SelectionStart.Date.ToShortDateString())
                        {
                            data_element.Tasks.Add(new TaskData(newEventText));
                            isAdded = true;
                            break;
                        }
                    }

                    if (!isAdded)
                    {
                        List<TaskData> tasks = new List<TaskData>();
                        tasks.Add(new TaskData(newEventText));
                        var calendarData = new CalendarData(monthCalendar1.SelectionStart.Date, tasks);
                        calendarData.ID = data.Count + 1;
                        db.Calendars.Add(calendarData);
                        isAdded = true;
                    }

                    db.SaveChanges();
                }
            }
            eventForm.Dispose();
        }

        // Изменение чекбокса
        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            using (DbManager db = new DbManager())
            {
                var calendars = db.Calendars.ToList();
                foreach (var calendar in calendars)
                {
                    List<TaskData> tasks;
                    if (calendar.Time.ToShortDateString() == monthCalendar1.SelectionStart.Date.ToShortDateString())
                    {
                        tasks = calendar.Tasks.ToList();
                        foreach (var task_item in tasks)
                        {                            
                            if (task_item.TaskText == checkedListBox1.Items[e.Index].ToString())
                            {
                                if (e.NewValue == CheckState.Checked)
                                    task_item.IsComplete = true;
                                else
                                    task_item.IsComplete = false;

                                if (!isShowingAllTasks)
                                    break;
                            }
                        }
                    }
                    else if (isShowingAllTasks)
                    {
                        var all_tasks = db.Tasks.ToList();
                        foreach (var task in all_tasks)
                        {
                            if (task.TaskText == checkedListBox1.Items[e.Index].ToString())
                            {
                                if (e.NewValue == CheckState.Checked)
                                    task.IsComplete = true;
                                else
                                    task.IsComplete = false;
                            }
                        }
                    }
                }

                db.SaveChanges();
            }
        }

        // Показать/скрыть все задачи, вне зависимости от даты
        private void Show_all_btn_Click_1(object sender, EventArgs e)
        {
            // если включен просмотр всех задач, сменить режим просмотра на задачи по дням
            if (isShowingAllTasks)
            {
                show_all_btn.BackgroundImage = Properties.Resources.visible; // иконка кнопки
                isShowingAllTasks = false;

                DayTaskPrint();
            }
            // иначе, если включен режим промотра по дням, сменить режим на просмотр всех задач
            else
            {
                show_all_btn.BackgroundImage = Properties.Resources.invisible; // иконка кнопки
                isShowingAllTasks = true;

                AllTaskPrint();
            }
        }



        ///////////////////////////////////////////////////////////////////////////////////////
        // another Methods
        ///////////////////////////////////////////////////////////////////////////////////////



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


        private void DayTaskPrint()
        {
            var selection_date = monthCalendar1.SelectionStart.Date;
            dateLb.Text = selection_date.ToString("dd.MM.yyyy") + " — " + GetDayOfWeek(monthCalendar1.SelectionStart.Date.DayOfWeek);

            checkedListBox1.Items.Clear();

            using (DbManager db = new DbManager())
            {
                var data = db.Calendars.ToList();
                foreach (var data_element in data)
                {
                    List<TaskData> tasks;
                    if (data_element.Time.ToShortDateString() == selection_date.ToShortDateString())
                    {
                        tasks = data_element.Tasks.ToList();

                        foreach (var task_item in tasks)
                        {
                            checkedListBox1.Items.Add(task_item.TaskText, task_item.IsComplete);
                        }
                    }
                }
            }
        }

        private void AllTaskPrint()
        {
            checkedListBox1.Items.Clear();

            using (DbManager db = new DbManager())
            {
                var tasks = db.Tasks.ToList();
                foreach (var task in tasks)
                {
                    checkedListBox1.Items.Add(task.TaskText, task.IsComplete);
                }
            }
        }
    }
}
