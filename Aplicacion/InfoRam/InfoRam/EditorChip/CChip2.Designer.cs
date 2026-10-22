namespace InfoRam.EditorChip
{
    partial class CChip2
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPageDiodos = new TabPage();
            tabPageVoltajes = new TabPage();
            gridDiodos = new DataGridView();
            gridVoltajes = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageDiodos.SuspendLayout();
            tabPageVoltajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDiodos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridVoltajes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDiodos);
            tabControl1.Controls.Add(tabPageVoltajes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(420, 291);
            tabControl1.TabIndex = 0;
            // 
            // tabPageDiodos
            // 
            tabPageDiodos.Controls.Add(gridDiodos);
            tabPageDiodos.Location = new Point(4, 24);
            tabPageDiodos.Name = "tabPageDiodos";
            tabPageDiodos.Padding = new Padding(3);
            tabPageDiodos.Size = new Size(412, 263);
            tabPageDiodos.TabIndex = 0;
            tabPageDiodos.Text = "Diodos";
            tabPageDiodos.UseVisualStyleBackColor = true;
            // 
            // tabPageVoltajes
            // 
            tabPageVoltajes.Controls.Add(gridVoltajes);
            tabPageVoltajes.Location = new Point(4, 24);
            tabPageVoltajes.Name = "tabPageVoltajes";
            tabPageVoltajes.Padding = new Padding(3);
            tabPageVoltajes.Size = new Size(412, 263);
            tabPageVoltajes.TabIndex = 1;
            tabPageVoltajes.Text = "Voltajes";
            tabPageVoltajes.UseVisualStyleBackColor = true;
            // 
            // gridDiodos
            // 
            gridDiodos.AllowUserToAddRows = false;
            gridDiodos.AllowUserToDeleteRows = false;
            gridDiodos.AllowUserToResizeRows = false;
            gridDiodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDiodos.Dock = DockStyle.Fill;
            gridDiodos.Location = new Point(3, 3);
            gridDiodos.Name = "gridDiodos";
            gridDiodos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridDiodos.Size = new Size(406, 257);
            gridDiodos.TabIndex = 0;
            // 
            // gridVoltajes
            // 
            gridVoltajes.AllowUserToAddRows = false;
            gridVoltajes.AllowUserToDeleteRows = false;
            gridVoltajes.AllowUserToResizeRows = false;
            gridVoltajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVoltajes.Dock = DockStyle.Fill;
            gridVoltajes.Location = new Point(3, 3);
            gridVoltajes.Name = "gridVoltajes";
            gridVoltajes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridVoltajes.Size = new Size(406, 257);
            gridVoltajes.TabIndex = 0;
            // 
            // CChip2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "CChip2";
            Size = new Size(420, 291);
            tabControl1.ResumeLayout(false);
            tabPageDiodos.ResumeLayout(false);
            tabPageVoltajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDiodos).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridVoltajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageDiodos;
        private TabPage tabPageVoltajes;
        private DataGridView gridDiodos;
        private DataGridView gridVoltajes;
    }
}
