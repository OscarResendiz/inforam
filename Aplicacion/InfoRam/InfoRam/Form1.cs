namespace InfoRam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editorDeMascarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void editorDeChipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            FormEditorMascara form = new FormEditorMascara();
            form.ShowDialog();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            FormEditorChip form = new FormEditorChip();
            form.ShowDialog();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
