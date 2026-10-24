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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(76, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 39);
            panel1.TabIndex = 1;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(76, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 39);
            panel2.TabIndex = 2;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(76, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 39);
            panel3.TabIndex = 3;
            panel3.MouseClick += panel3_MouseClick;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(440, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 80);
            panel4.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(542, 346);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TECSAM";
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
