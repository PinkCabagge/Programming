using System;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Entities.FederationSubject <int> altairegion = new Entities.FederationSubject<int>(22, "Барнаул", "Алтайский край", 30, 300, 10);
            Entities.FederationSubject<int> altairepublic = new Entities.FederationSubject<int>(04, "Горно-Алтайск", "Республика Алтай", 450, 200,20);
            Entities.FederationSubject<int> nskobl = new Entities.FederationSubject<int>(54, "Новосибирск", "Новосибирская область", 700, 400,30);


            Entities.CountryFederation <int>fed1 = new Entities.CountryFederation<int>("Российская Федерация", "Москва", "Путин Владимир Владимирович", "Русский язык", "Российский рубль", 1991);
            fed1.AddFederationSubject(altairegion);
            fed1.AddFederationSubject(altairepublic);
            fed1.AddFederationSubject(nskobl);

            fed1.CalculatePopulation();
            fed1.CalculateTerritory();

            Console.WriteLine("\n{0}", fed1);



            Entities.CountryFederation<string> fed2 = new Entities.CountryFederation<string>("Соединённые Штаты Америки", "Вашингтон", "Джозеф Робинетт Байден", "Английский язык", "Доллар США", 1776);

            Entities.FederationSubject<string> california = new Entities.FederationSubject<string>(310, "Сакраменто","Калифорния", "30", "300", 10);
            Entities.FederationSubject<string> texas = new Entities.FederationSubject<string>(409,"Остин", "Техас", "20", "400", 20);
            Entities.FederationSubject<string> oregon = new Entities.FederationSubject<string>(815, "Сейлем", "Орегон", "50", "1000",30);

            fed2.AddFederationSubject(california);
            fed2.AddFederationSubject(texas);
            fed2.AddFederationSubject(oregon);

            fed2.CalculatePopulation();
            fed2.CalculateTerritory();

            Console.WriteLine("\n{0}", fed2);

            Console.WriteLine("\nПеревод денег из бюждета Алтайского края в бюджет Республики Алтай");

            Console.WriteLine("\nБюджеты до перевода:");

            Console.WriteLine("\n{0} \n{1}", altairegion, altairepublic);

            Entities.Migration<int, int> mgr1 = new Entities.Migration<int, int>()
            {
                Id = 39,
                Amount = 5,
                FromFederationSubject = altairegion,
                InFederationSubject = altairepublic
            };
            mgr1.Perform();

            Console.WriteLine("\nБюджеты после перевода:");

            Console.WriteLine("\n{0} \n{1}", altairegion,altairepublic);
        }
    }
}
