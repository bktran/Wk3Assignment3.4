using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Assignment3._4
{
    internal class Coffee : Beverage
    {
        private double UpCharge = 2.00;
        public double Cost { get; set; }
        public string Name { get; set; }

        public Coffee(string name)
        {
            Name = name;
            Cost = Beverage.BasePrice+ UpCharge;
            BeverageSize Size = BeverageSize.Small;
            IceLevel Ice = IceLevel.RegularIce;
            SugarLevel Sugar = SugarLevel.RegularSugar;
        }
    }
}
