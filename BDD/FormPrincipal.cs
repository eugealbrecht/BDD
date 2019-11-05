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
    public partial class FormPrincipal : Form
    {
        SqlConnection conexion = new SqlConnection();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand it;
            string tabla = "create table Pacientesss (" + " Cod_pac nchar(10) primary key not null," + " NombreAp_pac nchar(30), " + " Cod_os nchar(10), " + " Nro_afiliado nchar(10), " + " Tel_pac int, " + " Fecha_nac Datetime, " + " NombreAp_med nchar(30))";
            it = new SqlCommand(tabla, conexion);

            try
            {


                it.ExecuteNonQuery();

            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message, "Puede ser que ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSP form = new FormSP();
            form.Owner = this;
            form.ShowDialog();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString= "Data Source=.;Initial Catalog=Hospital;Integrated Security=True";

        }

        private void Button5_Click(object sender, EventArgs e)
        {

           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormVista form = new FormVista();
            form.Owner = this;
            form.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
