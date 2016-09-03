using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
namespace OperationFactory
{
    public class CircleOperationFactory
    {
        public static CircleOperation GetCircleOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICircleOperation, CircleOperation>();
            CircleOperation circleOperation = container.Resolve<CircleOperation>();
            return circleOperation;
        }
    }
}
