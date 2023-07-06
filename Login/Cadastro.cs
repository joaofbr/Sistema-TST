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
    public partial class Cadastro : MetroFramework.Forms.MetroForm
    {
        MySqlConnection Conexao;
        public Cadastro()
        {
            //inserindo os dados para o conexão com o banco
            string dataSource = "datasource=localhost;username=root;password=Jp1011-fbr;database=sistematst";
            Conexao = new MySqlConnection(dataSource);
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            if (mtCpf.Text.Trim() == "" || tbNome.Text.Trim() == "" || tbSobrenome.Text.Trim() == "" ||
                tbUsuario.Text.Trim() == "" || tbEmail.Text.Trim() == "" || tbSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //abrindo conexão com o banco
                Conexao.Open();

                //capturando os dados e guardando na variável string
                string query = "INSERT INTO cadastro (cpf, nome, sobrenome, usuario, email, senha) VALUES (@cpf, @nome, @sobrenome, @usuario, @email, @senha )";
                //Inserindo os dados no banco
                MySqlCommand command = new MySqlCommand(query, Conexao);

                //passando parametros do formulario para dentro da query
                command.Parameters.AddWithValue("@cpf", mtCpf.Text);
                command.Parameters.AddWithValue("@nome", tbNome.Text);
                command.Parameters.AddWithValue("@sobrenome", tbSobrenome.Text);
                command.Parameters.AddWithValue("@usuario", tbUsuario.Text);
                command.Parameters.AddWithValue("@email", tbEmail.Text);
                command.Parameters.AddWithValue("@senha", tbSenha.Text);
                //MySQLCommand é responsável por executar os comandos SQL
                command.ExecuteReader();

                MessageBox.Show("Cadastro realizado com sucesso!");
                mtCpf.Text = "";
                tbNome.Text = "";
                tbSobrenome.Text = "";
                tbUsuario.Text = "";
                tbEmail.Text = "";
                tbSenha.Text = "";
            }

            //fechando conexão 
            Conexao.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Form1();
            this.Hide();
            login.Show();
        }

        
    }
}
