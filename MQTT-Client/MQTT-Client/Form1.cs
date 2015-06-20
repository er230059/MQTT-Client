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
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Client
{
    public partial class Form1 : Form
    {
        private delegate void myUICallBack(string myStr, TextBox ctl);
        static MqttClient client;
        private void myUI(string myStr, TextBox ctl)
        {
            if (this.InvokeRequired)
            {
                myUICallBack myUpdate = new myUICallBack(myUI);
                this.Invoke(myUpdate, myStr, ctl);
            }
            else
            {
                ctl.AppendText(myStr + Environment.NewLine);
            }
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            myUI(System.Text.Encoding.UTF8.GetString(e.Message), MessageTextBox);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.IsConnected) client.Disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SendMessageTextBox.Text.Length == 0)
            {
                label4.Text = "No message to send";
            }
            else
            {
                label4.Text = "";
                client.Publish(TopicTextBox.Text, Encoding.UTF8.GetBytes(SendMessageTextBox.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HostTextBox.Text.Length == 0)
            {
                label4.Text = "Invild host";
            }
            else if (TopicTextBox.Text.Length == 0)
            {
                label4.Text = "You need have topic to subscribe";
            }
            else
            {
                try
                {
                    client = new MqttClient(HostTextBox.Text);
                    client.Connect(Guid.NewGuid().ToString());
                    client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(client_MqttMsgPublishReceived);
                }
                catch
                {
                    label4.Text = "Can't connect to server";
                }
                if (client != null && client.IsConnected)
                {
                    label4.Text = "";
                    client.Subscribe(new string[] { TopicTextBox.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    button1.Enabled = true;
                    button2.Enabled = false;
                    HostTextBox.Enabled = false;
                    TopicTextBox.Enabled = false;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageTextBox.Clear();
        }
    }
}
