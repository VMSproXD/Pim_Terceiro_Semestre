namespace Pim_Terceiro_Semestre
{
    partial class GerarHolerite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarHolerite));
            picFazerCastro = new PictureBox();
            picCancelar = new PictureBox();
            bttCancelarCalculo = new Button();
            bttGerarHolerite = new Button();
            txtCPF = new TextBox();
            txtNomeFuncionario = new TextBox();
            dataGridFuncionario = new DataGridView();
            bttVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFazerCastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionario).BeginInit();
            SuspendLayout();
            // 
            // picFazerCastro
            // 
            picFazerCastro.Image = (Image)resources.GetObject("picFazerCastro.Image");
            picFazerCastro.Location = new Point(94, 523);
            picFazerCastro.Name = "picFazerCastro";
            picFazerCastro.Size = new Size(103, 79);
            picFazerCastro.SizeMode = PictureBoxSizeMode.StretchImage;
            picFazerCastro.TabIndex = 63;
            picFazerCastro.TabStop = false;
            // 
            // picCancelar
            // 
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(577, 523);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(103, 79);
            picCancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCancelar.TabIndex = 62;
            picCancelar.TabStop = false;
            // 
            // bttCancelarCalculo
            // 
            bttCancelarCalculo.BackColor = Color.IndianRed;
            bttCancelarCalculo.BackgroundImageLayout = ImageLayout.Stretch;
            bttCancelarCalculo.FlatStyle = FlatStyle.Popup;
            bttCancelarCalculo.Location = new Point(709, 544);
            bttCancelarCalculo.Name = "bttCancelarCalculo";
            bttCancelarCalculo.Size = new Size(188, 42);
            bttCancelarCalculo.TabIndex = 61;
            bttCancelarCalculo.Text = "Cancelar Calculo";
            bttCancelarCalculo.UseVisualStyleBackColor = false;
            bttCancelarCalculo.Click += bttCancelarCalculo_Click;
            // 
            // bttGerarHolerite
            // 
            bttGerarHolerite.BackColor = Color.FromArgb(128, 255, 128);
            bttGerarHolerite.BackgroundImageLayout = ImageLayout.Stretch;
            bttGerarHolerite.FlatStyle = FlatStyle.Popup;
            bttGerarHolerite.Location = new Point(236, 544);
            bttGerarHolerite.Name = "bttGerarHolerite";
            bttGerarHolerite.Size = new Size(188, 42);
            bttGerarHolerite.TabIndex = 60;
            bttGerarHolerite.Text = "Gerar Holerite";
            bttGerarHolerite.UseVisualStyleBackColor = false;
            bttGerarHolerite.Click += bttGerarHolerite_Click;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.GradientActiveCaption;
            txtCPF.ForeColor = SystemColors.MenuText;
            txtCPF.Location = new Point(83, 275);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "Digite o CPF do do Funcionario";
            txtCPF.Size = new Size(341, 31);
            txtCPF.TabIndex = 51;
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.BackColor = SystemColors.GradientActiveCaption;
            txtNomeFuncionario.ForeColor = SystemColors.MenuText;
            txtNomeFuncionario.Location = new Point(83, 219);
            txtNomeFuncionario.MaxLength = 256;
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.PlaceholderText = "Digite o nome do funcionario:";
            txtNomeFuncionario.Size = new Size(341, 31);
            txtNomeFuncionario.TabIndex = 50;
            // 
            // dataGridFuncionario
            // 
            dataGridFuncionario.AllowUserToOrderColumns = true;
            dataGridFuncionario.Anchor = AnchorStyles.None;
            dataGridFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridFuncionario.BackgroundColor = SystemColors.ActiveCaption;
            dataGridFuncionario.BorderStyle = BorderStyle.Fixed3D;
            dataGridFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFuncionario.Location = new Point(493, 166);
            dataGridFuncionario.Name = "dataGridFuncionario";
            dataGridFuncionario.RowHeadersWidth = 51;
            dataGridFuncionario.RowTemplate.Height = 29;
            dataGridFuncionario.Size = new Size(627, 351);
            dataGridFuncionario.TabIndex = 64;
            // 
            // bttVoltar
            // 
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.FlatStyle = FlatStyle.Popup;
            bttVoltar.Location = new Point(997, 78);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(123, 54);
            bttVoltar.TabIndex = 65;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // GerarHolerite
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 721);
            Controls.Add(bttVoltar);
            Controls.Add(dataGridFuncionario);
            Controls.Add(picFazerCastro);
            Controls.Add(picCancelar);
            Controls.Add(bttCancelarCalculo);
            Controls.Add(bttGerarHolerite);
            Controls.Add(txtCPF);
            Controls.Add(txtNomeFuncionario);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GerarHolerite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GerarHolerite";
            Load += GerarHolerite_Load;
            ((System.ComponentModel.ISupportInitialize)picFazerCastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFazerCastro;
        private PictureBox picCancelar;
        private Button bttCancelarCalculo;
        private Button bttGerarHolerite;
        private TextBox txtCPF;
        private TextBox txtNomeFuncionario;
        private DataGridView dataGridFuncionario;
        private Button bttVoltar;
    }
}