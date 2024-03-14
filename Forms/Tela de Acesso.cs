namespace Pim_Terceiro_Semestre
{
    public partial class TeladeAcesso : Form
    {
        public TeladeAcesso()
        {

            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Verificão dos informações inseridads para o login 

            Controle_de_Acesso controle = new Controle_de_Acesso();
            controle.Acesso(textBoxUsuario.Text, textBoxSenha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    Program.Acesso.Hide();
                    Menu_principal mp = new Menu_principal();
                    mp.ShowDialog();
                }
                else {
                    textBoxSenha.Clear();
                    textBoxUsuario.Clear();
                    MessageBox.Show("Usuário ou senha errados"); 

                }

            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void TeladeAcesso_Load(object sender, EventArgs e)
        {

        }
    }
}