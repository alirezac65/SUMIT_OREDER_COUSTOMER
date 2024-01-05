using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMIT_OREDER_COUSTOMER
{
    internal class Goruping_Food
    {
        int code_Gorupingfood;
        string name_Gorupingfood;
        public List<Food> food_list = new List<Food>();
        public int Code_Gorupingfood
        {
            set { code_Gorupingfood = value; }
            get { return code_Gorupingfood;}
        }
        public string Name_Gorupingfood
        {
            set {  name_Gorupingfood = value;}
            get { return name_Gorupingfood;}
        }
        public void AddFood(Food food)
        {
            food_list.Add(food);
        }

        public void RemoveFood(Food food)
        {
            food_list.Remove(food);
        }
        public void Print_G_f()
        {
            Console.WriteLine("Code_Gorupingfood :{0}\nname_Gorupingfood :{1}", Code_Gorupingfood, Name_Gorupingfood);
        }

        //public void Gorupingfood(int b)
        //{
        //    Dictionary<int,string> Gorup_food= new Dictionary<int,string>();
        //    for (int i = 0; i <b; i++)
        //    {
        //        Console.Write("code gaza:");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("name gaza :");
        //        string m = Console.ReadLine();
        //        Gorup_food.Add(n, m);
        //    }
        //    //Gorup_food.Add(1, "fastfood");
        //    //Gorup_food.Add(2, "ghaza kanegi");
        //}



    }
}
