using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_2Parcial
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        String Generar;

        private void button3_Click(object sender, EventArgs e)
        {
            CodigoUsuariotextBox.Focus();
            HabilitarControles();
            Generar = "Nuevo";

        }
        private void HabilitarControles()
        {
            CodigoUsuariotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            RolcomboBox.Enabled = true;
            FechatextBox.Enabled = true;
            LugarMantextBox.Enabled = true;
            Generarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            CodigoUsuariotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            RolcomboBox.Enabled = false;
            FechatextBox.Enabled = false;
            LugarMantextBox.Enabled = false;
            Generarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoUsuariotextBox.Clear();
            NombretextBox.Clear();
            CorreotextBox.Clear();
            RolcomboBox.Text = "";
            FechatextBox.Clear();
            LugarMantextBox.Clear();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();

        }

        private void Generarbutton_Click(object sender, EventArgs e)
        {
            if (Generar == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoUsuariotextBox.Text))
                {
                    errorProvider1.SetError(CodigoUsuariotextBox, "Su Codigo es obligatorio");
                    CodigoUsuariotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreotextBox.Text))
                {
                    errorProvider1.SetError(CorreotextBox, "Su correo es obligatorio");
                    CorreotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolcomboBox.Text))
                {
                    errorProvider1.SetError(RolcomboBox, "Su rol es obligatorio");
                    RolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(FechatextBox.Text))
                {
                    errorProvider1.SetError(FechatextBox, "La fecha es obligatoria");
                    FechatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(LugarMantextBox.Text))
                {
                    errorProvider1.SetError(LugarMantextBox, "El lugar es obligatorio");
                    LugarMantextBox.Focus();
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
