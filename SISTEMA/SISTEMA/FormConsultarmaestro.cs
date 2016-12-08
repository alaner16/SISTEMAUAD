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
    public partial class FormConsultarmaestro : Form
    {
        public FormConsultarmaestro()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmenu m = new Formmenu();
            m.Show();
        }

        private void btn_Buscarid_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MaestroDAL.Buscar2(txt_Idmaestro.Text);
        }

        private void btn_Buscarnombr_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MaestroDAL.Buscar(txt_Nombremaestro.Text, txt_Idmaestro.Text);
        }

        private void btn_Buscartodo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MaestroDAL.Buscar3();
        }
    }
}
