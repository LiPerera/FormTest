using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace ConexionCSharpconMySQL
{
    public class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=192.168.0.113; database=tom_tst; Uid=tom_usr; pwd=hola123;");

            conectar.Open();
            return conectar;
        }
    }
}
