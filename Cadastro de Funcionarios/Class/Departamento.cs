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
    class Departamento
    {
        // Atributos da Classe
        private int id;
        private string nome;

       
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        //Atualiza pelo codigo
        public void AtualizaDepartamento()
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
               command.CommandText = "UPDATE departamento SET nome ='" + nome + "';";
               // conn.open();
                command.ExecuteNonQuery();

                MessageBox.Show("Departamento atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void adicionarDepartamento()
        {
            throw new NotImplementedException();
        }

        //Deleta pelo codigo
        public void deletaDepartamento(int cod)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "DELETE FROM departAMENTO WHERE id = "+ cod + "";
                //conn.open();
                command.ExecuteNonQuery();

                MessageBox.Show("Departamento deletado com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Seleciona Departamento por codigo
    public Departamento selecionaDepartamento(int cod)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();
            MySqlConnection con = new MySqlConnection();

            try
            {
                MySqlDataReader rd;
                command.CommandText = "SELECT * FROM DEPARTAMENTO WHERE id =" + cod + "";
                
                command.CommandType = CommandType.Text;
                command.Connection = Banco.objConexao;
                con.Open();
                rd = command.ExecuteReader();
                
                Departamento departamento = new Departamento();
                 
                while (rd.Read())
                {
                   
                }
                return departamento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        // Lista os Departamento Cadastrados no Sistema
        public DataTable listarDepartamento()
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "SELECT * FROM departamento";
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
        
        // Adiciona um novo Departamento ao Sistema
        public void adicionarDepartamento(string nome)
        {
            Database Banco = new Database();

            MySqlCommand command = new MySqlCommand();

            Banco.objConexao.Open();
            command.Connection = Banco.objConexao;

            try
            {
                command.CommandText = "INSERT INTO departamento(nome) VALUES ('" + nome  + "')";
                command.ExecuteNonQuery();

                MessageBox.Show("Departamento cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Banco.objConexao.Close();
        }
    }
}
