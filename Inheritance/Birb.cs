using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birb : Animal
    {
        public Birb()
        {

        }
        public bool CanFly { get; set; }
        public string FeatherColor { get; set; }
        public string BeakType { get; set; }
        public double BeakLength { get; set; }

        public Birb(bool canFly, string featherColor, string beakType, double beakLength)
        {
            CanFly = canFly;
            FeatherColor = featherColor;
            BeakType = beakType;
            BeakLength = beakLength;
        }
    }
}
