namespace Pim_Terceiro_Semestre
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            picFazerCadastro = new PictureBox();
            picCancelar = new PictureBox();
            bttCancelarCadastro = new Button();
            bttCadastrarCliente = new Button();
            txtRamo = new TextBox();
            txtCNPJ = new TextBox();
            txtEstado = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtNomeEmpresa = new TextBox();
            bttVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFazerCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            SuspendLayout();
            // 
            // picFazerCadastro
            // 
            picFazerCadastro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picFazerCadastro.Image = (Image)resources.GetObject("picFazerCadastro.Image");
            picFazerCadastro.Location = new Point(113, 488);
            picFazerCadastro.Name = "picFazerCadastro";
            picFazerCadastro.Size = new Size(103, 79);
            picFazerCadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            picFazerCadastro.TabIndex = 30;
            picFazerCadastro.TabStop = false;
            // 
            // picCancelar
            // 
            picCancelar.Anchor = AnchorStyles.None;
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(597, 488);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(103, 79);
            picCancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCancelar.TabIndex = 29;
            picCancelar.TabStop = false;
            // 
            // bttCancelarCadastro
            // 
            bttCancelarCadastro.Anchor = AnchorStyles.None;
            bttCancelarCadastro.AutoSize = true;
            bttCancelarCadastro.BackColor = Color.IndianRed;
            bttCancelarCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            bttCancelarCadastro.FlatStyle = FlatStyle.Popup;
            bttCancelarCadastro.Location = new Point(745, 509);
            bttCancelarCadastro.Name = "bttCancelarCadastro";
            bttCancelarCadastro.Size = new Size(172, 33);
            bttCancelarCadastro.TabIndex = 28;
            bttCancelarCadastro.Text = "Cancelar cadastro";
            bttCancelarCadastro.UseVisualStyleBackColor = false;
            bttCancelarCadastro.Click += bttCancelarCadastro_Click;
            // 
            // bttCadastrarCliente
            // 
            bttCadastrarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bttCadastrarCliente.BackColor = Color.FromArgb(128, 255, 128);
            bttCadastrarCliente.BackgroundImageLayout = ImageLayout.Stretch;
            bttCadastrarCliente.FlatStyle = FlatStyle.Popup;
            bttCadastrarCliente.Location = new Point(255, 509);
            bttCadastrarCliente.Name = "bttCadastrarCliente";
            bttCadastrarCliente.Size = new Size(188, 42);
            bttCadastrarCliente.TabIndex = 27;
            bttCadastrarCliente.Text = "Fazer cadastro";
            bttCadastrarCliente.UseVisualStyleBackColor = false;
            bttCadastrarCliente.Click += bttCadastrarCliente_Click;
            // 
            // txtRamo
            // 
            txtRamo.BackColor = SystemColors.GradientActiveCaption;
            txtRamo.ForeColor = SystemColors.MenuText;
            txtRamo.Location = new Point(101, 226);
            txtRamo.MaxLength = 50;
            txtRamo.Name = "txtRamo";
            txtRamo.PlaceholderText = "Ramo de Atuação:";
            txtRamo.Size = new Size(341, 31);
            txtRamo.TabIndex = 22;
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = SystemColors.GradientActiveCaption;
            txtCNPJ.ForeColor = SystemColors.MenuText;
            txtCNPJ.Location = new Point(101, 263);
            txtCNPJ.MaxLength = 11;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ da Empresa:";
            txtCNPJ.Size = new Size(341, 31);
            txtCNPJ.TabIndex = 21;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.GradientActiveCaption;
            txtEstado.ForeColor = SystemColors.MenuText;
            txtEstado.Location = new Point(101, 300);
            txtEstado.MaxLength = 20;
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado do Registro:";
            txtEstado.Size = new Size(341, 31);
            txtEstado.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.GradientActiveCaption;
            txtEmail.ForeColor = SystemColors.MenuText;
            txtEmail.Location = new Point(101, 337);
            txtEmail.MaxLength = 256;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(341, 31);
            txtEmail.TabIndex = 19;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.GradientActiveCaption;
            txtSenha.ForeColor = SystemColors.MenuText;
            txtSenha.Location = new Point(101, 374);
            txtSenha.MaxLength = 20;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha para Acesso:";
            txtSenha.Size = new Size(341, 31);
            txtSenha.TabIndex = 18;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = SystemColors.GradientActiveCaption;
            txtNomeEmpresa.ForeColor = SystemColors.MenuText;
            txtNomeEmpresa.Location = new Point(101, 189);
            txtNomeEmpresa.MaxLength = 256;
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.PlaceholderText = "Nome da Empresa:";
            txtNomeEmpresa.Size = new Size(341, 31);
            txtNomeEmpresa.TabIndex = 17;
            // 
            // bttVoltar
            // 
            bttVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.Location = new Point(977, 43);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(134, 54);
            bttVoltar.TabIndex = 31;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 685);
            Controls.Add(bttVoltar);
            Controls.Add(picFazerCadastro);
            Controls.Add(picCancelar);
            Controls.Add(bttCancelarCadastro);
            Controls.Add(bttCadastrarCliente);
            Controls.Add(txtRamo);
            Controls.Add(txtCNPJ);
            Controls.Add(txtEstado);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeEmpresa);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)picFazerCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFazerCadastro;
        private PictureBox picCancelar;
        private Button bttCancelarCadastro;
        private Button bttCadastrarCliente;
        private TextBox txtRamo;
        private TextBox txtCNPJ;
        private TextBox txtEstado;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtNomeEmpresa;
        private Button bttVoltar;
    }
}