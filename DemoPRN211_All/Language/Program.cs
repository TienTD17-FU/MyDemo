using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Language
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "   Ta Dinh    Gia Tien   ";
            str = str.Trim();   
            
            String[] strs = str.Split(' ').ToArray();
            foreach (var item in strs)
            {
                Console.WriteLine("'"+item+"'");
            }

            Console.WriteLine("Lastname:" + strs[0]);
            Console.WriteLine("Firstname:" + strs[strs.Length - 1]);
            String surname = "";
            if (strs.Length > 2)
            {
                for (int i = 1; i < strs.Length - 1; i++)
                {
                    if (strs[i] != "")
                    {
                        surname += strs[i] + " ";
                    }
                }
            }
            Console.WriteLine("Surname:" + surname.Trim());

            List<String> lst = new List<String>() {
                "Nguyen Van A",
                "Nguyen Van B",
                "Nguyen Van C",
                "Nguyen",
                "Huyenh"
            };

            Console.WriteLine("danh sách tên:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("danh sách tên:");
            var list = lst.Where(item => item.Length == 6 && item.StartsWith("H"));
            foreach (var item in list)
            {
               Console.WriteLine(item);
            }
            Console.WriteLine("danh sách tên:");
            list = from item in lst where item.Length == 6 && item.StartsWith("H") select item;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Random r = new Random();
            int x = r.Next(10);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
