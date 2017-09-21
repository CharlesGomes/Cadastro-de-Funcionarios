using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Funcionarios
{
    public partial class AltFuncionario : Form
    {
        public AltFuncionario(string cod, string nome, string cpf, string sexo, string endereco, string telefone, string email)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

                // Chama a função para inserir um novo cliente no sistema
                Funcionario funcionario = new Funcionario();
                //funcionario.AtualizaFuncionario(cod, nome, cpf, sexo, endereco, telefone, email);

                // Fecha a janela
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
