using Sis_monolitico.Models;
using Sis_monolitico.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_monolitico.Controllers
{
    public class LoginController
    {
        private LoginModel loginModel = new LoginModel();

        public void Login(string usuario, string contraseña, Form loginForm)
        {
            if (loginModel.ValidarUsuario(usuario, contraseña))
            {
                // Login correcto → Abrir FrmGroupChat
                FrmGroupChat groupChatForm = new FrmGroupChat();
                groupChatForm.Show();

                // Cerrar el formulario de login
                loginForm.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
