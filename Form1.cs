using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Cliente_Forms : Form
    {
        public Cliente_Forms()
        {
            InitializeComponent();
        }
        SimpleTcpClient Client;
        private void Cliente_Forms_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
        }

        private void Btn_Conecatar_Click(object sender, EventArgs e)
        {
            Client.Connect(txtIP.Text, Convert.ToInt32(txtPuerto.Text));
        }
        

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            Client.WriteLineAndGetReply("Apagar", TimeSpan.FromSeconds(1));
        }

        private void Btn_Encender_Click(object sender, EventArgs e)
        {
            Client.WriteLineAndGetReply("Encender", TimeSpan.FromSeconds(1));
        }
    }
}
