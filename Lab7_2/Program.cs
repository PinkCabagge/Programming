using System;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities.FederationSubject altairegion = new Entities.FederationSubject(22, "Алтайский край", 30, 300);
            Entities.FederationSubject altairepublic = new Entities.FederationSubject(04, "Республика Алтай", 450, 200);

            Entities.CountryFederation cf1 = altairegion + altairepublic;
            Console.WriteLine("{0}", cf1);

            Entities.FederationSubject nskobl = new Entities.FederationSubject(54, "Новосибирская область", 700, 400);

            Entities.CountryUnitary cu1 = (Entities.CountryUnitary)nskobl;

            Console.WriteLine("{0}", cu1);
            Console.WriteLine("Карина - всё сложно...!")

        }
    }
}
