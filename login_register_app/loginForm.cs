﻿using Mysqlx.Expr;
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
    public partial class loginForm : Form
    {
        public MySqlConnection con;
        public loginForm()
        {
            InitializeComponent();
            Koneksi koneksi = new Koneksi();
            this.con = koneksi.con;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(email.Text,password.Text);
        }

        private void login(String email, String password)
        {
            try
            {
                String query = "select * from users where email=@Email and password=@Password";
                MySqlCommand cmd = new MySqlCommand(query, this.con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            register.Show();
            this.Hide();
        }
    }
}
