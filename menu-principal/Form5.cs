using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_principal
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string email = textBox2.Text;

            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para deletar o usuarios baseado no UsuarioID
                string query = $"SELECT nome, email FROM usuarios where nome = '{nome}'' or email = '{email}'";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o usuario: {ex.Message}");
            }
        }
    }
}
