using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClientDemo
{
    public partial class TCPDemoForm : Form
    {
        private TcpClient tcpClient;
        private System.Timers.Timer timer;
        private int sec;

        public TCPDemoForm()
        {
            InitializeComponent();
            initializeDemo();
        }

        private void initializeDemo()
        {
            tbIP.Text = Properties.Settings.Default.IP;
            tbPort.Text = Properties.Settings.Default.Port.ToString();
            tbInterval.Text = Properties.Settings.Default.SleepInterval.ToString();
            tbReadtimeout.Text = Properties.Settings.Default.ReadTimeOut.ToString();
            rbr.Checked = true;
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimerElapsed;
        }

        private void OnTimerElapsed(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                lbStatus.Text = "Offline";
                lbStatus.ForeColor = Color.Brown;
                timer.Close();
                lbTimer.Text = "Connecting: 0";
            }
            else
            {
                sec++;
                lbTimer.Text = "Connecting: " + sec.ToString();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(tbIP.Text, Convert.ToInt32(tbPort.Text));
                if (tcpClient.Connected)
                {
                    lbStatus.Text = "Online";
                    lbStatus.ForeColor = Color.Green;
                    lbReceived.Text = tbIP.Text + ": " + tbPort.Text + " connect successed.";
                    sec = 0;
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                lbReceived.Text = ex.Message;
            }
            finally
            {
                UpdateSettings();
            }
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
                return;

            tcpClient.Close();

            lbStatus.Text = "Offline";
            lbStatus.ForeColor = Color.Brown;
            lbReceived.Text = "Connection closed.";
            timer.Close();
            sec = 0;
            lbTimer.Text = "Connecting: 0";
        }

        private void btnSendBt_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
                return;
            if (!tcpClient.Connected)
            {
                btnDiscon_Click(null, null);
                return;
            }

            string newstr = string.Empty;
            if(rbr.Checked)
                newstr=tbCMD.Text + "\r";
            else if(rbn.Checked)
                newstr = tbCMD.Text + "\n";
            else if(rbrn.Checked)
                newstr = tbCMD.Text + "\r\n";

            byte[] buffer = new byte[newstr.Length];
            buffer = System.Text.Encoding.ASCII.GetBytes(newstr);

            try
            {
                NetworkStream n = tcpClient.GetStream();
                n.ReadTimeout = Properties.Settings.Default.ReadTimeOut;
                n.Write(buffer, 0, buffer.Length);
                Thread.Sleep(Properties.Settings.Default.SleepInterval);
                byte[] buffer_read = new byte[1024];
                n.Read(buffer_read, 0, 1024);
                string str_read = System.Text.Encoding.ASCII.GetString(buffer_read);
                lbReceived.Text = str_read;
            }
            catch (Exception ex)
            {
                lbReceived.Text = ex.Message;
            }
        }

        private void btnSendStr_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
                return;
            if (!tcpClient.Connected)
            {
                btnDiscon_Click(null, null);
                return;
            }

            string newstr = string.Empty;
            if (rbr.Checked)
                newstr = tbCMD.Text + "\r";
            else if (rbn.Checked)
                newstr = tbCMD.Text + "\n";
            else if (rbrn.Checked)
                newstr = tbCMD.Text + "\r\n";

            try
            {
                NetworkStream n = tcpClient.GetStream();
                n.ReadTimeout = Properties.Settings.Default.ReadTimeOut;
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write(newstr);
                bw.Flush();
                Thread.Sleep(Properties.Settings.Default.SleepInterval);
                lbReceived.Text = new BinaryReader(n).ReadString();
            }
            catch (Exception ex)
            {
                lbReceived.Text = ex.Message;
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
                return;
            if (!tcpClient.Connected)
            {
                btnDiscon_Click(null, null);
                return;
            }

            string revicestr;
            byte[] buffer = new byte[1024];

            try
            {
                tcpClient.GetStream().ReadTimeout = Properties.Settings.Default.ReadTimeOut;
                tcpClient.GetStream().Read(buffer, 0, buffer.Length);
                revicestr = System.Text.Encoding.ASCII.GetString(buffer);

                lbReceived.Text = revicestr;
            }
            catch (Exception ex)
            {
                lbReceived.Text = ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbReceived.Text = String.Empty;
        }

        private void OnRadiobuttonChecked(object sender,EventArgs e)
        {
            if (rbr.Checked)
            {
                rbn.Checked = false;
                rbrn.Checked = false;
            }
            else if (rbn.Checked)
            {
                rbr.Checked = false;
                rbrn.Checked = false;
            }
            else if (rbrn.Checked)
            {
                rbr.Checked = false;
                rbn.Checked = false;
            }
        }

        private void UpdateSettings()
        {
            Properties.Settings.Default.IP = tbIP.Text;
            Properties.Settings.Default.Port = Convert.ToInt32(tbPort.Text);
            Properties.Settings.Default.SleepInterval = Convert.ToInt32(tbInterval.Text);
            Properties.Settings.Default.ReadTimeOut = Convert.ToInt32(tbReadtimeout.Text);
        }
    }
}
