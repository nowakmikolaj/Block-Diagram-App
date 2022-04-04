using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BlockDiagramApp
{
    public abstract class Block
    {
        protected int x;
        protected int y;
        protected readonly Brush FillingBrush;
        protected readonly Pen pen;
        protected Bitmap bitmap;

        protected int A { get; }
        protected int B { get; }
        protected string Name { get; set; }

        public Block(int _x, int _y, int a, int b, Bitmap _bitmap)
        {
            x = _x;
            y = _y;
            A = a;
            B = b;
            bitmap = _bitmap;

            // Initialize pen and brush
            pen = new Pen(Brushes.Black, 3);
            FillingBrush = Brushes.White;
        }

        public abstract void Draw();
        public void AddText()
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
                        new RectangleF(x - A / 2, y - B / 2, A, B),
                        sf);
                }
            }
        }
    }

    public class OperationBlock : Block
    {
        public OperationBlock(int _x, int _y, int a, int b, Bitmap _bitmap) 
            : base(_x, _y, a, b, _bitmap) 
        {
            Name = "blok operacyjny";
        }


        public override void Draw()
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

        public DecisionBlock(int _x, int _y, int a, int b, Bitmap _bitmap)
            : base(_x, _y, a, b, _bitmap)
        {
            Name = "blok\ndecyzji";
            List<Point> temp = new List<Point>();
            temp.Add(new Point(x, y - B / 2));
            temp.Add(new Point(x + A / 2, y));
            temp.Add(new Point(x, y + B / 2));
            temp.Add(new Point(x - A / 2, y));

            points = temp.ToArray();
        }
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawPolygon(pen, points);
                g.FillPolygon(FillingBrush, points);
            }
        }
    }

}
