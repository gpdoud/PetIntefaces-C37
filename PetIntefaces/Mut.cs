using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetIntefaces {
    
    internal class Mut : IDog {
    
        public string Color { get; set; } = "Orange";
        public bool IsLarge { get; set; } = false;
        public string Name { get; set; } = "Beans";

        public string Bark() {
            return "Urf!";
        }
    }
}
