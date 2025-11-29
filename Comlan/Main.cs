using System.Net.Sockets;
using System.Text;

namespace Comlan
{
    public partial class Main : Form
    {
        private static TcpClient? _client;
        private static NetworkStream? _stream;
        private static string? Username { get; set; }
        private static string AESkey = "cM95jd3wAI5ot7SJ76HisAKR3NuaAEhj";
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

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

        /// <summary>
        /// The main form of the application. It initializes the components, starts the connection to the server, and starts a thread to receive messages.
        /// </summary>
        public Main(string serverIP, int serverPort, string Key, string? username = null)
        {
            InitializeComponent();

            if (Key != string.Empty)
                AESkey = Key;

            Username = username != null ? "@" + username : "@" + Environment.UserName;

            _client = new TcpClient();
            try
            {
                _client.Connect(serverIP, serverPort);

                if (_client.Connected)
                {
                    _stream = _client.GetStream();
                    AppendMessage("Server connexion : OK.");

                    Thread receiveThread = new(ReceiveMessages);
                    receiveThread.Start();
                }
                else
                    MessageBox.Show("Connexion Error : Server not found.", "Comlan - Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connexion Error : " + ex.Message, "Comlan - Error");
            }
        }

        /// <summary>
        /// Method to receive messages from the server.
        /// </summary>
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[4096];
            while (true)
            {
                try
                {
                    int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        if (!message.StartsWith('@'))
                            message = Aes256CbcEncrypt.Decrypt(message, AESkey);

                        AppendMessage(message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error when receiving message : " + ex.Message, "Comlan - Error");
                    break;
                }
            }
        }

        /// <summary>
        /// Method to append a message to the chat. 
        /// </summary>
        /// <param name="message"></param>
        private void AppendMessage(string message)
        {
            if (richTextBoxChannel.InvokeRequired) // thread safety
                richTextBoxChannel.Invoke(new Action(() => richTextBoxChannel.AppendText(message + Environment.NewLine + Environment.NewLine))); // Used from another thread
            else
                richTextBoxChannel.AppendText(message + Environment.NewLine + Environment.NewLine); // Used from the same thread
        }

        /// <summary>
        /// Method to send a message to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxWrite.Text.Trim() != string.Empty)
                {
                    string message = Username + ": " + TextBoxWrite.Text;
                    byte[] data = Encoding.UTF8.GetBytes(Aes256CbcEncrypt.Encrypt(message, AESkey));

                    if (_stream != null)
                    {
                        // avoid sending too large messages
                        if (data.Length < 4096)
                        {
                            _stream.Write(data, 0, data.Length);
                            TextBoxWrite.Text = "";
                        }
                        else
                            MessageBox.Show("Message is too long to be sent.", "Comlan - Error");

                    }
                    else
                        MessageBox.Show("Not connected to the server.", "Comlan - Error");
                }
                else
                    MessageBox.Show("Please enter a message.", "Comlan - Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when sending message : " + ex.Message, "Comlan - Error");
            }
        }

        /// <summary>
        /// Method to add a file if necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            // Fonction pour ajouter un fichier si nécessaire
        }

        /// <summary>
        /// Method to minimize the form.
        /// </summary>w
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Method to close the connection and the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            _stream?.Close();
            _client?.Close();

            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _stream?.Close();
            _client?.Close();
        }
    }
}
