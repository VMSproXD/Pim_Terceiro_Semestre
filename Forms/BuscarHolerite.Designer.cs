namespace Pim_Terceiro_Semestre
{
    partial class BuscarHolerite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarHolerite));
            dataGridFuncionario = new DataGridView();
            bttVoltar = new Button();
            pictureBox1 = new PictureBox();
            bttProcurarFuncionario = new Button();
            txtBuscarFuncionario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            dataGridFuncionario.Location = new Point(437, 159);
            dataGridFuncionario.Name = "dataGridFuncionario";
            dataGridFuncionario.RowHeadersWidth = 51;
            dataGridFuncionario.RowTemplate.Height = 29;
            dataGridFuncionario.Size = new Size(675, 436);
            dataGridFuncionario.TabIndex = 44;
            // 
            // bttVoltar
            // 
            bttVoltar.BackgroundImage = (Image)resources.GetObject("bttVoltar.BackgroundImage");
            bttVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            bttVoltar.FlatStyle = FlatStyle.Popup;
            bttVoltar.Location = new Point(989, 89);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(123, 54);
            bttVoltar.TabIndex = 43;
            bttVoltar.UseVisualStyleBackColor = true;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 516);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // bttProcurarFuncionario
            // 
            bttProcurarFuncionario.BackColor = Color.FromArgb(128, 255, 128);
            bttProcurarFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
            bttProcurarFuncionario.FlatStyle = FlatStyle.Popup;
            bttProcurarFuncionario.Location = new Point(159, 553);
            bttProcurarFuncionario.Name = "bttProcurarFuncionario";
            bttProcurarFuncionario.Size = new Size(172, 42);
            bttProcurarFuncionario.TabIndex = 39;
            bttProcurarFuncionario.Text = "Procurar";
            bttProcurarFuncionario.UseVisualStyleBackColor = false;
            bttProcurarFuncionario.Click += bttProcurarFuncionario_Click;
            // 
            // txtBuscarFuncionario
            // 
            txtBuscarFuncionario.BackColor = SystemColors.GradientActiveCaption;
            txtBuscarFuncionario.Cursor = Cursors.IBeam;
            txtBuscarFuncionario.ForeColor = SystemColors.MenuText;
            txtBuscarFuncionario.Location = new Point(72, 218);
            txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            txtBuscarFuncionario.PlaceholderText = "Digite o CPF do Funcionario:";
            txtBuscarFuncionario.Size = new Size(313, 31);
            txtBuscarFuncionario.TabIndex = 38;
            txtBuscarFuncionario.TextChanged += txtBuscarFuncionario_TextChanged;
            // 
            // BuscarHolerite
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 685);
            Controls.Add(dataGridFuncionario);
            Controls.Add(bttVoltar);
            Controls.Add(pictureBox1);
            Controls.Add(bttProcurarFuncionario);
            Controls.Add(txtBuscarFuncionario);
            DoubleBuffered = true;
            Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BuscarHolerite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarHolerite";
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridFuncionario;
        private Button bttVoltar;
        private PictureBox pictureBox1;
        private Button bttProcurarFuncionario;
        private TextBox txtBuscarFuncionario;
    }
}