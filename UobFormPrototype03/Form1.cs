using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace UobFormPrototype03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sendPort = 8080;
        int listeningPort = 8082;


        private void Form1_Load(object sender, EventArgs e)
        {
            ServerControlPanel.Hide();
        }

        private void ServerSelectionPanel_Paint(object sender, PaintEventArgs e)
        {
            LoadServerList();
        }
        
        private void ServerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ServerDisplayTextBox.Text = ServerListView.SelectedItems[0].SubItems[1].Text;
            }
            catch { }
        }

        private void ProcessInformationListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProcessesTextBox.Text = ProcessInformationListView.SelectedItems[0].SubItems[1].Text;
            }
            catch { }
        }

        private void ServiceInformationListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ServicesTextBox.Text = ServiceInformationListView.SelectedItems[0].SubItems[1].Text;
            }
            catch { }
        }


        private void ServerControlPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServerControlPanel.SelectedIndex == 0)
            {
                OperatorAssistantTextBox.Text = "System Information tab. Displays server's system information.";
            }
            if (ServerControlPanel.SelectedIndex == 1)
            {
                OperatorAssistantTextBox.Text = "Processes tab. Control server's processes here.";
            }
            if (ServerControlPanel.SelectedIndex == 2)
            {
                OperatorAssistantTextBox.Text = "Services tab. Control server's services here.";
            }
        }

        bool Permission = false;
        bool Accessed = false;
        private void ServerAccessButton_Click(object sender, EventArgs e)
        {
            AccessServer();
            if (Accessed == true)
            {
                RequestApproval();
            }
            if (Permission == true)
            {
                ServerControlPanel.Show();
                ServerSelectionPanel.Hide();
                Accessed = false;
                Permission = false;
                OperatorAssistantTextBox.Text = "System Information tab. Displays server's system information.";
            }
            else
            {
                //MessageBox.Show("Access Denied");
            }
        }

        private void SystemInformationLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequestSystemInformation();
                LoadSystemInformation();
            }
            catch
            {
                MessageBox.Show("Server Busy, Please try in a few minutes.");
            }
            
        }

        private void SystemInformationBackButton_Click(object sender, EventArgs e)
        {
            ServerControlPanel.Hide();
            ServerSelectionPanel.Show();
        }

        private void ProcessesLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequestProcessInformation();
                if (Accessed == true)
                {
                    LoadProcessInformation();
                }
            }
            catch
            {
                MessageBox.Show("Server Busy, Please try in a few minutes.");
            }
        }

        private void ProcessesStopButton_Click(object sender, EventArgs e)
        {
            StopProcess();
            ProcessStopConfirmation();
            RequestProcessInformation();
            LoadProcessInformation();
        }

        private void ProcessBackButton_Click(object sender, EventArgs e)
        {
            ServerControlPanel.Hide();
            ServerSelectionPanel.Show();
        }

        private void ServicesLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequestServiceInformation();
                if (Accessed == true)
                {
                    LoadServiceInformation();
                }
            }
            catch
            {
                MessageBox.Show("Server Busy, Please try in a few minutes.");
            }
            
        }

        private void ServicesStopButton_Click(object sender, EventArgs e)
        {
            StopService();
            ServiceStopConfirmation();
            RequestServiceInformation();
            LoadServiceInformation();
        }

        private void ServicesStartButton_Click(object sender, EventArgs e)
        {
            StartService();
            ServiceStartConfirmation();
            RequestServiceInformation();
            LoadServiceInformation();
        }

        private void ServicesBackButton_Click(object sender, EventArgs e)
        {
            ServerControlPanel.Hide();
            ServerSelectionPanel.Show();
        }






        /**
         * ************************************************************************************************
         * ************************************************************************************************
         * ************************************************************************************************
         * 
         * Below are the list of functions(17 in total):
         * 
         *          From Menu Page:
         * 1)LoadServerList ---> Display all servers accessible for the opperator
         * 2)AccessServer   ---> Attempted connection from host to server, triggered when "Access" button is clicked
         * 3)RequestApproval---> Authentication of host to server
         * 
         *          From Server Control Page:
         *          
         *              Under System Information Tab:
         * 4)RequestSystemInformation---> Signal sent to server for system information
         * 5)LoadSystemInformation   ---> Displays system information on screen once data is recieved
         * 
         *              Under Process Information Tab:
         * 6)RequestProcessInformation--> Signal sent to server for process information
         * 7)LoadProcessInformation ----> Displays process informaton on screen once data is received
         * 8)StopProcess  --------------> Signal sent to server to stop specific process
         * 9)ProcessStopConfirmation ---> Signal received from server that selected process is stopped successfully
         * 
         *              Under Service Information Tab:
         * 10)RequestServiceInformation-> Signal sent to server for service information
         * 11)LoadServiceInformation ---> Displays service information on screen once data is received
         * 12)StopService --------------> Signal sent to server to stop specific service
         * 13)ServiceStopConfirmation --> Signal received from server that selected service is stopped successfully
         * 14)StartService -------------> Signal sent to server to start specific service
         * 15)ServiceStartConfirmation--> Signal received from server that selected service is started successfully
         *          
         *          
         *          
         *          Other helper functions:
         * A)AutoComplete-->Function that loads autocomplete for textboxes, based on their index on the list view
         * B)LoadColumns--->Function that loads the columns for different listviews, with their title and width
         * 
         * ************************************************************************************************
         * ************************************************************************************************
         * ************************************************************************************************
         * */

        private void LoadServerList()
        {
            OperatorAssistantTextBox.Text = "Server Selection. List of authorized servers displayed here. Select any server to access.";
            List<string> serverList = new List<string>
            {
                "localhost",
                "123.456.789",
                "123.456.789",
                "localhost",
                "LA130029.global.avaya.com"
            };

            LoadColumns(
                ServerListView,
                2,
                new List<string> { "Index", "Ip Address" },
                new List<int> { 40, 310 }
                );

            var i = 1;
            foreach (var server in serverList)
            {
                ListViewItem items = new ListViewItem(i.ToString());
                ServerListView.Items.Add(items);
                if (i % 2 == 0)
                {
                    items.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    items.BackColor = Color.LightGray;
                }
                i++;
                ListViewSubItem listViewSubItem = new ListViewSubItem
                {
                    Text = server.ToString()
                };
                ListViewSubItem subitems1 = listViewSubItem;
                items.SubItems.Add(subitems1);
            }

        }


        private void AccessServer()
        {
            try
            {
                TcpClient client = new TcpClient(ServerDisplayTextBox.Text.ToString(), sendPort);
                int byteCount = Encoding.ASCII.GetByteCount("Request Access" + 1);
                byte[] sendData = new byte[byteCount];

                sendData = Encoding.ASCII.GetBytes("Request Access" + ";");
                NetworkStream stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);
                Accessed = true;
                stream.Close();
                client.Close();


                /*
                UdpClient c = new UdpClient();
                c.Connect("LA130029.global.avaya.com", 12345);
                var dataToSend = Encoding.ASCII.GetBytes("Request Access||" + Dns.GetHostEntry("localhost").HostName);
                c.Send(dataToSend, dataToSend.Length);
                */
                

            }
            catch (Exception error)
            {
                Debug.WriteLine(error.ToString());
                Accessed = false;
                MessageBox.Show("Unregistered IP");
            }
        }

        private void RequestApproval()
        {
            Permission = false;
            IPAddress ip = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server = new TcpListener(ip, listeningPort);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                client = server.AcceptTcpClient();
                byte[] receivedBuffer = new byte[100];
                NetworkStream stream = client.GetStream();
                stream.ReadTimeout = 1000;
                stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                StringBuilder msg = new StringBuilder();
                foreach (byte b in receivedBuffer)
                {
                    if (b.Equals(59))
                    {
                        break;
                    }
                    else
                    {
                        msg.Append(Convert.ToChar(b).ToString());
                    }
                }

                if (msg.ToString() == "Approved")
                {
                    Permission = true;
                }
                else
                {
                    Permission = false;
                }
                server.Stop();

                break;
            }
        }

        private void RequestSystemInformation()
        {
            SystemInformationLoadButton.Text = "Loading...";
            SystemInformationLoadButton.Enabled = false;
            SystemInformationLoadButton.Text = "Reload System Information";
            string serverIP = ServerDisplayTextBox.Text.ToString();
            int port = sendPort;

            TcpClient client = new TcpClient(serverIP, port);
            int byteCount = Encoding.ASCII.GetByteCount("System Information" + 1);
            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes("System Information" + ";");
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
            stream.Close();
            client.Close();
        }

        private void LoadSystemInformation()
        {
            LoadColumns(
                SystemInformationListView, 
                3, 
                new List<string> { "Index", "Title", "Information" }, 
                new List<int> { 40, 200, 380 }
                );

            IPAddress ip2 = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server2 = new TcpListener(ip2, listeningPort);
            TcpClient client2 = default(TcpClient);
            try
            {
                server2.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
                NetworkStream stream2 = client2.GetStream();
                stream2.ReadTimeout = 1000;
                BinaryFormatter formatter = new BinaryFormatter();
                var clientList = (List<string>)formatter.Deserialize(stream2);
                var a = 0;
                if(clientList[0] == "No")
                {
                    MessageBox.Show("Server Busy, Please try in a few minutes.");
                    break;
                }
                for (var i = 1; i < clientList.Count; i++)
                {
                    if(i % 2 == 1)
                    {
                        ListViewItem items = new ListViewItem(((i / 2) + 1).ToString());
                        SystemInformationListView.Items.Add(items);
                        
                        if (a % 2 == 0)
                        {
                            items.BackColor = Color.LightGoldenrodYellow;
                        }
                        else
                        {
                            items.BackColor = Color.LightGray;
                        }
                        a++;
                        ListViewSubItem subitems1 = new ListViewSubItem
                        {
                            Text = clientList[i-1]
                        };
                        items.SubItems.Add(subitems1);
                        ListViewSubItem subitems2 = new ListViewSubItem
                        {
                            Text = clientList[i]
                        };
                        items.SubItems.Add(subitems2);
                    }
                }
                SystemInformationLoadButton.Enabled = true;
                server2.Stop();
                break;
            }
        }
        

        private void RequestProcessInformation()
        {
            ProcessesLoadButton.Text = "Loading...";
            ProcessesLoadButton.Enabled = false;
            ProcessesLoadButton.Text = "Refresh Processes";
            string serverIP = ServerDisplayTextBox.Text.ToString();
            int port = sendPort;

            TcpClient client = new TcpClient(serverIP, port);
            int byteCount = Encoding.ASCII.GetByteCount("Process Information" + 1);
            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes("Process Information" + ";");
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
            stream.Close();
            client.Close();
            Accessed = true;
        }

        private void LoadProcessInformation()
        {
            LoadColumns(
                ProcessInformationListView, 
                3, 
                new List<string> { "Index", "Process", "Responding" } , 
                new List<int> { 40, 250, 150 }
                );
            IPAddress ip2 = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server2 = new TcpListener(ip2, listeningPort);
            TcpClient client2 = default(TcpClient);
            try
            {
                server2.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
                NetworkStream stream2 = client2.GetStream();
                stream2.ReadTimeout = 1000;
                BinaryFormatter formatter = new BinaryFormatter();
                var processList = (List<string>)formatter.Deserialize(stream2);
                if (processList[0] == "No")
                {
                    MessageBox.Show("Server Busy, Please try in a few minutes.");
                    break;
                }
                var a = 0;
                for (var i = 1; i < processList.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        ListViewItem items = new ListViewItem(((i / 2) + 1).ToString());
                        ProcessInformationListView.Items.Add(items);
                        if (a % 2 == 0)
                        {
                            items.BackColor = Color.LightGoldenrodYellow;
                        }
                        else
                        {
                            items.BackColor = Color.LightGray;
                        }
                        a++;
                        ListViewSubItem subitems1 = new ListViewSubItem
                        {
                            Text = processList[i - 1]
                        };
                        items.SubItems.Add(subitems1);
                        ListViewSubItem subitems2 = new ListViewSubItem
                        {
                            Text = processList[i]
                        };
                        items.SubItems.Add(subitems2);
                    }
                }
                server2.Stop();
                break;
            }
            AutoComplete(ProcessInformationListView, 1 , ProcessesTextBox);
            Accessed = false;
            ProcessesLoadButton.Enabled = true;
        }


        private void StopProcess()
        {
            string serverIP = ServerDisplayTextBox.Text.ToString();
            int port = sendPort;

            TcpClient client = new TcpClient(serverIP, port);
            int byteCount = Encoding.ASCII.GetByteCount("Stop process " + ProcessesTextBox.Text + 1);
            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes("Stop process " + ProcessesTextBox.Text + ";");
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            stream.Close();
            client.Close();
        }

        private void ProcessStopConfirmation()
        {
            IPAddress ip2 = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server2 = new TcpListener(ip2, listeningPort);
            TcpClient client2 = default(TcpClient);

            try
            {
                server2.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
                NetworkStream stream2 = client2.GetStream();
                stream2.ReadTimeout = 1000;
                BinaryFormatter formatter = new BinaryFormatter();
                var confirmation = (List<string>)formatter.Deserialize(stream2);
                if(confirmation[0] == "Yes")
                {
                    MessageBox.Show(ProcessesTextBox.Text + " Stopped Successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to stop " + ProcessesTextBox.Text);
                }
                server2.Stop();
                break;
            }
        }
        
        private void RequestServiceInformation()
        {
            ServicesLoadButton.Text = "Loading...";
            ServicesLoadButton.Enabled = false;
            ServicesLoadButton.Text = "Refresh Services";
            string serverIP = ServerDisplayTextBox.Text.ToString();
            int port = sendPort;

            TcpClient client = new TcpClient(serverIP, port);
            int byteCount = Encoding.ASCII.GetByteCount("Service Information" + 1);
            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes("Service Information" + ";");
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
            stream.Close();
            client.Close();
            Accessed = true;
        }

        private void LoadServiceInformation()
        {
            LoadColumns(
                ServiceInformationListView, 3, new List<string> { "Index", "Service", "Status" }, new List<int> { 40, 250, 150 }
                );
            IPAddress ip2 = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server2 = new TcpListener(ip2, listeningPort);
            TcpClient client2 = default(TcpClient);
            try
            {
                server2.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
                NetworkStream stream2 = client2.GetStream();
                stream2.ReadTimeout = 1000;
                BinaryFormatter formatter = new BinaryFormatter();
                var serviceList = (List<string>)formatter.Deserialize(stream2);
                if (serviceList[0] == "No")
                {
                    MessageBox.Show("Server Busy, Please try in a few minutes.");
                    break;
                }
                var a = 0;
                for (var i = 1; i < serviceList.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        ListViewItem items = new ListViewItem(((i / 2) + 1).ToString());
                        ServiceInformationListView.Items.Add(items);
                        if (a % 2 == 0)
                        {
                            items.BackColor = Color.LightGoldenrodYellow;
                        }
                        else
                        {
                            items.BackColor = Color.LightGray;
                        }
                        a++;
                        ListViewSubItem subitems1 = new ListViewSubItem
                        {
                            Text = serviceList[i - 1]
                        };
                        items.SubItems.Add(subitems1);
                        ListViewSubItem subitems2 = new ListViewSubItem
                        {
                            Text = serviceList[i]
                        };
                        items.SubItems.Add(subitems2);
                    }
                }
                server2.Stop();
                break;
            }
            AutoComplete(ServiceInformationListView , 1, ServicesTextBox);
            Accessed = false;
            ServicesLoadButton.Enabled = true;
        }

        private void StopService()
        {
            string serverIP = ServerDisplayTextBox.Text.ToString();
            int port = sendPort;

            TcpClient client = new TcpClient(serverIP, port);
            int byteCount = Encoding.ASCII.GetByteCount("Stop service " + ServicesTextBox.Text + 1);
            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes("Stop service " + ServicesTextBox.Text + ";");
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            stream.Close();
            client.Close();
        }

        private void ServiceStopConfirmation()
        {
            IPAddress ip2 = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server2 = new TcpListener(ip2, listeningPort);
            TcpClient client2 = default(TcpClient);

            try
            {
                server2.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
                NetworkStream stream2 = client2.GetStream();
                BinaryFormatter formatter = new BinaryFormatter();
                var confirmation = (List<string>)formatter.Deserialize(stream2);
                if (confirmation[0] == "Yes")
                {
                    MessageBox.Show(ServicesTextBox.Text + " Stopped Successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to stop " + ServicesTextBox.Text);
                }
                server2.Stop();
                break;
            }
        }

        private void StartService()
        {
            string serverIP = ServerDisplayTextBox.Text.ToString();
            int port = sendPort;

            TcpClient client = new TcpClient(serverIP, port);
            int byteCount = Encoding.ASCII.GetByteCount("Start service " + ServicesTextBox.Text + 1);
            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes("Start service " + ServicesTextBox.Text + ";");
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            stream.Close();
            client.Close();
        }

        private void ServiceStartConfirmation()
        {
            IPAddress ip2 = Dns.GetHostEntry(ServerDisplayTextBox.Text.ToString()).AddressList[0];
            TcpListener server2 = new TcpListener(ip2, listeningPort);
            TcpClient client2 = default(TcpClient);
            try
            {
                server2.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            DateTime start = DateTime.Now;
            while (DateTime.Now.Subtract(start).Seconds < 10)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
                NetworkStream stream2 = client2.GetStream();
                BinaryFormatter formatter = new BinaryFormatter();
                var confirmation = (List<string>)formatter.Deserialize(stream2);
                if (confirmation[0] == "Yes")
                {
                    MessageBox.Show(ServicesTextBox.Text + " Started Successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to stop " + ServicesTextBox.Text);
                }
                server2.Stop();
                break;
            }
        }

        private void AutoComplete(ListView list, int index, TextBox textbox)
        {
            var sourceList = new AutoCompleteStringCollection();
            foreach (ListViewItem items in list.Items)
            {
                sourceList.Add(items.SubItems[index].Text.ToString());
            }
            textbox.AutoCompleteCustomSource = sourceList;
        }


        private void LoadColumns(ListView list, int noOfColumns, List<string> colNames, List<int> colWidth)
        {
            list.Clear();
            if (noOfColumns == 2)
            {
                ColumnHeader columnHeader1 = new ColumnHeader();
                ColumnHeader columnHeader2 = new ColumnHeader();
                columnHeader1.Text = colNames[0];
                columnHeader2.Text = colNames[1];
                list.Columns.Add(columnHeader1);
                list.Columns.Add(columnHeader2);
                columnHeader1.Width = colWidth[0];
                columnHeader2.Width = colWidth[1];
                columnHeader1.TextAlign = HorizontalAlignment.Right;
            }
            if (noOfColumns == 3)
            {
                ColumnHeader columnHeader1 = new ColumnHeader();
                ColumnHeader columnHeader2 = new ColumnHeader();
                ColumnHeader columnHeader3 = new ColumnHeader();
                columnHeader1.Text = colNames[0];
                columnHeader2.Text = colNames[1];
                columnHeader3.Text = colNames[2];
                list.Columns.Add(columnHeader1);
                list.Columns.Add(columnHeader2);
                list.Columns.Add(columnHeader3);
                columnHeader1.Width = colWidth[0];
                columnHeader2.Width = colWidth[1];
                columnHeader3.Width = colWidth[2];
                columnHeader1.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void ServerListRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
