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
            if (textBoxServerIP.Text.Trim() != string.Empty)
            {
                if (textBoxServerPort.Text.Trim() != string.Empty)
                {
                    if (textBoxUsername.Text.Trim() == string.Empty)
                    {
                        Form Main = new Main(textBoxServerIP.Text.Trim(), Convert.ToInt16(textBoxServerPort.Text.Trim()), textBoxAesKey.Text.Trim());
                        this.Hide();
                        Main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Form Main = new Main(textBoxServerIP.Text.Trim(), Convert.ToInt16(textBoxServerPort.Text.Trim()), textBoxAesKey.Text.Trim(), textBoxUsername.Text);
                        this.Hide();
                        Main.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your entries.", "Comlan - Error");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
