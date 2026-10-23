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
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel4 = new ToolStripLabel();
            txtNombreChip = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            ComboOpciones = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            txtPad = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            txtValor = new ToolStripTextBox();
            btnAplicar = new ToolStripButton();
            cChip31 = new InfoRam.EditorChip.CChip3();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnNuevo, BtnSelMascara, BtnAbrir, BtnGuardar, toolStripSeparator1, toolStripLabel4, txtNombreChip, toolStripSeparator2, toolStripLabel1, ComboOpciones, toolStripSeparator3, toolStripLabel3, txtPad, toolStripLabel2, txtValor, btnAplicar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1085, 25);
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
            BtnNuevo.Click += BtnNuevo_Click;
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
            BtnAbrir.Click += BtnAbrir_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageTransparentColor = Color.Magenta;
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(23, 22);
            BtnGuardar.Text = "toolStripButton4";
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(77, 22);
            toolStripLabel4.Text = "Nombre chip";
            // 
            // txtNombreChip
            // 
            txtNombreChip.Name = "txtNombreChip";
            txtNombreChip.Size = new Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(48, 22);
            toolStripLabel1.Text = "Mostrar";
            // 
            // ComboOpciones
            // 
            ComboOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboOpciones.Items.AddRange(new object[] { "Nombres", "Voltajes", "Diodos" });
            ComboOpciones.MergeIndex = 0;
            ComboOpciones.Name = "ComboOpciones";
            ComboOpciones.Size = new Size(121, 25);
            ComboOpciones.SelectedIndexChanged += ComboOpciones_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(27, 22);
            toolStripLabel3.Text = "Pad";
            // 
            // txtPad
            // 
            txtPad.Name = "txtPad";
            txtPad.ReadOnly = true;
            txtPad.Size = new Size(100, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(33, 22);
            toolStripLabel2.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 25);
            txtValor.KeyUp += txtValor_KeyUp;
            // 
            // btnAplicar
            // 
            btnAplicar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAplicar.Image = (Image)resources.GetObject("btnAplicar.Image");
            btnAplicar.ImageTransparentColor = Color.Magenta;
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(48, 22);
            btnAplicar.Text = "Aplicar";
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cChip31
            // 
            cChip31.AnchoCuadricula = 50;
            cChip31.AutoScroll = true;
            cChip31.AutoScrollMinSize = new Size(717, 509);
            cChip31.BackColor = SystemColors.Control;
            cChip31.Columnas = 10;
            cChip31.Dock = DockStyle.Fill;
            cChip31.Filas = 10;
            cChip31.Location = new Point(0, 25);
            cChip31.Name = "cChip31";
            cChip31.Size = new Size(1085, 669);
            cChip31.TabIndex = 1;
            cChip31.Text = "cChip31";
            cChip31.OnPadClick += cChip31_OnPadClick;
            // 
            // FormEditorChip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 694);
            Controls.Add(cChip31);
            Controls.Add(toolStrip1);
            Name = "FormEditorChip";
            Text = "FormEditorChip";
            Load += FormEditorChip_Load;
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
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox ComboOpciones;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtValor;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox txtPad;
        private ToolStripButton btnAplicar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox txtNombreChip;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
    }
}