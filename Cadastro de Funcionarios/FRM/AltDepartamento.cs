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
    public partial class AltDepartamento : Form
    {
        public AltDepartamento(int cod, string marca, string modelo, int ano, string kilometragem, string diaria)
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos foram preenchidos
            
                // Recebe os dados do formulário
                
             

                // Chama a função para inserir o veículo
                Departamento departamento = new Departamento();
                //string codigo = TbxCodigo.txt;
                //departamento.AtualizaDepartamento(TbxCodigo.Text, marca, modelo, ano, kilometragem, diaria);

                // Fecha a janela
                this.Hide();
            
        }
    }
}
