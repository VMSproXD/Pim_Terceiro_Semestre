namespace Pim_Terceiro_Semestre
{
    public static class Program
    {
        public static  TeladeAcesso? Acesso;
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(Acesso = new TeladeAcesso());

        }
    }
}