namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lCadastro = new LinkLabel();
            btEntra = new MetroFramework.Controls.MetroButton();
            btCancela = new MetroFramework.Controls.MetroButton();
            tb2 = new MaskedTextBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            tb1 = new TextBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lCadastro);
            groupBox1.Controls.Add(btEntra);
            groupBox1.Controls.Add(btCancela);
            groupBox1.Controls.Add(tb2);
            groupBox1.Controls.Add(metroLabel2);
            groupBox1.Controls.Add(tb1);
            groupBox1.Controls.Add(metroLabel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lCadastro
            // 
            lCadastro.AutoSize = true;
            lCadastro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lCadastro.LinkColor = Color.Black;
            lCadastro.Location = new Point(6, 171);
            lCadastro.Name = "lCadastro";
            lCadastro.Size = new Size(68, 19);
            lCadastro.TabIndex = 6;
            lCadastro.TabStop = true;
            lCadastro.Text = "Cadastrar";
            lCadastro.LinkClicked += lCadastro_LinkClicked;
            // 
            // btEntra
            // 
            btEntra.Location = new Point(381, 167);
            btEntra.Name = "btEntra";
            btEntra.Size = new Size(75, 23);
            btEntra.TabIndex = 5;
            btEntra.Text = "Entrar";
            btEntra.UseSelectable = true;
            btEntra.Click += metroButton2_Click;
            // 
            // btCancela
            // 
            btCancela.Location = new Point(300, 167);
            btCancela.Name = "btCancela";
            btCancela.Size = new Size(75, 23);
            btCancela.TabIndex = 4;
            btCancela.Text = "Cancelar";
            btCancela.UseSelectable = true;
            btCancela.Click += btCancela_Click;
            // 
            // tb2
            // 
            tb2.Location = new Point(6, 122);
            tb2.Name = "tb2";
            tb2.Size = new Size(450, 27);
            tb2.TabIndex = 3;
            tb2.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Location = new Point(6, 100);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(47, 19);
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "Senha:";
            // 
            // tb1
            // 
            tb1.Location = new Point(6, 52);
            tb1.Name = "tb1";
            tb1.Size = new Size(450, 27);
            tb1.TabIndex = 1;
            tb1.TextChanged += tb1_TextChanged;
            tb1.KeyPress += tb1_KeyPress;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new Point(6, 30);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(56, 19);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Usuário:";
            metroLabel1.Click += metroLabel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 334);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sistema TST";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox tb2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private TextBox tb1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btEntra;
        private MetroFramework.Controls.MetroButton btCancela;
        private LinkLabel lCadastro;
    }
}