using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login_register_app
{
    internal class Koneksi
    {
         public MySqlConnection con;
        public Koneksi()
        {
            this.con = new MySqlConnection();
            connection();
        }

        public void connection()
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd='';database=latihan_db";
                this.con.ConnectionString = conn;
                this.con.Open();
               //MessageBox.Show("Success connection", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

   
}
