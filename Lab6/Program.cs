using System;


namespace Lab6
{

    class Program
    {
        static void Main(string[] args)
        {
            Entities.CountryUnitary unt1 = new Entities.CountryUnitary("Испания", "Мадрид", "Филипп VI", "Испанский язык", "Евро", 47431256, 505990, 1479, 0, 0);
            unt1.Lend(100);
            unt1.ImportGoods(300);
            Console.WriteLine("\n{0}", unt1);

            Entities.CountryUnitary unt2 = new Entities.CountryUnitary("Китайская Народная Республика", "Пекин", "Си Цзиньпин", "Китайский язык", "Китайский юань", 1404328000, 9596961, 1949, 0, 0);
            unt2.Lend(400);
            unt2.ImportGoods(100);
            Console.WriteLine("\n{0}", unt2);


            Entities.CountryUnitary unt3 = new Entities.CountryUnitary("Великобритания", "Лондон", "Елизавета II", "Английский язык", "Фунт стерлигов", 66273, 243809, 1707, 0, 0);
            unt3.Lend(10);
            unt3.ImportGoods(15);
            Console.WriteLine("\n{0}", unt3);

            Entities.CountryUnitary unt4 = new Entities.CountryUnitary("Италия","Рим","Серджо Маттарелла","Итальянский язык","Евро", 60588, 301340, 1861,0, 0);
            unt4.Lend(387);
            unt4.ImportGoods(1567);
            Console.WriteLine("\n{0}", unt4);
        }
    }
}
