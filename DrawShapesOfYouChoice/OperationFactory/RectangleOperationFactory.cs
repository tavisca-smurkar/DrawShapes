using Microsoft.Practices.Unity;
using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationFactory
{
    public class RectangleOperationFactory
    {
        public static RectangleOperation GetRectangleOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRectangleOperation, RectangleOperation>();
            RectangleOperation reactangleOperation = container.Resolve<RectangleOperation>();
            return reactangleOperation;
        }
    }
}
