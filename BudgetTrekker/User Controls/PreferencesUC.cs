using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: написать здесь нечто похожее на бюджеты, но не обязтельное, а то, на что хватит денег после расчета
namespace BudgetTrekker.User_Controls
{
    public partial class PreferencesUC : UserControl
    {
        public PreferencesUC()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
