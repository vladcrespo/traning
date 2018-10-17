using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computers comp1 = new Computers();
            Servers serv1 = new Servers();
            Console.WriteLine("Введите 1 если хотите увидеть цену в долларах, 0 если хотите увидеть цену в рублях:");
            int tmp = Int32.Parse(Console.ReadLine());

            comp1.setCurr(tmp);
            serv1.setCurr(tmp);

            Console.WriteLine("Введите код города доставки:");
            int tmp2 = Int32.Parse(Console.ReadLine());
            comp1.setLoc(tmp2);
            serv1.setLoc(tmp2);


            comp1.model = "GamesX";
            comp1.manufactured = "ASUS";
            comp1.cpu = "Intel Core i5";
            comp1.Hdd = 500;            
            comp1.ram = 8;
            comp1.Price = 1071.2f;
            



            Console.WriteLine("Ваш компьютер:");
            Console.WriteLine(comp1.getItem());
            Console.WriteLine("Компьютер будет доставлен в город {0}\n", comp1.getLoc());            
                                    
            serv1.model = "E5000";
            serv1.manufactured = "HP";
            serv1.typeBody = "cтойка(Blade)";
            serv1.typeServer = "медиасервер";
            serv1.cpu = "Intel Xeon E5";
            serv1.countCPU = 4;
            serv1.cpuSpeed = 2048;
            serv1.Hdd = 1000;
            serv1.HddSpeed = 7200;
            serv1.ram = 64;
            serv1.Price = 2051.5f;

            Console.WriteLine("Ваш компьютер:");   
            Console.WriteLine(serv1.getItem());                       
            Console.WriteLine("Компьютер будет доставлен в город {0}", serv1.getLoc());

            Console.WriteLine("\nСумма {0} компьютеров равна {1} долларов \n", Computers.countComp, Computers.summPrice);
            Console.WriteLine("Средняя сумма будет {0} долларов \n", Computers.meanSumm());


            Console.WriteLine("{0}", serv1.getPower(serv1));

            Console.ReadKey();
        }
    }
}
