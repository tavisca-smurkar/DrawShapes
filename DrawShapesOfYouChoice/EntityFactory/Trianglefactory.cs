using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
namespace EntityFactory
{
    public class Trianglefactory
    {
        public static Triangle GetTriangle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Triangle>();
            Triangle triangle = container.Resolve<Triangle>();
            return triangle;
        }
    }
}
