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
            comboBox1 = new ComboBox();
            label4 = new Label();
            TColunmas = new NumericUpDown();
            label3 = new Label();
            TFilas = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            PanelMascara = new Panel();
            controlDibujable1 = new ControlDibujable();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TColunmas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TFilas).BeginInit();
            toolStrip1.SuspendLayout();
            PanelMascara.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TColunmas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TFilas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 100);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "1";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5" });
            comboBox1.Location = new Point(423, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.ValueMember = "1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 56);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Zoom";
            // 
            // TColunmas
            // 
            TColunmas.Location = new Point(235, 52);
            TColunmas.Name = "TColunmas";
            TColunmas.Size = new Size(120, 23);
            TColunmas.TabIndex = 5;
            TColunmas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            TColunmas.ValueChanged += TColumnas_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 54);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "columnas";
            // 
            // TFilas
            // 
            TFilas.Location = new Point(60, 50);
            TFilas.Name = "TFilas";
            TFilas.Size = new Size(120, 23);
            TFilas.TabIndex = 3;
            TFilas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            TFilas.ValueChanged += TFilas_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "filas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1104, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Abrir";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Guardar";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // PanelMascara
            // 
            PanelMascara.AutoScroll = true;
            PanelMascara.Controls.Add(controlDibujable1);
            PanelMascara.Dock = DockStyle.Fill;
            PanelMascara.Location = new Point(0, 125);
            PanelMascara.Name = "PanelMascara";
            PanelMascara.Size = new Size(1104, 467);
            PanelMascara.TabIndex = 2;
            // 
            // controlDibujable1
            // 
            controlDibujable1.AnchoCuadricula = 25;
            controlDibujable1.BackColor = SystemColors.AppWorkspace;
            controlDibujable1.ColorCuadricula = Color.Black;
            controlDibujable1.Columnas = 10;
            controlDibujable1.Dock = DockStyle.Fill;
            controlDibujable1.Filas = 10;
            controlDibujable1.Location = new Point(0, 0);
            controlDibujable1.Name = "controlDibujable1";
            controlDibujable1.Size = new Size(1104, 467);
            controlDibujable1.TabIndex = 0;
            controlDibujable1.TabStop = false;
            controlDibujable1.Zoom = 0.5F;
            controlDibujable1.Click += controlDibujable1_Click;
            // 
            // FormEditorMascara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 592);
            Controls.Add(PanelMascara);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "FormEditorMascara";
            Text = "FormEditorMascara";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TColunmas).EndInit();
            ((System.ComponentModel.ISupportInitialize)TFilas).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            PanelMascara.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private NumericUpDown TColunmas;
        private Label label3;
        private NumericUpDown TFilas;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Panel PanelMascara;
        private ControlDibujable controlDibujable1;
        private ComboBox comboBox1;
        private Label label4;
    }
}