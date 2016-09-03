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
    public partial class LineForm : Form
    {
        Line line = LineFactory.GetLine();
        public LineForm()
        {
            InitializeComponent();
        }

        public LineForm(Line newLine)
        {
            InitializeComponent();
            this.line.pointOneXCoordinate = newLine.pointOneXCoordinate;
            this.line.pointOneYCoordinate = newLine.pointOneYCoordinate;
            this.line.pointTwoXCoordinate = newLine.pointTwoXCoordinate;
            this.line.pointTwoYCoordinate = newLine.pointTwoYCoordinate;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = linePanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawLine(pen, line.pointOneXCoordinate, line.pointOneYCoordinate, line.pointTwoXCoordinate, line.pointTwoYCoordinate);
            
        }
        private void linePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LineForm_Load(object sender, EventArgs e)
        {

        }
    }
}
