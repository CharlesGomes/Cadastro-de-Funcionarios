namespace Cadastro_de_Funcionarios
{
    partial class AddFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.TbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxEndereco = new System.Windows.Forms.TextBox();
            this.TbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxRG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CbxFuncao = new System.Windows.Forms.ComboBox();
            this.TbxDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.MtbMatricula = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TbxNome
            // 
            this.TbxNome.AccessibleName = "Nome";
            this.TbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNome.Location = new System.Drawing.Point(17, 87);
            this.TbxNome.Name = "TbxNome";
            this.TbxNome.Size = new System.Drawing.Size(308, 22);
            this.TbxNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // TbxCpf
            // 
            this.TbxCpf.AccessibleName = "CPF";
            this.TbxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCpf.Location = new System.Drawing.Point(17, 136);
            this.TbxCpf.Mask = "000.000.000-00";
            this.TbxCpf.Name = "TbxCpf";
            this.TbxCpf.Size = new System.Drawing.Size(308, 22);
            this.TbxCpf.TabIndex = 3;
            this.TbxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // TbxSexo
            // 
            this.TbxSexo.AccessibleName = "Sexo";
            this.TbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSexo.FormattingEnabled = true;
            this.TbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.TbxSexo.Location = new System.Drawing.Point(17, 184);
            this.TbxSexo.Name = "TbxSexo";
            this.TbxSexo.Size = new System.Drawing.Size(308, 24);
            this.TbxSexo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço:";
            // 
            // TbxEndereco
            // 
            this.TbxEndereco.AccessibleName = "Endereço";
            this.TbxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEndereco.Location = new System.Drawing.Point(17, 233);
            this.TbxEndereco.Name = "TbxEndereco";
            this.TbxEndereco.Size = new System.Drawing.Size(308, 22);
            this.TbxEndereco.TabIndex = 5;
            // 
            // TbxTelefone
            // 
            this.TbxTelefone.AccessibleName = "Telefone";
            this.TbxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxTelefone.Location = new System.Drawing.Point(18, 281);
            this.TbxTelefone.Mask = "(99) 00000-0000";
            this.TbxTelefone.Name = "TbxTelefone";
            this.TbxTelefone.Size = new System.Drawing.Size(307, 22);
            this.TbxTelefone.TabIndex = 6;
            this.TbxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail:";
            // 
            // TbxEmail
            // 
            this.TbxEmail.AccessibleName = "E-mail";
            this.TbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEmail.Location = new System.Drawing.Point(404, 280);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(243, 22);
            this.TbxEmail.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(190, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(369, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data de Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Matricula:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Função:";
            // 
            // TbxRG
            // 
            this.TbxRG.AccessibleName = "RG";
            this.TbxRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxRG.Location = new System.Drawing.Point(404, 136);
            this.TbxRG.Name = "TbxRG";
            this.TbxRG.Size = new System.Drawing.Size(243, 22);
            this.TbxRG.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "RG:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estado Civil:";
            // 
            // CbxEstadoCivil
            // 
            this.CbxEstadoCivil.AccessibleName = "Estado Civil";
            this.CbxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstadoCivil.FormattingEnabled = true;
            this.CbxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado"});
            this.CbxEstadoCivil.Location = new System.Drawing.Point(404, 184);
            this.CbxEstadoCivil.Name = "CbxEstadoCivil";
            this.CbxEstadoCivil.Size = new System.Drawing.Size(243, 24);
            this.CbxEstadoCivil.TabIndex = 9;
            // 
            // CbxFuncao
            // 
            this.CbxFuncao.AccessibleName = "Função";
            this.CbxFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFuncao.FormattingEnabled = true;
            this.CbxFuncao.Items.AddRange(new object[] {
            "GERENTE RH",
            "ANÁLISTA",
            "DESENVOLVEDOR",
            "SECRETÁRIO(A)",
            ""});
            this.CbxFuncao.Location = new System.Drawing.Point(404, 232);
            this.CbxFuncao.Name = "CbxFuncao";
            this.CbxFuncao.Size = new System.Drawing.Size(243, 24);
            this.CbxFuncao.TabIndex = 10;
            // 
            // TbxDtNasc
            // 
            this.TbxDtNasc.AccessibleName = "Data de Nascimento";
            this.TbxDtNasc.Location = new System.Drawing.Point(404, 90);
            this.TbxDtNasc.Mask = "00/00/0000";
            this.TbxDtNasc.Name = "TbxDtNasc";
            this.TbxDtNasc.Size = new System.Drawing.Size(100, 20);
            this.TbxDtNasc.TabIndex = 7;
            this.TbxDtNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TbxDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // MtbMatricula
            // 
            this.MtbMatricula.AccessibleName = "Matricula";
            this.MtbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbMatricula.Location = new System.Drawing.Point(19, 32);
            this.MtbMatricula.Mask = "9999999999";
            this.MtbMatricula.Name = "MtbMatricula";
            this.MtbMatricula.Size = new System.Drawing.Size(308, 22);
            this.MtbMatricula.TabIndex = 1;
            this.MtbMatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // AddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 375);
            this.Controls.Add(this.MtbMatricula);
            this.Controls.Add(this.TbxDtNasc);
            this.Controls.Add(this.CbxFuncao);
            this.Controls.Add(this.CbxEstadoCivil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TbxRG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxNome);
            this.Controls.Add(this.label1);
            this.Name = "AddFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TbxCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TbxSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxEndereco;
        private System.Windows.Forms.MaskedTextBox TbxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxRG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbxEstadoCivil;
        private System.Windows.Forms.ComboBox CbxFuncao;
        private System.Windows.Forms.MaskedTextBox TbxDtNasc;
        private System.Windows.Forms.MaskedTextBox MtbMatricula;
    }
}