using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() 
        { 
        
        }
        //public BadImageFormatException BadImageFormatException { get; set; }<== that looks neat
        public string GenusSpecies { get; set; }
        public string CommonName { get; set; }
        public bool IsWarmBlooded { get; set; }
        public string Population { get; set; }

    }
}
