using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Entities;

namespace EntityFactory
{
   public class HexagonFactory
    {
        public static Hexagon GetHexagon()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Hexagon>();
            Hexagon hexagon = container.Resolve<Hexagon>();
            return hexagon;
        }
    }
}
