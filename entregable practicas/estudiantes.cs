using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace entregable_practicas
{
    public partial class estudiantes : Form
    {
        public estudiantes()
        {
            InitializeComponent();
            cargar_codlibros();
            dataGridView4.DataSource = sql.mostrarprestamos();

        }

        conectar sql = new conectar();
        public SqlConnection conexion = new SqlConnection("Data Source =JOSE-PC\\SQLEXPRESS; initial catalog = BIBLIOTECA; Integrated security = true ");

        private void estudiantes_Load(object sender, EventArgs e)
        {
                }
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new inicio();
            formulario.Show();
            this.Hide();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            HorizontalScroll.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codprestamo.Text = dataGridView4.Rows.Count.ToString();
            if (sql.insertarprestamo(codprestamo.Text, comboBoxrol.Text.ToString(), idtxt.Text, nomprestamo.Text, comboBoxgrado.Text.ToString(), telefono.Text, comboBoxobra.SelectedValue.ToString(),comboBoxobra.Text.ToString(), cantidadtxt.Text, fecha1txt.Text, comboBoxestado.Text.ToString()))
            {
                MessageBox.Show("Datos insertados");
                dataGridView4.DataSource = sql.mostrarprestamos();
                codprestamo.Text = String.Empty;
                nomprestamo.Text = String.Empty;
                telefono.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
        }

        public void cargar_codlibros()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT CODIGO, NOMBRE FROM LIBROS", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["NOMBRE"] = "Selecciona el libro";
            dt.Rows.InsertAt(fila, 0);

            comboBoxobra.ValueMember = "CODIGO";
            comboBoxobra.DisplayMember = "NOMBRE";
            comboBoxobra.DataSource = dt;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView4.Rows[e.RowIndex];
            codprestamo.Text = Convert.ToString(fila.Cells[0].Value);
            comboBoxrol.SelectedValue = Convert.ToString(fila.Cells[1].Value);
            idtxt.Text = Convert.ToString(fila.Cells[2].Value);
            nomprestamo.Text = Convert.ToString(fila.Cells[3].Value);
            comboBoxgrado.SelectedValue = Convert.ToString(fila.Cells[4].Value);
            telefono.Text = Convert.ToString(fila.Cells[5].Value);
            comboBoxobra.SelectedValue = Convert.ToString(fila.Cells[6].Value);
            cantidadtxt.Text = Convert.ToString(fila.Cells[8].Value);
            fecha1txt.Text = Convert.ToString(fila.Cells[9].Value);
            comboBoxestado.SelectedValue = Convert.ToString(fila.Cells[10].Value);

        }

        private void buscarlibro_TextChanged(object sender, EventArgs e)
        {
            if (buscarprestamo.Text != "")
            {
                dataGridView4.DataSource = sql.buscarprestamo(buscarprestamo.Text);
            }
            else
            {
                dataGridView4.DataSource = sql.mostrarprestamos();
            }
        }

        private void idtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cantidadtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (sql.eliminarprestamo(codprestamo.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView4.DataSource = sql.mostrarprestamos();
                codprestamo.Text = String.Empty;
                idtxt.Text = String.Empty;
                nomprestamo.Text = String.Empty;
                telefono.Text = String.Empty;
                cantidadtxt.Text = String.Empty;
                fecha1txt.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            comboBoxobra.Text = dataGridView4.CurrentRow.Cells["NOMBRE_OBRA"].Value.ToString();
            Convert.ToInt32(comboBoxobra.SelectedValue);

            if (sql.actualizarprestamo(codprestamo.Text, comboBoxrol.Text, idtxt.Text, nomprestamo.Text, comboBoxgrado.Text, telefono.Text, comboBoxobra.SelectedValue.ToString(), cantidadtxt.Text, fecha1txt.Text, comboBoxestado.Text))
            {
                MessageBox.Show("Datos actualizados");
                dataGridView4.DataSource = sql.mostrarprestamos();
                codprestamo.Text = String.Empty;
                idtxt.Text = String.Empty;
                nomprestamo.Text = String.Empty;
                telefono.Text = String.Empty;
                cantidadtxt.Text = String.Empty;
                fecha1txt.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            codprestamo.Text = String.Empty;
            comboBoxrol.Text = String.Empty;
            idtxt.Text = String.Empty;
            nomprestamo.Text = String.Empty;
            comboBoxgrado.Text = String.Empty;
            telefono.Text = String.Empty;
            comboBoxobra.Text = String.Empty;
            cantidadtxt.Text = String.Empty;
            fecha1txt.Text = String.Empty;
            comboBoxestado.Text = String.Empty;


        }

        private void comboBoxestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

