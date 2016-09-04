using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Operations;

namespace OperationFactory
{
    public class TriangleOperationFactory
    {
        public static TriangleOperation GetTriangleOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ITriangleOperation, TriangleOperation>();
            TriangleOperation triangleOperation = container.Resolve<TriangleOperation>();
            return triangleOperation;
        }
    }
}
