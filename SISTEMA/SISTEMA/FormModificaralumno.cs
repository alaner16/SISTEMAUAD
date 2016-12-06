using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class FormModificaralumno : Form
    {
        public FormModificaralumno()
        {
            InitializeComponent();
        }

        private void btn_regresar_alumno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmenu m = new Formmenu();
            m.Show();
        }
    }
}
