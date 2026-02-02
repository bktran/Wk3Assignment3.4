using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Assignment3._4
{
    enum BeverageSize
    {
        Small,
        Medium,
        Large,
    }

    enum IceLevel
    {
        None,
        Regular,
        Less,
        More,
    }

    enum SugarLevel
    {
        None,
        Regular,
        Half,
        Extra,
    }
    internal abstract class Beverage
    {
        protected static double BasePrice = 3.00;
        public BeverageSize Size { get; set; } = BeverageSize.Small;
        public IceLevel IceLevel { get; set; } = IceLevel.Regular;
        public SugarLevel SugarLevel { get; set; } = SugarLevel.Regular;
        
    }
}