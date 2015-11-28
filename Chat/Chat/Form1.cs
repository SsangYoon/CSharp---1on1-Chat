using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using Microsoft.Win32;

namespace Chat
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private TcpClient serverClient, client;
        private NetworkStream myStream;
        private StreamReader myRead;
        private StreamWriter myWrite;
        private Boolean start = false;
        private Boolean clientConnect = false;
        private string myName;
        private int myPort;
        private Thread myReader, myServer;

        private RegistryKey key = Registry.LocalMachine.OpenSubKey
            ("SOFTWARE\\Microsoft\\.NETFramework", true);

        private delegate void AddTextDelegate(string strText);
        private AddTextDelegate AddText = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((string)key.GetValue("Message_name") == "")
            {
                this.myName = this.txtID.Text;
                this.myPort = Convert.ToInt32(this.txtPort.Text);
            }
            else
            {
                try
                {
                    this.myName = (string)key.GetValue("Message_name");
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port"));
                }
                catch
                {
                    this.myName = this.txtID.Text;
                    this.myPort = Convert.ToInt32(this.txtPort.Text);
                }
            }

        }
 
        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.설정ToolStripMenuItem.Enabled = false;
            this.plOption.Visible = true;
            this.txtID.Focus();
            this.txtID.Text = (string)key.GetValue("Message_name");
            this.txtPort.Text = (string)key.GetValue("Message_port");
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlCheck()
        {
            if(this.txtID.Text == "")
            {
                this.txtID.Focus();
            }
            else if(this.txtPort.Text == "")
            {
                this.txtPort.Focus();
            }
            else
            {
                try
                {
                    var name = this.txtID.Text;
                    var port = this.txtPort.Text;
                    key.SetValue("Message_name", name);
                    key.SetValue("Message_port", port);
                    this.plOption.Visible = false;
                    this.설정ToolStripMenuItem.Enabled = true;
                    this.tsbtnConnect.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("설정이 저장되지 않았습니다", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cbServer.Checked == true)
            {
                ControlCheck();
            }
            else
            {
                if (this.txtIP.Text == "")
                {
                    this.txtIP.Focus();
                }
                else
                {
                    ControlCheck();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.설정ToolStripMenuItem.Enabled = true;
            this.plOption.Visible = false;
            this.txtMessage.Focus();
        }

        private void cbServer_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbServer.Checked)
            {
                this.txtIP.Enabled = false;
            }
            else
            {
                this.txtIP.Enabled = true;
            }
        }

        private void tsbtnConnect_Click(object sender, EventArgs e)
        {
            AddText = new AddTextDelegate(MessageView);
            if(this.cbServer.Checked == true)
            {
                var addr = new IPAddress(0);
                try
                {
                    this.myName = (string)key.GetValue("Message_name");
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port"));
                }
                catch
                {
                    this.myName = this.txtID.Text;
                    this.myPort = Convert.ToInt32(this.txtPort.Text);
                }

                if (!(this.start))
                {
                    try
                    {
                        server = new TcpListener(addr, this.myPort);
                        server.Start();

                        this.start = true;
                        this.txtMessage.Enabled = true;
                        this.btnSend.Enabled = true;
                        this.txtMessage.Focus();
                        this.tsbtnDisconnect.Enabled = true;
                        this.tsbtnConnect.Enabled = false;
                        this.cbServer.Enabled = false;

                        // ServerStart() : Custom Method
                        myServer = new Thread(ServerStart);
                        myServer.Start();
                    }
                    catch
                    {
                        Invoke(AddText, "서버를 실행할 수 없습니다");
                    }
                }
                else
                {
                    // ServerStop() : Custom Method
                    ServerStop();
                }
            }
            else
            {
                if(!(this.clientConnect))
                {
                    this.myName = (string)key.GetValue("Message_name");
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port"));

                    // ClientConnection() : Custom Method
                    ClientConnection();
                }
            }
        }
        private void Receive()
        {
            try
            {
                while (this.clientConnect)
                {
                    if (myStream.CanRead)
                    {
                        var msg = myRead.ReadLine();
                        var Smsg = msg.Split('&');

                        if (msg.Length > 0)
                        {
                            Invoke(AddText, Smsg[0] + " : " + Smsg[1]);
                        }
                        this.tsslblTime.Text = "마지막으로 받은 시각 : " + Smsg[2];
                    }
                }
            }
            catch
            { }
        }

        private void MessageView(string strText)
        {
            this.rtbText.Text = this.rtbText.Text + strText + "\r\n";
            this.rtbText.Focus();
            this.rtbText.ScrollToCaret();
            this.txtMessage.Focus();
        }

        private void ServerStart()
        {
            Invoke(AddText, "서버 시행 : 채팅 상대의 접속을 기다립니다...");
            while(start)
            {
                try
                {
                    serverClient = server.AcceptTcpClient();
                    Invoke(AddText, "채팅 상대 접속...");
                    myStream = serverClient.GetStream();

                    myRead = new StreamReader(myStream);
                    myWrite = new StreamWriter(myStream);
                    this.clientConnect = true;

                    // Receive() : Custom Method
                    myReader = new Thread(Receive);
                    myReader.Start();
                }
                catch   // Empty
                { }
            }
        }

        private void ClientConnection()
        {
            try
            {
                client = new TcpClient(this.txtIP.Text, this.myPort);
                Invoke(AddText, "서버에 접속했습니다");
                myStream = client.GetStream();

                myRead = new StreamReader(myStream);
                myWrite = new StreamWriter(myStream);
                this.clientConnect = true;
                this.tsbtnConnect.Enabled = false;
                this.tsbtnDisconnect.Enabled = true;
                this.txtMessage.Enabled = true;
                this.btnSend.Enabled = true;
                this.txtMessage.Focus();

                myReader = new Thread(Receive);
                myReader.Start();
            }
            catch
            {
                this.clientConnect = false;
                Invoke(AddText, "서버에 접속하지 못했습니다");
            }
        }
        

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(this.txtMessage.Text == "")
            {
                this.txtMessage.Focus();
            }
            else
            {
                Msg_send();
            }
        }

        private void Msg_send()
        {
            try
            {
                var dt = Convert.ToString(DateTime.Now);
                myWrite.WriteLine(this.myName + "&" + this.txtMessage.Text + "&" + dt);
                myWrite.Flush();

                MessageView(this.myName + " : " + this.txtMessage.Text);
                this.txtMessage.Clear();
            }
            catch
            {
                Invoke(AddText, "데이터를 보내는 동안 오류가 발생하였습니다");
                this.txtMessage.Clear();
            }
        }

        private void tsbtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbServer.Checked)
                {
                    if (this.serverClient.Connected)
                    {
                        var dt = Convert.ToString(DateTime.Now);
                        myWrite.WriteLine(this.myName + "&" + "채팅 APP이 종료되었습니다" + "&" + dt);
                        myWrite.Flush();
                    }
                }
                else
                {
                    if (this.client.Connected)
                    {
                        var dt = Convert.ToString(DateTime.Now);
                        myWrite.WriteLine(this.myName + "&" + "채팅 APP이 종료되었습니다" + "&" + dt);
                        myWrite.Flush();
                    }
                }
            }
            catch
            { }
            ServerStop();
            this.설정ToolStripMenuItem.Enabled = true;
        }

        private void ServerStop()
        {
            this.start = false;
            this.txtMessage.Enabled = false;
            this.txtMessage.Clear();
            this.btnSend.Enabled = false;
            this.tsbtnConnect.Enabled = true;
            this.tsbtnDisconnect.Enabled = false;
            this.cbServer.Enabled = true;
            this.clientConnect = false;

            if(!(myRead == null))
            {
                myRead.Close();
            }
            if(!(myWrite == null))
            {
                myWrite.Close();
            }
            if(!(myStream == null))
            {
                myStream.Close();
            }
            if (!(serverClient == null))
            {
                serverClient.Close();
            }
            if(!(server == null))
            {
                server.Stop();
            }
            if(!(myReader == null))
            {
                myReader.Abort();
            }
            if (!(myServer == null))
            {
                myServer.Abort();
            }
            if (!(myServer == null))
            {
                myServer.Abort();
            }
            if(!(AddText == null))
            {
                Invoke(AddText, "연결이 끊어졌습니다");
            }
        }

        private void Disconnection()
        {
            this.clientConnect = false;
            try
            {
                if (!(myRead == null))
                {
                    myRead.Close();
                }
                if (!(myWrite == null))
                {
                    myWrite.Close();
                }
                if (!(myStream == null))
                {
                    myStream.Close();
                }
                if(!(client == null))
                {
                    client.Close();
                }
                if(!(myReader == null))
                {
                    myReader.Abort();
                }
            }
            catch
            {
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ServerStop();   
            }
            catch
            {
                Disconnection();
            }
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
                if(this.txtMessage.Text =="")
                {
                    this.txtMessage.Focus();
                }
                else
                {
                    Msg_send();
                }
            }
        }


    }
}
