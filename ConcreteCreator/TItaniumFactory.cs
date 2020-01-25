using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Creator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.ConcreteCreator
{
    class TitaniumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
