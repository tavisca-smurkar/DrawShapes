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
    public class TriangleOperation : ITriangleOperation
    { 
        public void Draw(Triangle triangle)
        {
            Application.Run(new TriangleForm(triangle));
        }
    }
}
