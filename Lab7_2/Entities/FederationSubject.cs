using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_2.Entities
{
    class FederationSubject
    {
        int id;
        public string name;
        string capital;

        public double Territory
        { get; set; }
        public int Population
        { get; set; }

       

        public FederationSubject(int i, string c ,string n, double t, int p)
        {
            this.id = i;
            this.capital = c;
            this.name = n;
            this.Territory = t;
            this.Population = p;

        }
        
        
        public override string ToString()
        {
            return String.Format("Код субъекта: {0}; Столица субъекта: {1};  Название субъекта: {2}; Территория: {3}, Население: {4}", this.id, this.capital, this.name, this.Territory, this.Population);
        }

        public static explicit operator CountryUnitary (FederationSubject fs)
        {
            DateTime dt = DateTime.Now;
            int y = dt.Year;
            CountryUnitary cu = new CountryUnitary(fs.capital+"ляндия", fs.capital, "Нет правителя", "Нет единого языка", "Нет денежной единицы", fs.Population, fs.Territory,y);
            //cu.Territory = fs.Territory;
            //cu.Name = fs.name;
            //cu.Population = fs.Population;
            //cu.Capital = fs.capital;
            return cu;
        }
        public static CountryFederation operator +(FederationSubject a, FederationSubject b)
        {
            DateTime dt = DateTime.Now;
            int y = dt.Year;
            CountryFederation cf = new CountryFederation("Новое Федеративное государство",a.Population>b.Population?a.capital:b.capital,"Нет правителя","Нет единого языка","Нет денежной единицы", y);//тернарный оператор
            cf.AddFederationSubject(a);
            cf.AddFederationSubject(b);
            cf.CalculatePopulation();
            cf.CalculateTerritory();
            return cf;
        }

        public static bool operator > (FederationSubject a, FederationSubject b)
        {
            return a.Territory > b.Territory ? true : false;
               
        }
        public static bool operator < (FederationSubject a, FederationSubject b)
        {
            return a.Territory < b.Territory ? true : false;

        }
    }
}
