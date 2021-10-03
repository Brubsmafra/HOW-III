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

namespace Biblioteca_sistema
{
    public partial class FormBiblioteca_sistema : Form
    {
        public FormBiblioteca_sistema()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder ConexaoBanco()
        {
            // Crio a estrutura da conexão com o banco de dados e passo os parâmetros 
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "sistema_biblioteca";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            return conexaoBD;

        }

        private void FormBiblioteca_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro WHERE ATIVO_LIVRO = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgsistema_biblioteca.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgsistema_biblioteca.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//AUTOR
                    row.Cells[3].Value = reader.GetString(3);//EDITORA
                    row.Cells[4].Value = reader.GetString(4);//CATEGORIA    
                    row.Cells[5].Value = reader.GetString(5);//DESCCRIÇÃO
                    dgsistema_biblioteca.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL

                comandoMySql.CommandText = "INSERT INTO LIVRO (NOME_LIVRO, AUTOR_LIVRO, EDITORA_LIVRO, CATEGORIA_LIVRO, DESCRICAO_LIVRO) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxAutor.Text + "','" + textBoxEditora.Text + "', '" + textBoxCategoria.Text + "' , '" + textBoxDescricao.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco

                MessageBox.Show("Inserido com sucesso"); // Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void limparCampos()

        {
            textBoxCategoria.Clear();
            textBoxDescricao.Clear();
            textBoxEditora.Clear();
            textBoxAutor.Clear();
            textBoxNome.Clear();
            textBoxID.Clear();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL

                comandoMySql.CommandText = " UPDATE livro SET NOME_LIVRO = '" + textBoxNome.Text + "', " + 
                            "AUTOR_LIVRO = '" + textBoxAutor.Text + "', " +
                            "EDITORA_LIVRO = '" + textBoxEditora.Text + "', " +
                            "DESCRICAO_LIVRO = '" + textBoxDescricao.Text + "', " +
                            "CATEGORIA_LIVRO = '" + textBoxCategoria.Text + "' " + 
                            "WHERE ID_LIVRO = " + textBoxID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco

                MessageBox.Show("Atualizado com sucesso"); // Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE livro SET ATIVO_LIVRO = 0 WHERE ID_LIVRO = " + textBoxID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Excluído com sucesso"); //Exibo mensagem de aviso de exclusão
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgsistema_biblioteca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgsistema_biblioteca.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgsistema_biblioteca.CurrentRow.Selected = true;
                //preenche os campos com as células da linha selecionada
                textBoxNome.Text = dgsistema_biblioteca.Rows[e.RowIndex].Cells["ColunaNome"].FormattedValue.ToString();
                textBoxCategoria.Text = dgsistema_biblioteca.Rows[e.RowIndex].Cells["ColunaCategoria"].FormattedValue.ToString();
                textBoxDescricao.Text = dgsistema_biblioteca.Rows[e.RowIndex].Cells["ColunaDescricao"].FormattedValue.ToString();
                textBoxAutor.Text = dgsistema_biblioteca.Rows[e.RowIndex].Cells["ColunaAutor"].FormattedValue.ToString();
                textBoxEditora.Text = dgsistema_biblioteca.Rows[e.RowIndex].Cells["ColunaEditora"].FormattedValue.ToString();
                textBoxID.Text = dgsistema_biblioteca.Rows[e.RowIndex].Cells["ColunaID"].FormattedValue.ToString();

            }
        }

    }
 }
