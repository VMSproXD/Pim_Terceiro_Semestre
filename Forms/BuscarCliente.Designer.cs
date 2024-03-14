namespace Pim_Terceiro_Semestre
{
    partial class BuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCliente));
            bttVoltar = new Button();
            pictureBox2 = new PictureBox();
            pictureProcurar = new PictureBox();
            bttEditarCliente = new Button();
            bttBuscarCliente = new Button();
            txtBuscarCliente = new TextBox();
            dataGridCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProcurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).BeginInit();
            SuspendLayout();
            // 
            // bttVoltar
            // 
            bttVoltar.Anchor = AnchorStyles.None;
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.FlatStyle = FlatStyle.Popup;
            bttVoltar.Location = new Point(1009, 71);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(123, 54);
            bttVoltar.TabIndex = 36;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(442, 505);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureProcurar
            // 
            pictureProcurar.Anchor = AnchorStyles.None;
            pictureProcurar.Image = (Image)resources.GetObject("pictureProcurar.Image");
            pictureProcurar.Location = new Point(53, 505);
            pictureProcurar.Name = "pictureProcurar";
            pictureProcurar.Size = new Size(94, 79);
            pictureProcurar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProcurar.TabIndex = 40;
            pictureProcurar.TabStop = false;
            // 
            // bttEditarCliente
            // 
            bttEditarCliente.Anchor = AnchorStyles.None;
            bttEditarCliente.AutoSize = true;
            bttEditarCliente.BackColor = Color.Yellow;
            bttEditarCliente.BackgroundImageLayout = ImageLayout.Stretch;
            bttEditarCliente.FlatStyle = FlatStyle.Popup;
            bttEditarCliente.Location = new Point(569, 542);
            bttEditarCliente.Name = "bttEditarCliente";
            bttEditarCliente.Size = new Size(319, 42);
            bttEditarCliente.TabIndex = 39;
            bttEditarCliente.Text = "Edicar Cadastro do Cliente";
            bttEditarCliente.UseVisualStyleBackColor = false;
            bttEditarCliente.Click += bttEditarCliente_Click;
            // 
            // bttBuscarCliente
            // 
            bttBuscarCliente.Anchor = AnchorStyles.None;
            bttBuscarCliente.BackColor = Color.FromArgb(128, 255, 128);
            bttBuscarCliente.BackgroundImageLayout = ImageLayout.Stretch;
            bttBuscarCliente.FlatStyle = FlatStyle.Popup;
            bttBuscarCliente.Location = new Point(164, 542);
            bttBuscarCliente.Name = "bttBuscarCliente";
            bttBuscarCliente.Size = new Size(172, 42);
            bttBuscarCliente.TabIndex = 38;
            bttBuscarCliente.Text = "Procurar";
            bttBuscarCliente.UseVisualStyleBackColor = false;
            bttBuscarCliente.Click += bttBuscarCliente_Click;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Anchor = AnchorStyles.Left;
            txtBuscarCliente.BackColor = SystemColors.GradientActiveCaption;
            txtBuscarCliente.ForeColor = SystemColors.MenuText;
            txtBuscarCliente.Location = new Point(77, 207);
            txtBuscarCliente.MaxLength = 11;
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.PlaceholderText = "Digite o CNPJ da Empresa:";
            txtBuscarCliente.Size = new Size(313, 31);
            txtBuscarCliente.TabIndex = 37;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // dataGridCliente
            // 
            dataGridCliente.AllowUserToOrderColumns = true;
            dataGridCliente.Anchor = AnchorStyles.None;
            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridCliente.BackgroundColor = SystemColors.ActiveCaption;
            dataGridCliente.BorderStyle = BorderStyle.Fixed3D;
            dataGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCliente.Location = new Point(491, 148);
            dataGridCliente.Name = "dataGridCliente";
            dataGridCliente.RowHeadersWidth = 51;
            dataGridCliente.RowTemplate.Height = 29;
            dataGridCliente.Size = new Size(627, 351);
            dataGridCliente.StandardTab = true;
            dataGridCliente.TabIndex = 42;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 685);
            Controls.Add(dataGridCliente);
            Controls.Add(pictureBox2);
            Controls.Add(pictureProcurar);
            Controls.Add(bttEditarCliente);
            Controls.Add(bttBuscarCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(bttVoltar);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BuscarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarCliente";
            Load += BuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProcurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bttVoltar;
        private PictureBox pictureBox2;
        private PictureBox pictureProcurar;
        private Button bttEditarCliente;
        private Button bttBuscarCliente;
        private TextBox txtBuscarCliente;
        private DataGridView dataGridCliente;
    }
}