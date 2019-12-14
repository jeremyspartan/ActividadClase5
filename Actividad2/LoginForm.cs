using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void aceptarButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(usuarioTextBox.TextLength==0)
            {
                LoginErrorProvider.SetError(usuarioTextBox, "Debe ingresar el nombre de usuario");
            }
            if (contraseñaTextBox.TextLength == 0)
            {
                LoginErrorProvider.SetError(contraseñaTextBox, "Debe ingresar su contraseña");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelarButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {

        }

    }
}
