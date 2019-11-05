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


namespace BDD
{
    public partial class FormVista : Form
    {
        SqlConnection conexion = new SqlConnection();
        public FormVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVista_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = "Data Source=.;Initial Catalog=Hospital;Integrated Security=True";
            conexion.Open();
            try
            {
                string mostrar = "select * from listadoPacientes";
                SqlCommand comando = new SqlCommand(mostrar, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "listadoPacientes");
                dataGridView1.DataSource = ds.Tables["listadoPacientes"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "puede ser que", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }
    }
}
