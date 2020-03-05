using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrekker
{
    public partial class FullCalendarEventTextForm : Form
    {
        public string EventText { get; set; }
        public FullCalendarEventTextForm()
        {
            InitializeComponent();
        }

        private void FullCalendarEventTextForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = EventText;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
            acceptBtn.Focus();            
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(textBox1.Text) && textBox1.Text != this.EventText)
            {
                this.EventText = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
