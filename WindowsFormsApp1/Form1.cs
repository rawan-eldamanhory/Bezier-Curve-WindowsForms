using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Cubic Bezier Curve (4 control points)
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Point[] controlPoints = new Point[4];
        private Point[] curvePoints = new Point[101];

        public Form1()
        {
            InitializeComponent();
            
            controlPoints[0] = new Point(50, 200);
            controlPoints[1] = new Point(150, 50);
            controlPoints[2] = new Point(250, 250);
            controlPoints[3] = new Point(350, 200);

            for (int i = 0; i <= 100; i++)
            {
                float t = (float)i / 100;
                curvePoints[i] = CalculateBezierPoint(t, controlPoints);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Point p in controlPoints)
            {
                e.Graphics.FillEllipse(Brushes.Red, p.X - 3, p.Y - 3, 6, 6);
            }

            e.Graphics.DrawLines(Pens.Blue, curvePoints);
        }

        private Point CalculateBezierPoint(float t, Point[] points)
        {
            float u = 1 - t;
            float tt = t * t;
            float uu = u * u;
            float uuu = uu * u;
            float ttt = tt * t;

            float x = uuu * points[0].X;
            x += 3 * uu * t * points[1].X;
            x += 3 * u * tt * points[2].X;
            x += ttt * points[3].X;

            float y = uuu * points[0].Y;
            y += 3 * uu * t * points[1].Y;
            y += 3 * u * tt * points[2].Y;
            y += ttt * points[3].Y;

            return new Point((int)x, (int)y);
        }
    }
}

