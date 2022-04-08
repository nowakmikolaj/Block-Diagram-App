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
    public partial class NewDiagramForm : Form
    {
        public static bool OK_CLICKED;
        public int newWidth { get; set; }
        public int newHeight { get; set; }

        public NewDiagramForm(int canvas_width, int canvas_height)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            OK_CLICKED = false;
            numericUpDownWidth.Value = newWidth = canvas_width;
            numericUpDownHeight.Value = newHeight = canvas_height;
        }

        public void resizeBitmapButton_Click(object sender, EventArgs e)
        {
            OK_CLICKED = true;
            newWidth = Convert.ToInt32(numericUpDownWidth.Value);
            newHeight = Convert.ToInt32(numericUpDownHeight.Value);

            Close();
        }

    }
}
