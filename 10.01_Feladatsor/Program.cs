using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01_Feladatsor
{
    class Program
    {
        static void Main(string[] args)
        {
            //nev 10
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kiss Péter Domnkos");
            }
            Console.ReadKey();
            Console.Clear();


            //ismetlesN
            Console.WriteLine("Adj meg egy számot");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Adj meg egy szót");
            string szo = Convert.ToString(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.Write(szo + " ");
            }
            Console.ReadKey();
            Console.Clear();


            ////visszaszamol
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.Write($"{i} ");
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("\nLejárt az időd");
            //Thread.Sleep(1000);
            //Console.ReadKey();
            //Console.Clear();


            ////nev_mozog
            //for (int i = 0; i < 120; i++)
            //{
            //    Console.SetCursorPosition(i, 0);
            //    Console.WriteLine("Péter");
            //    Thread.Sleep(10);
            //    Console.Clear();
            //}
            //Console.ReadKey();
            //Console.Clear();



            //randomcsillag
            Random rand = new Random();
            for (int i = 0; i < 200; i++)
            {
                int x = rand.Next(0, 120);
                int y = rand.Next(0, 31);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
            }
            Console.ReadKey();



            //randomszin
            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                int z = r.Next(0, 16);
                int x = r.Next(0, 120);
                int y = r.Next(0, 30);
                Console.SetCursorPosition(x, y);
                if (z == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (z == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (z == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (z == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (z == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (z == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (z == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (z == 8)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (z == 9)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (z == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (z == 11)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (z == 12)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (z == 13)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (z == 14)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (z == 15)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.WriteLine("*");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();


            //negyzetszamok
            Console.WriteLine("Négyzetszámok:");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            Console.ReadKey();
            Console.Clear();


            //2hatvanyok
            Console.WriteLine("2 hatványok:");
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
            Console.ReadKey();
            Console.Clear();


            //paratlan
            Console.WriteLine("Páratlan számok:");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
            Console.Clear();


            //paratlan2
            Console.WriteLine("Páratlan számok csökkenő sorrendben:");
            for (int i = 100; i > 0; i--)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();


            //szamtanisor1
            int d = 10;
            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine(d);
                d += 7;
            }
            Console.ReadKey();
            Console.Clear();


            //szamtanisor2
            Console.WriteLine("Add meg az első tagot");
            int elso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a differenciált");
            int di = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(elso);
            for (int i = 0; i < 20; i++)
            {

                elso += di;
                Console.WriteLine(elso);
            }
            Console.ReadKey(true);
            Console.Clear();


            //szamtanisor3
            Console.Write("Add meg az első tagot ");
            int elsu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a következő tagot ");
            int kov = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Harmadik számtani sor");
            int ha = kov - elsu;
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{elsu - (ha * i)}");
            }
            Console.WriteLine($"{elsu}\n{kov}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{kov + (ha * i)}");
            }
            Console.ReadKey();
            Console.Clear();


            //homerseklet_atvaltas
            for (int i = -30; i <= 30; i++)
            {
                Console.WriteLine($"{i}°C = {i * 1.8 + 32}°F");
            }
            Console.ReadKey();
            Console.Clear();


            //ketjegyu3
            Console.WriteLine("Hárommal osztható kétjegyű számok:");
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();


            //osztok
            Console.Write("Adj meg egy pozitív számot");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{p} osztói:");
            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0) Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();


            //prim_teszt
            Console.Write("Adj meg egy pozitív számot");
            int poz = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= poz; i++)
            {
                if (poz % i == 0) count++;
            }
            if (count == 2) Console.WriteLine("Prímszám");
            else Console.WriteLine("Nem prímszám");
            Console.ReadKey();
            Console.Clear();


            //lnko
            Console.Write("Adj meg egy számot ");
            int asd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot is ");
            int asdasd = Convert.ToInt32(Console.ReadLine());
            int index = asd > asdasd ? asd : asdasd;
            int lnko = 1;
            for (int i = 1; i < index; i++)
            {
                if (asd % i == 0 && asdasd % i == 0) lnko = i;
            }
            Console.WriteLine($"Lnko: {lnko}");
            Console.ReadKey();
            Console.Clear();


            //szim3jegyu
            Console.WriteLine("Háromjegyű számok amiknek az első és az utolsó számjegye ugyanaz");
            for (int i = 100; i < 1000; i++)
            {
                if (Convert.ToString(i)[0] == Convert.ToString(i)[2]) Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
