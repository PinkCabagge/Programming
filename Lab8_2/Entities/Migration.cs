using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2.Entities
{
    class Migration<T,S>
    {
        public FederationSubject<T> FromFederationSubject { get; set; }
        public FederationSubject<T> InFederationSubject { get; set; }
        public S Id { get; set; }
        public double Amount { get; set; }
        public void Perform() 
        {
            this.FromFederationSubject.Budget-=this.Amount;
            this.InFederationSubject.Budget += this.Amount;
        }

    }
}
