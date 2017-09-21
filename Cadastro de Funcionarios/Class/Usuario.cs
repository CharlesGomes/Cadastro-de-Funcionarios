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



        // Função que autentica o usuário e efetua o login no sistema
        public void LoginUsuario(string login, string senha)
        {

            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "SELECT count(*) FROM usuario WHERE login= '" + login + "' AND senha= '" + senha + "'";
                int rowCount = int.Parse(command.ExecuteScalar().ToString());

                if(rowCount == 1)
                {
                    Sistema sistema = new Sistema();
                    sistema.Show();
                } else
                {
                    MessageBox.Show("Usuário ou senha inválido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Banco.objConexao.Close();

        }

    }
}
