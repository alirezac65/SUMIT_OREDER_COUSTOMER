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
        string name_Gorupingfood;
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
        public string Name_gorupingfood
        {
            set { name_Gorupingfood = value; }
            get { return name_Gorupingfood;}
        }
       public void Print_Food()
        {
            Console.WriteLine("Code Food :{0}\tName Food :{1}\tPrice food :{2}",Code_Food,Name_Food,Price_Food);
        }









        } 
        
        
    }

