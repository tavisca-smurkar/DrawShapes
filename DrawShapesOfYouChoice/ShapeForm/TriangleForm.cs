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
    public partial class TriangleForm : Form
    {
        Triangle triangle = Trianglefactory.GetTriangle();
        public TriangleForm()
        {
            InitializeComponent();
        }

        public TriangleForm(Triangle triangle)
        {
            InitializeComponent();
            this.triangle.pointOne = triangle.pointOne;
            this.triangle.pointTwo = triangle.pointTwo;
            this.triangle.pointThree = triangle.pointThree;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = trianglePanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawPolygon(pen, new Point[3] { triangle.pointOne, triangle.pointTwo, triangle.pointThree });

        }
    }
}
