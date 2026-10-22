namespace InfoRam
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            ménuToolStripMenuItem = new ToolStripMenuItem();
            editorDeMascarasToolStripMenuItem = new ToolStripMenuItem();
            editorDeChipsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ménuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ménuToolStripMenuItem
            // 
            ménuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editorDeMascarasToolStripMenuItem, editorDeChipsToolStripMenuItem });
            ménuToolStripMenuItem.Name = "ménuToolStripMenuItem";
            ménuToolStripMenuItem.Size = new Size(50, 20);
            ménuToolStripMenuItem.Text = "Ménu";
            // 
            // editorDeMascarasToolStripMenuItem
            // 
            editorDeMascarasToolStripMenuItem.Name = "editorDeMascarasToolStripMenuItem";
            editorDeMascarasToolStripMenuItem.Size = new Size(180, 22);
            editorDeMascarasToolStripMenuItem.Text = "Editor de mascaras";
            editorDeMascarasToolStripMenuItem.Click += editorDeMascarasToolStripMenuItem_Click;
            // 
            // editorDeChipsToolStripMenuItem
            // 
            editorDeChipsToolStripMenuItem.Name = "editorDeChipsToolStripMenuItem";
            editorDeChipsToolStripMenuItem.Size = new Size(180, 22);
            editorDeChipsToolStripMenuItem.Text = "Editor de Chips";
            editorDeChipsToolStripMenuItem.Click += editorDeChipsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ménuToolStripMenuItem;
        private ToolStripMenuItem editorDeMascarasToolStripMenuItem;
        private ToolStripMenuItem editorDeChipsToolStripMenuItem;
    }
}
