using System;
using Bev.Props.Attributes;

namespace Bev.Props.Entities
{
    public class Rubi : Product
    {
        [PropNameAttribute("Produto")]
        public override string Name { get => nameof(Rubi); }

        [PropNameAttribute("Barreira")]
        public decimal Barrier { get; set; }

        [PropNameAttribute("Strike")]
        public decimal Strike { get; set; }

        [PropNameAttribute("Fixing")]
        public DateTime Fixing { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Barrier} - {Strike} - {Fixing}";
        }
    }
}