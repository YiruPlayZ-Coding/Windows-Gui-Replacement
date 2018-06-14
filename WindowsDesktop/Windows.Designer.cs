namespace WindowsDesktop
{
    partial class WindowsDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsDesktop));
            this.Desktop = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minecraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpeditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regeditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Desktop.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desktop
            // 
            resources.ApplyResources(this.Desktop, "Desktop");
            this.Desktop.BackgroundImage = global::WindowsDesktop.Properties.Resources.bg;
            this.Desktop.Controls.Add(this.menuStrip2);
            this.Desktop.Name = "Desktop";
            this.Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.Desktop_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip2.Name = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.png");
            this.imageList1.Images.SetKeyName(1, "start.png");
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.internetToolStripMenuItem,
            this.adobeToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.gamesToolStripMenuItem,
            this.exploitsToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.shutdownToolStripMenuItem});
            this.startToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.start;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            resources.ApplyResources(this.userToolStripMenuItem, "userToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.internetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            resources.ApplyResources(this.internetToolStripMenuItem, "internetToolStripMenuItem");
            this.internetToolStripMenuItem.Click += new System.EventHandler(this.internetToolStripMenuItem_Click);
            // 
            // adobeToolStripMenuItem
            // 
            this.adobeToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adobeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.adobeToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.Folder;
            this.adobeToolStripMenuItem.Name = "adobeToolStripMenuItem";
            resources.ApplyResources(this.adobeToolStripMenuItem, "adobeToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.epicToolStripMenuItem,
            this.minecraftToolStripMenuItem,
            this.technicToolStripMenuItem});
            this.gamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.gamesToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.Folder;
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            resources.ApplyResources(this.gamesToolStripMenuItem, "gamesToolStripMenuItem");
            // 
            // epicToolStripMenuItem
            // 
            this.epicToolStripMenuItem.Name = "epicToolStripMenuItem";
            resources.ApplyResources(this.epicToolStripMenuItem, "epicToolStripMenuItem");
            // 
            // minecraftToolStripMenuItem
            // 
            this.minecraftToolStripMenuItem.Name = "minecraftToolStripMenuItem";
            resources.ApplyResources(this.minecraftToolStripMenuItem, "minecraftToolStripMenuItem");
            // 
            // technicToolStripMenuItem
            // 
            this.technicToolStripMenuItem.Name = "technicToolStripMenuItem";
            resources.ApplyResources(this.technicToolStripMenuItem, "technicToolStripMenuItem");
            // 
            // exploitsToolStripMenuItem
            // 
            this.exploitsToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.exploitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spareToolStripMenuItem});
            this.exploitsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exploitsToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.Folder;
            this.exploitsToolStripMenuItem.Name = "exploitsToolStripMenuItem";
            resources.ApplyResources(this.exploitsToolStripMenuItem, "exploitsToolStripMenuItem");
            // 
            // spareToolStripMenuItem
            // 
            this.spareToolStripMenuItem.Name = "spareToolStripMenuItem";
            resources.ApplyResources(this.spareToolStripMenuItem, "spareToolStripMenuItem");
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.explorerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.explorerToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.Folder;
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            resources.ApplyResources(this.explorerToolStripMenuItem, "explorerToolStripMenuItem");
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gpeditToolStripMenuItem,
            this.regeditToolStripMenuItem,
            this.cmdToolStripMenuItem,
            this.runToolStripMenuItem,
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.Folder;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // gpeditToolStripMenuItem
            // 
            this.gpeditToolStripMenuItem.Name = "gpeditToolStripMenuItem";
            resources.ApplyResources(this.gpeditToolStripMenuItem, "gpeditToolStripMenuItem");
            this.gpeditToolStripMenuItem.Click += new System.EventHandler(this.gpeditToolStripMenuItem_Click);
            // 
            // regeditToolStripMenuItem
            // 
            this.regeditToolStripMenuItem.Name = "regeditToolStripMenuItem";
            resources.ApplyResources(this.regeditToolStripMenuItem, "regeditToolStripMenuItem");
            this.regeditToolStripMenuItem.Click += new System.EventHandler(this.regeditToolStripMenuItem_Click);
            // 
            // cmdToolStripMenuItem
            // 
            this.cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            resources.ApplyResources(this.cmdToolStripMenuItem, "cmdToolStripMenuItem");
            this.cmdToolStripMenuItem.Click += new System.EventHandler(this.cmdToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            resources.ApplyResources(this.runToolStripMenuItem, "runToolStripMenuItem");
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            resources.ApplyResources(this.settingsToolStripMenuItem1, "settingsToolStripMenuItem1");
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.shutdownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.lockToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.shutdownToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.shutdownToolStripMenuItem.Image = global::WindowsDesktop.Properties.Resources.start;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            resources.ApplyResources(this.shutdownToolStripMenuItem, "shutdownToolStripMenuItem");
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            resources.ApplyResources(this.lockToolStripMenuItem, "lockToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // WindowsDesktop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.Desktop);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsDesktop";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Desktop.ResumeLayout(false);
            this.Desktop.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Desktop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpeditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regeditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem epicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minecraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}

