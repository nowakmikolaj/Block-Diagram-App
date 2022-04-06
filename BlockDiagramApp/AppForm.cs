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
    public enum Buttons { Start, Stop, OpBlock, DecBlock, Link, Trash }

    public partial class AppForm : Form
    {
        private const int a = 90;
        private const int b = 60;
        private const float defaultPenSize = 5f;
        private const float ellipsePenSize = 8f;

        private Bitmap bitmap;
        private Brush FillingBrush;

        private List<Block> blocks;
        private bool startExists;
        private const string startExistsMessage = "Schemat posiada już jeden blok startowy";
        private Buttons selectedButton;
        private Block highlightedBlock;
        private Node nodeToLink;

        public AppForm()
        {
            InitializeComponent();

            // Create Bitmap
            CreateBitmap(Canvas.Size.Width, Canvas.Size.Height);

            // Choose color of blocks
            FillingBrush = Brushes.White;

            // Initialize list of blocks
            blocks = new List<Block>();

            // Keep selected radio button
            selectedButton = Buttons.Start;
        }
        private void CreateBitmap(int width, int height)
        {
            if (bitmap == null)
            {
                bitmap = new Bitmap(width, height);
                Canvas.Image = bitmap;
            }
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
        }


        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Block blockToAdd = null;
                switch (selectedButton)
                {
                    case Buttons.Start:
                        if (startExists)
                        {
                            MessageBox.Show(startExistsMessage);
                        }
                        else
                        {
                            blockToAdd = new StartBlock(e.X, e.Y, a, b);
                            startExists = true;
                        }
                        break;

                    case Buttons.Stop:
                        blockToAdd = new StopBlock(e.X, e.Y, a, b); break;

                    case Buttons.OpBlock:
                        blockToAdd = new OperationBlock(e.X, e.Y, a, b); break;

                    case Buttons.DecBlock:
                        blockToAdd = new DecisionBlock(e.X, e.Y, a, b); break;

                    case Buttons.Link:
                        {
                            nodeToLink = FindNode(e.X, e.Y);
                            if (nodeToLink != null)
                            {
                                Canvas.MouseMove += new MouseEventHandler(Canvas_LinkBlock);
                            }
                        }
                        break;

                    case Buttons.Trash:
                        DeleteBlock(e.X, e.Y); break;
                }

                if (blockToAdd != null)
                {
                    blocks.Add(blockToAdd);
                    blockToAdd.Draw(bitmap, GetPen(blockToAdd), FillingBrush);
                    blockToAdd.AddText(bitmap);
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                highlightedBlock = FindClosestBlock(e.X, e.Y);
                if (highlightedBlock is OperationBlock || highlightedBlock is DecisionBlock)
                {
                    textEditor.Enabled = true;
                    textEditor.Text = highlightedBlock.Name;
                }
                else
                {
                    textEditor.Enabled = false;
                    textEditor.Text = "";
                }
                RepaintCanvas();
            }
            else if(e.Button == MouseButtons.Middle && highlightedBlock != null && highlightedBlock == FindClosestBlock(e.X,e.Y))
            {
                Canvas.MouseMove += new MouseEventHandler(Canvas_MoveBlock);
            }


            Canvas.Refresh();
        }
        
        private void DeleteBlock(int X, int Y)
        {
            Block blockToDelete = FindClosestBlock(X, Y);

            if (blockToDelete != null)
            {
                if (blockToDelete is StartBlock) startExists = false;
                foreach (Node node in blockToDelete.nodes)
                {
                    if (node.NextNode != null)
                    {
                        node.NextNode.Next = default;
                        node.NextNode.NextNode = null;
                    }
                }

                blocks.Remove(blockToDelete);
                RepaintCanvas();
                textEditor.Enabled = false;
                textEditor.Text = "";
            }
        }

        private Node FindNode(int X, int Y, bool filled = true)
        {
            foreach(Block block in blocks)
                foreach(Node node in block.nodes)
                {
                    if (node.Hit(X, Y))
                    {
                        if (filled && (node is FilledNode || node is DecisionNode))
                            return node;
                        if (!filled && node is EmptyNode)
                            return node;
                    }
                }
            return null;
        }

        private Block FindClosestBlock(int X, int Y)
        {
            double distance, distanceToDelete = double.MaxValue;
            Block block = null;

            foreach (Block item in blocks)
            {
                if (item.Hit(X, Y, out distance))
                    if (distance <= distanceToDelete)
                    {
                        block = item;
                        distanceToDelete = distance;
                    }
            }
            return block;
        }

        private void RepaintCanvas()
        {
            CreateBitmap(Canvas.Width, Canvas.Height);

            foreach (Block item in blocks)
            {
                item.Draw(bitmap, GetPen(item), FillingBrush);
                item.AddText(bitmap);
            }
        }

        public Pen GetPen(Block block)
        {
            Pen pen;
            if (block is StartBlock)
                pen = new Pen(Brushes.MediumSpringGreen, ellipsePenSize);
            else if (block is StopBlock)
                pen = new Pen(Brushes.IndianRed, ellipsePenSize);
            else
                pen = new Pen(Brushes.Black, defaultPenSize);

            if(block == highlightedBlock)
                pen.DashPattern = new float[] { 2, 1 };

            return pen;
        }


        private Buttons GetButtonsEnum(RadioButton rb)
        {
            if (rb.Name == startButton.Name)
                return Buttons.Start;
            if (rb.Name == stopButton.Name)
                return Buttons.Stop;
            if (rb.Name == opButton.Name)
                return Buttons.OpBlock;
            if (rb.Name == decButton.Name)
                return Buttons.DecBlock;
            if (rb.Name == linkButton.Name)
                return Buttons.Link;

            return Buttons.Trash;
        }

        private void selectedBlock_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.Checked)
            {
                selectedButton = GetButtonsEnum(rb);
            }
        }


        private void newDiagramButton_Click(object sender, EventArgs e)
        {
            NewDiagramForm diagram = new NewDiagramForm(Canvas.Size.Width, Canvas.Size.Height);

            diagram.ShowDialog();
            diagram.Focus();

            Canvas.Width = diagram.newWidth;
            Canvas.Height = diagram.newHeight;

            blocks.Clear();
            startExists = false;

            CreateBitmap(diagram.newWidth, diagram.newHeight);
            Canvas.Refresh();
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            if (highlightedBlock == null || 
                highlightedBlock is StopBlock || 
                highlightedBlock is StartBlock) return;

            highlightedBlock.Name = textEditor.Text;
            RepaintCanvas();
            Canvas.Refresh();
        }
        
        private void Canvas_LinkBlock(object sender, MouseEventArgs e)
        {
            if (nodeToLink.NextNode != null)
            {
                nodeToLink.NextNode.NextNode = null;
                nodeToLink.NextNode.Next = default;
            }
            nodeToLink.NextNode = null;
            nodeToLink.Next = new Point(e.X, e.Y);
            RepaintCanvas();
            Canvas.Refresh();
        }

        private void Canvas_MoveBlock(object sender, MouseEventArgs e)
        {
            if (e.X < Canvas.Size.Width && e.Y < Canvas.Size.Height &&
                e.X >= 0 && e.Y >= 0)
                highlightedBlock.Move(e.X, e.Y);
            RepaintCanvas();
            Canvas.Refresh();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (nodeToLink != null)
            {
                Node node = FindNode(e.X, e.Y, false);
                if (node != null)
                {
                    nodeToLink.Next = node.GetPoint();
                    nodeToLink.NextNode = node;
                    node.Next = nodeToLink.GetPoint();
                    node.NextNode = nodeToLink;
                }
                else
                {
                    nodeToLink.Next = default;
                    nodeToLink.NextNode = null;
                }
                RepaintCanvas();
                Canvas.Refresh();
                Canvas.MouseMove -= Canvas_LinkBlock;
                nodeToLink = null;
            }
            else
            {
                Canvas.MouseMove -= Canvas_MoveBlock;
            }
        }
    }
}
