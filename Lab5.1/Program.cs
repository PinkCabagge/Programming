using System;

namespace Lab5._1
{
    abstract class Клиент
    {
        int код;
        string наимен;
        public int Код//автоматически-реализуемые свойства
        {
            get
            {
                return this.код;
            }
            set
            {
                this.код = value;
            }
        }
        public string Наимен
        {
            get
            {
                if(this.наимен =="-1")
                {
                    return "В наименовании продукта допущена ошибка";
                }
                else
                {
                    return this.наимен;
                }
            }
            set
            {
                this.наимен = value;
            }
        }
        public Клиент()
        {

        }
        public Клиент(int код, string наим)
        {
            this.Код = код;
            this.Наимен = наим;
        }
        public void ПечатьКарточки()
        {
            Console.WriteLine("Карточка № {0} \nНаименование = { 1} \nЗадолженность = { 2 } \nСкидка = { 3 }", this.Код, this.Наимен, this.Долг(), this.Скидка());
        }
        abstract public decimal Долг();
        abstract public decimal Скидка();
        abstract public void СовершитьПокупку(int a);

        public override string ToString()
        {
            return String.Format("Код = {0}; Наименование = {1}", this.Код, this.Наимен);
        }

    }
    class КлиентЮЛ : Клиент
    {
        public decimal ОбщаяСуммаПлатежей;
        public КлиентЮЛ(int код, string наим, decimal сумма_платежей) : base(код, наим)
        {
            this.ОбщаяСуммаПлатежей = сумма_платежей;
        }

        /// <summary>
        /// Расчет скидки для юл
        /// </summary>
        /// <returns></returns>
        public override decimal Скидка()
        {
            if (this.ОбщаяСуммаПлатежей > 10000000)
                return 0.15m;
            else if (this.ОбщаяСуммаПлатежей > 5000000)
                return 0.1m;
            else if (this.ОбщаяСуммаПлатежей > 2000000)
                return 0.05m;
            else
                return 0;
        }

        public override decimal Долг()
        {
            return 0;
        }

        public override void СовершитьПокупку(int a)
        {
            this.ОбщаяСуммаПлатежей += a;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Общая сумма платежей = " + this.ОбщаяСуммаПлатежей.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            КлиентЮЛ x1 = new КлиентЮЛ(10, "ООО Рассвет", 2300000);
            Console.WriteLine(x1);
            КлиентЮЛ x2 = new КлиентЮЛ(20, "-1", 10500);
            Console.WriteLine(x2);
            КлиентЮЛ x3 = new КлиентЮЛ(30, "АО Самара", 3333333);
            x3.СовершитьПокупку(20000);
            Console.WriteLine(x3);
           
            /*x1.ПечатьКарточки();
            x2.ПечатьКарточки();
            x3.ПечатьКарточки();*/
            Console.ReadLine();

        }
    }
}
