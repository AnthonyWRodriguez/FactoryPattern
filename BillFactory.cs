using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    abstract class BillFactory
    {
        public abstract Bill GetBillInformation();
    }
}
