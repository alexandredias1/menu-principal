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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
            if (listViewClientes.SelectedItems.Count > 0)
            {
                // Pega o ID do usuarios selecionado (primeira coluna do ListView)
                string UsuarioID = listViewClientes.SelectedItems[0].SubItems[0].Text;

                string strConexao = "server=localhost;uid=root;database=bancodedados1";
                MySqlConnection conexao = new MySqlConnection(strConexao);

                try
                {
                    conexao.Open();

                    // Query SQL para deletar o usuarios baseado no UsuarioID
                    string query = $"DELETE FROM usuarios WHERE UsuarioID = {UsuarioID}";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se o registro foi excluído com sucesso
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cliente excluído com sucesso!");
                        // Atualiza o ListView após a exclusão
                        ClienteHelper.CarregarClientes(listViewClientes);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o usuarios.");
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o usuarios: {ex.Message}");
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
