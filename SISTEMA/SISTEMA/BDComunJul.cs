using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SISTEMA
{
    public class BDComunJul
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=bd_escuela; Uid=root; pwd=1234;");

            conectar.Open();
            return conectar;
        }
    }
}
