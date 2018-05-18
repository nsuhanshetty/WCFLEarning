using BusinessServiceContracts;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace InternalClient
{
    public partial class Form1 : Form
    {

        IServiceA m_proxyA;
        IAdmin m_proxyAdminA;

        IServiceB m_proxyB;
        IAdmin m_proxyAdminB;

        public Form1()
        {
            InitializeComponent();

            ChannelFactory<IServiceA> factoryA = new ChannelFactory<IServiceA>("");
            m_proxyA = factoryA.CreateChannel();

            ChannelFactory<IAdmin> factoryAAdmin = new ChannelFactory<IAdmin>("TCP_IAdmin");
            m_proxyAdminA = factoryAAdmin.CreateChannel();

            ChannelFactory<IServiceB> factoryB = new ChannelFactory<IServiceB>("");
            m_proxyB = factoryB.CreateChannel();

            ChannelFactory<IAdmin> factoryBAdmin = new ChannelFactory<IAdmin>("IPC_IAdmin");
            m_proxyAdminB = factoryBAdmin.CreateChannel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = m_proxyAdminA.AdminOperation1();
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = m_proxyAdminA.AdminOperation2();
            MessageBox.Show(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = m_proxyAdminB.AdminOperation1();
            MessageBox.Show(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = m_proxyAdminB.AdminOperation2();
            MessageBox.Show(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = m_proxyA.Operation1();
            MessageBox.Show(s);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = m_proxyA.Operation2();
            MessageBox.Show(s);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = m_proxyB.Operation3();
            MessageBox.Show(s);
        }

        private void CloseProxy(ICommunicationObject proxy)
        {
            try
            {
                if (proxy != null)
                {
                    proxy.Close();
                }
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProxy(m_proxyA as ICommunicationObject);
            CloseProxy(m_proxyB as ICommunicationObject);
            CloseProxy(m_proxyAdminA as ICommunicationObject);
            CloseProxy(m_proxyAdminB as ICommunicationObject);
        }
    }
}
