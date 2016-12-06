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
    public partial class FormAgregarMaestro : Form
    {
        public FormAgregarMaestro()
        {
            InitializeComponent();
        }

        private void FormAgregarMaestro_Load(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formmenu m = new Formmenu();
            m.Show();

        }
    }
}
