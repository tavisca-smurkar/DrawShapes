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
    public class LineOperation : ILineOperation
    {
        public void Draw(Line line)
        {
           Application.Run(new LineForm(line));
           //new LineForm(line).ShowDialog();
        }
    }
}
