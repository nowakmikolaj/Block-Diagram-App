using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockDiagramApp
{
    public abstract class Block
    {
        protected int x;
        protected int y;
        protected RectangleF rectText;

        protected int A { get; }
        protected int B { get; }
        public string Name { get; set; }

        public Block(int _x, int _y, int a, int b)
        {
            x = _x;
            y = _y;
            A = a;
            B = b;
            rectText = new RectangleF(x - A / 2, y - B / 2, A, B);
        }

        public abstract void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush);

        public abstract bool Hit(int eX, int eY, out double distance);

        public void AddText(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 7))
                {
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    g.DrawString(
                        Name,
                        font,
                        Brushes.Black,
                        rectText,
                        sf);
                }
            }
        }
    }

    public class OperationBlock : Block
    {
        private const int penWidth = 5;

        public OperationBlock(int _x, int _y, int a, int b) 
            : base(_x, _y, a, b) 
        {
            Name = "blok operacyjny";
        }

        public override bool Hit(int eX, int eY, out double distance)
        {
            int dist_x = Math.Abs(x - eX);
            int dist_y = Math.Abs(y - eY);
            distance = Math.Sqrt(dist_x * dist_x + dist_y * dist_y);

            return (dist_x <= A / 2 && dist_y <= B / 2);
        }
        public override void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawRectangle(pen, x - A / 2, y - B / 2, A, B);
                g.FillRectangle(FillingBrush, x - A / 2, y - B / 2, A, B);
            }
        }

    }

    public class DecisionBlock : Block
    {
        private Point[] points;
        private const int penWidth = 5;

        public DecisionBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            Name = "blok\ndecyzji";
            List<Point> temp = new List<Point>();
            temp.Add(new Point(x, y - B / 2));
            temp.Add(new Point(x + A / 2, y));
            temp.Add(new Point(x, y + B / 2));
            temp.Add(new Point(x - A / 2, y));

            points = temp.ToArray();

            rectText = new RectangleF(x - A / 4, y - B / 4, A/2, B/2);
        }

        public override bool Hit(int eX, int eY, out double distance)
        {
            double dist_x = Math.Abs(x - eX);
            double dist_y = Math.Abs(y - eY);
            distance = Math.Sqrt(dist_x * dist_x + dist_y * dist_y);

            return (dist_y <= -Convert.ToDouble(B) / Convert.ToDouble(A) * dist_x + Convert.ToDouble(B) / 2);
        }

        public override void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawPolygon(pen, points);
                g.FillPolygon(FillingBrush, points);
            }
        }
    }

    public abstract class EllipseBlock : Block
    {
        private Rectangle rect;
        private const int penWidth = 8;

        public EllipseBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            rect = new Rectangle(x - A / 2, y - B / 2, A, B);
        }

        public override bool Hit(int eX, int eY, out double distance)
        {
            int dist_x = Math.Abs(x - eX);
            int dist_y = Math.Abs(y - eY);
            distance = Math.Sqrt(dist_x * dist_x + dist_y * dist_y);

            return Math.Pow(dist_x, 2) / Math.Pow(Convert.ToDouble(A) / 2, 2) + Math.Pow(dist_y, 2) / Math.Pow(Convert.ToDouble(B) / 2, 2) <= 1;
        }

        public override void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                //Pen pen = new Pen(BorderBrush, penWidth);
                g.DrawEllipse(pen, rect);
                g.FillEllipse(FillingBrush, rect);
            }
        }
    }

    public class StartBlock : EllipseBlock
    {
        public StartBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            Name = "START";
        }
    }

    public class StopBlock : EllipseBlock
    {
        public StopBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            Name = "STOP";
        }
    }

}
