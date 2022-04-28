using System;

namespace Bev.Props.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropNameAttribute : Attribute
    {
        public PropNameAttribute(string nameTranslated)
        {
            NameTranslated = nameTranslated;
        }

        public string NameTranslated { get; }
    }
}