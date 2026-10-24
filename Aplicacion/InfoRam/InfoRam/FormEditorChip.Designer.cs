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
            cChip31 = new InfoRam.EditorChip.CChip3();
            panel1 = new Panel();
            button5 = new Button();
            panel2 = new Panel();
            btnCerrar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            txtValor = new TextBox();
            label4 = new Label();
            txtPad = new TextBox();
            ComboOpciones = new ComboBox();
            label1 = new Label();
            txtNombreChip = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cChip31
            // 
            cChip31.AnchoCuadricula = 50;
            cChip31.AutoScroll = true;
            cChip31.AutoScrollMinSize = new Size(583, 463);
            cChip31.BackColor = Color.Transparent;
            cChip31.Columnas = 10;
            cChip31.Dock = DockStyle.Fill;
            cChip31.Filas = 10;
            cChip31.Location = new Point(268, 118);
            cChip31.Name = "cChip31";
            cChip31.Size = new Size(817, 576);
            cChip31.TabIndex = 1;
            cChip31.Text = "cChip31";
            cChip31.OnPadClick += cChip31_OnPadClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 118);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(122, 13);
            button5.Name = "button5";
            button5.Size = new Size(103, 95);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = true;
            button5.Click += BtnSelMascara_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(944, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 114);
            panel2.TabIndex = 10;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(3, 13);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 95);
            btnCerrar.TabIndex = 9;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(340, 13);
            button1.Name = "button1";
            button1.Size = new Size(103, 95);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnGuardar_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(231, 13);
            button2.Name = "button2";
            button2.Size = new Size(103, 95);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnAbrir_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(13, 13);
            button3.Name = "button3";
            button3.Size = new Size(103, 95);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnNuevo_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(txtValor);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtPad);
            panel3.Controls.Add(ComboOpciones);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtNombreChip);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 576);
            panel3.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(186, 167);
            button4.Name = "button4";
            button4.Size = new Size(39, 38);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(70, 172);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(110, 23);
            txtValor.TabIndex = 8;
            txtValor.KeyDown += txtValor_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(14, 167);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 7;
            label4.Text = "Valor";
            // 
            // txtPad
            // 
            txtPad.Location = new Point(56, 130);
            txtPad.Name = "txtPad";
            txtPad.ReadOnly = true;
            txtPad.Size = new Size(184, 23);
            txtPad.TabIndex = 6;
            // 
            // ComboOpciones
            // 
            ComboOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboOpciones.FormattingEnabled = true;
            ComboOpciones.Items.AddRange(new object[] { "Nombres", "Voltajes", "Diodos" });
            ComboOpciones.Location = new Point(55, 84);
            ComboOpciones.Name = "ComboOpciones";
            ComboOpciones.Size = new Size(185, 23);
            ComboOpciones.TabIndex = 5;
            ComboOpciones.SelectedIndexChanged += ComboOpciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Chip";
            // 
            // txtNombreChip
            // 
            txtNombreChip.Location = new Point(13, 42);
            txtNombreChip.Name = "txtNombreChip";
            txtNombreChip.Size = new Size(227, 23);
            txtNombreChip.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(14, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 2;
            label2.Text = "Ver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(14, 125);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 4;
            label3.Text = "Pad";
            // 
            // FormEditorChip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 694);
            Controls.Add(cChip31);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormEditorChip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de chips";
            WindowState = FormWindowState.Maximized;
            Load += FormEditorChip_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private EditorChip.CChip3 cChip31;
        private ToolStripLabel toolStripLabel4;
        private Panel panel1;
        private Panel panel2;
        private Button btnCerrar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private Label label1;
        private TextBox txtNombreChip;
        private NumericUpDown TFilas;
        private Label label2;
        private NumericUpDown TColunmas;
        private Label label3;
        private TextBox txtPad;
        private ComboBox ComboOpciones;
        private TextBox txtValor;
        private Label label4;
        private Button button4;
        private Button button5;
    }
}