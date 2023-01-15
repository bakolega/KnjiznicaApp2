using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaApp
{
    public static class Helper
    {
        //Ovo koristimo kako bi samo config morali mijenjati pri promjeni baze
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

     

    }


}
