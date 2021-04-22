using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_2.Entities
{
    class CountryUnitary: Country
    {
        public decimal Debt
        {
            get
            {
                return this.currentdebt;
            }
            set
            {
                this.currentdebt = value;
            }
        }
        public decimal TradeBalance
        {
            get
            {
                return this.currenttradebalance;
            }
            set
            {
                this.currenttradebalance = value;
            }
        }

        public CountryUnitary()
        {

        }
        public CountryUnitary(string n, string c, string r, string l, string m, int p, double t, int y, decimal ctb, decimal d) : base(n, c, r, l, m, y, ctb, d)//конструктрор, куда из базового класса перенеслись параметры
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
