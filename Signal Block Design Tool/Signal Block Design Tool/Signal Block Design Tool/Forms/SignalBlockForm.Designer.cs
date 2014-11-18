namespace Signal_Block_Design_Tool.Forms
{
    partial class SignalBlockForm
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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignalBlockForm));
               this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.menuStrip = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.fromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
               this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
               this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.trackLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
               this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.menuStrip.SuspendLayout();
               this.SuspendLayout();
               // 
               // contextMenuStrip
               // 
               this.contextMenuStrip.Name = "contextMenuStrip";
               this.contextMenuStrip.Size = new System.Drawing.Size(153, 26);
               this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
               // 
               // menuStrip
               // 
               this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vIEWToolStripMenuItem,
            this.aDDToolStripMenuItem,
            this.hELPToolStripMenuItem});
               this.menuStrip.Location = new System.Drawing.Point(0, 0);
               this.menuStrip.Name = "menuStrip";
               this.menuStrip.Size = new System.Drawing.Size(583, 24);
               this.menuStrip.TabIndex = 3;
               this.menuStrip.Text = "menuStrip1";
               this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
               this.fileToolStripMenuItem.Text = "FILE";
               // 
               // newToolStripMenuItem
               // 
               this.newToolStripMenuItem.Name = "newToolStripMenuItem";
               this.newToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
               this.newToolStripMenuItem.Text = "New";
               this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
               // 
               // toolStripSeparator1
               // 
               this.toolStripSeparator1.Name = "toolStripSeparator1";
               this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
               // 
               // loadToolStripMenuItem
               // 
               this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
               this.loadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
               this.loadToolStripMenuItem.Text = "Load";
               this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
               // 
               // importToolStripMenuItem
               // 
               this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromDatabaseToolStripMenuItem});
               this.importToolStripMenuItem.Name = "importToolStripMenuItem";
               this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
               this.importToolStripMenuItem.Text = "Import";
               this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
               // 
               // fromFileToolStripMenuItem
               // 
               this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
               this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
               this.fromFileToolStripMenuItem.Text = "From File";
               this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
               // 
               // fromDatabaseToolStripMenuItem
               // 
               this.fromDatabaseToolStripMenuItem.Name = "fromDatabaseToolStripMenuItem";
               this.fromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
               this.fromDatabaseToolStripMenuItem.Text = "From Database";
               this.fromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.fromDatabaseToolStripMenuItem_Click);
               // 
               // toolStripSeparator2
               // 
               this.toolStripSeparator2.Name = "toolStripSeparator2";
               this.toolStripSeparator2.Size = new System.Drawing.Size(107, 6);
               // 
               // saveToolStripMenuItem
               // 
               this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
               this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
               this.saveToolStripMenuItem.Text = "Save";
               this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
               // 
               // toolStripSeparator3
               // 
               this.toolStripSeparator3.Name = "toolStripSeparator3";
               this.toolStripSeparator3.Size = new System.Drawing.Size(107, 6);
               // 
               // exitToolStripMenuItem
               // 
               this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
               this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
               this.exitToolStripMenuItem.Text = "Exit";
               this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
               // 
               // vIEWToolStripMenuItem
               // 
               this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.trackLayoutToolStripMenuItem,
            this.toolStripSeparator4,
            this.mainMenuToolStripMenuItem});
               this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
               this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
               this.vIEWToolStripMenuItem.Text = "VIEW";
               // 
               // dataToolStripMenuItem
               // 
               this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
               this.dataToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
               this.dataToolStripMenuItem.Text = "Data Grid";
               this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
               // 
               // trackLayoutToolStripMenuItem
               // 
               this.trackLayoutToolStripMenuItem.Name = "trackLayoutToolStripMenuItem";
               this.trackLayoutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
               this.trackLayoutToolStripMenuItem.Text = "Track Layout";
               this.trackLayoutToolStripMenuItem.Click += new System.EventHandler(this.trackLayoutToolStripMenuItem_Click);
               // 
               // toolStripSeparator4
               // 
               this.toolStripSeparator4.Name = "toolStripSeparator4";
               this.toolStripSeparator4.Size = new System.Drawing.Size(139, 6);
               // 
               // mainMenuToolStripMenuItem
               // 
               this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
               this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
               this.mainMenuToolStripMenuItem.Text = "Main Menu";
               this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
               // 
               // aDDToolStripMenuItem
               // 
               this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrackToolStripMenuItem});
               this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
               this.aDDToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
               this.aDDToolStripMenuItem.Text = "ADD";
               // 
               // newTrackToolStripMenuItem
               // 
               this.newTrackToolStripMenuItem.Name = "newTrackToolStripMenuItem";
               this.newTrackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
               this.newTrackToolStripMenuItem.Text = "Track Segment";
               this.newTrackToolStripMenuItem.Click += new System.EventHandler(this.newTrackToolStripMenuItem_Click);
               // 
               // hELPToolStripMenuItem
               // 
               this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
               this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
               this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
               this.hELPToolStripMenuItem.Text = "HELP";
               // 
               // viewHelpToolStripMenuItem
               // 
               this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
               this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
               this.viewHelpToolStripMenuItem.Text = "View Help";
               this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
               // 
               // toolStripSeparator5
               // 
               this.toolStripSeparator5.Name = "toolStripSeparator5";
               this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // SignalBlockForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(583, 325);
               this.Controls.Add(this.menuStrip);
               this.DoubleBuffered = true;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.IsMdiContainer = true;
               this.MainMenuStrip = this.menuStrip;
               this.Name = "SignalBlockForm";
               this.Text = "Signal Block Design Tool";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               this.menuStrip.ResumeLayout(false);
               this.menuStrip.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}

