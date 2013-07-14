namespace Avitaminose
{
    partial class GUIRunner
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.labelInput = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.textBoxAssembledProgram = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.RunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.AcceptsReturn = true;
			this.textBoxInput.AcceptsTab = true;
			this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInput.Location = new System.Drawing.Point(3, 23);
			this.textBoxInput.MaxLength = 0;
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxInput.Size = new System.Drawing.Size(277, 331);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.WordWrap = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.labelInput);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxInput);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBoxOutput);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.labelOutput);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxAssembledProgram);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(611, 357);
			this.splitContainer1.SplitterDistance = 283;
			this.splitContainer1.TabIndex = 1;
			// 
			// labelInput
			// 
			this.labelInput.AutoSize = true;
			this.labelInput.Location = new System.Drawing.Point(4, 4);
			this.labelInput.Name = "labelInput";
			this.labelInput.Size = new System.Drawing.Size(31, 13);
			this.labelInput.TabIndex = 1;
			this.labelInput.Text = "Input";
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(3, 4);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(99, 13);
			this.labelOutput.TabIndex = 2;
			this.labelOutput.Text = "Assembled program";
			// 
			// textBoxAssembledProgram
			// 
			this.textBoxAssembledProgram.AcceptsTab = true;
			this.textBoxAssembledProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAssembledProgram.Location = new System.Drawing.Point(3, 23);
			this.textBoxAssembledProgram.MaxLength = 0;
			this.textBoxAssembledProgram.Multiline = true;
			this.textBoxAssembledProgram.Name = "textBoxAssembledProgram";
			this.textBoxAssembledProgram.ReadOnly = true;
			this.textBoxAssembledProgram.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxAssembledProgram.Size = new System.Drawing.Size(318, 140);
			this.textBoxAssembledProgram.TabIndex = 1;
			this.textBoxAssembledProgram.WordWrap = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(611, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// RunToolStripMenuItem
			// 
			this.RunToolStripMenuItem.Name = "RunToolStripMenuItem";
			this.RunToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.RunToolStripMenuItem.Text = "Run";
			this.RunToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Output";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.AcceptsTab = true;
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Location = new System.Drawing.Point(3, 182);
			this.textBoxOutput.MaxLength = 0;
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxOutput.Size = new System.Drawing.Size(318, 172);
			this.textBoxOutput.TabIndex = 4;
			this.textBoxOutput.WordWrap = false;
			// 
			// GUIRunner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 380);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GUIRunner";
			this.Text = "Avitaminose";
			this.Load += new System.EventHandler(this.GUIRunner_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxAssembledProgram;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem RunToolStripMenuItem;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Label label1;
    }
}

