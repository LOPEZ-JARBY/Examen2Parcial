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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            if(UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox,("Ingrese un usuario"));
                UsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(PasswordtextBox.Text))
            {
                errorProvider1.SetError(PasswordtextBox, "Ingrese una contraseña");
                PasswordtextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //validar en la base de datos

            //mostrar menu
            MenuForm menu = new MenuForm();
            Hide();
            menu.ShowDialog();

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarPasswordbutton_Click(object sender, EventArgs e)
        {
            if (PasswordtextBox.PasswordChar == '*')
            {
                PasswordtextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordtextBox.PasswordChar = '*';
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
