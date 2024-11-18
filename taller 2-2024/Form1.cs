using MySql.Data.MySqlClient;
using Taller2;

namespace taller_2_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarTrabajador(nameBox.Text, passBox.Text))
            {
                int codigoSucursal = ObtenerCodigoSucursal(nameBox.Text, passBox.Text);
                SesionActual.CodigoSucursal = codigoSucursal;

                menuPrincipal menu = new menuPrincipal();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intente nuevamente");
            }

            
        }
        private bool ValidarTrabajador(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM trabajador WHERE nombre = @nombre AND contraseña = @contraseña";
            string[] parameters = {
        "@nombre", username,
        "@contraseña", password
            };

            string result = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);

            // Convertir el resultado a entero y verificar si es mayor que 0
            return int.TryParse(result, out int count) && count > 0;
        }
        private int ObtenerCodigoSucursal(string username, string password)
        {
            string query = "SELECT sucursalID FROM trabajador WHERE nombre = @nombre AND contraseña = @contraseña";
            string[] parameters = { "@nombre", username, "@contraseña", password };

            string result = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);

            // Si la consulta devuelve un valor válido, lo convierte a entero y lo devuelve
            if (int.TryParse(result, out int codigoSucursal))
            {
                return codigoSucursal;
            }

            // Retorna -1 si las credenciales no son válidas o no se obtuvo ningún resultado
            return -1;
        }



    }
}
