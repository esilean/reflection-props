using System;
using Bev.Props.Attributes;

namespace Bev.Props.Entities
{
    public class Booster : Product
    {
        [PropNameAttribute("Produto")]
        public override string Name { get => nameof(Booster); }

        [PropNameAttribute("Barreira")]
        public decimal Barrier { get; set; }

        [PropNameAttribute("Strike1")]
        public decimal Strike1 { get; set; }

        [PropNameAttribute("Strike2")]
        public decimal Strike2 { get; set; }

        [PropNameAttribute("Fixing")]
        public DateTime Fixing { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Barrier} - {Strike1} - {Strike2} - {Fixing}";
        }
    }
}