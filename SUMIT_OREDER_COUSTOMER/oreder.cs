using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SUMIT_OREDER_COUSTOMER
{
    internal class oreder
    {
        int code_Oreder;
       public Food food = new Food(); 
        int number_Food;
        public int Code_oreder
        {
            set { code_Oreder = value; }
            get { return code_Oreder; }
        }
        public int Number_Food
        {
            set { number_Food = value;}
            get { return number_Food; }
        }

    }
}
