using System.Net.Sockets;
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
        /// Method to allow the form to be moved on borderless form.
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
                if (Convert.ToUInt16(textBoxServerPort.Text) >= 0 && Convert.ToUInt16(textBoxServerPort.Text) <= 65535)
                {
                    if (ValidateIP(textBoxServerIP.Text))
                    {
                        if (TestConnection(textBoxServerIP.Text, Convert.ToUInt16(textBoxServerPort.Text)))
                        {
                            if (string.IsNullOrEmpty(textBoxUsername.Text))
                                textBoxUsername.Text = Environment.UserName;
                            Form Main = new Main(textBoxServerIP.Text.Trim(), Convert.ToUInt16(textBoxServerPort.Text.Trim()), textBoxAesKey.Text.Trim(), textBoxUsername.Text);
                            Hide();
                            // show main form and when main form is closed, show login form again
                            Main.FormClosed += (s, args) => this.Show();
                            Main.Show();
                        }
                        else
                            MessageBox.Show("Connexion Error : Server not found.", "Comlan - Error");
                    }
                    else
                        MessageBox.Show("IP Error : Enter a valid IP address.", "Comlan - Error");
                }
                else
                    MessageBox.Show("Port Error : Choose a port between 0 and 65535.", "Comlan - Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Comlan - Error");
            }
        }

        private static bool ValidateIP(string ipaddr)
        {
            Regex validateIPv4Regex = new("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return validateIPv4Regex.IsMatch(ipaddr);
        }

        private static bool TestConnection(string serverIp, int port)
        {
            try
            {
                using TcpClient client = new();
                var result = client.BeginConnect(serverIp, port, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2)); // Timeout de 2 secondes

                if (!success)
                    return false;

                client.EndConnect(result);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
