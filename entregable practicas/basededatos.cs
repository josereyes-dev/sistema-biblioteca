using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entregable_practicas
{
    public partial class basededatos : Form
    {
        public basededatos()
        {
            InitializeComponent();
            dataGridView3.DataSource = sql.mostrarlibros();
        }
        conectar sql = new conectar();

        private void basededatos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void buscarlibro_TextChanged(object sender, EventArgs e)
        {
            if (buscarlibro.Text != "")
            {
                dataGridView3.DataSource = sql.buscarlibro(buscarlibro.Text);
            }
            else
            {
                dataGridView3.DataSource = sql.mostrarlibros();
            }
        }
    }
}
