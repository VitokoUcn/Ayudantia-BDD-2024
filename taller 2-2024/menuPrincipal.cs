using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_2_2024
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            MenuProductos menuProductos = new MenuProductos();
            menuProductos.Show(this);
          
        }
    }
}
