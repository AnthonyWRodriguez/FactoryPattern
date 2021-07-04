using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Peso : Bill
    {
        private readonly string _name;
        private int _value;
        private int _year;

        public Peso(int value, int year)
        {
            _name = "Peso";
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
