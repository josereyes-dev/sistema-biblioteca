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
    public partial class categorias : Form
    {
        public categorias()
        {
            InitializeComponent();
        }

        conectar sql = new conectar();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            txtcodcat.Text = Convert.ToString(fila.Cells[0].Value);
            txtnomcat.Text = Convert.ToString(fila.Cells[1].Value);

        }

        private void categorias_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.mostrardatos();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodcat.Text = dataGridView1.Rows.Count.ToString();
            if (sql.insertar(txtcodcat.Text, txtnomcat.Text))
            {
                MessageBox.Show("Datos insertados");
                dataGridView1.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }

            txtcodcat.Text = String.Empty;
            txtnomcat.Text = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sql.eliminar(txtcodcat.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView1.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
            txtcodcat.Text = String.Empty;
            txtnomcat.Text = String.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sql.actualizar(txtcodcat.Text, txtnomcat.Text))
            {
                MessageBox.Show("Datos actualizados");
                dataGridView1.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
            txtcodcat.Text = String.Empty;
            txtnomcat.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcodcat.Text = String.Empty;
            txtnomcat.Text = String.Empty;
        }

        private void txtbuscarcat_TextChanged(object sender, EventArgs e)
        {
            if(txtbuscarcat.Text != "")
            {
               dataGridView1.DataSource = sql.buscar(txtbuscarcat.Text);
            }
            else
            {
                dataGridView1.DataSource = sql.mostrardatos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new inicio();
            formulario.Show();
            this.Hide();
        }
    }
}
