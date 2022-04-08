﻿
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.langBox = new System.Windows.Forms.GroupBox();
            this.langLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.editBox = new System.Windows.Forms.GroupBox();
            this.editLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textEditor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.RadioButton();
            this.stopButton = new System.Windows.Forms.RadioButton();
            this.linkButton = new System.Windows.Forms.RadioButton();
            this.decButton = new System.Windows.Forms.RadioButton();
            this.opButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.RadioButton();
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
            this.tableLayoutPanel3.SuspendLayout();
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
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(1125, 1015);
            this.splitContainer.SplitterDistance = 878;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(857, 867);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.langBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.editBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.fileBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.56569F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.43431F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(246, 1015);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // langBox
            // 
            this.langBox.Controls.Add(this.langLayoutPanel);
            this.langBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langBox.Location = new System.Drawing.Point(3, 867);
            this.langBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.langBox.Name = "langBox";
            this.langBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.langBox.Size = new System.Drawing.Size(240, 144);
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
            this.langLayoutPanel.Location = new System.Drawing.Point(3, 24);
            this.langLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.langLayoutPanel.Name = "langLayoutPanel";
            this.langLayoutPanel.RowCount = 2;
            this.langLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.langLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.langLayoutPanel.Size = new System.Drawing.Size(234, 116);
            this.langLayoutPanel.TabIndex = 2;
            // 
            // plButton
            // 
            this.plButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plButton.Enabled = false;
            this.plButton.Location = new System.Drawing.Point(3, 4);
            this.plButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(228, 50);
            this.plButton.TabIndex = 0;
            this.plButton.Text = "Polski";
            this.plButton.UseVisualStyleBackColor = true;
            // 
            // enButton
            // 
            this.enButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enButton.Enabled = false;
            this.enButton.Location = new System.Drawing.Point(3, 62);
            this.enButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(228, 50);
            this.enButton.TabIndex = 1;
            this.enButton.Text = "English";
            this.enButton.UseVisualStyleBackColor = true;
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.editLayoutPanel);
            this.editBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox.Location = new System.Drawing.Point(3, 198);
            this.editBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBox.Name = "editBox";
            this.editBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBox.Size = new System.Drawing.Size(240, 661);
            this.editBox.TabIndex = 1;
            this.editBox.TabStop = false;
            this.editBox.Text = "Edycja";
            // 
            // editLayoutPanel
            // 
            this.editLayoutPanel.ColumnCount = 3;
            this.editLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.editLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.editLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.editLayoutPanel.Controls.Add(this.textEditor, 0, 3);
            this.editLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.editLayoutPanel.Controls.Add(this.deleteButton, 2, 1);
            this.editLayoutPanel.Controls.Add(this.stopButton, 0, 1);
            this.editLayoutPanel.Controls.Add(this.linkButton, 2, 0);
            this.editLayoutPanel.Controls.Add(this.decButton, 1, 1);
            this.editLayoutPanel.Controls.Add(this.opButton, 1, 0);
            this.editLayoutPanel.Controls.Add(this.startButton, 0, 0);
            this.editLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editLayoutPanel.Location = new System.Drawing.Point(3, 24);
            this.editLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editLayoutPanel.Name = "editLayoutPanel";
            this.editLayoutPanel.RowCount = 4;
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.editLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.editLayoutPanel.Size = new System.Drawing.Size(234, 633);
            this.editLayoutPanel.TabIndex = 4;
            // 
            // textEditor
            // 
            this.editLayoutPanel.SetColumnSpan(this.textEditor, 3);
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.Enabled = false;
            this.textEditor.Location = new System.Drawing.Point(3, 187);
            this.textEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditor.Multiline = true;
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(228, 442);
            this.textEditor.TabIndex = 1;
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.editLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst zaznaczonego bloku:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            this.deleteButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Image = global::BlockDiagramApp.Properties.Resources.trash;
            this.deleteButton.Location = new System.Drawing.Point(159, 82);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 70);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // stopButton
            // 
            this.stopButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.stopButton.AutoSize = true;
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopButton.Image = global::BlockDiagramApp.Properties.Resources.stop1;
            this.stopButton.Location = new System.Drawing.Point(3, 82);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(72, 70);
            this.stopButton.TabIndex = 10;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // linkButton
            // 
            this.linkButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.linkButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.linkButton.Image = global::BlockDiagramApp.Properties.Resources.link;
            this.linkButton.Location = new System.Drawing.Point(159, 4);
            this.linkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(71, 70);
            this.linkButton.TabIndex = 9;
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // decButton
            // 
            this.decButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.decButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decButton.Image = global::BlockDiagramApp.Properties.Resources.diamond5;
            this.decButton.Location = new System.Drawing.Point(81, 82);
            this.decButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(72, 70);
            this.decButton.TabIndex = 3;
            this.decButton.Tag = "";
            this.decButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // opButton
            // 
            this.opButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.opButton.BackColor = System.Drawing.Color.Transparent;
            this.opButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opButton.Image = global::BlockDiagramApp.Properties.Resources.rect2;
            this.opButton.Location = new System.Drawing.Point(81, 4);
            this.opButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opButton.Name = "opButton";
            this.opButton.Size = new System.Drawing.Size(72, 70);
            this.opButton.TabIndex = 2;
            this.opButton.Tag = "";
            this.opButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opButton.UseVisualStyleBackColor = false;
            this.opButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.startButton.AutoSize = true;
            this.startButton.Checked = true;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Image = global::BlockDiagramApp.Properties.Resources.start2;
            this.startButton.Location = new System.Drawing.Point(3, 4);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 70);
            this.startButton.TabIndex = 8;
            this.startButton.TabStop = true;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // fileBox
            // 
            this.fileBox.Controls.Add(this.fileLayoutPanel);
            this.fileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileBox.Location = new System.Drawing.Point(3, 4);
            this.fileBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileBox.Name = "fileBox";
            this.fileBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileBox.Size = new System.Drawing.Size(240, 186);
            this.fileBox.TabIndex = 0;
            this.fileBox.TabStop = false;
            this.fileBox.Text = "Plik";
            // 
            // fileLayoutPanel
            // 
            this.fileLayoutPanel.ColumnCount = 1;
            this.fileLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.fileLayoutPanel.Controls.Add(this.newDiagramButton, 0, 0);
            this.fileLayoutPanel.Controls.Add(this.loadDiagramButton, 0, 2);
            this.fileLayoutPanel.Controls.Add(this.saveDiagramButton, 0, 1);
            this.fileLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLayoutPanel.Location = new System.Drawing.Point(3, 24);
            this.fileLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.RowCount = 3;
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.66667F));
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fileLayoutPanel.Size = new System.Drawing.Size(234, 158);
            this.fileLayoutPanel.TabIndex = 3;
            // 
            // newDiagramButton
            // 
            this.newDiagramButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newDiagramButton.Location = new System.Drawing.Point(3, 4);
            this.newDiagramButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newDiagramButton.Name = "newDiagramButton";
            this.newDiagramButton.Size = new System.Drawing.Size(228, 46);
            this.newDiagramButton.TabIndex = 0;
            this.newDiagramButton.Text = "Nowy Schemat";
            this.newDiagramButton.UseVisualStyleBackColor = true;
            this.newDiagramButton.Click += new System.EventHandler(this.newDiagramButton_Click);
            // 
            // loadDiagramButton
            // 
            this.loadDiagramButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadDiagramButton.Location = new System.Drawing.Point(3, 108);
            this.loadDiagramButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadDiagramButton.Name = "loadDiagramButton";
            this.loadDiagramButton.Size = new System.Drawing.Size(228, 46);
            this.loadDiagramButton.TabIndex = 2;
            this.loadDiagramButton.Text = "Wczytaj Schemat";
            this.loadDiagramButton.UseVisualStyleBackColor = true;
            this.loadDiagramButton.Click += new System.EventHandler(this.loadDiagramButton_Click);
            // 
            // saveDiagramButton
            // 
            this.saveDiagramButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveDiagramButton.Location = new System.Drawing.Point(3, 58);
            this.saveDiagramButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveDiagramButton.Name = "saveDiagramButton";
            this.saveDiagramButton.Size = new System.Drawing.Size(228, 42);
            this.saveDiagramButton.TabIndex = 1;
            this.saveDiagramButton.Text = "Zapisz Schemat";
            this.saveDiagramButton.UseVisualStyleBackColor = true;
            this.saveDiagramButton.Click += new System.EventHandler(this.saveDiagramButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 1015);
            this.Controls.Add(this.splitContainer);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(912, 784);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Diagram App";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.langBox.ResumeLayout(false);
            this.langLayoutPanel.ResumeLayout(false);
            this.editBox.ResumeLayout(false);
            this.editLayoutPanel.ResumeLayout(false);
            this.editLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TableLayoutPanel fileLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel editLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel langLayoutPanel;
        private System.Windows.Forms.RadioButton linkButton;
        private System.Windows.Forms.RadioButton startButton;
        private System.Windows.Forms.RadioButton deleteButton;
        private System.Windows.Forms.RadioButton stopButton;
        private System.Windows.Forms.RadioButton decButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEditor;
    }
}

