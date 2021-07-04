using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class YenFactory : BillFactory
    {
        private int _value;
        private int _year;

        public YenFactory(int value, int year)
        {
            _value = value;
            _year = year;
        }

        public override Bill GetBillInformation()
        {
            return new Yen(_value, _year);
        }
    }
}