using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.NameChanged += P_NameChanged;
            p.Name = "Huynh";
            p.Name = "De";
            Console.Read();
        }

        private static void P_NameChanged(string n1, string n2)
        {
            Console.WriteLine("May vua doi ten");
            Console.WriteLine("Old name:" +n1);
            Console.WriteLine("New name:"+n2);
        }
    }
}
