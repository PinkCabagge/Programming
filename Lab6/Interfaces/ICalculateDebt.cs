using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.Interfaces
{
    interface ICalculateDebt// у членов интерфейса не может быть реализации
    {
        public decimal Debt
        { get; set; }

        public void Borrow(decimal sum);
        public void Lend(decimal sum);
    }
}
