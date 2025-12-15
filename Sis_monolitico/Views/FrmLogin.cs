using Sis_monolitico.Controllers;
using System.Windows.Forms;

namespace Sis_monolitico.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contraseña = txtPassword.Text;

            LoginController controller = new LoginController();
            controller.Login(usuario, contraseña, this);
        }
    }
}
