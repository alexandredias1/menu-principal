using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_principal
{
    public class ClienteHelper
    {

        public static void CarregarClientes (ListView listViewClientes)
        {
            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para selecionar todos os registros da tabela 'usuarios'
                string query = "select us.UsuarioID, us.nome, up.salario, us.idade, us.email, us.DataCriacao, us.status from usuarios as us join usuarioperfil as up on us.UsuarioID = up.PerfilID";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa os itens existentes no ListView antes de recarregar
                listViewClientes.Items.Clear();

                // Itera sobre os dados e os adiciona ao ListView
                while (reader.Read())
                {
                    // Adiciona os itens ao ListView
                    ListViewItem item = new ListViewItem(reader["UsuarioID"].ToString());
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["salario"].ToString());
                    item.SubItems.Add(reader["idade"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["DataCriacao"]).ToString());
                    item.SubItems.Add(reader["status"].ToString());
                    listViewClientes.Items.Add(item);
                }

                reader.Close();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuarioss: {ex.Message}");
            }
        }
    }

    public class loaderinicial
    {
        public static void Chamartabelas(ListView listViewClientes)
        {
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Salário", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Idade", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Email", 200, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Data-Criacao", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Status", 50, HorizontalAlignment.Left);
            listViewClientes.FullRowSelect = true; // Ativa a seleção da linha toda
            listViewClientes.GridLines = true; // Adiciona linhas de grade para melhor visualização
                                               // Carrega os usuarioss na ListView
        }
    }


}
