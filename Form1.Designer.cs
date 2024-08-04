namespace DemoCRUD
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
            lblEmail = new Label();
            lblCPF = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btnSalvar = new Button();
            btnPesquisar = new Button();
            btnAtualizar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblEmail.Location = new Point(18, 86);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 18);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblCPF.Location = new Point(18, 141);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(42, 18);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblEndereco.Location = new Point(18, 203);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(81, 18);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            lblEndereco.Click += lblEndereco_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblNome.Location = new Point(18, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 18);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 11.25F);
            txtNome.Location = new Point(111, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(294, 25);
            txtNome.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 11.25F);
            txtEmail.Location = new Point(111, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 25);
            txtEmail.TabIndex = 6;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Arial", 11.25F);
            txtCPF.Location = new Point(111, 141);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(294, 25);
            txtCPF.TabIndex = 7;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 11.25F);
            txtEndereco.Location = new Point(111, 203);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(294, 25);
            txtEndereco.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(394, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(287, 266);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Buscar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(182, 266);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(86, 266);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Deletar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 321);
            Controls.Add(button1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblEndereco);
            Controls.Add(lblCPF);
            Controls.Add(lblEmail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEmail;
        private Label lblCPF;
        private Label lblEndereco;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btnSalvar;
        private Button btnPesquisar;
        private Button btnAtualizar;
        private Button button1;
    }
}
