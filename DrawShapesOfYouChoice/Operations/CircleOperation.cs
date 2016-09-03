using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Windows.Forms;
using ShapeForm;

namespace Operations
{
    public class CircleOperation : ICircleOperation
    {
        public void Draw(Circle circle)
        {
            Application.Run(new CircleForm(circle));
        }
    }
}
