using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;

namespace DemoCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") 
                    && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastrarAluno cadAluno = new cadastrarAluno();

                    cadAluno.Nome = txtNome.Text;
                    cadAluno.Email = txtEmail.Text;
                    cadAluno.Cpf = txtCPF.Text;
                    cadAluno.Endereco = txtEndereco.Text;


                    if (cadAluno.cadastrarAlunos())
                    {
                        MessageBox.Show($"O aluno {cadAluno.Nome} foi aluno com sucesso");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar aluno");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals(""))
                {
                    cadastrarAluno cadAluno = new cadastrarAluno();
                    cadAluno.Cpf = txtCPF.Text;

                    MySqlDataReader reader = cadAluno.localizarAluno();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nao foi possível localizar o Aluno");
            }
        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtEmail.Text.Equals("")
                    && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    cadastrarAluno buscaAluno = new cadastrarAluno();

                    buscaAluno.Id = int.Parse(lblId.Text);
                    buscaAluno.Email = txtEmail.Text;
                    buscaAluno.Endereco = txtEndereco.Text;

                    if (buscaAluno.atualizarAlunos())
                    {
                        MessageBox.Show($"Os dados do aluno foram atualizados com sucesso");
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Clear();
                        txtNome.Focus();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar dados do aluno" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") 
                    && !txtNome.Text.Equals(""))
                {
                    cadastrarAluno deletarAluno = new cadastrarAluno();
                    deletarAluno.Id = int.Parse(lblId.Text);

                    if (deletarAluno.deletarFuncionario())
                    {
                        MessageBox.Show("Aluno excluido com sucesso");
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Clear();
                        lblId.Text = "";
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir Aluno");
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Clear();
                        txtNome.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual aluno deseja excluir!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir aluno:" + ex.Message);
            }
        }
    }
}
