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
            FormEditorMascara form=new FormEditorMascara();
            form.ShowDialog();
        }
    }
}
