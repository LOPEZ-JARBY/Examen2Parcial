using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2Parcial
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.MdiParent= this;
            ticketForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.MdiParent = this;
            ticketForm.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarios = new UsuariosForm();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void ClientestoolStripButton_Click(object sender, EventArgs e)
        {
            ClienteForm clientes = new ClienteForm();
            clientes.MdiParent = this;
            clientes.Show();

        }
    }
}
