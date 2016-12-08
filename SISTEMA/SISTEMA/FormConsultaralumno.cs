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
    public partial class FormConsultaralumno : Form
    {
        public FormConsultaralumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmenu m = new Formmenu();
            m.Show();
        }

        private void btn_Buscarcuenta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoDAL.Buscar2(txt_Cuenta.Text);
        }

        private void btn_Buscarnombre_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoDAL.Buscar(txt_Nombre.Text, txt_Apellido.Text);
        }
    }
}
