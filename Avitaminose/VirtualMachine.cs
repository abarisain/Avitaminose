using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
    class VirtualMachine
    {
        internal Stack Stack { get; set; }
        internal CPU CPU { get; set; }
        internal Flow Flow { get; set; }

        public VirtualMachine()
        {
            Stack = new Stack();
            CPU = new CPU(this);
            Flow = new Flow(this);
        }
    }
}
