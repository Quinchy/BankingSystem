namespace BankingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Database.MySQLDatabase.EnableEventScheduler();
            Application.Run(new Forms.BaseForm());
        }
    }
}   