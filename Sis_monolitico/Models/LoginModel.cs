using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_monolitico.Models
{
    public class LoginModel
    {
        private string connectionString = "Server=localhost;Database=LoginDb;Integrated Security=True;TrustServerCertificate=True;";

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            bool esValido = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Usuarios WHERE Usuario = @Usuario AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Password", contraseña);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    esValido = true;
                }
            }

            return esValido;
        }
    }
}
