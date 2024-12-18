using System;
using System.ComponentModel.Design;

namespace DreamMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Rüya Markete Hoşgeldinizn\n" + "Elma = 2 Tl \n" + "Armut = 3 Tl\n"
                + "Çilek = 2 Tl\n" + "Muz = 3 Tl\n" + "Diğer Bütün Meyveler = 4 Tl\n\n" + "Hangi Mevyenin Almak İstiyorsunuz?(Elma,Muz,Çilek,Armut,Diğer)");

            string meyve = Console.ReadLine().ToLower();

            switch (meyve)
            {
                case "elma":
                    Console.WriteLine("Elma fiyatı 2Tl'dir");
                    break;

                case "armut":
                    Console.WriteLine("Armut fiyatı 3Tl'dir");
                    break;

                case "çilek":
                    Console.WriteLine("Çilek fiyatı 3Tl'dir");
                    break;

                case "muz":
                    Console.WriteLine("Muz fiyatı 3Tl'dir");
                    break;

                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4Tl'dir");
                    break;
                


            }// Bu uygulama için SwitchCase kullanımını direk olarak meyve ismi ile sorduğumuz için daha mantıklı buldum ve switchcase ile derledim. Çünkü muz dediğimizde diğer meyveleri kontrol etmeye gerek kalmıyor. 

        //    Console.WriteLine("Rüya Markete Hoşgeldinizn\n" + "Elma = 2 Tl \n" + "Armut = 3 Tl\n"
        //        + "Çilek = 2 Tl\n" + "Muz = 3 Tl\n" + "Diğer Bütün Meyveler = 4 Tl\n\n" + "Hangi Mevyenin Almak İstiyorsunuz?(Elma,Muz,Çilek,Armut,Diğer)");

        //    string meyve = Console.ReadLine().ToLower();

        //    if (meyve == "elma")
        //    { Console.WriteLine("Elma Fiyatı 2Tl'dir"); 

        //    else if (meyve == "armut")
        //    Console.WriteLine("Armut fiyatı 3Tl'dir");
            
        //    else if (meyve == "çilek")
        //    Console.WriteLine("Çilek Fiyatı 3Tl'dir");

        //    else if (meyve == "Muz")
        //    Console.WriteLine("Muz fiyatı 3Tl'dir");

        //    else
        //    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4Tl'dir"
        //}



             





        }
    }
}