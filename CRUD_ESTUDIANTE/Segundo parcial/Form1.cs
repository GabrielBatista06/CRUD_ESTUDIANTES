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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("server=(local);database=AGENDA;integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select carrera from carrera", cn);
            cn.Open();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cbxcarrera.Items.Add(reader["carrera"].ToString());
            }
            cn.Close();

            SqlCommand cm = new SqlCommand("Select nombre from provincia", cn);
            cn.Open();
            SqlDataReader leer = cm.ExecuteReader();
            while (leer.Read())
            {
                cbxprovincia.Items.Add(leer["nombre"].ToString());
            }
            cn.Close();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrera ca = new Carrera();
            ca.ShowDialog();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provincias pro = new provincias();
            pro.ShowDialog();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
             try
            { //Para insertar datos
                string codigo = "INSERT INTO Estudiante (id,matricula,nombre)VALUES (@id,@matricula,@nombre)";
                cn.Open();
                SqlCommand command = new SqlCommand(codigo, cn);
                command.Parameters.AddWithValue("@matricula", txtmatricula.Text);
                command.Parameters.AddWithValue("@nombre", txtnombre.Text);
                command.Parameters.AddWithValue("@id", txtid.Text);
                command.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Insertado");

            }
            catch(Exception error)
            {
                MessageBox.Show(" Ha ocurrido un Error! " + error.Message);
            }
    }   }
}
