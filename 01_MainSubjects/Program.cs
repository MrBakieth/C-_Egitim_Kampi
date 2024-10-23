using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomuları

            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Yemekler");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Kategorileri ****");

            #endregion


            #region StringDeğişkenler

            //string 
            // Değişken_türü değişken_adı;

            //string name;
            //name = "Furkan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Furkan";
            //customerSurname = "Çınar";
            //customerPhone = "+90 594 438 12 34";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "Istanbul";

            //Console.WriteLine("***** Rezervasyon Kaydı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email adresi:" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 579 478 12 32";
            //customerEmail = "ayşegül@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email adresi:" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------");

            #endregion


            #region Int Değişkenler

            //int 

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("---- Hammburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Water: " + waterPrice + " TL");
            Console.WriteLine("---- Fries: " + friesPrice + " TL");
            Console.WriteLine("---- Coke: " + cokePrice + " TL");
            Console.WriteLine("---- Lemonade: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;


            int totalhamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice ;
            totalCokePrice = cokeCount * cokePrice ;
            totalWaterPrice = waterCount * waterPrice ;
            totalFriesPrice = friesCount * friesPrice ;
            totalPizzaPrice = pizzaCount * pizzaPrice ;
            totalLemonadePrice = lemonadeCount * lemonadePrice ;

            Console.WriteLine("------------------------");
            Console.WriteLine("Hamburger tutarı; " + totalhamburgerPrice + "TL");
            Console.WriteLine("Pizza tutarı; " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma tutarı; " + totalFriesPrice + "TL");
            Console.WriteLine("Kola tutarı; " + totalCokePrice + "TL");
            Console.WriteLine("Limonata tutarı; " + totalLemonadePrice + "TL");
            Console.WriteLine("Su tutarı; " + totalWaterPrice + "TL");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            int totalPrice = totalCokePrice + totalFriesPrice + totalhamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;
                
            Console.WriteLine("Toplam tutar = " + totalPrice);

            #endregion

            Console.Read();
        }
    }
}
