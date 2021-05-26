using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Entities
{
    class FederationSubject
    {
        int id;
        string name;

        public double Territory
        { get; set; }
        public int Population
        { get; set; }
       

        public FederationSubject(int i, string n, double t, int p)
        {
            this.id = i;
            this.name = n;
            this.Territory = t;
            this.Population = p;

        }
        
        
        public override string ToString()
        {
            return String.Format("Код субъекта: {0}; Название субъекта: {1}; Территория: {2}, Население: {3}", this.id, this.name, this.Territory, this.Population);
        }
    }
}
