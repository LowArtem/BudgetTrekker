using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BudgetTrekker
{
    static class GlobalFunctions
    {
        static public IEnumerable<Control> GetAllChildControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllChildControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        static public void SetColorChildPanels(Color color, ref Panel parentPanel)
        {
            var controlsArray = (GetAllChildControls(parentPanel, typeof(Panel))).ToArray();

            foreach (var i in controlsArray)
            {
                i.BackColor = color;
            }
        }
    }
}
