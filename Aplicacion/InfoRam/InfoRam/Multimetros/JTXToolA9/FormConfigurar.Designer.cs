namespace InfoRam.Multimetros.JTXToolA9
{
    partial class FormConfigurar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurar));
            groupBox1 = new GroupBox();
            ComboBitsParo = new ComboBox();
            label5 = new Label();
            ComboBitsDatos = new ComboBox();
            label4 = new Label();
            ComboParidad = new ComboBox();
            label3 = new Label();
            ComboVelocidad = new ComboBox();
            label2 = new Label();
            ComboPuerto = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            TxtRetardo = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRetardo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ComboBitsParo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ComboBitsDatos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ComboParidad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ComboVelocidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ComboPuerto);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comunicación Serial";
            // 
            // ComboBitsParo
            // 
            ComboBitsParo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBitsParo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ComboBitsParo.FormattingEnabled = true;
            ComboBitsParo.Items.AddRange(new object[] { "None", "One", "Two", "OnePointFive" });
            ComboBitsParo.Location = new Point(146, 190);
            ComboBitsParo.Name = "ComboBitsParo";
            ComboBitsParo.Size = new Size(246, 33);
            ComboBitsParo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 8;
            label5.Text = "Bits de paro";
            // 
            // ComboBitsDatos
            // 
            ComboBitsDatos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBitsDatos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ComboBitsDatos.FormattingEnabled = true;
            ComboBitsDatos.Items.AddRange(new object[] { "5", "6", "7", "8" });
            ComboBitsDatos.Location = new Point(134, 151);
            ComboBitsDatos.Name = "ComboBitsDatos";
            ComboBitsDatos.Size = new Size(258, 33);
            ComboBitsDatos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 6;
            label4.Text = "Bits de datos";
            // 
            // ComboParidad
            // 
            ComboParidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboParidad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ComboParidad.FormattingEnabled = true;
            ComboParidad.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            ComboParidad.Location = new Point(134, 112);
            ComboParidad.Name = "ComboParidad";
            ComboParidad.Size = new Size(258, 33);
            ComboParidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Paridad";
            // 
            // ComboVelocidad
            // 
            ComboVelocidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboVelocidad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ComboVelocidad.FormattingEnabled = true;
            ComboVelocidad.Items.AddRange(new object[] { "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "230400" });
            ComboVelocidad.Location = new Point(134, 71);
            ComboVelocidad.Name = "ComboVelocidad";
            ComboVelocidad.Size = new Size(258, 33);
            ComboVelocidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Velocidad";
            // 
            // ComboPuerto
            // 
            ComboPuerto.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPuerto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ComboPuerto.FormattingEnabled = true;
            ComboPuerto.Location = new Point(134, 30);
            ComboPuerto.Name = "ComboPuerto";
            ComboPuerto.Size = new Size(258, 33);
            ComboPuerto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Puerto COM";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(TxtRetardo);
            groupBox2.Controls.Add(label6);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ActiveCaption;
            groupBox2.Location = new Point(0, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Otros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(11, 35);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 0;
            label6.Text = "Retardo";
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackgroundImage = (Image)resources.GetObject("BtnAceptar.BackgroundImage");
            BtnAceptar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAceptar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnAceptar.Location = new Point(20, 336);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(70, 70);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackgroundImage = (Image)resources.GetObject("BtnCancelar.BackgroundImage");
            BtnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCancelar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnCancelar.Location = new Point(293, 336);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(70, 70);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtRetardo
            // 
            TxtRetardo.Location = new Point(146, 27);
            TxtRetardo.Name = "TxtRetardo";
            TxtRetardo.Size = new Size(246, 33);
            TxtRetardo.TabIndex = 2;
            // 
            // FormConfigurar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(404, 415);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormConfigurar";
            Text = "JTXTool A9";
            Load += FormConfigurar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRetardo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox ComboParidad;
        private Label label3;
        private ComboBox ComboVelocidad;
        private Label label2;
        private ComboBox ComboPuerto;
        private Label label1;
        private ComboBox ComboBitsParo;
        private Label label5;
        private ComboBox ComboBitsDatos;
        private Label label4;
        private GroupBox groupBox2;
        private Label label6;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private NumericUpDown TxtRetardo;
    }
}