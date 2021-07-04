using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Rupee : Bill
    {
        private readonly string _name;
        private int _value;
        private int _year;

        public Rupee(int value, int year)
        {
            _name = "Rupee";
            _value = value;
            _year = year;
        }

        public override string Name
        {
            get { return _name; }
        }

        public override int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override int Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}
