using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_2.Entities
{
    class CountryFederation: Country
    {
        FederationSubject[] fdrts;


        public CountryFederation()
        {
            this.fdrts = new FederationSubject[0];

        }
        public CountryFederation(string n, string c, string r, string l, string m,  int y) : base(n, c, r, l, m, y)
        {

            this.fdrts = new FederationSubject[0];
        }
        public CountryFederation(string n, string c, string r, string l, string m,  int y, FederationSubject[] fd) : base(n, c, r, l, m, y)
        {
            this.fdrts = fd;

        }
        public void AddFederationSubject(FederationSubject f)
        {
            int n = this.fdrts.Length + 1;
            Array.Resize<FederationSubject>(ref this.fdrts, n);
            this.fdrts[n - 1] = f;
        }
        public override int CalculatePopulation()
        {
            foreach(var subject in  fdrts)
            {
                this.Population += subject.Population;
            }
            return this.Population;
        }
        public override double CalculateTerritory()
        {
            foreach(var subject in fdrts)
            {
                this.Territory += subject.Territory;
            }
            return this.Territory;
        }
        public override string ToString()
        {

            string s = "Федеративное государство:\n" + base.ToString() + "\nСубъекты Федерации:";
            for (int i = 0; i < this.fdrts.Length; i++)
            {
                s += String.Format("\n{0}", this.fdrts[i]);

            }
            return s;
        }
        public override void PrintCard()
        {
            Console.WriteLine("Федеративное государство:\n");
            base.PrintCard();
        }

       
    }
}
