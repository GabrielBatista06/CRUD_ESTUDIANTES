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

namespace Segundo_parcial
{
    public partial class provincias : Form
    {
        SqlConnection cn = new SqlConnection("server=(local);database=Segundo parcial;integrated security=true");
        public provincias()
        {
            InitializeComponent();
        }

        private void provincias_Load(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand comando = new SqlCommand("Select * from provincia", cn);
                cn.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvprovincia.DataSource = tabla;
                dgvprovincia.Visible = true;
                cn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = "UPDATE provincia SET  nombre=@nombre WHERE id_provincia=@id_provincia";
                cn.Open();
                SqlCommand command = new SqlCommand(codigo, cn);
                command.Parameters.AddWithValue("@id_provincia", txtid_provincia.Text);
                command.Parameters.AddWithValue("@nombre", txtprovincia.Text);

                command.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Provincia Editada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = "INSERT INTO provincia (nombre)VALUES (@nombre)";
                cn.Open();
                SqlCommand command = new SqlCommand(codigo, cn);
                command.Parameters.AddWithValue("@nombre", txtprovincia.Text);
                command.ExecuteNonQuery();
                MessageBox.Show(" Provincia Insertada");
                cn.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(" Ha ocurrido un Error! " + error.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string codigo = "DELETE from provincia where id_provincia=@id_provincia";
                    cn.Open();
                    SqlCommand cm = new SqlCommand(codigo, cn);
                    cm.Parameters.AddWithValue("@id_provincia", txtid_provincia.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Provincia Eliminada");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error! " + error.Message);
                }
            }
        }
    }
}
