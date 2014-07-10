namespace AgeEstimation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripleSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataSetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDataSetToolStripMenuItem
            // 
            this.loadDataSetToolStripMenuItem.Name = "loadDataSetToolStripMenuItem";
            this.loadDataSetToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.loadDataSetToolStripMenuItem.Text = "Train From DataSet";
            this.loadDataSetToolStripMenuItem.Click += new System.EventHandler(this.loadDataSetToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticTestingToolStripMenuItem});
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.testingToolStripMenuItem.Text = "Testing";
            // 
            // automaticTestingToolStripMenuItem
            // 
            this.automaticTestingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleSliceToolStripMenuItem,
            this.tripleSliceToolStripMenuItem});
            this.automaticTestingToolStripMenuItem.Name = "automaticTestingToolStripMenuItem";
            this.automaticTestingToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.automaticTestingToolStripMenuItem.Text = "Automatic Testing";
            // 
            // singleSliceToolStripMenuItem
            // 
            this.singleSliceToolStripMenuItem.Name = "singleSliceToolStripMenuItem";
            this.singleSliceToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.singleSliceToolStripMenuItem.Text = "Single Slice";
            this.singleSliceToolStripMenuItem.Click += new System.EventHandler(this.singleSliceToolStripMenuItem_Click);
            // 
            // tripleSliceToolStripMenuItem
            // 
            this.tripleSliceToolStripMenuItem.Name = "tripleSliceToolStripMenuItem";
            this.tripleSliceToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.tripleSliceToolStripMenuItem.Text = "Triple Slice";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 447);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(654, 17);
            this.progressBar.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(0, 427);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Idle..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 464);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticTestingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripleSliceToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;

    }
}

