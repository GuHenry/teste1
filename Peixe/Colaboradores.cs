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
    public partial class Colaboradores : Form
    {
        public Colaboradores()
        {
            InitializeComponent();
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

        private void AtualizarTabela()
        {
            dgvColaboradores.Rows.Clear();
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, nome, salario, cpf, sexo, cargo, programador FROM colaboradores";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Colaborador colaboradores = new Colaborador();
                colaboradores.Id = Convert.ToInt32(linha["id"]);
                colaboradores.Nome = linha["nome"].ToString();
                colaboradores.Salario = Convert.ToDecimal(linha["salario"]);
                colaboradores.Cpf = linha["cpf"].ToString();
                colaboradores.Sexo = linha["sexo"].ToString();
                colaboradores.Cargo = linha["cargo"].ToString();
                colaboradores.Programador =Convert.ToBoolean(linha["programador"]);

                dgvColaboradores.Rows.Add(new string[] {
                    colaboradores.Id.ToString(), colaboradores.Nome, colaboradores.Salario.ToString(),
                    colaboradores.Cpf, colaboradores.Sexo, colaboradores.Cargo, colaboradores.Programador.ToString()
                });
            }
            conexao.Close();






        }

        private void Inserir()
        {
            Colaborador colaboradores = new Colaborador();
            colaboradores.Id = Convert.ToInt32(lblId.Text);
            colaboradores.Nome = txtNome.Text;
            colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text);
            colaboradores.Cpf = txtCpf.Text;
            colaboradores.Sexo = cbSexo.Text;
            colaboradores.Cargo = txtCargo.Text;
            if(checkBox1.Checked == true)
            {
                colaboradores.Programador = true;
            }
            else
            {
                colaboradores.Programador = false; 
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO colaboradores (nome, salario, cpf, sexo, cargo, programador) VALUES(@NOME, @SALARIO, @CPF, @SEXO, @CARGO, @PROGRAMADOR)";
            comando.Parameters.AddWithValue("@NOME", colaboradores.Nome);
            comando.Parameters.AddWithValue("@SALARIO", colaboradores.Salario);
            comando.Parameters.AddWithValue("@CPF", colaboradores.Cpf);
            comando.Parameters.AddWithValue("@SEXO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaboradores.Programador);
            try
            {
            comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            conexao.Close();
            AtualizarTabela();
            LimparTabela();

        }

        private void Alterar()
        {

            Colaborador colaboradores = new Colaborador();
            colaboradores.Id = Convert.ToInt32(lblId.Text);
            colaboradores.Nome = txtNome.Text;
            colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text.ToString());
            colaboradores.Cpf = txtCpf.Text;
            colaboradores.Sexo = cbSexo.Text;
            colaboradores.Cargo = txtCargo.Text;
            if (checkBox1.Checked == true)
            {
                colaboradores.Programador = true;
            }
            else
            {
                colaboradores.Programador = false;
            }


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE colaboradores SET nome=@NOME, salario=@SALARIO, cpf=@CPF, sexo=@SEXO, cargo=@CARGO, programador=@PROGRAMADOR";

            comando.Parameters.AddWithValue("@NOME", colaboradores.Nome);
            comando.Parameters.AddWithValue("@SALARIO", colaboradores.Salario);
            comando.Parameters.AddWithValue("@CPF", colaboradores.Cpf);
            comando.Parameters.AddWithValue("@SEXO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaboradores.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaboradores.Programador);
            comando.ExecuteNonQuery();
            MessageBox.Show("Atualizado com sucesso!");
            conexao.Close();
            AtualizarTabela();
            LimparTabela();
        }

        private void LimparTabela()
        {
            txtCargo.Clear();
            txtCpf.Clear();
            txtNome.Clear();
            mtbSalario.Clear();
            cbSexo.SelectedIndex = -1;

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult caixaDeDialogo = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);
            if (caixaDeDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM colaboradores WHERE id= @ID";

                int id = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
                LimparTabela();
            }
            AtualizarTabela();

        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dgvColaboradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Peixes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, nome, salario, cpf, sexo, cargo, programador FROM colaboradores WHERE id=@ID";

            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;
            comando.ExecuteNonQuery();

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());


            DataRow linha = tabela.Rows[0];
            Colaborador colaboradores = new Colaborador();
            colaboradores.Id = Convert.ToInt32(linha["id"]);
            colaboradores.Nome = linha["nome"].ToString();
            colaboradores.Salario = Convert.ToDecimal(linha["salario"]);
            colaboradores.Cpf = linha["cpf"].ToString();
            colaboradores.Sexo = linha["sexo"].ToString();
            colaboradores.Cargo = linha["cargo"].ToString();
            if (Convert.ToBoolean(linha["programador"]) == true)
            {
                checkBox1.Checked = true; 
            }
            else
            {
                colaboradores.Programador = false;
            }

            lblId.Text = colaboradores.Id.ToString();
            txtNome.Text = colaboradores.Nome;
            txtCpf.Text = colaboradores.Cpf;
            mtbSalario.Text = colaboradores.Salario.ToString();
            cbSexo.Text = colaboradores.Sexo;
            txtCargo.Text = colaboradores.Cargo;

            conexao.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
