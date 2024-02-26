using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login_register_app
{
    public partial class registerForm : Form
    {

        private MySqlConnection con; 
        public registerForm()
        {
            InitializeComponent();
            Koneksi konesi = new Koneksi();
            this.con = konesi.con;
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void register()
        {
            try
            {
                String query = "insert into users (name,email,password) values (@name,@email,@password)";
                MySqlCommand cmd = new MySqlCommand(query,this.con);
                cmd.Parameters.AddWithValue("@name", fullname.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil Register", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loginForm login = new loginForm();
                login.Show();

                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           register();
        }
    }
}
