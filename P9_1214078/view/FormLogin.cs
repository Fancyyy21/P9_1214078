using MySql.Data.MySqlClient;
using P9_1214078.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214078
{
    public partial class FormLogin : Form
    {

        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        CekLogin login = new CekLogin();

        public FormLogin()
        {
            server = "localhost";
            database = "ulbi";
            uid = "root";
            password = "";

            string connString;
            connString = "Server=localhost;Database=ulbi;Uid=root;Pwd=;";

            conn = new MySqlConnection(connString);

            InitializeComponent();
        }

        public bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM user WHERE username = '{user}' AND password = '{pass}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (IsLogin(user, pass))
            {
                this.Hide();
                MessageBox.Show($"Login Berhasil \rSelamat Datang {user} !", "Berhasil", MessageBoxButtons.OK);
                ParentForm panggil = new ParentForm();
                panggil.Show();

            }
            else if (user == "" && pass == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!!");
            }
            else if (user == "" )
            {
                MessageBox.Show("Username tidak boleh kosong!!");
            }
            else if (pass == "")
            {
                MessageBox.Show("Password tidak boleh kosong!!");
            }
            else
            {
                MessageBox.Show("GAGAL LOGIN!!", "Gagal", MessageBoxButtons.OK);
            }
        }

        private void LoginBaru_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                bool status = login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    ParentForm pform = new ParentForm();
                    pform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
    }
}
