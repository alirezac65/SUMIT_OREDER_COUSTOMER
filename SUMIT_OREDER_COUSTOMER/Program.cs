using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMIT_OREDER_COUSTOMER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            table nametable = new table();
            Console.Write("please Enter number table self reservation :");
            nametable.Code_Table=Convert.ToInt32(Console.ReadLine());
            Food food = new Food();
            food.C_N_food();
           
        }
    }
}
