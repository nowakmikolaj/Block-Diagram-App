using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BlockDiagramApp
{
    [Serializable]
    public abstract class Node
    {
        protected const float penSize = 1f;
        protected const string decisionTrue = "T";
        protected const string decisionFalse = "F";
        protected const int r = 7;

        protected int X { get; set; }
        protected int Y { get; set; }
        public Point Next { get; set; }
        public Node NextNode { get; set; }

        public Node(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public abstract void SetNode(int _x, int _y, int A, int B, int size);

        public virtual Point GetPoint() => new Point(X, Y);

        public virtual bool Hit(int eX, int eY)
        {
            return NextNode == null && Math.Pow(eX - X, 2) + Math.Pow(eY - Y, 2) <= Math.Pow(r, 2);
        }

        public virtual void Draw(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Brushes.Black, penSize);
                g.DrawEllipse(pen, X - r/2, Y - r/2, r, r);
            }
        }

    }

    [Serializable]
    public class EmptyNode : Node
    {

        public EmptyNode(int _x, int _y) : base(_x, _y) { }

        public override void SetNode(int _x, int _y, int A, int B, int size)
        {
            X = _x;
            Y = _y - B / 2 - size;
        }

        public override void Draw(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                if (Next != default)
                {
                    Pen pen = new Pen(Brushes.Black, penSize);
                    g.DrawLine(pen, GetPoint(), NextNode == null ? Next : NextNode.GetPoint());
                }
                else
                {
                    g.FillEllipse(Brushes.White, X - r / 2, Y - r / 2, r, r);
                    base.Draw(bitmap);
                }
            }
        }
    }

    [Serializable]
    public class FilledNode : Node
    {
        public FilledNode(int _x, int _y) : base(_x, _y) { }

        public override void SetNode(int _x, int _y, int A, int B, int size)
        {
            X = _x;
            Y = _y + B / 2 + size;
        }

        public override void Draw(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                if (Next != default)
                {
                    Pen pen = new Pen(Brushes.Black, penSize);
                    pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                    g.DrawLine(pen, GetPoint(), NextNode == null ? Next : NextNode.GetPoint());
                }
                else
                {
                    g.FillEllipse(Brushes.Black, X - r / 2, Y - r / 2, r, r);
                    base.Draw(bitmap);
                }
            }
        }
    }

    [Serializable]
    public class DecisionNode : FilledNode
    {
        private string decision { get; }
        private readonly int k;

        public DecisionNode(int _x, int _y, bool _b) : base(_x, _y)
        {
            decision = _b ? decisionTrue : decisionFalse;
            k = _b ? -1 : 1;
        }

        public override void SetNode(int _x, int _y, int A, int B, int size)
        {
            X = _x + k * (A / 2 + size);
            Y = _y;
        }

        public override void Draw(Bitmap bitmap)
        {
            base.Draw(bitmap);
            AddText(bitmap);
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
                        decision,
                        font,
                        Brushes.Black,
                        new Point(X, Y - 10),
                        sf);
                }
            }
        }
    }

    
}
