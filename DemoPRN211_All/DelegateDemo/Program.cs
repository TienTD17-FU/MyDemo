using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        delegate void myDelegate(int a,int b);
        static void Main(string[] args)
        {
            myDelegate md = new myDelegate(getArea);
            md += new myDelegate(getPerimeter);
            md += new myDelegate(UCLN);

            md(4, 6);
            
            Console.Read(); 
        }

        static void getArea(int length, int width)
        {
            Console.WriteLine("Area="+(length * width)); ;
        }

        static void getPerimeter(int length,int width)
        {
            Console.WriteLine("Perimeter="+ (length + width) * 2); ;
        }

        static void UCLN(int a,int b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine("UCLN="+a);
        }
    }
}
