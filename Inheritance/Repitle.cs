using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Repitle : Animal
    {
        public Repitle() { }
        public bool IsPoisoness { get; set; }
        public bool IsLegless { get; set; }
        public bool CanRegenerate { get; set; }
        public bool InfraredVision { get; set; }

        public Repitle(bool isPoisoness, bool isLegless, bool canRegenerate, bool infraredVision)
        {
            IsPoisoness = isPoisoness;
            IsLegless = isLegless;
            CanRegenerate = canRegenerate;
            InfraredVision = infraredVision;
        }
    }
}
