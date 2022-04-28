using System.Collections.Generic;
using Bev.Props.Attributes;

namespace Bev.Props.Entities
{
    public abstract class Product
    {
        [PropNameAttribute("Produto")]
        public virtual string Name { get; }
    }
}