namespace English_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sinisterLabel_Click(object sender, EventArgs e)
        {
            translatorLabel.Text = "left";
        }

        private void dexterLabel_Click(object sender, EventArgs e)
        {
            translatorLabel.Text = "right";
        }

        private void mediumLabel_Click(object sender, EventArgs e)
        {
            translatorLabel.Text = "center";
        }
    }
}