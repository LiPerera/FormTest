using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConexionCSharpconMySQL
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            BdComun.ObtenerConexion();
            MessageBox.Show("Uju....¡¡¡¡Ya entro!!!!");
        }
    }
}
