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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        MySqlConnection Conexao;
        public Form1()
        {
            string dataSource = "datasource=localhost;username=root;password=Jp1011-fbr;database=sistematst";
            Conexao = new MySqlConnection(dataSource);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //abrindo conexão com o banco
            Conexao.Open();

            string query = "SELECT * FROM cadastro WHERE usuario=@usuario AND senha=@senha";
            MySqlCommand command = new MySqlCommand(query, Conexao);
            //passando os parametros do formulario para a query
            command.Parameters.AddWithValue("@usuario", tb1.Text);
            command.Parameters.AddWithValue("@senha", tb2.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.Close();
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int back = (int)e.KeyChar;
            if (!char.IsLetterOrDigit(e.KeyChar) && back != 8)
            {
                e.Handled = true;
                MessageBox.Show("Apenas letras ou números.", "Erro! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb1.SelectionStart = 0;
                tb1.SelectionLength = tb1.Text.Length;
                tb1.Focus();
            }
        }

        private void lCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}