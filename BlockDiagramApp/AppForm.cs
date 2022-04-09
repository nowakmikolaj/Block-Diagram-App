using System;
using System.IO;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BlockDiagramApp
{
    public enum Buttons { Start, Stop, OpBlock, DecBlock, Link, Trash }

    public partial class AppForm : Form
    {
        private const int a = 90;
        private const int b = 60;
        private const float defaultPenSize = 5f;
        private const float ellipsePenSize = 8f;
        private readonly string CreateFileExceptionMessage = "Nie udało się zapisać schematu.";
        private readonly string SerializationExceptionMessage = "Plik jest uszkodzony.";
        private readonly string InvalidCastExceptionMessage = "Plik jest niepoprawny.";

        private Bitmap bitmap;
        private Brush FillingBrush;
        private const string startExistsMessage = "Schemat posiada już jeden blok startowy";
        private Node nodeToLink;

        [Serializable]
        internal class DiagramInfo
        {
            internal Buttons selectedButton;
            internal bool startExists;
            internal Block highlightedBlock;
            internal List<Block> blocks;
            internal Size bitmapSize;

            public DiagramInfo(int width, int heigth)
            {
                blocks = new List<Block>();
                selectedButton = Buttons.Start;
                bitmapSize = new Size(width, heigth);
            }

            internal void Reset(int width, int height)
            {
                blocks.Clear();
                startExists = false;
                selectedButton = Buttons.Start;
                highlightedBlock = null;
                bitmapSize = new Size(width, height);
            }
        }

        DiagramInfo info;
            
        public AppForm()
        {
            InitializeComponent();
            
            // Create Bitmap
            CreateBitmap(Canvas.Size.Width, Canvas.Size.Height);

            // Choose color of blocks
            FillingBrush = Brushes.White;

            // Initialize diagram data
            info = new DiagramInfo(Canvas.Size.Width, Canvas.Size.Height);
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
                switch (info.selectedButton)
                {
                    case Buttons.Start:
                        if (info.startExists)
                        {
                            MessageBox.Show(startExistsMessage);
                        }
                        else
                        {
                            blockToAdd = new StartBlock(e.X, e.Y, a, b);
                            info.startExists = true;
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
                    info.blocks.Add(blockToAdd);
                    blockToAdd.Draw(bitmap, GetPen(blockToAdd), FillingBrush);
                    blockToAdd.AddText(bitmap);
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                info.highlightedBlock = FindClosestBlock(e.X, e.Y);
                if (info.highlightedBlock is OperationBlock || info.highlightedBlock is DecisionBlock)
                {
                    TextUpdate(true);
                }
                else
                {
                    TextUpdate(false);
                }
                RepaintCanvas();
            }
            else if(e.Button == MouseButtons.Middle && info.highlightedBlock != null && info.highlightedBlock == FindClosestBlock(e.X,e.Y))
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
                if (blockToDelete is StartBlock) info.startExists = false;
                foreach (Node node in blockToDelete.nodes)
                {
                    if (node.NextNode != null)
                    {
                        node.NextNode.Next = default;
                        node.NextNode.NextNode = null;
                    }
                }

                info.blocks.Remove(blockToDelete);
                RepaintCanvas();
                if(info.highlightedBlock == blockToDelete)
                    TextUpdate(false);
            }
        }

        private Node FindNode(int X, int Y, bool filled = true)
        {
            foreach(Block block in info.blocks)
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

            foreach (Block item in info.blocks)
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
            CreateBitmap(((Point)info.bitmapSize).X, ((Point)info.bitmapSize).Y);

            foreach (Block item in info.blocks)
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

            if(block == info.highlightedBlock)
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
                info.selectedButton = GetButtonsEnum(rb);
            }
        }

        private void TextUpdate(bool enabled)
        {
            textEditor.Text = enabled ? info.highlightedBlock.Name : "";
            textEditor.Enabled = enabled;
        }

        private void newDiagramButton_Click(object sender, EventArgs e)
        {
            NewDiagramForm diagram = new NewDiagramForm(Canvas.Size.Width, Canvas.Size.Height);

            diagram.Focus();
            diagram.ShowDialog();
            if (NewDiagramForm.OK_CLICKED)
            {
                TextUpdate(false);
                Canvas.Width = diagram.newWidth;
                Canvas.Height = diagram.newHeight;

                info.Reset(Canvas.Width, Canvas.Height);


                CreateBitmap(diagram.newWidth, diagram.newHeight);
                Canvas.Refresh();
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            if (info.highlightedBlock == null ||
                info.highlightedBlock is StopBlock ||
                info.highlightedBlock is StartBlock) return;

            info.highlightedBlock.Name = textEditor.Text;
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
                info.highlightedBlock.Move(e.X, e.Y);
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

        private void saveDiagramButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "diag files (*.diag)|*.diag";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(dialog.FileName, FileMode.Create);
                }
                catch
                {
                    MessageBox.Show(CreateFileExceptionMessage);
                    return;
                }
                
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, info);
                fs.Close();
            }
        }

        private void loadDiagramButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "diag files (*.diag)|*.diag";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(dialog.FileName, FileMode.Open);
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }

                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    info = (DiagramInfo)bf.Deserialize(fs);
                }
                catch (SerializationException)
                {
                    MessageBox.Show(SerializationExceptionMessage);
                    return;
                }
                catch(InvalidCastException)
                {
                    MessageBox.Show(InvalidCastExceptionMessage);
                    return;
                }
                finally
                {
                    fs.Close();
                }

                if (info.highlightedBlock != null)
                    TextUpdate(true);

                Canvas.Width = ((Point)info.bitmapSize).X;
                Canvas.Height = ((Point)info.bitmapSize).Y;

                startButton.Checked = true;
                CreateBitmap(Canvas.Size.Width, Canvas.Size.Height);
                RepaintCanvas();
                Canvas.Refresh();
            }
        }
    }
}
