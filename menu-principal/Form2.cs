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

namespace menu_principal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Email", 200, HorizontalAlignment.Left);
            listViewClientes.FullRowSelect = true; // Ativa a seleção da linha toda
            listViewClientes.GridLines = true; // Adiciona linhas de grade para melhor visualização
                                               // Carrega os usuarioss na ListView
            ClienteHelper.CarregarClientes(listViewClientes);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string dataCriacao = DateTime.Now.ToString("yyyy-MM-dd");
            string status = "Ativo";

            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para inserção de dados na tabela 'usuarios'
                string query = $"INSERT INTO usuarios (nome, email, DataCriacao, Status) VALUES ('{nome}', '{email}', '{dataCriacao}', '{status}')";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // Executa o comando de inserção
                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                    // Após inserção, atualiza a ListView
                    ClienteHelper.CarregarClientes(listViewClientes);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir dados.");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

