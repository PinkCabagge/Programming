using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.Entities
{
    class CountryUnitary: Country, Interfaces.ICalculateDebt, Interfaces.IMarketRelationship// если класс наследуется от какого-нибудт класса, то сначала укахывается этот класс тольклько потом интерфейс
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
        public void Borrow(decimal sum)
        {
            this.Debt += sum;
        }
        public void Lend(decimal sum)
        {
            this.Debt -= sum;
        }
        public void ExportGoods(decimal sum)
        {
            this.TradeBalance += sum;
        }
        public void ImportGoods(decimal sum)
        {
            this.TradeBalance -= sum;
        }
    }
}
