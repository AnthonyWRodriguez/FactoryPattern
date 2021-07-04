using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class PesoFactory : BillFactory
    {
        private int _value;
        private int _year;

        public PesoFactory(int value, int year)
        {
            _value = value;
            _year = year;
        }

        public override Bill GetBillInformation()
        {
            return new Peso(_value, _year);
        }
    }
}
