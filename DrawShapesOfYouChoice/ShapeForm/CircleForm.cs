using Entities;
using EntityFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeForm
{
    public partial class CircleForm : Form
    {
        Circle circle = CircleFactory.GetCircle();
        public CircleForm()
        {
            InitializeComponent();
        }

        public CircleForm(Circle circle)
        {
            InitializeComponent();
            this.circle.pointOneXCoordinate = circle.pointOneXCoordinate;
            this.circle.pointOneYCoordinate = circle.pointOneYCoordinate;
            this.circle.pointTwoXCoordinate = circle.pointTwoXCoordinate;
            this.circle.pointTwoYCoordinate = circle.pointTwoYCoordinate;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = circlePanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen, circle.pointOneXCoordinate, circle.pointOneYCoordinate, circle.pointTwoXCoordinate, circle.pointTwoYCoordinate);
        }
    }
}
