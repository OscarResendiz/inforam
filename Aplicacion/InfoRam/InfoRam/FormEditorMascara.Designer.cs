namespace InfoRam
{
    partial class FormEditorMascara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorMascara));
            panel1 = new Panel();
            panel2 = new Panel();
            btnCerrar = new Button();
            btnGuardar = new Button();
            btnAbrir = new Button();
            btnNuevo = new Button();
            TColunmas = new NumericUpDown();
            label3 = new Label();
            TFilas = new NumericUpDown();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            PanelMascara = new Panel();
            panel3 = new Panel();
            controlDibujable1 = new ControlDibujable();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TColunmas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TFilas).BeginInit();
            PanelMascara.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnAbrir);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 118);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(963, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 114);
            panel2.TabIndex = 10;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(17, 13);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 95);
            btnCerrar.TabIndex = 9;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(231, 13);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 95);
            btnGuardar.TabIndex = 8;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.BackgroundImage = (Image)resources.GetObject("btnAbrir.BackgroundImage");
            btnAbrir.BackgroundImageLayout = ImageLayout.Stretch;
            btnAbrir.Location = new Point(122, 13);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(103, 95);
            btnAbrir.TabIndex = 7;
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(13, 13);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 95);
            btnNuevo.TabIndex = 6;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // TColunmas
            // 
            TColunmas.Location = new Point(14, 183);
            TColunmas.Name = "TColunmas";
            TColunmas.Size = new Size(226, 23);
            TColunmas.TabIndex = 5;
            TColunmas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            TColunmas.ValueChanged += TColumnas_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "columnas";
            // 
            // TFilas
            // 
            TFilas.Location = new Point(13, 110);
            TFilas.Name = "TFilas";
            TFilas.Size = new Size(227, 23);
            TFilas.TabIndex = 3;
            TFilas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            TFilas.ValueChanged += TFilas_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(14, 82);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 2;
            label2.Text = "filas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // PanelMascara
            // 
            PanelMascara.AutoScroll = true;
            PanelMascara.BackColor = Color.Transparent;
            PanelMascara.Controls.Add(panel3);
            PanelMascara.Controls.Add(controlDibujable1);
            PanelMascara.Dock = DockStyle.Fill;
            PanelMascara.Location = new Point(0, 118);
            PanelMascara.Name = "PanelMascara";
            PanelMascara.Size = new Size(1104, 474);
            PanelMascara.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(TFilas);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(TColunmas);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 474);
            panel3.TabIndex = 0;
            // 
            // controlDibujable1
            // 
            controlDibujable1.AnchoCuadricula = 25;
            controlDibujable1.AutoScroll = true;
            controlDibujable1.AutoScrollMinSize = new Size(637, 322);
            controlDibujable1.BackColor = Color.Transparent;
            controlDibujable1.BackgroundImage = (Image)resources.GetObject("controlDibujable1.BackgroundImage");
            controlDibujable1.ColorCuadricula = Color.Black;
            controlDibujable1.Columnas = 10;
            controlDibujable1.Dock = DockStyle.Fill;
            controlDibujable1.Filas = 10;
            controlDibujable1.Location = new Point(0, 0);
            controlDibujable1.Name = "controlDibujable1";
            controlDibujable1.Size = new Size(1104, 474);
            controlDibujable1.TabIndex = 0;
            controlDibujable1.TabStop = false;
            controlDibujable1.Zoom = 0.5F;
            controlDibujable1.Click += controlDibujable1_Click;
            // 
            // FormEditorMascara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1104, 592);
            Controls.Add(PanelMascara);
            Controls.Add(panel1);
            Name = "FormEditorMascara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de mascaras";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TColunmas).EndInit();
            ((System.ComponentModel.ISupportInitialize)TFilas).EndInit();
            PanelMascara.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown TColunmas;
        private Label label3;
        private NumericUpDown TFilas;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Panel PanelMascara;
        private ControlDibujable controlDibujable1;
        private Button btnNuevo;
        private Button btnCerrar;
        private Button btnGuardar;
        private Button btnAbrir;
        private Panel panel2;
        private Panel panel3;
    }
}