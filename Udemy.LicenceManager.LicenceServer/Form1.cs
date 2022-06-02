using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WatsonTcp;



namespace Udemy.LicenceManager.LicenceServer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        WatsonTcpServer server;
        List<Client> clients = new List<Client>();
        public Form1()
        {
            InitializeComponent();
            server = new WatsonTcpServer("192.168.1.105", 148);
            server.Events.ClientConnected += Client_Connected;
            server.Events.ClientDisconnected += Client_Disconnected;
            server.Events.MessageReceived += Message_Received;
            gridControl1.DataSource = clients;
            



        }

        private void Message_Received(object sender, MessageReceivedEventArgs e)
        {
            MessageBox.Show(Encoding.UTF8.GetString(e.Data));
        }

        private void Client_Disconnected(object sender, DisconnectionEventArgs e)
        {
            var disconnectedClient = clients.SingleOrDefault(c => c.IpAdress == e.IpPort);
            clients.Remove(disconnectedClient);
            gridView1.RefreshData();

        }

        private void Client_Connected(object sender, ConnectionEventArgs e)
        {
            clients.Add(new Client
            {
                IpAdress = e.IpPort,
                Time = DateTime.Now
            });
            gridView1.RefreshData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            server.Start();
        }
    }
}
