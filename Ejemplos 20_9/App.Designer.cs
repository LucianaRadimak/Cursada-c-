namespace Ejemplos_20_9
{
    partial class App
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
            menuStrip1=new MenuStrip();
            iNICIOToolStripMenuItem=new ToolStripMenuItem();
            cELULARESToolStripMenuItem=new ToolStripMenuItem();
            samsungToolStripMenuItem=new ToolStripMenuItem();
            xiaomiToolStripMenuItem=new ToolStripMenuItem();
            appleToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, cELULARESToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(800, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name="iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size=new Size(54, 20);
            iNICIOToolStripMenuItem.Text="INICIO";
            // 
            // cELULARESToolStripMenuItem
            // 
            cELULARESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { samsungToolStripMenuItem, xiaomiToolStripMenuItem, appleToolStripMenuItem });
            cELULARESToolStripMenuItem.Name="cELULARESToolStripMenuItem";
            cELULARESToolStripMenuItem.Size=new Size(80, 20);
            cELULARESToolStripMenuItem.Text="CELULARES";
            // 
            // samsungToolStripMenuItem
            // 
            samsungToolStripMenuItem.Name="samsungToolStripMenuItem";
            samsungToolStripMenuItem.Size=new Size(180, 22);
            samsungToolStripMenuItem.Text="Samsung";
            // 
            // xiaomiToolStripMenuItem
            // 
            xiaomiToolStripMenuItem.Name="xiaomiToolStripMenuItem";
            xiaomiToolStripMenuItem.Size=new Size(180, 22);
            xiaomiToolStripMenuItem.Text="Xiaomi";
            // 
            // appleToolStripMenuItem
            // 
            appleToolStripMenuItem.Name="appleToolStripMenuItem";
            appleToolStripMenuItem.Size=new Size(180, 22);
            appleToolStripMenuItem.Text="Apple";
            // 
            // App
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="App";
            Text="App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem cELULARESToolStripMenuItem;
        private ToolStripMenuItem samsungToolStripMenuItem;
        private ToolStripMenuItem xiaomiToolStripMenuItem;
        private ToolStripMenuItem appleToolStripMenuItem;
    }
}