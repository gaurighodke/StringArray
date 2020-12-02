using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {  
        static void Main(string[] args)
        {
            List<String> Names = new List<String>{ "Gauri","Purva","Ekta","Aishwarya","Chaitali", "Anuja","Sayali","Neha"};       
                //Console.WriteLine("Enter The Names");
                //string result = Console.ReadLine();
            //Console.WriteLine(Names.Contains(result));
            //Console.ReadLine();

            // string contains letter a
            foreach (var item in Names)
            {     
                if (item.Contains("a") == true)
                {
                    Console.WriteLine(item);
                }
            }
            //foreach (var item in Names)
            //    {
            //        if (item.Length % 2 != 0)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
        }
    }
}
