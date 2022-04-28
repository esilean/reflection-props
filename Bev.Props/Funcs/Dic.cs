using System;
using System.Collections.Generic;
using Bev.Props.Entities;

namespace Bev.Props.Funcs
{
    public static class Dic
    {
        public static Product CreateFromDictionary(Type type, IReadOnlyDictionary<string, string> d)
        {
            var obj = Activator.CreateInstance(type);

            foreach (var propertyInfo in type.GetProperties())
            {
                if(propertyInfo.Name == "Name")
                    continue;

                if(propertyInfo.PropertyType.FullName.Contains("Decimal"))
                {
                    propertyInfo.SetValue(obj, GetDecimal(d[propertyInfo.Name]));
                }

                if(propertyInfo.PropertyType.FullName.Contains("DateTime"))
                {
                    propertyInfo.SetValue(obj, GetDateTime(d[propertyInfo.Name]));
                }

                if(propertyInfo.PropertyType.FullName.Contains("String"))
                {
                    propertyInfo.SetValue(obj, d[propertyInfo.Name]);
                }
            }

            return (Product)obj;
        }

        public static decimal GetDecimal(string value)
        {
            return Convert.ToDecimal(value);
        }

        public static DateTime GetDateTime(string value)
        {
            return Convert.ToDateTime(value);
        }
    }
}