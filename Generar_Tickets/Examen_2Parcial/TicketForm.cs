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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }
        String agregar;

        private void Nuevoticketbutton_Click(object sender, EventArgs e)
        {
            UsuariotextBox.Focus();
            HabilitarControles();
            agregar = "Nuevo ticket";

        }
        private void HabilitarControles()
        {
            FechatextBox.Enabled = true;
            UsuariotextBox.Enabled = true;
            ClientetextBox.Enabled = true;
            TipoSoportecomboBox.Enabled = true;
            DescripcionResptextBox.Enabled = true;
            DescripcionSolitextBox.Enabled = true;
            PreciotextBox.Enabled = true;
            ImpuestotextBox.Enabled = true;
            DescuentotextBox.Enabled = true;
            TotaltextBox.Enabled = true;
            Añadirticketbutton.Enabled = true;
            Cancelarticketbutton.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            FechatextBox.Enabled = false;
            UsuariotextBox.Enabled = false;
            ClientetextBox.Enabled = false;
            TipoSoportecomboBox.Enabled = false;
            DescripcionResptextBox.Enabled = false;
            DescripcionSolitextBox.Enabled = false;
            PreciotextBox.Enabled = false;
            ImpuestotextBox.Enabled = false;
            DescuentotextBox.Enabled = false;
            TotaltextBox.Enabled = false;
            Añadirticketbutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            FechatextBox.Clear();
            UsuariotextBox.Clear();
            ClientetextBox.Clear();
            TipoSoportecomboBox.Text = string.Empty;
            DescripcionResptextBox.Clear();
            DescripcionSolitextBox.Clear();
            PreciotextBox.Clear();
            ImpuestotextBox.Clear();
            DescuentotextBox.Clear();
            TotaltextBox.Clear();
        }

        private void Cancelarticketbutton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void Añadirticketbutton_Click(object sender, EventArgs e)
        {
            if (agregar == "Nuevo ticket")
            {
                if (string.IsNullOrEmpty(FechatextBox.Text))
                {
                    errorProvider1.SetError(FechatextBox, "Ingrese la fecha");
                    FechatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(UsuariotextBox.Text))
                {
                    errorProvider1.SetError(UsuariotextBox, "Ingrese el usuario");
                    UsuariotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ClientetextBox.Text))
                {
                    errorProvider1.SetError(ClientetextBox, "Ingrese el cliente");
                    ClientetextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PreciotextBox.Text))
                {
                    errorProvider1.SetError(PreciotextBox, "Ingrese el precio");
                    PreciotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DescuentotextBox.Text))
                {
                    errorProvider1.SetError(DescuentotextBox, "Ingrese el descuento");
                    DescuentotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                //revisar el impuesto
                if (string.IsNullOrEmpty(ImpuestotextBox.Text))
                {
                    errorProvider1.SetError(ImpuestotextBox, "Ingrese el impuesto");
                    ImpuestotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                //para que me genere el total
                if (string.IsNullOrEmpty(TotaltextBox.Text))
                {
                    errorProvider1.SetError(TotaltextBox, "Ingrese el total");
                    TotaltextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(TipoSoportecomboBox.Text))
                {
                    errorProvider1.SetError(TipoSoportecomboBox, "Ingrese el tipo de soporte");
                    TipoSoportecomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DescripcionSolitextBox.Text))
                {
                    errorProvider1.SetError(DescripcionSolitextBox, "Ingrese la descripcion de la solicitud");
                    DescripcionSolitextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(DescripcionResptextBox.Text))
                {
                    errorProvider1.SetError(DescripcionResptextBox, "Ingrese la respuesta");
                    DescripcionResptextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

            }
            else
            {

            }

        }
    }
}
