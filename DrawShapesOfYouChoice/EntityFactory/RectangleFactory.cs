using Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFactory
{
   public class RectangleFactory
    {
        public static RecTangle GetRectangle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Line>();
            RecTangle rectangle = container.Resolve<RecTangle>();
            return rectangle;
        }
    }
}
