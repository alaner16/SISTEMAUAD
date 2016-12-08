using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    public class Alumno
    {
        public int id_alumno { get; set; }
        public string No_cuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido_pat { get; set; }
        public string Apellido_mat { get; set; }
        public string Dir_calle { get; set; }
        public string Dir_num { get; set; }
        public string Dir_col { get; set; }
        public string Telefono { get; set; }

        public Alumno() { }
        public Alumno(int pid_alumno, string pNo_cuenta, string pNombre, string pApellido_pat, string pApellido_mat, string pDir_calle, string pDir_num, string pDir_col, string pTelefono)
        {
            this.id_alumno = pid_alumno;
            this.No_cuenta = pNo_cuenta;
            this.Nombre = pNombre;
            this.Apellido_pat = pApellido_pat;
            this.Apellido_mat = pApellido_mat;
            this.Dir_calle = pDir_calle;
            this.Dir_num = pDir_num;
            this.Dir_col = pDir_col;
            this.Telefono = pTelefono;
        }
    }
}
