using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Creator
{
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
