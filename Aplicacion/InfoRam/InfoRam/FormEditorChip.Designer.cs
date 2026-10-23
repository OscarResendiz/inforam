namespace InfoRam
{
    partial class FormEditorChip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorChip));
            toolStrip1 = new ToolStrip();
            BtnNuevo = new ToolStripButton();
            BtnSelMascara = new ToolStripButton();
            BtnAbrir = new ToolStripButton();
            BtnGuardar = new ToolStripButton();
            cChip31 = new InfoRam.EditorChip.CChip3();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnNuevo, BtnSelMascara, BtnAbrir, BtnGuardar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnNuevo
            // 
            BtnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnNuevo.Image = (Image)resources.GetObject("BtnNuevo.Image");
            BtnNuevo.ImageTransparentColor = Color.Magenta;
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(23, 22);
            BtnNuevo.Text = "toolStripButton1";
            // 
            // BtnSelMascara
            // 
            BtnSelMascara.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnSelMascara.Image = (Image)resources.GetObject("BtnSelMascara.Image");
            BtnSelMascara.ImageTransparentColor = Color.Magenta;
            BtnSelMascara.Name = "BtnSelMascara";
            BtnSelMascara.Size = new Size(23, 22);
            BtnSelMascara.Text = "toolStripButton2";
            BtnSelMascara.Click += BtnSelMascara_Click;
            // 
            // BtnAbrir
            // 
            BtnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnAbrir.Image = (Image)resources.GetObject("BtnAbrir.Image");
            BtnAbrir.ImageTransparentColor = Color.Magenta;
            BtnAbrir.Name = "BtnAbrir";
            BtnAbrir.Size = new Size(23, 22);
            BtnAbrir.Text = "toolStripButton3";
            // 
            // BtnGuardar
            // 
            BtnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageTransparentColor = Color.Magenta;
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(23, 22);
            BtnGuardar.Text = "toolStripButton4";
            // 
            // cChip31
            // 
            cChip31.AnchoCuadricula = 50;
            cChip31.AutoScroll = true;
            cChip31.AutoScrollMinSize = new Size(575, 387);
            cChip31.BackColor = SystemColors.Control;
            cChip31.Columnas = 10;
            cChip31.Dock = DockStyle.Fill;
            cChip31.Filas = 10;
            cChip31.Location = new Point(0, 25);
            cChip31.Name = "cChip31";
            cChip31.Size = new Size(800, 425);
            cChip31.TabIndex = 1;
            cChip31.Text = "cChip31";
            // 
            // FormEditorChip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cChip31);
            Controls.Add(toolStrip1);
            Name = "FormEditorChip";
            Text = "FormEditorChip";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton BtnNuevo;
        private ToolStripButton BtnSelMascara;
        private ToolStripButton BtnAbrir;
        private ToolStripButton BtnGuardar;
        private EditorChip.CChip3 cChip31;
    }
}