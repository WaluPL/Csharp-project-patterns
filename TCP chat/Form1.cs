using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcp
{
    public partial class Form1 : Form
    {
        private delegate void LogAddProc(string message);
        private delegate void AdjustControlsProc();
        private UInt16 port = 4201;
        private bool IsConnected = false;
        private TcpListener server;
        private TcpClient client;
        private List<Socket> clients = new List<Socket>();

        public Form1()
        {
            InitializeComponent();
            txtPort.Text = port.ToString();
            AdjustControls();
        }

        private void LogAdd(string message)
        {
            if(InvokeRequired)
            {
                Invoke(new LogAddProc(LogAdd),message);
            }
            else
            {
                txtLog.AppendText(message + Environment.NewLine);
            }           
        }

        private void AdjustControls()
        {
            if (InvokeRequired) Invoke(new AdjustControlsProc(AdjustControls));
            else
            {
                string message = txtMessage.Text.Trim();
                bool isNotEmpty = message.Length > 0;
                btnSend.Enabled = isNotEmpty;
                if (IsConnected)
                {
                    chkServer.Enabled = false;
                    txtHost.Enabled = false;
                    txtPort.Enabled = false;
                    btnConnect.Text = "Disconnect";
                }
                else
                {
                    chkServer.Enabled = true;
                    txtHost.Enabled = !chkServer.Checked;
                    txtPort.Enabled = true;
                    btnConnect.Text = "Connect";
                }
            }
        }

        private void ServerThread()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            LogAdd("Server conntected");
            IsConnected = true;
            AdjustControls();
            while (IsConnected)
            {
                if(server.Pending())
                {
                    new Thread(ServerClientThread).Start();
                }
            }
            IsConnected = false;
            AdjustControls();
            LogAdd("Server disconntected");
            server.Stop();
            
        }

        private void ServerClientThread()
        {
            Socket socket;
            try
            {
                socket = server.AcceptSocket();
            }
            catch (SocketException)
            {
                return;
            }
            
            string who = socket.RemoteEndPoint.ToString();
            lock (clients) clients.Add(socket);            
            LogAdd($"Client conntected { who } ");
            while(IsConnected)
            {
                if (socket.Poll(50000, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buffor = new byte[size];
                    socket.Receive(buffor);
                    string message = who + ": " + UTF8Encoding.UTF8.GetString(buffor);
                    buffor = UTF8Encoding.UTF8.GetBytes(message);
                    lock (clients) foreach (Socket s in clients) s.Send(buffor);
                    LogAdd(message);
                }
            }
            LogAdd($"Client { who } disconntected");
            lock (clients) clients.Remove(socket);
            socket.Disconnect(false);
        }

        private void ClientThread()
        {
            try
            {
                client = new TcpClient(TextHost.Text.Trim(), port);
            }
            catch (SocketException)
            {
                AppendLog("Serwer offline");
                return;
            }
            
            Socket socket = client.Client;
            LogAdd("Connected");
            IsConnected = true;
            AdjustControls();
            while (IsConnected)
            {
                if (socket.Poll(50000, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buffor = new byte[size];
                    socket.Receive(buffor);
                    string message = UTF8Encoding.UTF8.GetString(buffor);
                    LogAdd(message);
                }
            }
			
            IsConnected = false;
            AdjustControls();
            LogAdd("Disconnected");
            socket.Disconnect(false);

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            byte[] buffor = UTF8Encoding.UTF8.GetBytes(message);
            
            if (chkServer.Checked)
            
                LogAdd(message);
                lock (clients) foreach (Socket s in clients) s.Send(buffor);
            }
            else {
                client.Client.Send(buffor);
            }
            

        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = UInt16.TryParse(txtPort.Text, out port ) && (txtHost.Text.Trim().Length > 0 || chkServer.Checked);
            AdjustControls();
        }

        private void chkServer_CheckedChanged(object sender, EventArgs e)
        {
            txtHost.Enabled = !chkServer.Checked;
            txtPort_TextChanged(sender, e);
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            txtPort_TextChanged(sender, e);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                IsConnected = false;
            }
            else
            {
                if (chkServer.Checked)
                {
                    new Thread(ServerThread).Start();
                }
                else
                {
                    new Thread(ClientThread).Start();
                }
            }
            AdjustControls();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            AdjustControls();
        }
    }
}
