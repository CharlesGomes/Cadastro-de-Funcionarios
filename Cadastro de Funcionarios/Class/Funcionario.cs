using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Funcionarios
{
    class Funcionario
    {
        // Atributos da Classe
        private string nome;
        private string cpf;
        private string sexo;
        private string endereco;
        private string telefone;
        private string email;
        private string rg;
        private string est_civil;
        private int matricula;
        private string nascimento;
        private string funcao;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Est_civil
        {
            get
            {
                return est_civil;
            }

            set
            {
                est_civil = value;
            }
        }

        public int Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }

        public string Funcao
        {
            get
            {
                return funcao;
            }

            set
            {
                funcao = value;
            }
        }



        // Adiciona um novo Funcionario ao sistema
        public void adicionarFuncionario(string nome, string cpf, string sexo, string endereco, string telefone, string email, int matricula, string dtNasc, string rg, string estadoCivil, string funcao)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "INSERT INTO funcionario(nome, cpf, sexo, endereco, telefone, email, matricula, nasc, rg, estado_civil, funcao) VALUES ('" + nome + "', '" + cpf + "', '" + sexo + "', '" + endereco + "', '" + telefone + "', '" + email + "', '" + matricula + "','" + dtNasc + "', '" + rg + "', '" + estadoCivil + "', '" + funcao + "')";
                command.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Banco.objConexao.Close();
        }

        // Consulta todos os funcionario do Sistema
        public DataTable listarFuncionario()
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "SELECT * FROM funcionario";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable data = new DataTable();
                adapter.Fill(data);

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Atualiza pelo codigo
        public void AtualizaFuncionario(string cod, string nome, int cpf, string sexo, string endereco, int telefone, string email, int matricula, string dtNasc, int rg, string estadoCivil, string funcao)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "UPDATE funcionario SET nome ='" + nome + "', cpf ='" + cpf + "', sexo ='" + sexo + "', endereco ='" + endereco + "', telefone='" + telefone + "', email='" + email + "', matricula = '" + matricula + "', nasc ='" + dtNasc + "', rg ='" + rg + "', estado_civil ='" + estadoCivil + "', funcao ='" + funcao + "' WHERE id ='" + cod + "';";
                //conn.open();
                command.ExecuteNonQuery();

                MessageBox.Show("Funcionario atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Deleta pelo codigo
        public void deletaFuncionario(int cod)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "DELETE FROM funcionario WHERE id = " + cod + "";
                //conn.open();
                command.ExecuteNonQuery();

                MessageBox.Show("Funcionario deletado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Seleciona funcionario por codigo
        public Funcionario selecionaFuncionario(int cod)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();
            MySqlConnection con = new MySqlConnection();

            try
            {
                MySqlDataReader rd;
                command.CommandText = "SELECT * FROM funcionario WHERE id =" + cod + "";

                command.CommandType = CommandType.Text;
                command.Connection = Banco.objConexao;
                con.Open();
                rd = command.ExecuteReader();

                Funcionario funcionario = new Funcionario();

                while (rd.Read())
                {
                    
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

    }
}
