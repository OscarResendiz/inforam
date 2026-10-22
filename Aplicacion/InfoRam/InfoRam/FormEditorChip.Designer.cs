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
            cChip21 = new InfoRam.EditorChip.CChip2();
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
            // cChip21
            // 
            cChip21.Dock = DockStyle.Fill;
            cChip21.Location = new Point(0, 25);
            cChip21.Name = "cChip21";
            cChip21.Size = new Size(800, 425);
            cChip21.TabIndex = 1;
            // 
            // FormEditorChip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cChip21);
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
        private EditorChip.CChip2 cChip21;
    }
}