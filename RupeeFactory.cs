using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class RupeeFactory : BillFactory
    {
        private int _value;
        private int _year;

        public RupeeFactory(int value, int year)
        {
            _value = value;
            _year = year;
        }

        public override Bill GetBillInformation()
        {
            return new Rupee(_value, _year);
        }
    }
}
