using System.Drawing;
using System.Windows.Forms;

namespace BudgetTrekker.User_Controls
{
    public partial class LastTransactionPanel : UserControl
    {
        public LastTransactionPanel(string dateText, string sumText, string categoryText, bool isIncome = false)
        {
            InitializeComponent();

            dateLbl1.Text = dateText;            
            categoryLbl1.Text = categoryText;

            if (isIncome)
            {
                priceLbl1.Text = "+" + sumText + " руб";
                priceLbl1.ForeColor = Color.Green;
            }
            else
            {
                priceLbl1.Text = "-" + sumText + " руб";
                priceLbl1.ForeColor = Color.Red;
            }
        }
    }
}
