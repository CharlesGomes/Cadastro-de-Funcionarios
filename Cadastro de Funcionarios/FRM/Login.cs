﻿using Cadastro_de_Funcionarios.Utilitarios;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidaDados validaDados = new ValidaDados();
            if (validaDados.validacampos2(this))
            {
                // Recebe usuário e senha
                string login = TbxLogin.Text;
                string senha = TbxSenha.Text;

                // Chama a função para autenticar
                Usuario u = new Usuario();
                u.LoginUsuario(login, senha);

                // Fecha a janela de Login
                this.Hide();
            }
            else
            {
                // E finalmente a MessageBox é exibida para o usuário.
                MessageBox.Show(string.Format("Por favor preencha o(s) campo(s) {0}.", validaDados.Campos));
                // Recomendo que use string.Format ao invés de usar +, pois assim seu programa rodará mais fluidamente.
            }
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
