using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.Interfaces
{
    interface IMarketRelationship
    {
        public decimal TradeBalance//отсутствует реализация не тоже самое, что и автоматические свойства
        { get; set; }

        public void ExportGoods(decimal sum);
        public void ImportGoods(decimal sum);
    }

}
