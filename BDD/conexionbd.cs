using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDD
{
    public class conexionbd
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public conexionbd()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }


  
    }

}
