using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    abstract class Country
    {
        string name;
        string capital;
        string ruler;
        string language;
        string moneyunit;
        int population;
        double territory;
        int yearoffoundation;
        protected decimal currenttradebalance;
        protected decimal currentdebt;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Capital
        {
            get
            {
                return this.capital;
            }
            set
            {
                this.name = value;
            }
        }
        public string Ruler
        {
            get
            {
                return this.ruler;
            }
            set
            {
                this.ruler = value;
            }
        }
        public string Language
        {
            get
            {
                return this.language;
            }
        }
        public string Moneyunit
        {
            get
            {
                return this.moneyunit;
            }
        }
        public int Population
        {
            get
            {
                return this.population;
            }
            set
            {
                this.population = value;
            }
        }
        public double Territory
        {
            get
            {
                return this.territory;
            }
            set
            {
                this.territory = value;
            }
        }
        public int Yearoffoundation
        {
            get
            {
                return this.yearoffoundation;
            }
        }
        public Country()
        {

        }
        public Country(string n, string c, string r, string l, string m, int y, decimal ctb, decimal d)
        {
            this.name = n;
            this.capital = c;
            this.ruler = r;
            this.language = l;
            this.moneyunit = m;
            this.yearoffoundation = y;
            this.currenttradebalance = ctb;
            this.currentdebt = d;
        }

        abstract public double CalculateTerritory();
        abstract public int CalculatePopulation();
        public override string ToString()
        {

            return String.Format("\nНазвание страны: {0};\nСтолица: {1};\nПравитель: {2};\nЯзык: {3};\nДенежная единица: {4};\nНаселение: {5} чел.;\nТерритория: {6}км^2;\nГод основания: {7};\nТекущее сальдо торгового балланса: {8};\nТекущий государственный долг: {9};\n", this.name, this.capital, this.ruler, this.language,
                this.moneyunit, this.population, this.territory, this.yearoffoundation, this.currenttradebalance, this.currentdebt);
        }
        public virtual void PrintCard()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
