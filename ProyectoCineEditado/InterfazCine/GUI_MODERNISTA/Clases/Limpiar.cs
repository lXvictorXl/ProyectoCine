using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    class Limpiar
    {
        public void BorrarCampos(Control control) 
        {
            foreach (var txt in control.Controls) 
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox) 
                {
                    ((ComboBox)txt).ResetText();
                }
            }
        }
    }
}
