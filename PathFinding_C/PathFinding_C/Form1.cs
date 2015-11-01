using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PathFinding_C
{  

    public partial class MainForm : Form
    {
        private List<MyCircle> myCircles = new List<MyCircle>();
        private MyCircle activeCircle;
        private bool drawingLine = false;
        private bool drawingCircle = false;
        private bool draggingCircle = false;
        private Pen pen = new Pen(new SolidBrush(Color.Blue));
        private Point dragOffset;
        private int numberOfCircles = 1;

        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isNode.Checked)
            {

                if (e.Button != MouseButtons.Left) return;

                drawingCircle = false;
                draggingCircle = false;

                activeCircle = CheckIfCircleClicked(e.Location);

                if (activeCircle == null)
                {
                    activeCircle = new MyCircle(e.Location, 0, numberOfCircles, Color.Blue);
                    numberOfCircles++;
                    drawingCircle = true;
                }
                else
                {
                    draggingCircle = true;
                    dragOffset = new Point(activeCircle.Point.X - e.Location.X, activeCircle.Point.Y - e.Location.Y);
                }
            }
            else if(isVertecie.Checked)
            {
                if (e.Button != MouseButtons.Left) return;

                drawingLine = false;

                activeCircle = CheckIfCircleClicked(e.Location);

                if (activeCircle == null)
                {
                    MessageBox.Show("gfy");
                }
                else
                {
                    MessageBox.Show((activeCircle.Number).ToString());
                    activeCircle.Color = Color.Red;
                }
            }
        }

        private MyCircle CheckIfCircleClicked(Point point)
        {
            return
                myCircles.FirstOrDefault(
                    circle =>
                        Math.Abs(circle.Point.X - point.X) < circle.Radius &&
                        Math.Abs(circle.Point.Y - point.Y) < circle.Radius);
        }

        public class MyCircle
        {
            public Point Point { get; set; }
            public double Radius { get; set; }
            public int Number { get; set; }
            public Color Color { get; set; }
            public bool Selected = false;

            public MyCircle(Point point, Double radius, int number, Color color)
            {
                Point = point;
                Radius = radius;
                Number = number;
                Color = color;

            }
        }

        public class MyLine
        {
            public Point Start { get; set; }
            public Point End { get; set; }
            public int Number { get; set; }

            public MyLine(Point start, Point end, int number)
            {
                Start = start;
                end = End;
                Number = number;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingCircle)
            {
                activeCircle.Radius = Math.Max(Math.Abs(e.Location.X - activeCircle.Point.X),
                    Math.Abs(e.Location.Y - activeCircle.Point.Y));
                pictureBox1.Invalidate();
            }
            else if (draggingCircle)
            {
                activeCircle.Point = new Point(e.Location.X + dragOffset.X, e.Location.Y + dragOffset.Y);
                pictureBox1.Invalidate();
            }
            else if(drawingLine)
            {

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            if (activeCircle == null)
                return;
            if(draggingCircle)
            {
                activeCircle.Point = new Point(e.Location.X + dragOffset.X, e.Location.Y + dragOffset.Y);
            }
            else if(drawingCircle)
            {
                activeCircle.Radius = Math.Max(Math.Abs(e.Location.X - activeCircle.Point.X),
                    Math.Abs(e.Location.Y - activeCircle.Point.Y));
                myCircles.Add(activeCircle);
            }

            draggingCircle = false;
            drawingCircle = false;
            drawingLine = false;

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            foreach (var circle in myCircles.Where(c => c != activeCircle))
            {
                if(drawingLine)
                {

                }
                g.DrawEllipse(pen, (float)(circle.Point.X - circle.Radius), (float)(circle.Point.Y - circle.Radius),
                    (float)(circle.Radius * 2),
                    (float)(circle.Radius * 2));

                g.DrawString(circle.Number.ToString(),
                new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(Convert.ToInt32(circle.Point.X - 5), Convert.ToInt32(circle.Point.Y - 5)));
            }

            if (activeCircle != null)
            {
                pen.Color = activeCircle.Color;
                g.DrawEllipse(pen, (float)(activeCircle.Point.X - activeCircle.Radius),
                    (float)(activeCircle.Point.Y - activeCircle.Radius), (float)(activeCircle.Radius * 2),
                    (float)(activeCircle.Radius * 2));

                g.DrawString(activeCircle.Number.ToString(),
                new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(Convert.ToInt32(activeCircle.Point.X - 5), Convert.ToInt32(activeCircle.Point.Y - 5)));
            }

        }

    }
}