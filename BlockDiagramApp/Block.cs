using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockDiagramApp
{
    [Serializable]
    public abstract class Block
    {
        protected const int penSize = 2;
        protected RectangleF rectText;
        public List<Node> nodes;

        protected int X { get; set; }
        protected int Y { get; set; }
        protected int A { get; }
        protected int B { get; }
        public string Name { get; set; }

        public Block(int _x, int _y, int a, int b)
        {
            X = _x;
            Y = _y;
            A = a;
            B = b;
            rectText = new RectangleF(X - A / 2, Y - B / 2, A, B);
            nodes = new List<Node>();
        }

        public virtual void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush)
        {
            foreach (Node node in nodes)
                node.Draw(bitmap);
        }
        public abstract bool Hit(int eX, int eY, out double distance);

        public abstract Block Copy(int _x, int _y);

        public virtual void Move(int _x, int _y)
        {
            
            X = _x;
            Y = _y;
            rectText = new RectangleF(X - A / 2, Y - B / 2, A, B);
            foreach (Node node in nodes)
            {
                if (node.NextNode != null) 
                    node.Next = node.NextNode.GetPoint();

                node.SetNode(X, Y, A, B, penSize);
                //node.NextNode.Next = default;
            }
        }

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

    [Serializable]
    public class OperationBlock : Block
    {
        public OperationBlock(int _x, int _y, int a, int b) 
            : base(_x, _y, a, b) 
        {
            Name = "blok operacyjny";
            nodes.Add(new EmptyNode(X, Y - B / 2 - penSize));
            nodes.Add(new FilledNode(X, Y + B / 2 + penSize));
        }

        public override bool Hit(int eX, int eY, out double distance)
        {
            int dist_x = Math.Abs(X - eX);
            int dist_y = Math.Abs(Y - eY);
            distance = Math.Sqrt(dist_x * dist_x + dist_y * dist_y);

            return (dist_x <= A / 2 && dist_y <= B / 2);
        }
        public override void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawRectangle(pen, X - A / 2, Y - B / 2, A, B);
                g.FillRectangle(FillingBrush, X - A / 2, Y - B / 2, A, B);
            }
            base.Draw(bitmap, pen, FillingBrush);
        }

        public override Block Copy(int _x, int _y) => new OperationBlock(_x, _y, A, B);

    }

    [Serializable]
    public class DecisionBlock : Block
    {
        private Point[] points;

        public DecisionBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            Name = "blok \ndecyzji";
            nodes.Add(new EmptyNode(X, Y - B / 2 - penSize));
            nodes.Add(new DecisionNode(X - A / 2 - penSize, Y, true));
            nodes.Add(new DecisionNode(X + A / 2 + penSize, Y, false));
            Move(X, Y);
        }

        public override void Move(int _x, int _y)
        {
            base.Move(_x, _y);
            List<Point> temp = new List<Point>();
            temp.Add(new Point(X, Y - B / 2));
            temp.Add(new Point(X + A / 2, Y));
            temp.Add(new Point(X, Y + B / 2));
            temp.Add(new Point(X - A / 2, Y));
            points = temp.ToArray();

            rectText = new RectangleF(X - A / 4, Y - B / 4, A / 2, B / 2);
        }

        public override bool Hit(int eX, int eY, out double distance)
        {
            double dist_x = Math.Abs(X - eX);
            double dist_y = Math.Abs(Y - eY);
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
            base.Draw(bitmap, pen, FillingBrush);
        }

        public override Block Copy(int _x, int _y) => new DecisionBlock(_x, _y, A, B);
    }

    [Serializable]
    public abstract class EllipseBlock : Block
    {

        public EllipseBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
        }

        public override bool Hit(int eX, int eY, out double distance)
        {
            int dist_x = Math.Abs(X - eX);
            int dist_y = Math.Abs(Y - eY);
            distance = Math.Sqrt(dist_x * dist_x + dist_y * dist_y);

            return  Math.Pow(dist_x, 2) / Math.Pow(Convert.ToDouble(A) / 2, 2) + 
                    Math.Pow(dist_y, 2) / Math.Pow(Convert.ToDouble(B) / 2, 2) <= 1;
        }

        public override void Draw(Bitmap bitmap, Pen pen, Brush FillingBrush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawEllipse(pen, rectText);
                g.FillEllipse(FillingBrush, rectText);
            }
            base.Draw(bitmap, pen, FillingBrush);
        }


  }

    [Serializable]
    public class StartBlock : EllipseBlock
    {
        public StartBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            Name = "START";
            nodes.Add(new FilledNode(X, Y + B / 2 + penSize));
        }

        public override Block Copy(int _x, int _y) => new StartBlock(_x, _y, A, B);
  }

    [Serializable]
    public class StopBlock : EllipseBlock
    {
        public StopBlock(int _x, int _y, int a, int b)
            : base(_x, _y, a, b)
        {
            Name = "STOP";
            nodes.Add(new EmptyNode(X, Y - B / 2 - penSize));
        }
          public override Block Copy(int _x, int _y) => new StopBlock(_x, _y, A, B);
  }

}
