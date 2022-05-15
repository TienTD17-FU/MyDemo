using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonEvent
{
    class MyApp
    {
        public Button btnAsa { get; set; }
        public Button btnHiru { get; set; }
        public Button btnBan { get; set; }

        //Khoi tao 1 app co 3 button
        public MyApp()
        {
            btnAsa = new Button("Asa");
            btnHiru = new Button("Hiru");
            btnBan = new Button("Ban");
            btnAsa.onClicked += BtnAsa_onClicked;
            btnHiru.onClicked += BtnHiru_onClicked;
            btnBan.onClicked += BtnBan_onClicked;
        }

        private void BtnBan_onClicked()
        {
            Console.WriteLine("Chet het chung no roi!");
        }

        private void BtnHiru_onClicked()
        {
            Console.WriteLine("Konichiwa!");
        }

        private void BtnAsa_onClicked()
        {
            Console.WriteLine("Ohayogozaimasu!");
        }

        static void Main(string[] args)
        {
            MyApp a = new MyApp();

            while (true)
            {
                Console.WriteLine("1. Asagohan");
                Console.WriteLine("2. Hirugohan");
                Console.WriteLine("3. Bangohan");
                Console.WriteLine("Ban nhan nut nao?");
                int nut = Int32.Parse(Console.ReadLine());
                switch (nut)
                {
                    case 1:
                        a.btnAsa.click();
                        break;
                    case 2:
                        a.btnHiru.click();
                        break;
                    case 3:
                        a.btnBan.click();
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
