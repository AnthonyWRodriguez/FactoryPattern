using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    abstract class Bill
    {
        public abstract string Name { get; }
        public abstract int Value { get; set; }
        public abstract int Year { get; set; }
    }
}
