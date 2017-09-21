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
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void adicionarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chama a tela para adicionar um novo veículo ao clicar no menu (Novo Veículo)
            AddDepartamento adicionarDepartamento = new AddDepartamento();
            adicionarDepartamento.ShowDialog();
        }

        

        private void meusFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chama a tela para adicionar um novo cliente ao clicar no menu (Novo Cliente)
            AddFuncionario adicionarFuncionario = new AddFuncionario();
            adicionarFuncionario.ShowDialog();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
