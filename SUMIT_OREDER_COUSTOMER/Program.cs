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
           List<Goruping_Food> G_F=new List<Goruping_Food>();
            Console.Write("tedad daste bandi masolat ghaza :");
            int D_b=Convert.ToInt32(Console.ReadLine());
            Console.Write("tedad ghaza baraye har daste :");
            int F_d=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <D_b; i++)
            {
                Goruping_Food goruping_Food = new Goruping_Food();
                Console.Write("Enter Code Goruping Food :");
                goruping_Food.Code_Gorupingfood=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name Goruping Food :");
                goruping_Food.Name_Gorupingfood=Console.ReadLine();
                for (int j = 0; j < F_d; j++)
                {
                    Food food = new Food();
                    Console.Write("\tEnter Code  Food :");
                    food.Code_Food = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\tEnter Name  Food :");
                    food.Name_Food = Console.ReadLine();
                    Console.Write("\tEnter Price Food :");
                    food.Price_Food = Convert.ToInt32(Console.ReadLine());
                    goruping_Food.AddFood(food);

                }
                G_F.Add(goruping_Food);

            }
            foreach (var item in G_F)
            {
                item.Print_G_f();
                for (int i = 0; i <item.food_list.Count; i++) {
                    item.food_list[i].Print_Food();
                }
            }
            table table = new table();
            Console.Write("Enter number table reservation :");
            table.Code_Table=Convert.ToInt32(Console.ReadLine());

        }
    }
}
