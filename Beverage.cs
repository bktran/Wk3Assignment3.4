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
        NoIce,
        RegularIce,
        LessIce,
        MoreIce,
    }

    enum SugarLevel
    {
        NoSugar,
        RegularSugar,
        HalfSugar,
        ExtraSugar,
    }
    internal abstract class Beverage
    {
        public bool Cold { get; set; } = true;
        protected static double BasePrice = 3.00;
        protected BeverageSize Size { get; set; }
        protected IceLevel IceOption { get; set; }
        protected SugarLevel SugarLevel { get; set; }

    }
}