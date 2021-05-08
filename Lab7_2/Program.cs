using System;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities.FederationSubject altairegion = new Entities.FederationSubject(22,"Барнаул", "Алтайский край", 30, 300);
            Entities.FederationSubject altairepublic = new Entities.FederationSubject(04,"Горно-Алтайск", "Республика Алтай", 450, 200);

            Entities.CountryFederation cf1 = altairegion + altairepublic;
          
            Console.WriteLine("{0}", cf1);
            
            if(altairegion>altairepublic)
            {
                Console.WriteLine("Размер территории {0} больше размера территории {1}",altairegion.name, altairepublic.name);
            }
            else
            {
                Console.WriteLine("Размер территории {0} не больше размера территории {1}", altairegion.name, altairepublic.name);
            }
            

            Entities.FederationSubject nskobl = new Entities.FederationSubject(54,"Новосибирск", "Новосибирская область", 700, 400);

            Console.WriteLine(nskobl.name);

            Entities.CountryUnitary cu1 = (Entities.CountryUnitary)nskobl;

            Console.WriteLine("{0}", cu1);

           

        }
    }
}
