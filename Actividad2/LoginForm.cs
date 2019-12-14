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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void aceptarButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CancelarButton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
