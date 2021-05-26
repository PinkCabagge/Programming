using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public delegate void CountryDel();// для анонимного делегата
    public delegate double SumTerritory(Entities.CountryFederation a, Entities.CountryUnitary b);
    public delegate int SumPopulation(Entities.CountryFederation a, Entities.CountryUnitary b);

    class Program
    {
        public static double SumTR(Entities.CountryFederation a, Entities.CountryUnitary b)
        {
            return a.Territory + b.Territory;
        }

        public static int SumPpln(Entities.CountryFederation a, Entities.CountryUnitary b)
        {
            return a.Population + b.Population;
        }

        static void Main(string[] args)
        {
            Entities.CountryFederation fed1 = new Entities.CountryFederation("Российская Федерация", "Москва", "Путин Владимир Владимирович", "Русский язык", "Российский рубль", 1991);
            Entities.CountryUnitary unt1 = new Entities.CountryUnitary("Испания", "Мадрид", "Филипп VI", "Испанский язык", "Евро", 47431256, 505990, 1479);
            //применение анонимных методов
            Console.WriteLine("Информацию какой страны вы желаете увидеть? \nЕсли России, то введите цифру: '1' \nЕсли Испонии, то введите цифру: '2'");

            Console.Write("Ваша цифра: ");

            int a = int.Parse(Console.ReadLine());

            CountryDel cd = new CountryDel(delegate ()
             {
                 switch(a)
                {
                     case 1:
                         
                         Console.WriteLine("\n{0}", fed1);
                         break;
                     case 2:
                         
                         Console.WriteLine("\n{0}", unt1);
                         break;
                     default:
                         Console.WriteLine("Вы выбрали не правильный вариант ответа!");
                         break;
                         
                 }
             });
            
            cd();

            Console.WriteLine("Что Вы хотите увидеть? \nЕсли общий размер территории Испании и России, то введите цифру: '1' \nЕсли общую численность населения России и Испании, то введите цифру: '2'");

            int answer = int.Parse(Console.ReadLine());
            SumTerritory sumter = SumTR;
            SumPopulation sumppl = SumPpln;

            switch(answer)
            {
                case 1:
                    Console.WriteLine("Общий размер территории Испании и России = " + sumter(fed1, unt1)+ "км^2");
                    break;
                case 2:
                    Console.WriteLine("Общая численность населения Испании и России = " + sumppl(fed1, unt1)+" человек");
                    break;
                default:
                    Console.WriteLine("Вы выбрали не правильный вариант ответа!");
                    break;
            }

            Action<Entities.CountryUnitary> info_about_country;
            info_about_country = ctr => Console.WriteLine("\n{0}", ctr);
            Console.WriteLine("Информация об Испании:");
            info_about_country(unt1);

            Func<Entities.CountryUnitary, double> density;
            density = ctr => ctr.Population / ctr.Territory;
            Console.WriteLine(String.Format("Плотность населения Испании = {0} чел/км^2", Math.Floor(density(unt1))));



            Console.ReadLine();
        }
    }
}
