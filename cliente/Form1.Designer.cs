namespace ProjetoTCC
{
    partial class Form1Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rBttnFem = new System.Windows.Forms.RadioButton();
            this.rBttnMasc = new System.Windows.Forms.RadioButton();
            this.txtbIdade = new System.Windows.Forms.TextBox();
            this.txtbCPF = new System.Windows.Forms.TextBox();
            this.txtbRG = new System.Windows.Forms.TextBox();
            this.txtbSobre = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.cBoxCidade = new System.Windows.Forms.ComboBox();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.Idade = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.Cpf = new System.Windows.Forms.Label();
            this.Rg = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bttnSair = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.bttnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtErroNome = new System.Windows.Forms.Label();
            this.txtErroRG = new System.Windows.Forms.Label();
            this.txtErroCPF = new System.Windows.Forms.Label();
            this.txtErroCidade = new System.Windows.Forms.Label();
            this.txtErroSobre = new System.Windows.Forms.Label();
            this.txtErroEstado = new System.Windows.Forms.Label();
            this.txtErroSexo = new System.Windows.Forms.Label();
            this.txtErroIdade = new System.Windows.Forms.Label();
            this.lblTamCamisa = new System.Windows.Forms.Label();
            this.lblTamCalça = new System.Windows.Forms.Label();
            this.cBoxTamSup = new System.Windows.Forms.ComboBox();
            this.cBoxTamInf = new System.Windows.Forms.ComboBox();
            this.txtErroTamSup = new System.Windows.Forms.Label();
            this.txtErroTamInf = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bttnOrdCadastro = new System.Windows.Forms.Button();
            this.bttnEdCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.CadastroOk);
            // 
            // rBttnFem
            // 
            this.rBttnFem.AutoSize = true;
            this.rBttnFem.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBttnFem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rBttnFem.Location = new System.Drawing.Point(201, 317);
            this.rBttnFem.Name = "rBttnFem";
            this.rBttnFem.Size = new System.Drawing.Size(83, 29);
            this.rBttnFem.TabIndex = 42;
            this.rBttnFem.TabStop = true;
            this.rBttnFem.Text = "Feminino";
            this.rBttnFem.UseVisualStyleBackColor = true;
            // 
            // rBttnMasc
            // 
            this.rBttnMasc.AutoSize = true;
            this.rBttnMasc.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBttnMasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rBttnMasc.Location = new System.Drawing.Point(102, 317);
            this.rBttnMasc.Name = "rBttnMasc";
            this.rBttnMasc.Size = new System.Drawing.Size(88, 29);
            this.rBttnMasc.TabIndex = 41;
            this.rBttnMasc.TabStop = true;
            this.rBttnMasc.Text = "Masculino";
            this.rBttnMasc.UseVisualStyleBackColor = true;
            // 
            // txtbIdade
            // 
            this.txtbIdade.Location = new System.Drawing.Point(517, 325);
            this.txtbIdade.Name = "txtbIdade";
            this.txtbIdade.Size = new System.Drawing.Size(100, 22);
            this.txtbIdade.TabIndex = 40;
            // 
            // txtbCPF
            // 
            this.txtbCPF.Location = new System.Drawing.Point(517, 179);
            this.txtbCPF.Name = "txtbCPF";
            this.txtbCPF.Size = new System.Drawing.Size(100, 22);
            this.txtbCPF.TabIndex = 39;
            // 
            // txtbRG
            // 
            this.txtbRG.Location = new System.Drawing.Point(102, 179);
            this.txtbRG.Name = "txtbRG";
            this.txtbRG.Size = new System.Drawing.Size(100, 22);
            this.txtbRG.TabIndex = 38;
            // 
            // txtbSobre
            // 
            this.txtbSobre.Location = new System.Drawing.Point(517, 109);
            this.txtbSobre.Name = "txtbSobre";
            this.txtbSobre.Size = new System.Drawing.Size(100, 22);
            this.txtbSobre.TabIndex = 37;
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(102, 114);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 22);
            this.txtbNome.TabIndex = 36;
            // 
            // cBoxCidade
            // 
            this.cBoxCidade.AllowDrop = true;
            this.cBoxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCidade.FormattingEnabled = true;
            this.cBoxCidade.Items.AddRange(new object[] {
            "Ribeirão Preto",
            "Orlândia",
            "Franca",
            "Pirassununga"});
            this.cBoxCidade.Location = new System.Drawing.Point(517, 251);
            this.cBoxCidade.Name = "cBoxCidade";
            this.cBoxCidade.Size = new System.Drawing.Size(100, 24);
            this.cBoxCidade.TabIndex = 35;
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.AllowDrop = true;
            this.cBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cBoxEstado.Location = new System.Drawing.Point(102, 251);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(100, 24);
            this.cBoxEstado.TabIndex = 34;
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.BackColor = System.Drawing.Color.Transparent;
            this.Idade.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Idade.Location = new System.Drawing.Point(352, 321);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(66, 25);
            this.Idade.TabIndex = 33;
            this.Idade.Text = "Idade :";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.BackColor = System.Drawing.Color.Transparent;
            this.Sexo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sexo.Location = new System.Drawing.Point(7, 317);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(61, 25);
            this.Sexo.TabIndex = 32;
            this.Sexo.Text = "Sexo :";
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.BackColor = System.Drawing.Color.Transparent;
            this.Cidade.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cidade.Location = new System.Drawing.Point(352, 247);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(78, 25);
            this.Cidade.TabIndex = 31;
            this.Cidade.Text = "Cidade :";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Estado.Location = new System.Drawing.Point(3, 247);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(77, 25);
            this.Estado.TabIndex = 30;
            this.Estado.Text = "Estado :";
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.BackColor = System.Drawing.Color.Transparent;
            this.Cpf.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cpf.Location = new System.Drawing.Point(352, 175);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(56, 25);
            this.Cpf.TabIndex = 29;
            this.Cpf.Text = "CPF :";
            // 
            // Rg
            // 
            this.Rg.AutoSize = true;
            this.Rg.BackColor = System.Drawing.Color.Transparent;
            this.Rg.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rg.Location = new System.Drawing.Point(3, 179);
            this.Rg.Name = "Rg";
            this.Rg.Size = new System.Drawing.Size(47, 25);
            this.Rg.TabIndex = 28;
            this.Rg.Text = "RG :";
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.Sobrenome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrenome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sobrenome.Location = new System.Drawing.Point(352, 110);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(113, 25);
            this.Sobrenome.TabIndex = 27;
            this.Sobrenome.Text = "Sobrenome :";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nome.Location = new System.Drawing.Point(3, 110);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(70, 27);
            this.Nome.TabIndex = 26;
            this.Nome.Text = "Nome :";
            // 
            // bttnSair
            // 
            this.bttnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSair.Location = new System.Drawing.Point(619, 510);
            this.bttnSair.Name = "bttnSair";
            this.bttnSair.Size = new System.Drawing.Size(108, 40);
            this.bttnSair.TabIndex = 25;
            this.bttnSair.Text = "Sair";
            this.bttnSair.UseVisualStyleBackColor = true;
            this.bttnSair.Click += new System.EventHandler(this.bttnSair_Click_1);
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpar.Location = new System.Drawing.Point(467, 510);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(108, 40);
            this.bttnLimpar.TabIndex = 24;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // bttnCadastrar
            // 
            this.bttnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnCadastrar.FlatAppearance.BorderSize = 0;
            this.bttnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCadastrar.Location = new System.Drawing.Point(12, 510);
            this.bttnCadastrar.Name = "bttnCadastrar";
            this.bttnCadastrar.Size = new System.Drawing.Size(108, 40);
            this.bttnCadastrar.TabIndex = 23;
            this.bttnCadastrar.Text = "Cadastrar";
            this.bttnCadastrar.UseVisualStyleBackColor = true;
            this.bttnCadastrar.Click += new System.EventHandler(this.bttnCadastrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // txtErroNome
            // 
            this.txtErroNome.AutoSize = true;
            this.txtErroNome.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroNome.Location = new System.Drawing.Point(99, 147);
            this.txtErroNome.Name = "txtErroNome";
            this.txtErroNome.Size = new System.Drawing.Size(108, 16);
            this.txtErroNome.TabIndex = 43;
            this.txtErroNome.Text = "Dados não inseridos!";
            this.txtErroNome.Visible = false;
            // 
            // txtErroRG
            // 
            this.txtErroRG.AutoSize = true;
            this.txtErroRG.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroRG.Location = new System.Drawing.Point(99, 220);
            this.txtErroRG.Name = "txtErroRG";
            this.txtErroRG.Size = new System.Drawing.Size(108, 16);
            this.txtErroRG.TabIndex = 44;
            this.txtErroRG.Text = "Dados não inseridos!";
            this.txtErroRG.Visible = false;
            // 
            // txtErroCPF
            // 
            this.txtErroCPF.AutoSize = true;
            this.txtErroCPF.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroCPF.Location = new System.Drawing.Point(514, 220);
            this.txtErroCPF.Name = "txtErroCPF";
            this.txtErroCPF.Size = new System.Drawing.Size(108, 16);
            this.txtErroCPF.TabIndex = 45;
            this.txtErroCPF.Text = "Dados não inseridos!";
            this.txtErroCPF.Visible = false;
            // 
            // txtErroCidade
            // 
            this.txtErroCidade.AutoSize = true;
            this.txtErroCidade.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroCidade.Location = new System.Drawing.Point(514, 292);
            this.txtErroCidade.Name = "txtErroCidade";
            this.txtErroCidade.Size = new System.Drawing.Size(108, 16);
            this.txtErroCidade.TabIndex = 46;
            this.txtErroCidade.Text = "Dados não inseridos!";
            this.txtErroCidade.Visible = false;
            // 
            // txtErroSobre
            // 
            this.txtErroSobre.AutoSize = true;
            this.txtErroSobre.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroSobre.Location = new System.Drawing.Point(514, 147);
            this.txtErroSobre.Name = "txtErroSobre";
            this.txtErroSobre.Size = new System.Drawing.Size(108, 16);
            this.txtErroSobre.TabIndex = 47;
            this.txtErroSobre.Text = "Dados não inseridos!";
            this.txtErroSobre.Visible = false;
            // 
            // txtErroEstado
            // 
            this.txtErroEstado.AutoSize = true;
            this.txtErroEstado.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroEstado.Location = new System.Drawing.Point(99, 292);
            this.txtErroEstado.Name = "txtErroEstado";
            this.txtErroEstado.Size = new System.Drawing.Size(108, 16);
            this.txtErroEstado.TabIndex = 48;
            this.txtErroEstado.Text = "Dados não inseridos!";
            this.txtErroEstado.UseWaitCursor = true;
            this.txtErroEstado.Visible = false;
            // 
            // txtErroSexo
            // 
            this.txtErroSexo.AutoSize = true;
            this.txtErroSexo.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroSexo.Location = new System.Drawing.Point(99, 358);
            this.txtErroSexo.Name = "txtErroSexo";
            this.txtErroSexo.Size = new System.Drawing.Size(108, 16);
            this.txtErroSexo.TabIndex = 49;
            this.txtErroSexo.Text = "Dados não inseridos!";
            this.txtErroSexo.Visible = false;
            // 
            // txtErroIdade
            // 
            this.txtErroIdade.AutoSize = true;
            this.txtErroIdade.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroIdade.Location = new System.Drawing.Point(514, 358);
            this.txtErroIdade.Name = "txtErroIdade";
            this.txtErroIdade.Size = new System.Drawing.Size(108, 16);
            this.txtErroIdade.TabIndex = 50;
            this.txtErroIdade.Text = "Dados não inseridos!";
            this.txtErroIdade.Visible = false;
            // 
            // lblTamCamisa
            // 
            this.lblTamCamisa.AutoSize = true;
            this.lblTamCamisa.BackColor = System.Drawing.Color.Transparent;
            this.lblTamCamisa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamCamisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTamCamisa.Location = new System.Drawing.Point(7, 408);
            this.lblTamCamisa.Name = "lblTamCamisa";
            this.lblTamCamisa.Size = new System.Drawing.Size(179, 25);
            this.lblTamCamisa.TabIndex = 51;
            this.lblTamCamisa.Text = "Tam. Peça Superior :";
            // 
            // lblTamCalça
            // 
            this.lblTamCalça.AutoSize = true;
            this.lblTamCalça.BackColor = System.Drawing.Color.Transparent;
            this.lblTamCalça.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamCalça.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTamCalça.Location = new System.Drawing.Point(352, 408);
            this.lblTamCalça.Name = "lblTamCalça";
            this.lblTamCalça.Size = new System.Drawing.Size(167, 25);
            this.lblTamCalça.TabIndex = 52;
            this.lblTamCalça.Text = "Tam. Peça Inferior :";
            // 
            // cBoxTamSup
            // 
            this.cBoxTamSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTamSup.DropDownWidth = 50;
            this.cBoxTamSup.FormattingEnabled = true;
            this.cBoxTamSup.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG"});
            this.cBoxTamSup.Location = new System.Drawing.Point(227, 412);
            this.cBoxTamSup.Name = "cBoxTamSup";
            this.cBoxTamSup.Size = new System.Drawing.Size(47, 24);
            this.cBoxTamSup.TabIndex = 53;
            // 
            // cBoxTamInf
            // 
            this.cBoxTamInf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTamInf.FormattingEnabled = true;
            this.cBoxTamInf.Items.AddRange(new object[] {
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48"});
            this.cBoxTamInf.Location = new System.Drawing.Point(567, 412);
            this.cBoxTamInf.Name = "cBoxTamInf";
            this.cBoxTamInf.Size = new System.Drawing.Size(50, 24);
            this.cBoxTamInf.TabIndex = 54;
            // 
            // txtErroTamSup
            // 
            this.txtErroTamSup.AutoSize = true;
            this.txtErroTamSup.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroTamSup.Location = new System.Drawing.Point(99, 453);
            this.txtErroTamSup.Name = "txtErroTamSup";
            this.txtErroTamSup.Size = new System.Drawing.Size(108, 16);
            this.txtErroTamSup.TabIndex = 55;
            this.txtErroTamSup.Text = "Dados não inseridos!";
            this.txtErroTamSup.Visible = false;
            // 
            // txtErroTamInf
            // 
            this.txtErroTamInf.AutoSize = true;
            this.txtErroTamInf.ForeColor = System.Drawing.Color.Maroon;
            this.txtErroTamInf.Location = new System.Drawing.Point(514, 453);
            this.txtErroTamInf.Name = "txtErroTamInf";
            this.txtErroTamInf.Size = new System.Drawing.Size(108, 16);
            this.txtErroTamInf.TabIndex = 56;
            this.txtErroTamInf.Text = "Dados não inseridos!";
            this.txtErroTamInf.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bttnOrdCadastro
            // 
            this.bttnOrdCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOrdCadastro.Location = new System.Drawing.Point(166, 510);
            this.bttnOrdCadastro.Name = "bttnOrdCadastro";
            this.bttnOrdCadastro.Size = new System.Drawing.Size(108, 40);
            this.bttnOrdCadastro.TabIndex = 57;
            this.bttnOrdCadastro.Text = "Ordenar Cadastro";
            this.bttnOrdCadastro.UseVisualStyleBackColor = true;
            this.bttnOrdCadastro.Click += new System.EventHandler(this.bttnOrdCadastro_Click);
            // 
            // bttnEdCadastro
            // 
            this.bttnEdCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEdCadastro.Location = new System.Drawing.Point(310, 510);
            this.bttnEdCadastro.Name = "bttnEdCadastro";
            this.bttnEdCadastro.Size = new System.Drawing.Size(108, 40);
            this.bttnEdCadastro.TabIndex = 58;
            this.bttnEdCadastro.Text = "Editar Cadastro";
            this.bttnEdCadastro.UseVisualStyleBackColor = true;
            this.bttnEdCadastro.Click += new System.EventHandler(this.bttnEdCadastro_Click);
            // 
            // Form1Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(739, 571);
            this.Controls.Add(this.bttnEdCadastro);
            this.Controls.Add(this.bttnOrdCadastro);
            this.Controls.Add(this.txtErroTamInf);
            this.Controls.Add(this.txtErroTamSup);
            this.Controls.Add(this.cBoxTamInf);
            this.Controls.Add(this.cBoxTamSup);
            this.Controls.Add(this.lblTamCalça);
            this.Controls.Add(this.lblTamCamisa);
            this.Controls.Add(this.txtErroIdade);
            this.Controls.Add(this.txtErroSexo);
            this.Controls.Add(this.txtErroEstado);
            this.Controls.Add(this.txtErroSobre);
            this.Controls.Add(this.txtErroCidade);
            this.Controls.Add(this.txtErroCPF);
            this.Controls.Add(this.txtErroRG);
            this.Controls.Add(this.txtErroNome);
            this.Controls.Add(this.rBttnFem);
            this.Controls.Add(this.rBttnMasc);
            this.Controls.Add(this.txtbIdade);
            this.Controls.Add(this.txtbCPF);
            this.Controls.Add(this.txtbRG);
            this.Controls.Add(this.txtbSobre);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.cBoxCidade);
            this.Controls.Add(this.cBoxEstado);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Cpf);
            this.Controls.Add(this.Rg);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.bttnSair);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnCadastrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton rBttnFem;
        private System.Windows.Forms.RadioButton rBttnMasc;
        private System.Windows.Forms.TextBox txtbIdade;
        private System.Windows.Forms.TextBox txtbCPF;
        private System.Windows.Forms.TextBox txtbRG;
        private System.Windows.Forms.TextBox txtbSobre;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.ComboBox cBoxCidade;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Label Rg;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bttnSair;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.Button bttnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtErroNome;
        private System.Windows.Forms.Label txtErroRG;
        private System.Windows.Forms.Label txtErroCPF;
        private System.Windows.Forms.Label txtErroCidade;
        private System.Windows.Forms.Label txtErroSobre;
        private System.Windows.Forms.Label txtErroEstado;
        private System.Windows.Forms.Label txtErroSexo;
        private System.Windows.Forms.Label txtErroIdade;
        private System.Windows.Forms.Label lblTamCamisa;
        private System.Windows.Forms.Label lblTamCalça;
        private System.Windows.Forms.ComboBox cBoxTamSup;
        private System.Windows.Forms.ComboBox cBoxTamInf;
        private System.Windows.Forms.Label txtErroTamSup;
        private System.Windows.Forms.Label txtErroTamInf;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bttnOrdCadastro;
        private System.Windows.Forms.Button bttnEdCadastro;
    }
}

