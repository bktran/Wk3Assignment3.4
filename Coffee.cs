using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Assignment3._4
{
    internal class Coffee : Beverage
    {
        public string Name { get; set; }
        public double Cost 
        {
            get
            {
                if (Size == BeverageSize.Medium)
                {
                    return BasePrice + 2; 
                }
                else if(Size == BeverageSize.Large) 
                {
                    return BasePrice + 2.5;      
                }
                    return BasePrice;
            }
        }
    }
}
