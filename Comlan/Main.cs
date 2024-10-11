using System.Net.Sockets;
using System.Text;

namespace Comlan
{
    public partial class Main : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private static TcpClient _client;
        private static NetworkStream _stream;
        private string username = Environment.UserName;

        /// <summary>
        /// The main form of the application. It initializes the components, starts the connection to the server, and starts a thread to receive messages.
        /// </summary>
        public Main()
        {
            InitializeComponent();

            string serverIp = "192.168.1.99";         
            int port = 8888;

            _client = new TcpClient();
            try
            {
                _client.Connect(serverIp, port);

                if (_client.Connected)
                {
                    _stream = _client.GetStream();
                    AppendMessage("Connecté au serveur.");

                    Thread receiveThread = new Thread(ReceiveMessages);
                    receiveThread.Start();
                }
                else
                {
                    AppendMessage("Impossible de se connecter au serveur.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Comlan - Error");
                this.Close();
            }
        }

        /// <summary>
        /// Method to receive messages from the server.
        /// </summary>
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
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
                    MessageBox.Show("Error when receiving message : " + ex.Message);
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
                    string message = username + ": " + TextBoxWrite.Text;
                    byte[] data = Encoding.UTF8.GetBytes(message);

                    _stream.Write(data, 0, data.Length);
                    TextBoxWrite.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when sending message : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a message.");
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
