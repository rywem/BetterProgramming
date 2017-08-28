namespace Algorithms.GUI
{
    partial class RandomGrid
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
            this.algorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.robotOptimizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestNeighborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closestPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOutputLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmsToolStripMenuItem,
            this.algorithmsToolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algorithmsToolStripMenuItem
            // 
            this.algorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateRandomPointsToolStripMenuItem,
            this.clearPointsToolStripMenuItem});
            this.algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
            this.algorithmsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.algorithmsToolStripMenuItem.Text = "Basics";
            // 
            // generateRandomPointsToolStripMenuItem
            // 
            this.generateRandomPointsToolStripMenuItem.Name = "generateRandomPointsToolStripMenuItem";
            this.generateRandomPointsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.generateRandomPointsToolStripMenuItem.Text = "Generate Random Points";
            this.generateRandomPointsToolStripMenuItem.Click += new System.EventHandler(this.generateRandomPointsToolStripMenuItem_Click);
            // 
            // clearPointsToolStripMenuItem
            // 
            this.clearPointsToolStripMenuItem.Name = "clearPointsToolStripMenuItem";
            this.clearPointsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.clearPointsToolStripMenuItem.Text = "Clear Points";
            this.clearPointsToolStripMenuItem.Click += new System.EventHandler(this.clearPointsToolStripMenuItem_Click);
            // 
            // algorithmsToolStripMenuItem1
            // 
            this.algorithmsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotOptimizationToolStripMenuItem});
            this.algorithmsToolStripMenuItem1.Name = "algorithmsToolStripMenuItem1";
            this.algorithmsToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.algorithmsToolStripMenuItem1.Text = "Algorithms";
            // 
            // robotOptimizationToolStripMenuItem
            // 
            this.robotOptimizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nearestNeighborToolStripMenuItem,
            this.closestPairToolStripMenuItem});
            this.robotOptimizationToolStripMenuItem.Name = "robotOptimizationToolStripMenuItem";
            this.robotOptimizationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.robotOptimizationToolStripMenuItem.Text = "Robot Tour Optimization";
            // 
            // nearestNeighborToolStripMenuItem
            // 
            this.nearestNeighborToolStripMenuItem.Name = "nearestNeighborToolStripMenuItem";
            this.nearestNeighborToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nearestNeighborToolStripMenuItem.Text = "Nearest Neighbor";
            this.nearestNeighborToolStripMenuItem.Click += new System.EventHandler(this.nearestNeighborToolStripMenuItem_Click);
            // 
            // closestPairToolStripMenuItem
            // 
            this.closestPairToolStripMenuItem.Name = "closestPairToolStripMenuItem";
            this.closestPairToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closestPairToolStripMenuItem.Text = "Closest Pair";
            this.closestPairToolStripMenuItem.Click += new System.EventHandler(this.closestPairToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOutputLogToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // showOutputLogToolStripMenuItem
            // 
            this.showOutputLogToolStripMenuItem.Name = "showOutputLogToolStripMenuItem";
            this.showOutputLogToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showOutputLogToolStripMenuItem.Text = "Show Output Log";
            this.showOutputLogToolStripMenuItem.Click += new System.EventHandler(this.showOutputLogToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // RandomGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RandomGrid";
            this.Text = "RandomGrid";
            this.Load += new System.EventHandler(this.RandomGrid_Load);
            this.ResizeEnd += new System.EventHandler(this.RandomGrid_ResizeEnd);
            this.Resize += new System.EventHandler(this.RandomGrid_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomPointsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clearPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem robotOptimizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearestNeighborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOutputLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closestPairToolStripMenuItem;
    }
}