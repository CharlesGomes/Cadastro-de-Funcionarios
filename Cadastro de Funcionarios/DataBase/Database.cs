﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cadastro_de_Funcionarios
{
    class Database
    {
        /** Dados de Acesso ao MySQL **/
        private string server   = "localhost";
        private string port     = "3306";
        private string user     = "root";
        private string password = "";
        private string database = "cadastrar_funcionario";

       // MySqlConnection con = null;

        public MySqlConnection objConexao;

        /** Método de Conexão ao MySQL **/
        public MySqlConnection AbrirConexao()
        {
           
                // String de Conexão pegando os atributos da classe
                objConexao = new MySqlConnection("server=" + this.server + ";port=" + this.port + ";User Id=" + this.user + ";database=" + this.database + ";passoword=" + this.password);
            try
            {

                objConexao.Open();
            }
            catch
            {
                // Caso a conexão falhe, exibe uma mensagem para o usuário
                MessageBox.Show("Erro ao conectar-se ao MySQL!");
                Application.ExitThread(); 
            }
            return objConexao;
        }

    }
}
