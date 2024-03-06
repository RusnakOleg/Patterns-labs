using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Creational.Builder
{
    public  class GuitarComponentsBuilder
    {
        public bool Strings { get; set; }
        public bool GuitarCase { get; set; }
        public bool Strap { get; set; }
        public bool Pick { get; set; }
        public bool Capo { get; set; }
        public bool Stand { get; set; }

        public GuitarComponentsBuilder(){}
        public GuitarComponentsBuilder SetStrings(bool strings)
        {
            Strings = strings;
            return this;
        }
        public GuitarComponentsBuilder SetGuitarCase(bool guitarCase)
        {
            GuitarCase = guitarCase;
            return this;
        }
        public GuitarComponentsBuilder SetStrap(bool strap)
        {
            Strap = strap;
            return this;
        }
        public GuitarComponentsBuilder SetPick(bool pick)
        {
            Pick = pick;
            return this;
        }
        public GuitarComponentsBuilder SetCapo(bool capo)
        {
            Capo = capo;
            return this;
        }
        public GuitarComponentsBuilder SetStand(bool stand)
        {
            Stand = stand;
            return this;
        }
        public GuitarComponents Build()
        {
            return new GuitarComponents(this);
        }

    }
}
