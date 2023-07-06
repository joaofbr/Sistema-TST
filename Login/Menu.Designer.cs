namespace Login
{
    partial class Menu
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
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            lbSaldo = new MetroFramework.Controls.MetroLabel();
            lb3 = new MetroFramework.Controls.MetroLabel();
            lbNome = new MetroFramework.Controls.MetroLabel();
            tbTransfere = new TextBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Location = new Point(653, 88);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(45, 19);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Saldo:";
            // 
            // lbSaldo
            // 
            lbSaldo.AutoSize = true;
            lbSaldo.Location = new Point(704, 88);
            lbSaldo.Name = "lbSaldo";
            lbSaldo.Size = new Size(16, 19);
            lbSaldo.TabIndex = 1;
            lbSaldo.Text = "0";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(23, 88);
            lb3.Name = "lb3";
            lb3.Size = new Size(30, 19);
            lb3.TabIndex = 2;
            lb3.Text = "Olá";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(59, 88);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(15, 19);
            lbNome.TabIndex = 3;
            lbNome.Text = "-";
            lbNome.Click += lbNome_Click;
            // 
            // tbTransfere
            // 
            tbTransfere.Location = new Point(23, 207);
            tbTransfere.Name = "tbTransfere";
            tbTransfere.Size = new Size(316, 23);
            tbTransfere.TabIndex = 4;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Location = new Point(23, 185);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(84, 19);
            metroLabel2.TabIndex = 5;
            metroLabel2.Text = "Transferência";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(metroLabel2);
            Controls.Add(tbTransfere);
            Controls.Add(lbNome);
            Controls.Add(lb3);
            Controls.Add(lbSaldo);
            Controls.Add(metroLabel1);
            Name = "Menu";
            Text = "Banco TST";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbSaldo;
        private MetroFramework.Controls.MetroLabel lb3;
        private MetroFramework.Controls.MetroLabel lbNome;
        private TextBox tbTransfere;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}