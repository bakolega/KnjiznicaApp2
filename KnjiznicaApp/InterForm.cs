using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;

namespace KnjiznicaApp
{
    public static class InterForm
    {
        public static void goback(Form temp) //Prikazuje glavnu formu
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            //temp.Close(); 
        }
    }
}
