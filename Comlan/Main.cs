using System.Net.Sockets;
using System.Text;

namespace Comlan
{
    public partial class Main : Form
    {
        /// <summary>                              
        /// Required designer variable.
        /// </summary>
        private static TcpClient? _client;
        private static NetworkStream? _stream;
        private static string? Username { get; set; }

        /// <summary>
        /// The main form of the application. It initializes the components, starts the connection to the server, and starts a thread to receive messages.
        /// </summary>
        public Main(string serverIP, int serverPort, string username = null)
        {
            InitializeComponent();

            if (username != null)
            {
                Username = username;
            }
            else
            {
                Username = Environment.UserName;
            }

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
                {
                    AppendMessage("Cannot join the server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connexion Error : " + ex.Message, "Comlan - Error");
                this.Close();
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

                        AppendMessage(message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when receiving message : " + ex.Message, "Comlan - Error");
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
            if (richTextBoxChannel.InvokeRequired)
            {
                richTextBoxChannel.Invoke(new Action(() => richTextBoxChannel.AppendText(message + Environment.NewLine)));
            }
            else
            {
                richTextBoxChannel.AppendText(message + Environment.NewLine);
            }
        }

        /// <summary>
        /// Method to send a message to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxWrite.Text.Trim() != string.Empty)
            {
                try
                {
                    string message = Username + ": " + TextBoxWrite.Text;
                    byte[] data = Encoding.UTF8.GetBytes(message);

                    if (_stream != null)
                    {
                        _stream.Write(data, 0, data.Length);
                        TextBoxWrite.Text = "";
                    }
                    else
                    {
                        throw new Exception("Network stream is null.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when sending message : " + ex.Message, "Comlan - Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a message.", "Comlan - Error");
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
    }
}
