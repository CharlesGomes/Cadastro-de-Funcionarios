using Cadastro_de_Funcionarios.Utilitarios;
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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidaDados validaDados = new ValidaDados();
            ///// Verifica os campos vazios ////////
            if (validaDados.validacampos2(this))
            {

                // Recebe os dados do formulário
                string nome = TbxNome.Text;
                double matricula = Convert.ToDouble(MtbMatricula.Text);
                double cpf = Convert.ToDouble(TbxCpf.Text);
                string sexo = TbxSexo.Text;
                string endereco = TbxEndereco.Text;
                double telefone = Convert.ToDouble(TbxTelefone.Text);
                string email = TbxEmail.Text;
                string dtNasc = TbxDtNasc.Text;
                string rg = tbxRG.Text;
                string estadoCivil = CbxEstadoCivil.Text;
                int funcao = Convert.ToInt32(CbxFuncao.SelectedValue);
                string login = tbxLogin.Text;
                string senha = tbxSenha.Text;


                // Chama a função para inserir um novo funcionario no sistema
                Funcionario funcionario = new Funcionario();
                funcionario.adicionarFuncionario(nome, cpf, sexo, endereco, telefone, email, matricula, dtNasc, rg, estadoCivil, funcao);
                Usuario usuario = new Usuario();
                usuario.adicionarUsuario(login, senha, cpf);
                //// Fecha a janela
                this.Close();
            }
            else
            {
                // E finalmente a MessageBox é exibida para o usuário.
                MessageBox.Show(string.Format("Por favor preencha o(s) campo(s) {0}.", validaDados.Campos));
                // Recomendo que use string.Format ao invés de usar +, pois assim seu programa rodará mais fluidamente.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// Fecha a tela de cadastro ///
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //// Limpa todos os campos do form ////////
            TbxNome.Text = "";
            MtbMatricula.Text = "";
            TbxCpf.Text = "";
            TbxSexo.SelectedIndex = -1;
            TbxEndereco.Text = "";
            TbxTelefone.Text = "";
            TbxEmail.Text = "";
            TbxDtNasc.Text = "";
            tbxRG.Text = "";
            CbxEstadoCivil.SelectedIndex = -1;
            CbxFuncao.SelectedIndex = -1;
            //////////////////////////////////////////
        }

        private void carrega()
        {
            Departamento departamento = new Departamento();
           
            CbxFuncao.DataSource = departamento.RetornarDepartamento();
            CbxFuncao.DisplayMember = "Nome";
            CbxFuncao.ValueMember = "id";

        }

        private void AddFuncionario_Load(object sender, EventArgs e)
        {
            carrega();
        }
    }
}
