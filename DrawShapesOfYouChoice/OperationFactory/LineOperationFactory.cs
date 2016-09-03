using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Operations;

namespace OperationFactory
{
    public class LineOperationFactory
    {
        public static LineOperation GetLineOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILineOperation,LineOperation> ();
            LineOperation lineOperation = container.Resolve<LineOperation>();
            return lineOperation;
        }
    }
}
