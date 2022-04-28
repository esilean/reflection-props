using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bev.Props.Attributes;
using Bev.Props.Entities;
using Bev.Props.Funcs;
using Bev.Props.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bev.Props.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(Command command)
        {
            var productName = command.Product["Name"];

            var productType = typeof(Product).Assembly.GetTypes()
                            .Where(type => type.IsSubclassOf(typeof(Product)))
                            .FirstOrDefault(x => x.Name == productName)
                            ;

            var product = Dic.CreateFromDictionary(productType, command.Product);
            Console.WriteLine(product.ToString());

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var classes = typeof(Product).Assembly.GetTypes()
                            .Where(type => type.IsSubclassOf(typeof(Product)));

            foreach (var c in classes)
            {
                foreach (var props in c.GetProperties())
                {
                    Console.WriteLine(props.Name);
                    Console.WriteLine(props.PropertyType);
                    
                    var att = (PropNameAttribute) Attribute.GetCustomAttribute (props, typeof (PropNameAttribute));
                    Console.WriteLine(att.NameTranslated);

                    Console.WriteLine("-------------");
                }
            }
            return Ok();
        }
    }

    
}
