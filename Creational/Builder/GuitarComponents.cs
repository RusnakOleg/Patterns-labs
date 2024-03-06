using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class GuitarComponents
    {
        private readonly bool strings;
        private readonly bool guitarCase;
        private readonly bool strap;
        private readonly bool pick;
        private readonly bool capo;
        private readonly bool stand;

        public GuitarComponents(GuitarComponentsBuilder builder)
        {
            strings = builder.Strings;
            guitarCase = builder.GuitarCase;
            strap = builder.Strap;
            pick = builder.Pick;
            capo = builder.Capo;
            stand = builder.Stand;
        }
        public override string ToString()
        {
            return "GuitarComponents\n" +
                "{\n" +
                "    stings = " + strings + "\n" +
                "    guitar case = " + guitarCase + "\n" +
                "    strap = " + strap + "\n" +
                "    pick = " + pick + "\n" +
                "    capo = " + capo + "\n" +
                "    stand = " + stand + "\n" +
                "}";
        }
    }
}
