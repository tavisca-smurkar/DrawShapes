using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
namespace OperationFactory
{
   public class HexagonOperationFactory
    {
        public static HexagonOperation GetHexagonOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IHexagonOperation,HexagonOperation>();
            HexagonOperation hexagonOperation = container.Resolve<HexagonOperation>();
            return hexagonOperation;
        }
    }
}
