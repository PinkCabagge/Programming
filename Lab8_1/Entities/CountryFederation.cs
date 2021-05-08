using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_1.Entities
{
    class CountryFederation<T>: Country
    {
        FederationSubject<T>[] fdrts;


        public CountryFederation()
        {
            this.fdrts = new FederationSubject<T>[0];

        }
        public CountryFederation(string n, string c, string r, string l, string m,  int y) : base(n, c, r, l, m, y)
        {

            this.fdrts = new FederationSubject <T>[0];
        }
        public CountryFederation(string n, string c, string r, string l, string m,  int y, FederationSubject<T>[] fd) : base(n, c, r, l, m, y)
        {
            this.fdrts = fd;

        }
        public void AddFederationSubject(FederationSubject<T> f)
        {
            int n = this.fdrts.Length + 1;
            Array.Resize<FederationSubject<T>>(ref this.fdrts, n);
            this.fdrts[n - 1] = f;
        }
        public override int CalculatePopulation()
        {
            foreach(var subject in  fdrts)
            {
                this.Population += Convert.ToInt32 (subject.Population);
            }
            return this.Population;
        }
        public override double CalculateTerritory()
        {
            foreach(var subject in fdrts)
            {
                this.Territory += Convert.ToDouble (subject.Territory);
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
