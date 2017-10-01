using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Funcionarios.Utilitarios
{
    class ValidaDados
    {
        // String que representará todos os campos em branco.
        private string campos;

        public string Campos
        {
            get
            {
                return campos;
            }

            set
            {
                campos = value;
            }
        }

        public bool validacampos2(Control formulario)
        {
            
        campos = "";
            int cont = 0;
            foreach (Control controle in formulario.Controls)
            {
                // Coloquei para também aceitar RichTextBox, por isso se lembre dos parênteses, sem eles só será analisado os RichTextBox.
                if ((controle is TextBox || controle is MaskedTextBox || controle is ComboBox || controle is RichTextBox) && string.IsNullOrEmpty(controle.Text))
                {
                    // Aqui será adicionado o nome da entrada em branco e a vírgula.
                    campos += controle.AccessibleName + ", ";
                    cont++;
                }
}
            if (cont >= 1)
            {
                if (cont > 1)
                {
                    // Modificadores da mensagem que será mostrada para o usuário.
                    campos = campos.Substring(0, campos.Length - 2);
                    int x = campos.LastIndexOf(',');
                    campos = campos.Remove(x, 1);
                    campos = campos.Insert(x, " e");

                }
                else
                {
                    campos = campos.Substring(0, campos.Length - 2);
                    int x = campos.LastIndexOf(',');
                    //campos = campos.Remove(x, 1);
                    //campos = campos.Insert(x, " e");
                }
                return false;
            }else
            {
                return true;
            }
          
            // E finalmente a MessageBox é exibida para o usuário.
            //MessageBox.Show(string.Format("Por favor preencha o(s) campo(s) {0}.", campos));
        // Recomendo que use string.Format ao invés de usar +, pois assim seu programa rodará mais fluidamente.
    }

    
    }
}
