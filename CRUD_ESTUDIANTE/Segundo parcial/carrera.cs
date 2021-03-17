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
    public partial class Carrera : Form
    {
        SqlConnection cn = new SqlConnection("server=(local);database=Segundo parcial;integrated security=true");
        public Carrera()
        {
            InitializeComponent();
        }


        private void btnmostrar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand comando = new SqlCommand("Select * from carrera", cn);
                cn.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvcarreras.DataSource = tabla;
                dgvcarreras.Visible = true;
                cn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = "UPDATE carrera SET  carrera=@carrera WHERE id_carrera=@id_carrera ";
                cn.Open();
                SqlCommand command = new SqlCommand(codigo, cn);
                command.Parameters.AddWithValue("@id_carrera", txtid_carrera.Text);
                command.Parameters.AddWithValue("@carrera", txtcarrera.Text);

                command.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Editado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error.Message);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = "INSERT INTO carrera (carrera)VALUES (@carrera)";
                cn.Open();
                SqlCommand command = new SqlCommand(codigo, cn);
                command.Parameters.AddWithValue("@carrera", txtcarrera.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Insertado");
                cn.Close();

            }
            catch(Exception error)
            {
                MessageBox.Show(" Ha ocurrido un Error! " + error.Message);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = "DELETE from carrera where id_carrera=@id_carrera";
                cn.Open();
                SqlCommand cm = new SqlCommand(codigo, cn);
                cm.Parameters.AddWithValue("@id_carrera", txtid_carrera.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Carrera Eliminada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error.Message);
            }
        }
    }
}
