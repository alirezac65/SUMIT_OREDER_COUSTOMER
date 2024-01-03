using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMIT_OREDER_COUSTOMER
{
    internal class PriceOreder
    {
        int code_priceoreder;
        public table t=new table();
       public List<oreder> oreders = new List<oreder>();
        public int Code_priceoreder
        {
            set { code_priceoreder = value; }
            get { return code_priceoreder; }
        }
        
    }
}
