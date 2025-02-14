using System.Text.RegularExpressions;

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
            try
            {
                if (ValidateIP(textBoxServerIP.Text))
                {
                    if (Convert.ToInt16(textBoxServerPort.Text) > 0 && Convert.ToInt32(textBoxServerPort.Text) <= 65535)
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
                    MessageBox.Show("Invalid IP address.", "Comlan - Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Comlan - Error");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateIP(string ipaddr)
        {
            Regex validateIPv4Regex = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return validateIPv4Regex.IsMatch(ipaddr);
        }
    }


}
