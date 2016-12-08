using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    public class Maestro
    {
        public int id_maestro { get; set; }
        public string Nombre { get; set; }
        public string Apellido_pat { get; set; }
        public string Apellido_mat { get; set; }
        public string Nss { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Dir_calle { get; set; }
        public string Dir_num { get; set; }
        public string Telefono { get; set; }

        public Maestro() { }
        public Maestro(int pid_maestro, string pNombre, string pApellido_pat, string pApellido_mat, string pNss,string pCurp,string pRfc, string pDir_calle, string pDir_num, string pTelefono)
        {
            this.id_maestro = pid_maestro;
            this.Nombre = pNombre;
            this.Apellido_pat = pApellido_pat;
            this.Apellido_mat = pApellido_mat;
            this.Nss = pNss;
            this.Curp = pCurp;
            this.Rfc = pRfc;
            this.Dir_calle = pDir_calle;
            this.Dir_num = pDir_num;
            this.Telefono = pTelefono;
        }
    }
}
