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
    public partial class HexagonForm : Form
    {
        Hexagon hexagon = HexagonFactory.GetHexagon();
        public HexagonForm()
        {
            InitializeComponent();
        }

        public HexagonForm(Hexagon hexagon)
        {
            InitializeComponent();
            this.hexagon.pointOne = hexagon.pointOne;
            this.hexagon.pointTwo = hexagon.pointTwo;
            this.hexagon.pointThree = hexagon.pointThree;
            this.hexagon.pointFour = hexagon.pointFour;
            this.hexagon.pointFive = hexagon.pointFive;
            this.hexagon.pointSix = hexagon.pointSix;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = hexagonPanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawPolygon(pen,new Point[6] {hexagon.pointOne,hexagon.pointTwo,hexagon.pointThree,hexagon.pointFour,hexagon.pointFive,hexagon.pointSix });
        }
    }
}
