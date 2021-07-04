using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class PoundFactory : BillFactory
    {
        private int _value;
        private int _year;

        public PoundFactory(int value, int year)
        {
            _value = value;
            _year = year;
        }

        public override Bill GetBillInformation()
        {
            return new Pound(_value, _year);
        }
    }
}
