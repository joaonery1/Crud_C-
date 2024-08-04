using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD
{
    internal class cadastrarAluno
    {

        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public bool cadastrarAlunos()
        {
            try
            {
                MySqlConnection ConexaoComBanco = new MySqlConnection(ConexaoBancoDDados.bancoServidor);
                ConexaoComBanco.Open();

                string insert = $"INSERT INTO aluno (nome, email, cpf, endereco) " +
                    $"VALUES ('{Nome}', '{Email}', '{cpf}', '{Endereco}')";

                MySqlCommand comando = ConexaoComBanco.CreateCommand();
                comando.CommandText = insert;   
                comando.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("nao foi possível cadastrar o aluno");
                return false;
            }
        }

        public MySqlDataReader localizarAluno()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBancoDDados.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"SELECT id, nome, email, cpf, endereco from aluno WHERE cpf = '{Cpf}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Metódo Localizar Aluno");
                return null;
            }
        }


        public bool atualizarAlunos()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBancoDDados.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"UPDATE aluno SET email = '{Email}', endereco = '{endereco}' WHERE id = '{Id}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - Metódo Atualizar Aluno" + ex.Message);
                return false;
            }
        }


        public bool deletarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBancoDDados.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"DELETE FROM aluno where id = '{Id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro para deletar Aluno" + ex.Message);
                return false;
            }
        }



    }

}
