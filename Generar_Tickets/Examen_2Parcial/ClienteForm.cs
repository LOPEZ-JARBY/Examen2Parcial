using DATOS;
using ENTIDADES;
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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }
        string operar;
        ClientesDB clientesDB = new ClientesDB();
        Cliente cliente;
        DataTable dt = new DataTable();
        private void HabilitarControles()
        {
            NombreClientetextBox.Enabled = true;
            IdentidadtextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            Modificarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Eliminarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;

        }

        private void DeshabilitarControles()
        {
            NombreClientetextBox.Enabled = false;
            IdentidadtextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            Modificarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = true;
            Eliminarbutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            NombreClientetextBox.Clear();
            IdentidadtextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            DirecciontextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            operar = "Nuevo";
            HabilitarControles();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (operar == "Nuevo")
            {
                if (string.IsNullOrEmpty(NombreClientetextBox.Text))
                {
                    errorProvider1.SetError(NombreClientetextBox, "Ingrese el nombre");
                    NombreClientetextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(IdentidadtextBox.Text))
                {
                    errorProvider1.SetError(IdentidadtextBox, "Ingrese su numero de identidad");
                    IdentidadtextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(TelefonotextBox.Text))
                {
                    errorProvider1.SetError(TelefonotextBox, "Ingrese su telefono");
                    TelefonotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreotextBox.Text))
                {
                    errorProvider1.SetError(CorreotextBox, "Ingrese su correo");
                    CorreotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DirecciontextBox.Text))
                {
                    errorProvider1.SetError(DirecciontextBox, "Ingrese la direccion");
                    DirecciontextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                cliente = new Cliente();
                cliente.NombreCliente = NombreClientetextBox.Text;
                cliente.Identidad = IdentidadtextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;

                //base de datos

                bool inserto = clientesDB.Insertar(cliente);

                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerClientes();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operar == "Modificar")
            {
                bool modifico = clientesDB.Editar(cliente);
                if (modifico)
                {
                    NombreClientetextBox.ReadOnly = false;
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerClientes();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puro actualizar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void TraerClientes()
        {
            dt = clientesDB.DevolverClientes();

            ClientesdataGridView.DataSource = dt;

        }
    }
}
