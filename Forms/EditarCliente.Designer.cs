namespace Pim_Terceiro_Semestre
{
    partial class EditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCliente));
            bttVoltar = new Button();
            picFazerCadastro = new PictureBox();
            picCancelar = new PictureBox();
            bttCancelarCadastro = new Button();
            bttAttCadastro = new Button();
            txtRamo = new TextBox();
            txtCNPJ = new TextBox();
            txtEstado = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtNomeEmpresa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picFazerCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            SuspendLayout();
            // 
            // bttVoltar
            // 
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.FlatStyle = FlatStyle.Popup;
            bttVoltar.Location = new Point(993, 68);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(134, 54);
            bttVoltar.TabIndex = 42;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // picFazerCadastro
            // 
            picFazerCadastro.Image = (Image)resources.GetObject("picFazerCadastro.Image");
            picFazerCadastro.Location = new Point(129, 513);
            picFazerCadastro.Name = "picFazerCadastro";
            picFazerCadastro.Size = new Size(103, 79);
            picFazerCadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            picFazerCadastro.TabIndex = 41;
            picFazerCadastro.TabStop = false;
            // 
            // picCancelar
            // 
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(613, 513);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(103, 79);
            picCancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCancelar.TabIndex = 40;
            picCancelar.TabStop = false;
            // 
            // bttCancelarCadastro
            // 
            bttCancelarCadastro.BackColor = Color.IndianRed;
            bttCancelarCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            bttCancelarCadastro.FlatStyle = FlatStyle.Popup;
            bttCancelarCadastro.Location = new Point(745, 534);
            bttCancelarCadastro.Name = "bttCancelarCadastro";
            bttCancelarCadastro.Size = new Size(188, 42);
            bttCancelarCadastro.TabIndex = 39;
            bttCancelarCadastro.Text = "Cancelar cadastro";
            bttCancelarCadastro.UseVisualStyleBackColor = false;
            bttCancelarCadastro.Click += bttCancelarCadastro_Click;
            // 
            // bttAttCadastro
            // 
            bttAttCadastro.BackColor = Color.FromArgb(128, 255, 128);
            bttAttCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            bttAttCadastro.FlatStyle = FlatStyle.Popup;
            bttAttCadastro.Location = new Point(271, 534);
            bttAttCadastro.Name = "bttAttCadastro";
            bttAttCadastro.Size = new Size(188, 42);
            bttAttCadastro.TabIndex = 38;
            bttAttCadastro.Text = "Atualizar Cadasro";
            bttAttCadastro.UseVisualStyleBackColor = false;
            bttAttCadastro.Click += bttAttCadastro_Click;
            // 
            // txtRamo
            // 
            txtRamo.BackColor = SystemColors.GradientActiveCaption;
            txtRamo.ForeColor = SystemColors.MenuText;
            txtRamo.Location = new Point(117, 251);
            txtRamo.Name = "txtRamo";
            txtRamo.PlaceholderText = "Ramo de Atuação:";
            txtRamo.Size = new Size(341, 31);
            txtRamo.TabIndex = 37;
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = SystemColors.GradientActiveCaption;
            txtCNPJ.ForeColor = SystemColors.MenuText;
            txtCNPJ.Location = new Point(117, 288);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ da Empresa:";
            txtCNPJ.Size = new Size(341, 31);
            txtCNPJ.TabIndex = 36;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.GradientActiveCaption;
            txtEstado.ForeColor = SystemColors.MenuText;
            txtEstado.Location = new Point(117, 325);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado de Registro:";
            txtEstado.Size = new Size(341, 31);
            txtEstado.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.GradientActiveCaption;
            txtEmail.ForeColor = SystemColors.MenuText;
            txtEmail.Location = new Point(117, 362);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(341, 31);
            txtEmail.TabIndex = 34;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.GradientActiveCaption;
            txtSenha.ForeColor = SystemColors.MenuText;
            txtSenha.Location = new Point(117, 399);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha para Acesso:";
            txtSenha.Size = new Size(341, 31);
            txtSenha.TabIndex = 33;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = SystemColors.GradientActiveCaption;
            txtNomeEmpresa.ForeColor = SystemColors.MenuText;
            txtNomeEmpresa.Location = new Point(117, 214);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.PlaceholderText = "Nome da Empresa:";
            txtNomeEmpresa.Size = new Size(341, 31);
            txtNomeEmpresa.TabIndex = 32;
            // 
            // EditarCliente
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 685);
            Controls.Add(bttVoltar);
            Controls.Add(picFazerCadastro);
            Controls.Add(picCancelar);
            Controls.Add(bttCancelarCadastro);
            Controls.Add(bttAttCadastro);
            Controls.Add(txtRamo);
            Controls.Add(txtCNPJ);
            Controls.Add(txtEstado);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeEmpresa);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarCliente";
            Load += EditarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)picFazerCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttVoltar;
        private PictureBox picFazerCadastro;
        private PictureBox picCancelar;
        private Button bttCancelarCadastro;
        private Button bttAttCadastro;
        private TextBox txtRamo;
        private TextBox txtCNPJ;
        private TextBox txtEstado;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtNomeEmpresa;
    }
}