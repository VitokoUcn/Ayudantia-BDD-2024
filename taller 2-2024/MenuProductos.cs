using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static taller_2_2024.SesionActual;
using Taller2;
using MySql.Data.MySqlClient;

namespace taller_2_2024
{
    public partial class MenuProductos : Form
    {
        public MenuProductos()
        {
            InitializeComponent();
        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreProducto = Nombre.Text;
            int precioProducto = int.Parse(precio.Text);

            string query = "INSERT INTO producto (SucursalID, Nombre, Precio) VALUES (@codigo_sucursal, @nombre_producto, @precio)";

            MySqlParameter[] parameters = {
            new MySqlParameter("@codigo_sucursal",SesionActual.CodigoSucursal.ToString()),
            new MySqlParameter("@nombre_producto", nombreProducto),
            new MySqlParameter("@precio", precioProducto.ToString())
        };

            // Ejecuta la consulta
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);

            // Muestra un mensaje de éxito
            MessageBox.Show("Producto agregado exitosamente a la sucursal.");
        }
    }
}
