using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFactory;
namespace ShapeForm
{
    public partial class RectangleForm : Form
    {
        RecTangle rectangle = RectangleFactory.GetRectangle();
        public RectangleForm()
        {
            InitializeComponent();
        }

        public RectangleForm(RecTangle rectangle)
        {
            InitializeComponent();
            this.rectangle.pointOneXCoordinate = rectangle.pointOneXCoordinate;
            this.rectangle.pointOneYCoordinate = rectangle.pointOneYCoordinate;
            this.rectangle.pointTwoXCoordinate = rectangle.pointTwoXCoordinate;
            this.rectangle.pointTwoYCoordinate = rectangle.pointTwoYCoordinate;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = reactanglePanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawRectangle(pen, rectangle.pointOneXCoordinate, rectangle.pointOneYCoordinate, rectangle.pointTwoXCoordinate, rectangle.pointTwoYCoordinate);

        }
    }
}
