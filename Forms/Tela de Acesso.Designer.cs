namespace Pim_Terceiro_Semestre
{
    partial class TeladeAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeladeAcesso));
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.ForeColor = SystemColors.WindowText;
            textBoxUsuario.Location = new Point(416, 237);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario:";
            textBoxUsuario.Size = new Size(342, 31);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.None;
            textBoxSenha.Location = new Point(416, 307);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PlaceholderText = "Senha: ";
            textBoxSenha.Size = new Size(342, 31);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.BackColor = Color.RoyalBlue;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(496, 359);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(193, 31);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Entrar";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // TeladeAcesso
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 685);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeladeAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Acesso";
            Load += TeladeAcesso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonLogin;
    }
}