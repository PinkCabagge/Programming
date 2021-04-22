using System;

namespace Lab7_1
{
    class Счетчик
    {
        public double Длина
        { get; set; }
        public int Величина
        {
            get;
            set;
        }
        public string Наименование
        { get; set; }
        public static explicit operator int(Счетчик a)
        {
            return a.Величина;
        }
        public static explicit operator Счетчик(int i)
        {
            Счетчик a = new Счетчик() { Величина = i, Наименование = "" };
            return a;
        }
        public override string ToString()
        {
            
            return String.Format("Величина:{0} \nДлина:{1} \n\n", this.Величина, this.Длина);
        }
        public static Счетчик operator *(Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина * b.Величина;
            c.Длина = a.Длина * b.Длина;
            return c;

        }
        public static Счетчик operator / (Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина / b.Величина;
            c.Длина = a.Длина / b.Длина;
            return c;

        }
        public static Счетчик operator +(Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина + b.Величина;
            return c;
        }
        public static bool operator <(Счетчик a, Счетчик b)
        {
            return (a.Величина < b.Величина);
        }
        public static bool operator >(Счетчик a, Счетчик b)
        {
            return (a.Величина > b.Величина);
        }
        public static Счетчик operator ++(Счетчик a)
        {
            Счетчик x = new Счетчик() { Величина = a.Величина++ };
            return x;
        }
        public static Счетчик operator --(Счетчик a)
        {
            Счетчик x = new Счетчик() { Величина = a.Величина-- };
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Счетчик x1 = new Счетчик() { Величина = 15 , Длина=20};
            Счетчик x2 = new Счетчик() { Величина = -5, Длина= 10 };
            System.Console.WriteLine(" {0} \n {1} ", x1, x2);
            Счетчик x3 = x1 + x2;
            System.Console.WriteLine(" x3={0}", x3);
            if (x1 < x2)
            {
                System.Console.WriteLine(" {0} меньше {1} ", x1, x2);
            }
            else
            {
                System.Console.WriteLine(" {0} не меньше {1} ", x1, x2);

            }
            int i = (int)x1;
            Счетчик x4 = new Счетчик();
            x4 = (Счетчик)60;
            System.Console.WriteLine("i={0} \n x4={1}", i, x4);
            Счетчик x5 = x1 * x2;
            Console.WriteLine(" x5={0}", x5);
            Счетчик x6 = x1 / x2;
            Console.WriteLine(" x6={0}", x6);
            System.Console.ReadLine();

        }
    }
}
