using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace RedEye
{   
    /// <summary>
    /// just wanna see if this works lol
    /// </summary>
    public partial class Main : Form
    {
  
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //variable declarations
            //
            //
            string[] myPort;

            //Fill combo box w/ available port names
            myPort = SerialPort.GetPortNames();
            portBox.Items.AddRange(myPort);
            
           

           

        }

        public SerialPort sendSerialPort()
        {
            return serialPortx;
        }
        public void closeSerialPort()
        {
            serialPortx.Close();
        }

        private void btnPair_Click(object sender, EventArgs e)
        {   
            //sets port name if not default
            serialPortx.PortName = portBox.Text;
            
            //switches to form 2 (after pairing)
            Form2 form2 = new Form2(this);
            form2.Tag = this;
            form2.Show(this);
            Hide();
            
        }
    }
}
