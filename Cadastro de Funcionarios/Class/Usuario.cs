using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Funcionarios
{
    class Usuario
    {
        // Atributos da classe  
        private string login;
        private string senha;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        // Adiciona um novo usuario ao sistema
        public void adicionarUsuario(string login, string senha, double cpf)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            MySqlConnection con = null;
            con = Banco.AbrirConexao();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "INSERT INTO usuario(login, senha, status, cpf) VALUES ('" + login + "', '" + senha + "', 'Ativo', '" + cpf + "')";

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Banco.objConexao.Close();
        }

        // Função que autentica o usuário e efetua o login no sistema
        public bool LoginUsuario(string login, string senha)
        {

            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            MySqlConnection con = null;
            con = Banco.AbrirConexao();

            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "SELECT count(*) FROM usuario WHERE login= '" + login + "' AND senha= '" + senha + "'";
                int rowCount = int.Parse(command.ExecuteScalar().ToString());

                Banco.objConexao.Close();

                if (rowCount == 1)
                {
                    return true;

                } else
                {
                    return false;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            

        }

        // Função verifica se existe usuario cadastrado no banco
        public bool VerificaUsuario()
        {

            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            try
            {
                MySqlConnection con = null;
               

                command.CommandText = "SELECT count(*) FROM usuario";
                con = Banco.AbrirConexao();

                command.Connection = Banco.objConexao;
                int rowCount = int.Parse(command.ExecuteScalar().ToString());

                if (rowCount == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

    }
}
