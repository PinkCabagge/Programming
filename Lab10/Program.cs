using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public delegate void CountryDel();// для анонимного делегата
    public delegate int SumTerritory(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //применение анонимных методов
            Console.WriteLine("Информацию какой страны вы желаете увидеть? \nЕсли России, то введите цифру: '1' \nЕсли Испонии, то введите цифру: '2'");

            Console.Write("Ваша цифра: ");

            int a = int.Parse(Console.ReadLine());

            CountryDel cd = new CountryDel(delegate ()
             {
                 switch(a)
                {
                     case 1:
                         Entities.CountryFederation fed1 = new Entities.CountryFederation("Российская Федерация", "Москва", "Путин Владимир Владимирович", "Русский язык", "Российский рубль", 1991);
                         Console.WriteLine("\n{0}", fed1);
                         break;
                     case 2:
                         Entities.CountryUnitary unt1 = new Entities.CountryUnitary("Испания", "Мадрид", "Филипп VI", "Испанский язык", "Евро", 47431256, 505990, 1479);
                         Console.WriteLine("\n{0}", unt1);
                         break;
                     default:
                         Console.WriteLine("Вы выбрали не правильный вариант ответа!");
                         break;
                         
                 }
             });
            
            cd();
            Console.ReadLine();
        }
    }
}
