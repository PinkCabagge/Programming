using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_2.Entities
{
    class FederationSubject <T>
    {
        int id;
        public string name;
        string capital;

        public T Territory
        { get; set; }
        public T Population
        { get; set; }

        public double Budget
        { get; set; }

       

        public FederationSubject(int i, string c ,string n, T t, T p, double b)
        {
            this.id = i;
            this.capital = c;
            this.name = n;
            this.Territory = t ;
            this.Population = p;
            this.Budget = b;

        }
        
        
        public override string ToString()
        {
            return String.Format("Код субъекта: {0}; Столица субъекта: {1};  Название субъекта: {2}; Территория: {3}, Население: {4}, Бюджет: {5}", this.id, this.capital, this.name, this.Territory, this.Population, this.Budget);
        }

    }
}
