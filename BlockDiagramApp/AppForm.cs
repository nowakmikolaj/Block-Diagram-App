using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockDiagramApp
{

    public partial class AppForm : Form
    {
        private RadioButton selectedBlock;
        private Bitmap bitmap;

        private List<Block> blocks;

        public AppForm()
        {
            InitializeComponent();

            // Create Bitmap
            CreateBitmap(Canvas.Size.Width, Canvas.Size.Height);

            // Initialize list of blocks
            blocks = new List<Block>();

            // Keep selected radio button
            selectedBlock = opButton;
        }

        private void CreateBitmap(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            Canvas.Image = bitmap;
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int a = 90;
                int b = 60;
                if (selectedBlock == opButton)
                {
                    Block opBlock = new OperationBlock(e.X, e.Y, a, b, bitmap);
                    blocks.Add(opBlock);
                    opBlock.Draw();
                    opBlock.AddText();
                }
                else if (selectedBlock == decButton)
                {
                    Block decBlock = new DecisionBlock(e.X, e.Y, a, b, bitmap);
                    blocks.Add(decBlock);
                    decBlock.Draw();
                    decBlock.AddText();
                }
            }
            Canvas.Refresh();
        }

        private void selectedBlock_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.Checked)
            {
                selectedBlock = rb;
            }
        }

        

    }

    
}
