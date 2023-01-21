using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entregable_practicas;
using System.Data;
using System.Data.SqlClient;



namespace entregable_practicas
{
    public partial class Libros : Form
    {
        public Libros()
        {
           
            InitializeComponent();
            cargar_categorias();
            dataGridView2.DataSource = sql.mostrarlibros();
        }

        conectar sql = new conectar();
        public SqlConnection conexion = new SqlConnection("Data Source =JOSE-PC\\SQLEXPRESS; initial catalog = BIBLIOTECA; Integrated security = true ");



       



        private void button1_Click(object sender, EventArgs e)
        {
            codlibro.Text = dataGridView2.Rows.Count.ToString();
            if (sql.insertarlibro(codlibro.Text, nomlibro.Text, autlibro.Text, cantlibro.Text, comboBox1.SelectedValue.ToString(),comboBox1.Text.ToString(), arealibro.Text))
            {
                MessageBox.Show("Datos insertados");
                dataGridView2.DataSource = sql.mostrarlibros();
                codlibro.Text = String.Empty;
                nomlibro.Text = String.Empty;
                autlibro.Text = String.Empty;
                cantlibro.Text = String.Empty;
                arealibro.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }

            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sql.eliminarlibro(codlibro.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView2.DataSource = sql.mostrarlibros();
                codlibro.Text = String.Empty;
                nomlibro.Text = String.Empty;
                autlibro.Text = String.Empty;
                cantlibro.Text = String.Empty;
                arealibro.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            comboBox1.Text = dataGridView2.CurrentRow.Cells["CODCATEGORIA"].Value.ToString();
            Convert.ToInt32(comboBox1.SelectedValue);

            if (sql.actualizarlibro(codlibro.Text, nomlibro.Text, autlibro.Text, cantlibro.Text, comboBox1.SelectedValue.ToString(), arealibro.Text))
            {
                MessageBox.Show("Datos actualizados");
                dataGridView2.DataSource = sql.mostrarlibros();
                codlibro.Text = String.Empty;
                nomlibro.Text = String.Empty;
                autlibro.Text = String.Empty;
                cantlibro.Text = String.Empty;
             
                arealibro.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codlibro.Text = String.Empty;
            nomlibro.Text = String.Empty;
            autlibro.Text = String.Empty;
            cantlibro.Text = String.Empty;
            arealibro.Text = String.Empty;
            comboBox1.Text = String.Empty;
        }

        private void buscarlibro_TextChanged(object sender, EventArgs e)
        {
            if (buscarlibro.Text != "")
            {
                dataGridView2.DataSource = sql.buscarlibro(buscarlibro.Text);
            }
            else
            {
                dataGridView2.DataSource = sql.mostrarlibros();
            }
        }

        public void cargar_categorias()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT CODIGO, NOMBRE FROM CATEGORIA", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);    
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["NOMBRE"] = "Selecciona la Categoria";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "CODIGO";
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.DataSource = dt;

            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView2.Rows[e.RowIndex];
            codlibro.Text = Convert.ToString(fila.Cells[0].Value);
            nomlibro.Text = Convert.ToString(fila.Cells[1].Value);
            autlibro.Text = Convert.ToString(fila.Cells[2].Value);
            cantlibro.Text = Convert.ToString(fila.Cells[3].Value);
            comboBox1.SelectedValue = Convert.ToString(fila.Cells[4].Value);
            arealibro.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void cantlibro_TextChanged(object sender, EventArgs e)
        {
           
            }

        private void cantlibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
    }

