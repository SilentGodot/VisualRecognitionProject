namespace AgeEstimation
{
    partial class AgeEstimator
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
            this.manualTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.testPanel = new System.Windows.Forms.Panel();
            this.resLabel = new System.Windows.Forms.Label();
            this.testPb = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testingToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 27);
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
            this.loadDataSetToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.loadDataSetToolStripMenuItem.Text = "Load DataSet";
            this.loadDataSetToolStripMenuItem.Click += new System.EventHandler(this.loadDataSetToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticTestingToolStripMenuItem,
            this.manualTestingToolStripMenuItem});
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
            this.singleSliceToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.singleSliceToolStripMenuItem.Text = "Single Iteration";
            this.singleSliceToolStripMenuItem.Click += new System.EventHandler(this.singleSliceToolStripMenuItem_Click);
            // 
            // tripleSliceToolStripMenuItem
            // 
            this.tripleSliceToolStripMenuItem.Name = "tripleSliceToolStripMenuItem";
            this.tripleSliceToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.tripleSliceToolStripMenuItem.Text = "Multiple Iterations";
            this.tripleSliceToolStripMenuItem.Click += new System.EventHandler(this.tripleSliceToolStripMenuItem_Click);
            // 
            // manualTestingToolStripMenuItem
            // 
            this.manualTestingToolStripMenuItem.Name = "manualTestingToolStripMenuItem";
            this.manualTestingToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.manualTestingToolStripMenuItem.Text = "Manual Testing";
            this.manualTestingToolStripMenuItem.Click += new System.EventHandler(this.manualTestingToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 443);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(808, 17);
            this.progressBar.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(0, 423);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Idle..";
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowPanel.Location = new System.Drawing.Point(0, 27);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(342, 396);
            this.flowPanel.TabIndex = 3;
            this.flowPanel.Visible = false;
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.resLabel);
            this.testPanel.Controls.Add(this.testPb);
            this.testPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testPanel.Location = new System.Drawing.Point(342, 27);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(466, 396);
            this.testPanel.TabIndex = 4;
            this.testPanel.Visible = false;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.BackColor = System.Drawing.SystemColors.Control;
            this.resLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLabel.Location = new System.Drawing.Point(0, 372);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(133, 24);
            this.resLabel.TabIndex = 1;
            this.resLabel.Text = "Ready To Test";
            // 
            // testPb
            // 
            this.testPb.Dock = System.Windows.Forms.DockStyle.Top;
            this.testPb.Location = new System.Drawing.Point(0, 0);
            this.testPb.Name = "testPb";
            this.testPb.Size = new System.Drawing.Size(466, 349);
            this.testPb.TabIndex = 0;
            this.testPb.TabStop = false;
            // 
            // AgeEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AgeEstimator";
            this.Text = "AgeEstimator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPb)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ToolStripMenuItem manualTestingToolStripMenuItem;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.PictureBox testPb;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;

    }
}

