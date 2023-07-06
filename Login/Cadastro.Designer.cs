namespace Login
{
    partial class Cadastro
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
            groupBox1 = new GroupBox();
            tbUsuario = new TextBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            tbSenha = new TextBox();
            mtCpf = new MaskedTextBox();
            tbSobrenome = new TextBox();
            btCadastro = new MetroFramework.Controls.MetroButton();
            btCancela = new MetroFramework.Controls.MetroButton();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            tbEmail = new TextBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            tbNome = new TextBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            lCadastro = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lCadastro);
            groupBox1.Controls.Add(tbUsuario);
            groupBox1.Controls.Add(metroLabel6);
            groupBox1.Controls.Add(tbSenha);
            groupBox1.Controls.Add(mtCpf);
            groupBox1.Controls.Add(tbSobrenome);
            groupBox1.Controls.Add(btCadastro);
            groupBox1.Controls.Add(btCancela);
            groupBox1.Controls.Add(metroLabel5);
            groupBox1.Controls.Add(metroLabel3);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(metroLabel4);
            groupBox1.Controls.Add(metroLabel2);
            groupBox1.Controls.Add(tbNome);
            groupBox1.Controls.Add(metroLabel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(9, 173);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(276, 27);
            tbUsuario.TabIndex = 20;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Location = new Point(9, 151);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(56, 19);
            metroLabel6.TabIndex = 19;
            metroLabel6.Text = "Usuário:";
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(9, 333);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(276, 27);
            tbSenha.TabIndex = 18;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // mtCpf
            // 
            mtCpf.Location = new Point(9, 225);
            mtCpf.Mask = "000000000-00";
            mtCpf.Name = "mtCpf";
            mtCpf.Size = new Size(276, 27);
            mtCpf.TabIndex = 17;
            // 
            // tbSobrenome
            // 
            tbSobrenome.Location = new Point(9, 121);
            tbSobrenome.Name = "tbSobrenome";
            tbSobrenome.Size = new Size(276, 27);
            tbSobrenome.TabIndex = 16;
            // 
            // btCadastro
            // 
            btCadastro.Location = new Point(210, 377);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(75, 23);
            btCadastro.TabIndex = 15;
            btCadastro.Text = "Cadastrar";
            btCadastro.UseSelectable = true;
            btCadastro.Click += btCadastro_Click;
            // 
            // btCancela
            // 
            btCancela.Location = new Point(129, 377);
            btCancela.Name = "btCancela";
            btCancela.Size = new Size(75, 23);
            btCancela.TabIndex = 14;
            btCancela.Text = "Cancelar";
            btCancela.UseSelectable = true;
            btCancela.Click += btCancela_Click;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Location = new Point(9, 203);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(36, 19);
            metroLabel5.TabIndex = 12;
            metroLabel5.Text = "CPF:";
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Location = new Point(9, 311);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(47, 19);
            metroLabel3.TabIndex = 10;
            metroLabel3.Text = "Senha:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(9, 277);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(276, 27);
            tbEmail.TabIndex = 9;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Location = new Point(9, 255);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(44, 19);
            metroLabel4.TabIndex = 8;
            metroLabel4.Text = "Email:";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Location = new Point(9, 99);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(81, 19);
            metroLabel2.TabIndex = 6;
            metroLabel2.Text = "Sobrenome:";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(9, 65);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(276, 27);
            tbNome.TabIndex = 5;
            tbNome.TextChanged += tb1_TextChanged;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new Point(9, 43);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(49, 19);
            metroLabel1.TabIndex = 4;
            metroLabel1.Text = "Nome:";
            // 
            // lCadastro
            // 
            lCadastro.AutoSize = true;
            lCadastro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lCadastro.LinkColor = Color.Black;
            lCadastro.Location = new Point(9, 381);
            lCadastro.Name = "lCadastro";
            lCadastro.Size = new Size(43, 19);
            lCadastro.TabIndex = 21;
            lCadastro.TabStop = true;
            lCadastro.Text = "Login";
            lCadastro.LinkClicked += lCadastro_LinkClicked;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 526);
            Controls.Add(groupBox1);
            Name = "Cadastro";
            Text = "Sistema TST";
            Load += Cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MaskedTextBox maskedTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox tbEmail;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MaskedTextBox tb2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private TextBox tbNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btCadastro;
        private MetroFramework.Controls.MetroButton btCancela;
        private MaskedTextBox mtCpf;
        private TextBox tbSobrenome;
        private TextBox tbUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private TextBox tbSenha;
        private LinkLabel lCadastro;
    }
}