namespace Comlan
{
    public partial class ComlanLogin : Form
    {
        public ComlanLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to allow the form to be moved by clicking on the title bar.
        /// Thanks to : elimad at https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

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
                else
                {
                    MessageBox.Show("Please check your entries.", "Comlan - Error");
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
