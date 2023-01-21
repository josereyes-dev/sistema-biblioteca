using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace entregable_practicas
{

    class conectar
    {
        public SqlConnection conexion = new SqlConnection("Data Source =JOSE-PC\\SQLEXPRESS; initial catalog = BIBLIOTECA; Integrated security = true ");
        private DataSet ds,dn;
        private SqlDataReader leerfilas;

        public DataTable mostrardatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIA", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM CATEGORIA where NOMBRE like '%{0}%'",nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public bool insertar(string codigo, string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO CATEGORIA VALUES ({0}, '{1}')", new string[] { codigo, nombre }),conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public bool eliminar(string codigo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM CATEGORIA WHERE CODIGO = {0}", codigo),conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool actualizar(string codigo, string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE CATEGORIA SET NOMBRE = '{0}' WHERE CODIGO = {1}", new string[] {nombre, codigo}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //LIBROS

        public DataTable mostrarlibros()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LIBROS", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            dn = new DataSet();
            ad.Fill(dn, "tabla");
            conexion.Close();
            return dn.Tables["tabla"];
        }
        public DataTable buscarlibro(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM LIBROS where NOMBRE like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            dn = new DataSet();
            ad.Fill(dn, "tabla");
            conexion.Close();
            return dn.Tables["tabla"];
        }
        public bool insertarlibro(string codigo, string nombre, string autor, string cantidad, string codcategoria, string nombrecategoria, string area)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO LIBROS VALUES ({0}, '{1}', '{2}', {3}, '{4}', '{5}', '{6}')", new string[] { codigo, nombre, autor, cantidad, codcategoria, nombrecategoria, area }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool eliminarlibro(string codigo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM LIBROS WHERE CODIGO = {0}", codigo), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool actualizarlibro(string codigo, string nombre, string autor, string cantidad, string codcategoria, string area)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE LIBROS SET NOMBRE = '{0}', AUTOR ='{1}', CANTIDAD = {2}, CODCATEGORIA = {3}, ESPECIFICA = '{4}' WHERE CODIGO = {5}", new string[] {nombre, autor, cantidad, codcategoria, area, codigo }), conexion);

            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //PRESTAMOS

        public DataTable mostrarprestamos()
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRESTAMOS", conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                dn = new DataSet();
                ad.Fill(dn, "tabla");
                conexion.Close();
                return dn.Tables["tabla"];
            }
            public DataTable buscarprestamo(string nombre)
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM PRESTAMOS where NOMBRE like '%{0}%'", nombre), conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                dn = new DataSet();
                ad.Fill(dn, "tabla");
                conexion.Close();
                return dn.Tables["tabla"];
            }

        
        public bool insertarprestamo(string codigo, string rol, string identificacion, string nombre, string grado, string telefono, string codobra, string nombre_obra, string cantidad,string fecha_prestamo, string estado)
            {

                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO PRESTAMOS VALUES ({0}, '{1}',{2}, '{3}', '{4}', {5}, {6}, '{7}', {8}, '{9}', '{10}')", new string[] { codigo, rol, identificacion, nombre, grado, telefono,codobra, nombre_obra, cantidad, fecha_prestamo, estado}), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public bool eliminarprestamo(string codigo)
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM PRESTAMOS WHERE CODIGO = {0}", codigo), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public bool actualizarprestamo(string codigo, string rol, string id, string nombre, string grado, string telefono, string cod_obra, string cantidad, string fecha_prestamo, string estado)
            {

                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE PRESTAMOS SET ROL = '{0}', IDENTIFICACION ={1}, NOMBRE = '{2}', GRADO = '{3}', TELEFONO = {4}, CODOBRA = {5}, CANTIDAD = {6}, FECHA_PRESTAMO = '{7}', ESTADO = '{8}' WHERE CODIGO = {9}", new string[] { rol, id, nombre, grado, telefono, cod_obra, cantidad, fecha_prestamo, estado, codigo}), conexion);

                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

        }
    }
}

          
           

    

