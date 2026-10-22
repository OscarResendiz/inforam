namespace InfoRam.EditorChip
{
    partial class CPadEditable
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            LNombre = new Label();
            label1 = new Label();
            TDiodo = new TextBox();
            TVoltaje = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Microsoft Sans Serif", 11.25F);
            LNombre.ForeColor = SystemColors.ActiveCaption;
            LNombre.Location = new Point(3, 0);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(25, 18);
            LNombre.TabIndex = 0;
            LNombre.Text = "A0";
            LNombre.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 1;
            label1.Text = "Diodo";
            // 
            // TDiodo
            // 
            TDiodo.Font = new Font("Microsoft Sans Serif", 11.25F);
            TDiodo.Location = new Point(57, 15);
            TDiodo.Name = "TDiodo";
            TDiodo.Size = new Size(49, 24);
            TDiodo.TabIndex = 2;
            TDiodo.Text = "1";
            TDiodo.KeyPress += textbox_KeyPress;
            // 
            // TVoltaje
            // 
            TVoltaje.Font = new Font("Microsoft Sans Serif", 11.25F);
            TVoltaje.Location = new Point(57, 41);
            TVoltaje.Name = "TVoltaje";
            TVoltaje.Size = new Size(49, 24);
            TVoltaje.TabIndex = 4;
            TVoltaje.Text = "1";
            TVoltaje.KeyPress += textbox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 3;
            label2.Text = "Voltaje";
            // 
            // CPadEditable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(TVoltaje);
            Controls.Add(label2);
            Controls.Add(TDiodo);
            Controls.Add(label1);
            Controls.Add(LNombre);
            Name = "CPadEditable";
            Size = new Size(118, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label label1;
        private TextBox TDiodo;
        private TextBox TVoltaje;
        private Label label2;
    }
}
