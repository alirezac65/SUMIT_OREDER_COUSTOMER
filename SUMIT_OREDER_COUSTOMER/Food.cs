using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMIT_OREDER_COUSTOMER
{
    internal class Food
    {
        int code_Food;
        string name_Food;
        int price_Food;
        public Goruping_Food G=new Goruping_Food();
        public int Code_Food
        {
            set { code_Food = value; }
            get { return code_Food; }
        }
        public string Name_Food
        {
            set { name_Food = value; }
            get { return name_Food; }
        }
        public int Price_Food
        {
            set { price_Food = value; }
            get { return price_Food; }
        } 
        public void C_N_food()
        {
            Dictionary<int, string> food_codes = new Dictionary<int, string>();
           
            while (true)
            {
                Console.Write("baraye gerftan food shore 1 bezanid , baraye print 0 :");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    int count = 1,count1=1;
                    Console.Write("enter code food {0} :", count);
                    code_Food = Convert.ToInt32(Console.ReadLine());
                    count++;
                    Console.Write("enter food {0} :", count1);
                    Name_Food = Console.ReadLine();
                    count1++;
                    food_codes.Add(Code_Food, name_Food);
                }
                if (n ==0)
                {
                    break;
                }
                
            }
            foreach (var item in food_codes)
            {
                Console.WriteLine(item);
            }









        } 
        
        
    }
}
