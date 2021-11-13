namespace RandomizeCodeEvergyMonster
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MainForm m = new MainForm();
            Application.Run(m);
        }
    }
}