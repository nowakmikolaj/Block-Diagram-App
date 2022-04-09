
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
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
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.Controls.Add(this.Canvas);
            this.splitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Canvas, "Canvas");
            this.Canvas.Name = "Canvas";
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.langBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.editBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.fileBox, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // langBox
            // 
            this.langBox.Controls.Add(this.langLayoutPanel);
            resources.ApplyResources(this.langBox, "langBox");
            this.langBox.Name = "langBox";
            this.langBox.TabStop = false;
            // 
            // langLayoutPanel
            // 
            resources.ApplyResources(this.langLayoutPanel, "langLayoutPanel");
            this.langLayoutPanel.Controls.Add(this.plButton, 0, 0);
            this.langLayoutPanel.Controls.Add(this.enButton, 0, 1);
            this.langLayoutPanel.Name = "langLayoutPanel";
            // 
            // plButton
            // 
            resources.ApplyResources(this.plButton, "plButton");
            this.plButton.Name = "plButton";
            this.plButton.UseVisualStyleBackColor = true;
            // 
            // enButton
            // 
            resources.ApplyResources(this.enButton, "enButton");
            this.enButton.Name = "enButton";
            this.enButton.UseVisualStyleBackColor = true;
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.editLayoutPanel);
            resources.ApplyResources(this.editBox, "editBox");
            this.editBox.Name = "editBox";
            this.editBox.TabStop = false;
            // 
            // editLayoutPanel
            // 
            resources.ApplyResources(this.editLayoutPanel, "editLayoutPanel");
            this.editLayoutPanel.Controls.Add(this.textEditor, 0, 3);
            this.editLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.editLayoutPanel.Controls.Add(this.deleteButton, 2, 1);
            this.editLayoutPanel.Controls.Add(this.stopButton, 0, 1);
            this.editLayoutPanel.Controls.Add(this.linkButton, 2, 0);
            this.editLayoutPanel.Controls.Add(this.decButton, 1, 1);
            this.editLayoutPanel.Controls.Add(this.opButton, 1, 0);
            this.editLayoutPanel.Controls.Add(this.startButton, 0, 0);
            this.editLayoutPanel.Name = "editLayoutPanel";
            // 
            // textEditor
            // 
            this.editLayoutPanel.SetColumnSpan(this.textEditor, 3);
            resources.ApplyResources(this.textEditor, "textEditor");
            this.textEditor.Name = "textEditor";
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.editLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Name = "label1";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Image = global::BlockDiagramApp.Properties.Resources.trash;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Image = global::BlockDiagramApp.Properties.Resources.stop1;
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // linkButton
            // 
            resources.ApplyResources(this.linkButton, "linkButton");
            this.linkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.linkButton.Image = global::BlockDiagramApp.Properties.Resources.link;
            this.linkButton.Name = "linkButton";
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // decButton
            // 
            resources.ApplyResources(this.decButton, "decButton");
            this.decButton.Image = global::BlockDiagramApp.Properties.Resources.diamond5;
            this.decButton.Name = "decButton";
            this.decButton.Tag = "";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // opButton
            // 
            resources.ApplyResources(this.opButton, "opButton");
            this.opButton.BackColor = System.Drawing.Color.Transparent;
            this.opButton.Image = global::BlockDiagramApp.Properties.Resources.rect2;
            this.opButton.Name = "opButton";
            this.opButton.Tag = "";
            this.opButton.UseVisualStyleBackColor = false;
            this.opButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Checked = true;
            this.startButton.Image = global::BlockDiagramApp.Properties.Resources.start2;
            this.startButton.Name = "startButton";
            this.startButton.TabStop = true;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.CheckedChanged += new System.EventHandler(this.selectedBlock_CheckedChanged);
            // 
            // fileBox
            // 
            this.fileBox.Controls.Add(this.fileLayoutPanel);
            resources.ApplyResources(this.fileBox, "fileBox");
            this.fileBox.Name = "fileBox";
            this.fileBox.TabStop = false;
            // 
            // fileLayoutPanel
            // 
            resources.ApplyResources(this.fileLayoutPanel, "fileLayoutPanel");
            this.fileLayoutPanel.Controls.Add(this.newDiagramButton, 0, 0);
            this.fileLayoutPanel.Controls.Add(this.loadDiagramButton, 0, 2);
            this.fileLayoutPanel.Controls.Add(this.saveDiagramButton, 0, 1);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            // 
            // newDiagramButton
            // 
            resources.ApplyResources(this.newDiagramButton, "newDiagramButton");
            this.newDiagramButton.Name = "newDiagramButton";
            this.newDiagramButton.UseVisualStyleBackColor = true;
            this.newDiagramButton.Click += new System.EventHandler(this.newDiagramButton_Click);
            // 
            // loadDiagramButton
            // 
            resources.ApplyResources(this.loadDiagramButton, "loadDiagramButton");
            this.loadDiagramButton.Name = "loadDiagramButton";
            this.loadDiagramButton.UseVisualStyleBackColor = true;
            this.loadDiagramButton.Click += new System.EventHandler(this.loadDiagramButton_Click);
            // 
            // saveDiagramButton
            // 
            resources.ApplyResources(this.saveDiagramButton, "saveDiagramButton");
            this.saveDiagramButton.Name = "saveDiagramButton";
            this.saveDiagramButton.UseVisualStyleBackColor = true;
            this.saveDiagramButton.Click += new System.EventHandler(this.saveDiagramButton_Click);
            // 
            // AppForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.IsMdiContainer = true;
            this.Name = "AppForm";
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

