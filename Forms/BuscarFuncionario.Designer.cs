namespace Pim_Terceiro_Semestre
{
    partial class BuscarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarFuncionario));
            txtBuscarFuncionario = new TextBox();
            picEditarCadastro = new PictureBox();
            pictureBox1 = new PictureBox();
            bttEditarFuncionario = new Button();
            bttProcurarFuncionario = new Button();
            bttVoltar = new Button();
            dataGridFuncionario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picEditarCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarFuncionario
            // 
            txtBuscarFuncionario.BackColor = SystemColors.GradientActiveCaption;
            txtBuscarFuncionario.ForeColor = SystemColors.MenuText;
            txtBuscarFuncionario.Location = new Point(94, 200);
            txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            txtBuscarFuncionario.PlaceholderText = "Digite o CPF do Funcionario:";
            txtBuscarFuncionario.Size = new Size(313, 31);
            txtBuscarFuncionario.TabIndex = 18;
            txtBuscarFuncionario.TextChanged += txtBuscarFuncionario_TextChanged;
            // 
            // picEditarCadastro
            // 
            picEditarCadastro.Image = (Image)resources.GetObject("picEditarCadastro.Image");
            picEditarCadastro.Location = new Point(459, 498);
            picEditarCadastro.Name = "picEditarCadastro";
            picEditarCadastro.Size = new Size(94, 79);
            picEditarCadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            picEditarCadastro.TabIndex = 35;
            picEditarCadastro.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 498);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // bttEditarFuncionario
            // 
            bttEditarFuncionario.BackColor = Color.Yellow;
            bttEditarFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
            bttEditarFuncionario.FlatStyle = FlatStyle.Popup;
            bttEditarFuncionario.Location = new Point(586, 535);
            bttEditarFuncionario.Name = "bttEditarFuncionario";
            bttEditarFuncionario.Size = new Size(334, 42);
            bttEditarFuncionario.TabIndex = 33;
            bttEditarFuncionario.Text = "Edicar Cadastro do Funcionario";
            bttEditarFuncionario.UseVisualStyleBackColor = false;
            bttEditarFuncionario.Click += bttEditarFuncionario_Click;
            // 
            // bttProcurarFuncionario
            // 
            bttProcurarFuncionario.BackColor = Color.FromArgb(128, 255, 128);
            bttProcurarFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
            bttProcurarFuncionario.FlatStyle = FlatStyle.Popup;
            bttProcurarFuncionario.Location = new Point(181, 535);
            bttProcurarFuncionario.Name = "bttProcurarFuncionario";
            bttProcurarFuncionario.Size = new Size(172, 42);
            bttProcurarFuncionario.TabIndex = 32;
            bttProcurarFuncionario.Text = "Procurar";
            bttProcurarFuncionario.UseVisualStyleBackColor = false;
            bttProcurarFuncionario.Click += bttProcurarFuncionario_Click;
            // 
            // bttVoltar
            // 
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.FlatStyle = FlatStyle.Popup;
            bttVoltar.Location = new Point(1011, 71);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(123, 54);
            bttVoltar.TabIndex = 36;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
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
            dataGridFuncionario.Location = new Point(459, 141);
            dataGridFuncionario.Name = "dataGridFuncionario";
            dataGridFuncionario.RowHeadersWidth = 51;
            dataGridFuncionario.RowTemplate.Height = 29;
            dataGridFuncionario.Size = new Size(627, 351);
            dataGridFuncionario.TabIndex = 37;
            // 
            // BuscarFuncionario
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 685);
            Controls.Add(dataGridFuncionario);
            Controls.Add(bttVoltar);
            Controls.Add(picEditarCadastro);
            Controls.Add(pictureBox1);
            Controls.Add(bttEditarFuncionario);
            Controls.Add(bttProcurarFuncionario);
            Controls.Add(txtBuscarFuncionario);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BuscarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarFuncionario";
            ((System.ComponentModel.ISupportInitialize)picEditarCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarFuncionario;
        private PictureBox picEditarCadastro;
        private PictureBox pictureBox1;
        private Button bttEditarFuncionario;
        private Button bttProcurarFuncionario;
        private Button bttVoltar;
        private DataGridView dataGridFuncionario;
    }
}