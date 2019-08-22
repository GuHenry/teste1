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

namespace Peixe
{
    public partial class Peixes : Form
    {
        public Peixes()
        {
            InitializeComponent();
        }

        private void Peixes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (lblId.Text == "0")
            {
                Inserir();
                AtualizarTabela();
            }
            else
            {
                Alterar();
            }


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alterar()
        {
            Peixe peixes = new Peixe();
            peixes.Id = Convert.ToInt32(lblId.Text);
            peixes.Nome = txtNome.Text;
            peixes.Raca = txtRaca.Text;
            peixes.Preco = Convert.ToDecimal(txtPreco.Text);
            peixes.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE peixes SET nome =@NOME, raca=@RACA,  preco=@PRECO, quantidade=@QUANTIDADE WHERE id=@ID";

            comando.Parameters.AddWithValue("@ID", peixes.Id);
            comando.Parameters.AddWithValue("@NOME", peixes.Nome);
            comando.Parameters.AddWithValue("@RACA", peixes.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixes.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixes.Quantidade);
            comando.ExecuteNonQuery();
            MessageBox.Show("Atualizadocom sucesso");
            conexao.Close();
            AtualizarTabela();
            LimparTabela();

        }

        private void Inserir()
        {
            Peixe peixes = new Peixe();
            peixes.Id = Convert.ToInt32(lblId.Text);
            peixes.Nome = txtNome.Text;
            peixes.Raca = txtRaca.Text;
            peixes.Preco = Convert.ToDecimal(txtPreco.Text);
            peixes.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO peixes(nome, raca, preco, quantidade)
VALUES (@NOME, @RACA, @PRECO, @QUANTIDADE)";
            comando.Parameters.AddWithValue("@NOME", peixes.Nome);
            comando.Parameters.AddWithValue("@RACA", peixes.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixes.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixes.Quantidade);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro criado com sucesso");
            conexao.Close();
            AtualizarTabela();
            

        }

        private void AtualizarTabela()
        {
            dataGridView1.Rows.Clear();
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, nome, raca, preco, quantidade FROM peixes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            for (int i = 0; i < tabela.Rows.Count; i++)
            {

                DataRow linha = tabela.Rows[i];
                Peixe peixes = new Peixe();
                peixes.Id = Convert.ToInt32(linha["id"]);
                peixes.Nome = linha["nome"].ToString();
                peixes.Raca = linha["raca"].ToString();
                peixes.Preco = Convert.ToDecimal(linha["preco"]);
                peixes.Quantidade = Convert.ToInt32(linha["quantidade"]); 

                dataGridView1.Rows.Add(new string[] { peixes.Id.ToString(), peixes.Nome, peixes.Raca, peixes.Preco.ToString(), peixes.Quantidade.ToString() });
            }
            
            
           

        }
        
        private void LimparTabela()
        {
            txtNome.Clear();
            txtRaca.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
            DialogResult caixaDialogo = MessageBox.Show("Deseja  realmente apagar?","AVISO",MessageBoxButtons.YesNo);
            if (caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"DELETE FROM peixes WHERE id=@ID";

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
            }
            AtualizarTabela();

                    
                

                
            }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, raca, preco, quantidade FROM peixes WHERE id =@ID";

            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;


            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            DataRow linha = tabela.Rows[0];
            Peixe peixes = new Peixe();
            peixes.Id = Convert.ToInt32(linha["id"]);
            peixes.Nome = linha["nome"].ToString();
            peixes.Raca = linha["raca"].ToString();
            peixes.Preco = Convert.ToDecimal(linha["preco"]);
            peixes.Quantidade = Convert.ToInt32(linha["quantidade"]);

            lblId.Text = peixes.Id.ToString();
            txtNome.Text = peixes.Nome;
            txtPreco.Text = peixes.Preco.ToString();
            txtQuantidade.Text = peixes.Quantidade.ToString();
            txtRaca.Text = peixes.Raca.ToString();

            conexao.Close();
           
            AtualizarTabela();
        }
        
    }
    
}
