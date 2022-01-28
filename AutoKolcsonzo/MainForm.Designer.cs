namespace AutoKolcsonzo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.összesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.allCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsByMakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összesBérlőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törzsvásárlókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.összesToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(123, 28);
            // 
            // összesToolStripMenuItem
            // 
            this.összesToolStripMenuItem.Name = "összesToolStripMenuItem";
            this.összesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.összesToolStripMenuItem.Text = "Összes";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCarToolStripMenuItem,
            this.carsByMakeToolStripMenuItem,
            this.összesBérlőToolStripMenuItem,
            this.törzsvásárlókToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // allCarToolStripMenuItem
            // 
            this.allCarToolStripMenuItem.Name = "allCarToolStripMenuItem";
            this.allCarToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.allCarToolStripMenuItem.Text = "Összes Autó";
            this.allCarToolStripMenuItem.Click += new System.EventHandler(this.AllCarToolStripMenuItem_Click);
            // 
            // carsByMakeToolStripMenuItem
            // 
            this.carsByMakeToolStripMenuItem.Name = "carsByMakeToolStripMenuItem";
            this.carsByMakeToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.carsByMakeToolStripMenuItem.Text = "Autók Gyártmány szerint";
            this.carsByMakeToolStripMenuItem.Click += new System.EventHandler(this.CarsByMakeToolStripMenuItem_Click);
            // 
            // összesBérlőToolStripMenuItem
            // 
            this.összesBérlőToolStripMenuItem.Name = "összesBérlőToolStripMenuItem";
            this.összesBérlőToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.összesBérlőToolStripMenuItem.Text = "Összes Bérlő";
            // 
            // törzsvásárlókToolStripMenuItem
            // 
            this.törzsvásárlókToolStripMenuItem.Name = "törzsvásárlókToolStripMenuItem";
            this.törzsvásárlókToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.törzsvásárlókToolStripMenuItem.Text = "Törzsvásárlók";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 90);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 29;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(776, 348);
            this.dgvMain.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(12, 49);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 38);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Összes Autó";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Autó Kölcsönző";
            this.contextMenuStrip2.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem összesToolStripMenuItem;
        private MenuStrip mainMenu;
        private ToolStripMenuItem allCarToolStripMenuItem;
        private ToolStripMenuItem carsByMakeToolStripMenuItem;
        private ToolStripMenuItem összesBérlőToolStripMenuItem;
        private ToolStripMenuItem törzsvásárlókToolStripMenuItem;
        private DataGridView dgvMain;
        private Label lblHeader;
    }
}