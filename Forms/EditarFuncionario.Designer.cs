namespace Pim_Terceiro_Semestre
{
    partial class EditarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionario));
            txtSalarioBruto = new TextBox();
            bttVoltar = new Button();
            picFazerCastro = new PictureBox();
            picCancelar = new PictureBox();
            bttCancelarCadastro = new Button();
            bttAttCadastro = new Button();
            txtReservista = new TextBox();
            txtEndereço = new TextBox();
            txtCEP = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtRG = new TextBox();
            txtCPF = new TextBox();
            txtPIS = new TextBox();
            txtCarteira = new TextBox();
            txtEmpresa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picFazerCastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            SuspendLayout();
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.BackColor = SystemColors.GradientActiveCaption;
            txtSalarioBruto.ForeColor = SystemColors.MenuText;
            txtSalarioBruto.Location = new Point(56, 401);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.PlaceholderText = "Salario Bruto:";
            txtSalarioBruto.Size = new Size(341, 31);
            txtSalarioBruto.TabIndex = 49;
            // 
            // bttVoltar
            // 
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.FlatStyle = FlatStyle.Popup;
            bttVoltar.Location = new Point(990, 80);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(134, 54);
            bttVoltar.TabIndex = 48;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // picFazerCastro
            // 
            picFazerCastro.Image = (Image)resources.GetObject("picFazerCastro.Image");
            picFazerCastro.Location = new Point(68, 515);
            picFazerCastro.Name = "picFazerCastro";
            picFazerCastro.Size = new Size(103, 79);
            picFazerCastro.SizeMode = PictureBoxSizeMode.StretchImage;
            picFazerCastro.TabIndex = 47;
            picFazerCastro.TabStop = false;
            // 
            // picCancelar
            // 
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(551, 515);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(103, 79);
            picCancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCancelar.TabIndex = 46;
            picCancelar.TabStop = false;
            // 
            // bttCancelarCadastro
            // 
            bttCancelarCadastro.BackColor = Color.IndianRed;
            bttCancelarCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            bttCancelarCadastro.FlatStyle = FlatStyle.Popup;
            bttCancelarCadastro.Location = new Point(683, 536);
            bttCancelarCadastro.Name = "bttCancelarCadastro";
            bttCancelarCadastro.Size = new Size(188, 42);
            bttCancelarCadastro.TabIndex = 45;
            bttCancelarCadastro.Text = "Cancelar cadastro";
            bttCancelarCadastro.UseVisualStyleBackColor = false;
            bttCancelarCadastro.Click += bttCancelarCadastro_Click;
            // 
            // bttAttCadastro
            // 
            bttAttCadastro.BackColor = Color.FromArgb(128, 255, 128);
            bttAttCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            bttAttCadastro.FlatStyle = FlatStyle.Popup;
            bttAttCadastro.Location = new Point(210, 536);
            bttAttCadastro.Name = "bttAttCadastro";
            bttAttCadastro.Size = new Size(188, 42);
            bttAttCadastro.TabIndex = 44;
            bttAttCadastro.Text = "Atualizar Cadastro";
            bttAttCadastro.UseVisualStyleBackColor = false;
            bttAttCadastro.Click += bttAttCadastro_Click;
            // 
            // txtReservista
            // 
            txtReservista.BackColor = SystemColors.GradientActiveCaption;
            txtReservista.ForeColor = SystemColors.MenuText;
            txtReservista.Location = new Point(529, 253);
            txtReservista.Name = "txtReservista";
            txtReservista.PlaceholderText = "N° da Reservista:";
            txtReservista.Size = new Size(341, 31);
            txtReservista.TabIndex = 43;
            // 
            // txtEndereço
            // 
            txtEndereço.BackColor = SystemColors.GradientActiveCaption;
            txtEndereço.ForeColor = SystemColors.MenuText;
            txtEndereço.Location = new Point(529, 290);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.PlaceholderText = "Endereço:";
            txtEndereço.Size = new Size(341, 31);
            txtEndereço.TabIndex = 42;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.GradientActiveCaption;
            txtCEP.ForeColor = SystemColors.MenuText;
            txtCEP.Location = new Point(529, 327);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP:";
            txtCEP.Size = new Size(341, 31);
            txtCEP.TabIndex = 41;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.GradientActiveCaption;
            txtSenha.ForeColor = SystemColors.MenuText;
            txtSenha.Location = new Point(529, 364);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha para Acesso:";
            txtSenha.Size = new Size(341, 31);
            txtSenha.TabIndex = 40;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.GradientActiveCaption;
            txtNome.ForeColor = SystemColors.MenuText;
            txtNome.Location = new Point(56, 253);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Funcionario:";
            txtNome.Size = new Size(341, 31);
            txtNome.TabIndex = 39;
            // 
            // txtRG
            // 
            txtRG.BackColor = SystemColors.GradientActiveCaption;
            txtRG.ForeColor = SystemColors.MenuText;
            txtRG.Location = new Point(56, 290);
            txtRG.Name = "txtRG";
            txtRG.PlaceholderText = "RG:";
            txtRG.Size = new Size(341, 31);
            txtRG.TabIndex = 38;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.GradientActiveCaption;
            txtCPF.ForeColor = SystemColors.MenuText;
            txtCPF.Location = new Point(56, 327);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF:";
            txtCPF.Size = new Size(341, 31);
            txtCPF.TabIndex = 37;
            // 
            // txtPIS
            // 
            txtPIS.BackColor = SystemColors.GradientActiveCaption;
            txtPIS.ForeColor = SystemColors.MenuText;
            txtPIS.Location = new Point(56, 364);
            txtPIS.Name = "txtPIS";
            txtPIS.PlaceholderText = "PIS:";
            txtPIS.Size = new Size(341, 31);
            txtPIS.TabIndex = 36;
            // 
            // txtCarteira
            // 
            txtCarteira.BackColor = SystemColors.GradientActiveCaption;
            txtCarteira.ForeColor = SystemColors.MenuText;
            txtCarteira.Location = new Point(529, 216);
            txtCarteira.Name = "txtCarteira";
            txtCarteira.PlaceholderText = "N° da Carteira de Trabalho";
            txtCarteira.Size = new Size(341, 31);
            txtCarteira.TabIndex = 35;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = SystemColors.GradientActiveCaption;
            txtEmpresa.ForeColor = SystemColors.MenuText;
            txtEmpresa.Location = new Point(56, 216);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PlaceholderText = "Empresa:";
            txtEmpresa.Size = new Size(341, 31);
            txtEmpresa.TabIndex = 34;
            // 
            // EditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 715);
            Controls.Add(txtSalarioBruto);
            Controls.Add(bttVoltar);
            Controls.Add(picFazerCastro);
            Controls.Add(picCancelar);
            Controls.Add(bttCancelarCadastro);
            Controls.Add(bttAttCadastro);
            Controls.Add(txtReservista);
            Controls.Add(txtEndereço);
            Controls.Add(txtCEP);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(txtRG);
            Controls.Add(txtCPF);
            Controls.Add(txtPIS);
            Controls.Add(txtCarteira);
            Controls.Add(txtEmpresa);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EditarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarFuncionario";
            Load += EditarFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)picFazerCastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalarioBruto;
        private Button bttVoltar;
        private PictureBox picFazerCastro;
        private PictureBox picCancelar;
        private Button bttCancelarCadastro;
        private Button bttAttCadastro;
        private TextBox txtReservista;
        private TextBox txtEndereço;
        private TextBox txtCEP;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtRG;
        private TextBox txtCPF;
        private TextBox txtPIS;
        private TextBox txtCarteira;
        private TextBox txtEmpresa;
    }
}