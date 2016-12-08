using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SISTEMA
{
    public class MaestroDAL
    {
        public static List<Maestro> Buscar(string pNombre, string pApellido_pat)
        {
            List<Maestro> lista = new List<Maestro>();

            MySqlCommand comando = new MySqlCommand(String.Format(
             "SELECT id_maestro, Nombre, Apellido_pat,Apellido_Mat,Nss,Curp,Rfc, Dir_calle,Dir_num,Telefono FROM maestro where Nombre ='{0}' or Apellido_pat='{1}'", pNombre, pApellido_pat), BDComunJul.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Maestro pMaestro = new Maestro();
                pMaestro.id_maestro = reader.GetInt32(0);             
                pMaestro.Nombre = reader.GetString(1);
                pMaestro.Apellido_pat = reader.GetString(2);
                pMaestro.Apellido_mat = reader.GetString(3);
                pMaestro.Nss = reader.GetString(4);
                pMaestro.Curp = reader.GetString(5);
                pMaestro.Rfc = reader.GetString(6);
                pMaestro.Dir_calle = reader.GetString(7);
                pMaestro.Dir_num = reader.GetString(8);              
                pMaestro.Telefono = reader.GetString(9);


                lista.Add(pMaestro);
            }

            return lista;
        }

        public static List<Maestro> Buscar2(string pid_maestro)
        {
            List<Maestro> lista = new List<Maestro>();

            MySqlCommand comando = new MySqlCommand(String.Format(
             "SELECT id_maestro, Nombre, Apellido_pat,Apellido_Mat,Nss,Curp,Rfc, Dir_calle,Dir_num,Telefono FROM maestro where id_maestro ='{0}' ", pid_maestro), BDComunJul.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Maestro pMaestro = new Maestro();
                pMaestro.id_maestro = reader.GetInt32(0);
                pMaestro.Nombre = reader.GetString(1);
                pMaestro.Apellido_pat = reader.GetString(2);
                pMaestro.Apellido_mat = reader.GetString(3);
                pMaestro.Nss = reader.GetString(4);
                pMaestro.Curp = reader.GetString(5);
                pMaestro.Rfc = reader.GetString(6);
                pMaestro.Dir_calle = reader.GetString(7);
                pMaestro.Dir_num = reader.GetString(8);
                pMaestro.Telefono = reader.GetString(9);


                lista.Add(pMaestro);
            }

            return lista;
        }

        public static List<Maestro> Buscar3()
        {
            List<Maestro> lista = new List<Maestro>();

            MySqlCommand comando = new MySqlCommand(String.Format(
             "SELECT id_maestro, Nombre, Apellido_pat,Apellido_Mat,Nss,Curp,Rfc, Dir_calle,Dir_num,Telefono FROM maestro"), BDComunJul.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Maestro pMaestro = new Maestro();
                pMaestro.id_maestro = reader.GetInt32(0);
                pMaestro.Nombre = reader.GetString(1);
                pMaestro.Apellido_pat = reader.GetString(2);
                pMaestro.Apellido_mat = reader.GetString(3);
                pMaestro.Nss = reader.GetString(4);
                pMaestro.Curp = reader.GetString(5);
                pMaestro.Rfc = reader.GetString(6);
                pMaestro.Dir_calle = reader.GetString(7);
                pMaestro.Dir_num = reader.GetString(8);
                pMaestro.Telefono = reader.GetString(9);


                lista.Add(pMaestro);
            }

            return lista;
        }
    }
}
