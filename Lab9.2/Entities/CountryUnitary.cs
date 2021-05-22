using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9._2.Entities
{
    class CountryUnitary: Country
    {
        

        public CountryUnitary()
        {

        }
        public CountryUnitary(string n, string c, string r, string l, string m, int p, double t, int y) : base(n, c, r, l, m, y)//конструктрор, куда из базового класса перенеслись параметры
        {
            this.Population = p;
            this.Territory = t;
        }

        public override int CalculatePopulation()
        {
            return this.Population;
        }
        public override double CalculateTerritory()
        {
            return this.Territory;
        }
        public override string ToString()
        {
            return "Унитарное государство:\n" + base.ToString();
        }
        
    }
}
