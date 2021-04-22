using System;


namespace Lab5._2
{

    class Program
    {
        static void Main(string[] args)
        {
            Entities.CountryFederation fed1 = new Entities.CountryFederation("Российская Федерация", "Москва", "Путин Владимир Владимирович", "Русский язык", "Российский рубль", 1991);

            Entities.FederationSubject altairegion = new Entities.FederationSubject(22, "Алтайский край", 30, 300);
            Entities.FederationSubject altairepublic = new Entities.FederationSubject(04, "Республика Алтай", 450, 200);
            Entities.FederationSubject nskobl = new Entities.FederationSubject(54, "Новосибирская область", 700, 400);

            fed1.AddFederationSubject(altairegion);
            fed1.AddFederationSubject(altairepublic);
            fed1.AddFederationSubject(nskobl);

            fed1.CalculatePopulation();
            fed1.CalculateTerritory();

            Console.WriteLine("\n{0}", fed1);

            Entities.CountryFederation fed2 = new Entities.CountryFederation("Соединённые Штаты Америки", "Вашингтон", "Джозеф Робинетт Байден", "Английский язык", "Доллар США",  1776);

            Entities.FederationSubject california = new Entities.FederationSubject(310, "Калифорния",30, 300);
            Entities.FederationSubject texas = new Entities.FederationSubject(409, "Техас",20,400);
            Entities.FederationSubject oregon = new Entities.FederationSubject(815, "Орегон",50,1000);

            fed2.AddFederationSubject(california);
            fed2.AddFederationSubject(texas);
            fed2.AddFederationSubject(oregon);

            fed2.CalculatePopulation();
            fed2.CalculateTerritory();

            Console.WriteLine("\n{0}", fed2);

            Entities.CountryFederation fed3 = new Entities.CountryFederation("Объединённые Арабские Эмираты", "Абу-Даби", "Халифа ибн Зайд аль-Нахайян", "Арабский язык", "Дирхам ОАЭ", 1971);

            Entities.FederationSubject abdb = new Entities.FederationSubject(2, "Абу-Даби", 10, 100);
            Entities.FederationSubject adg = new Entities.FederationSubject(6, "Аджман",20, 200);
            Entities.FederationSubject dubai = new Entities.FederationSubject(4, "Дубай", 30, 300);

            fed3.AddFederationSubject(abdb);
            fed3.AddFederationSubject(adg);
            fed3.AddFederationSubject(dubai);

            fed3.CalculatePopulation();
            fed3.CalculateTerritory();

            Console.WriteLine("\n{0}", fed3);

            Entities.CountryUnitary unt1 = new Entities.CountryUnitary("Испания", "Мадрид", "Филипп VI", "Испанский язык", "Евро", 47431256, 505990, 1479);
            Console.WriteLine("\n{0}", unt1);

            Entities.CountryUnitary unt2 = new Entities.CountryUnitary("Китайская Народная Республика", "Пекин", "Си Цзиньпин", "Китайский язык", "Китайский юань", 1404328000, 9596961, 1949);
            Console.WriteLine("\n{0}", unt2);
        }
    }
}
