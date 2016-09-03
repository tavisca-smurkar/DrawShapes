using Entities;
using ShapeForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operations
{
    public class RectangleOperation : IRectangleOperation
    {
        public void Draw(RecTangle rectangle)
        {
            Application.Run(new RectangleForm(rectangle));
            //new LineForm(line).ShowDialog();
        }
    }
}
