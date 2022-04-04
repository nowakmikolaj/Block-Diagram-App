
namespace BlockDiagramApp
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.langBox = new System.Windows.Forms.GroupBox();
            this.langLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.editBox = new System.Windows.Forms.GroupBox();
            this.editLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.opButton = new System.Windows.Forms.RadioButton();
            this.decButton = new System.Windows.Forms.RadioButton();
            this.fileBox = new System.Windows.Forms.GroupBox();
            this.fileLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newDiagramButton = new System.Windows.Forms.Button();
            this.loadDiagramButton = new System.Windows.Forms.Button();
            this.saveDiagramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.langBox.SuspendLayout();
            this.langLayoutPanel.SuspendLayout();
            this.editBox.SuspendLayout();
            this.editLayoutPanel.SuspendLayout();
            this.fileBox.SuspendLayout();
            this.fileLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.Canvas);
            this.splitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.langBox);
            this.splitContainer.Panel2.Controls.Add(this.editBox);
            this.splitContainer.Panel2.Controls.Add(this.fileBox);
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(984, 761);
            this.splitContainer.SplitterDistance = 776;
            this.splitContainer.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(750, 650);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            // 
            // langBox
            // 
            this.langBox.Controls.Add(this.langLayoutPanel);
            this.langBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.langBox.Location = new System.Drawing.Point(0, 656);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(204, 105);
            this.langBox.TabIndex = 2;
            this.langBox.TabStop = false;
            this.langBox.Text = "Język";
            // 
            // langLayoutPanel
            // 
            this.langLayoutPanel.ColumnCount = 1;
            this.langLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.langLayoutPanel.Controls.Add(this.plButton, 0, 0);
            this.langLayoutPanel.Controls.Add(this.enButton, 0, 1);
            this.langLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.langLayoutPanel.Name = "langLayoutPanel";
            this.langLayoutPanel.RowCount = 2;
            this.langLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.langLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.langLayoutPanel.Size = new System.Drawing.Size(198, 83);
            this.langLayoutPanel.TabIndex = 2;
            // 
            // plButton
            // 
            this.plButton.Enabled = false;
            this.plButton.Location = new System.Drawing.Point(3, 3);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(192, 31);
            this.plButton.TabIndex = 0;
            this.plButton.Text = "Polski";
            this.plButton.UseVisualStyleBackColor = true;
            // 
            // enButton
            // 
            this.enButton.Enabled = false;
            this.enButton.Location = new System.Drawing.Point(3, 44);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(191, 31);
            this.enButton.TabIndex = 1;
            this.enButton.Text = "English";
            this.enButton.UseVisualStyleBackColor = true;
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.editLayoutPanel);
            this.editBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox.Location = new System.Drawing.Point(0, 140);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(204, 621);
            this.editBox.TabIndex = 1;
            this.editBox.TabStop = false;
            this.editBox.Text = "Edycja";
            // 
            // editLayoutPanel
            // 
            this.editLayoutPanel.ColumnCount = 1;
            this.editLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editLayoutPanel.Controls.Add(this.opButton, 0, 0);
            this.editLayoutPanel.Controls.Add(this.decButton, 0, 1);
            this.editLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.editLayoutPanel.Name = "editLayoutPanel";
            this.editLayoutPanel.RowCount = 3;
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editLayoutPanel.Size = new System.Drawing.Size(198, 599);
            this.editLayoutPanel.TabIndex = 4;
            // 
            // opButton
            // 
            this.opButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.opButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opButton.Checked = true;
            this.opButton.Location = new System.Drawing.Point(3, 3);
            this.opButton.MaximumSize = new System.Drawing.Size(192, 43);
            this.opButton.Name = "opButton";
            this.opButton.Size = new System.Drawing.Size(192, 39);
            this.opButton.TabIndex = 2;
            this.opButton.TabStop = true;
            this.opButton.Text = "Blok Operacyjny";
            this.opButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opButton.UseVisualStyleBackColor = true;
            this.opButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // decButton
            // 
            this.decButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.decButton.Location = new System.Drawing.Point(3, 48);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(192, 39);
            this.decButton.TabIndex = 3;
            this.decButton.Text = "Blok Decyzyjny";
            this.decButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // fileBox
            // 
            this.fileBox.Controls.Add(this.fileLayoutPanel);
            this.fileBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileBox.Location = new System.Drawing.Point(0, 0);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(204, 140);
            this.fileBox.TabIndex = 0;
            this.fileBox.TabStop = false;
            this.fileBox.Text = "Plik";
            // 
            // fileLayoutPanel
            // 
            this.fileLayoutPanel.ColumnCount = 1;
            this.fileLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fileLayoutPanel.Controls.Add(this.newDiagramButton, 0, 0);
            this.fileLayoutPanel.Controls.Add(this.loadDiagramButton, 0, 2);
            this.fileLayoutPanel.Controls.Add(this.saveDiagramButton, 0, 1);
            this.fileLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.RowCount = 3;
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.66667F));
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fileLayoutPanel.Size = new System.Drawing.Size(198, 118);
            this.fileLayoutPanel.TabIndex = 3;
            // 
            // newDiagramButton
            // 
            this.newDiagramButton.Location = new System.Drawing.Point(3, 3);
            this.newDiagramButton.Name = "newDiagramButton";
            this.newDiagramButton.Size = new System.Drawing.Size(192, 31);
            this.newDiagramButton.TabIndex = 0;
            this.newDiagramButton.Text = "Nowy Schemat";
            this.newDiagramButton.UseVisualStyleBackColor = true;
            this.newDiagramButton.Click += new System.EventHandler(this.newDiagramButton_Click);
            // 
            // loadDiagramButton
            // 
            this.loadDiagramButton.Enabled = false;
            this.loadDiagramButton.Location = new System.Drawing.Point(3, 80);
            this.loadDiagramButton.Name = "loadDiagramButton";
            this.loadDiagramButton.Size = new System.Drawing.Size(192, 31);
            this.loadDiagramButton.TabIndex = 2;
            this.loadDiagramButton.Text = "Wczytaj Schemat";
            this.loadDiagramButton.UseVisualStyleBackColor = true;
            // 
            // saveDiagramButton
            // 
            this.saveDiagramButton.Enabled = false;
            this.saveDiagramButton.Location = new System.Drawing.Point(3, 43);
            this.saveDiagramButton.Name = "saveDiagramButton";
            this.saveDiagramButton.Size = new System.Drawing.Size(192, 31);
            this.saveDiagramButton.TabIndex = 1;
            this.saveDiagramButton.Text = "Zapisz Schemat";
            this.saveDiagramButton.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.splitContainer);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Diagram App";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.langBox.ResumeLayout(false);
            this.langLayoutPanel.ResumeLayout(false);
            this.editBox.ResumeLayout(false);
            this.editLayoutPanel.ResumeLayout(false);
            this.fileBox.ResumeLayout(false);
            this.fileLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox fileBox;
        private System.Windows.Forms.GroupBox langBox;
        private System.Windows.Forms.GroupBox editBox;
        private System.Windows.Forms.Button loadDiagramButton;
        private System.Windows.Forms.Button saveDiagramButton;
        private System.Windows.Forms.Button newDiagramButton;
        private System.Windows.Forms.Button enButton;
        private System.Windows.Forms.Button plButton;
        private System.Windows.Forms.RadioButton opButton;
        private System.Windows.Forms.RadioButton decButton;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TableLayoutPanel fileLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel editLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel langLayoutPanel;
    }
}

