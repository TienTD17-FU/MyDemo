using System;

namespace LambdaDemo
{
    //Biểu thức lambda còn gọi là biểu thức hàm nặc danh (Anonymous),
    ////một biểu thức khai báo giống phương thức (hàm) nhưng thiếu tên
    internal class Program
    {
        public delegate int Tinhtong(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Sum (not lambda)=" + tong(4, 5));
            Console.WriteLine("Sum (lambda)=" + tong2(4, 5));

            //Gán biểu thức lambda cho delegate
            Tinhtong tinh = (int x, int y) => { return x + y; };
            Console.WriteLine("Sum (lambda vs delegate)=" + tinh(4, 5));

            //Gán lambda cho Function
            Func<int, int, int> sum = (int x, int y) => { return x + y; };

            //Gán lambda cho Action
            Action<int> showResult=(int result) => Console.WriteLine("Sum (action)="+result);
            showResult(sum(4, 5));


        }

        public static int tong(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Chỉ dùng với loại phương thức có kiểu trả về khác void
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int tong2(int x, int y) => x + y;
    }
}
