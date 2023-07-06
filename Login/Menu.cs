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

namespace Login
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        MySqlConnection Conexao;
        public Menu()
        {
            string datasource = "datasource=localhost;username=root;password=Jp1011-fbr;database=sistematst";
            Conexao = new MySqlConnection(datasource);
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Conexao.Open();
            string query = "SELECT usuario FROM cadastro";
            MySqlCommand command = new MySqlCommand(query);
            string user = "ola " + command;
            lbNome.Text = user;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {
        }
    }
}
