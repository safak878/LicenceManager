using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WatsonTcp;


namespace Udemy.LicenceManager.TCPClient
{
    public class TCPClient
    {
        private WatsonTcpClient client;


        public TCPClient()
        {
            client = new WatsonTcpClient("192.168.1.105", 148);
            client.Events.MessageReceived += Message_Received;
            //client.Start();
                }
        private void Message_Received(object sender, MessageReceivedEventArgs e)
        {
            MessageBox.Show(Encoding.UTF8.GetString(e.Data));

        }
    }
}
