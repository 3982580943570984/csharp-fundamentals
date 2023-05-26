namespace Studying
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox() => InitializeComponent();

        private void buttonExit_Click(object sender, EventArgs e) => Close();
        private void buttonCopy_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxResult.Text);

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            textBoxResult.SelectionStart = 0;
            textBoxResult.SelectionLength = 0;
        }
    }
}
