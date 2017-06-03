using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedEye
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Main _parentForm = null;
        public Form2(Main parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            serialPorty = _parentForm.sendSerialPort();
            _parentForm.closeSerialPort();
            serialPorty.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPorty.Write(txtInput.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.Close();
            Close();
        }
    }
}
