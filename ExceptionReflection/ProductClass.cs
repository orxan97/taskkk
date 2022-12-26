using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionReflection
{
   
    internal class ProductClass
    {
        public int Number;
        public string Name;
        public double Price;
        public Enum Type;
        static int i = 0;
        public ProductClass( string name, double price, Enum type)
        {
            Number = ++i;
            Name = name;
            Price = price;
            Type = type;
      
        }
        public override string ToString()
        {
            return Number+" "+Name+"   price:"+Price;
        }
    }
    
   
    
}
