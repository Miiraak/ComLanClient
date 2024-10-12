namespace Comlan
{
    public partial class ComlanLogin : Form
    {
        public ComlanLogin()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() == string.Empty)
            {
                Form Main = new Main(textBoxServerIP.Text, Convert.ToInt16(textBoxServerPort.Text));
                this.Hide();
                Main.ShowDialog();
                this.Close();
            }
            else
            {
                Form Main = new Main(textBoxServerIP.Text, Convert.ToInt16(textBoxServerPort.Text), textBoxUsername.Text);
                this.Hide();
                Main.ShowDialog();
                this.Close();
            }
        }
    }


}
