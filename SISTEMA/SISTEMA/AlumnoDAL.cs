using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SISTEMA
{
    public class AlumnoDAL
    {
        public static List<Alumno> Buscar(string pNombre, string pApellido_pat)
        {
            List<Alumno> lista = new List<Alumno>();

            MySqlCommand comando = new MySqlCommand(String.Format(
             "SELECT id_alumno,No_cuenta, Nombre, Apellido_pat,Apellido_Mat, Dir_calle,Dir_num,Dir_col,Telefono FROM alumno where Nombre ='{0}' or Apellido_pat='{1}'", pNombre, pApellido_pat), BDComunJul.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Alumno pAlumno = new Alumno();
                pAlumno.id_alumno = reader.GetInt32(0);
                pAlumno.No_cuenta = reader.GetString(1);
                pAlumno.Nombre = reader.GetString(2);
                pAlumno.Apellido_pat = reader.GetString(3);
                pAlumno.Apellido_mat = reader.GetString(4);
                pAlumno.Dir_calle = reader.GetString(5);
                pAlumno.Dir_num = reader.GetString(6);
                pAlumno.Dir_col = reader.GetString(7);
                pAlumno.Telefono = reader.GetString(8);


                lista.Add(pAlumno);
            }

            return lista;
        }


        public static List<Alumno> Buscar2(string pNo_cuenta)
        {
            List<Alumno> lista = new List<Alumno>();

            MySqlCommand comando = new MySqlCommand(String.Format(
             "SELECT id_alumno,No_cuenta, Nombre, Apellido_pat,Apellido_Mat, Dir_calle,Dir_num,Dir_col,Telefono FROM alumno where No_cuenta ='{0}'", pNo_cuenta), BDComunJul.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Alumno pAlumno = new Alumno();
                pAlumno.id_alumno = reader.GetInt32(0);
                pAlumno.No_cuenta = reader.GetString(1);
                pAlumno.Nombre = reader.GetString(2);
                pAlumno.Apellido_pat = reader.GetString(3);
                pAlumno.Apellido_mat = reader.GetString(4);
                pAlumno.Dir_calle = reader.GetString(5);
                pAlumno.Dir_num = reader.GetString(6);
                pAlumno.Dir_col = reader.GetString(7);
                pAlumno.Telefono = reader.GetString(8);


                lista.Add(pAlumno);
            }

            return lista;
        }

        public static List<Alumno> Buscar3()
        {
            List<Alumno> lista = new List<Alumno>();

            MySqlCommand comando = new MySqlCommand(String.Format(
             "SELECT id_alumno,No_cuenta, Nombre, Apellido_pat,Apellido_Mat, Dir_calle,Dir_num,Dir_col,Telefono FROM alumno"), BDComunJul.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                Alumno pAlumno = new Alumno();
                pAlumno.id_alumno = reader.GetInt32(0);
                pAlumno.No_cuenta = reader.GetString(1);
                pAlumno.Nombre = reader.GetString(2);
                pAlumno.Apellido_pat = reader.GetString(3);
                pAlumno.Apellido_mat = reader.GetString(4);
                pAlumno.Dir_calle = reader.GetString(5);
                pAlumno.Dir_num = reader.GetString(6);
                pAlumno.Dir_col = reader.GetString(7);
                pAlumno.Telefono = reader.GetString(8);


                lista.Add(pAlumno);
            }

            return lista;
        }
    }
}
