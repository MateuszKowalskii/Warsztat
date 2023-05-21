using Warsztat_samochodowy.Zdarzenia;

namespace Warsztat_samochodowy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();
            Aplikacja program = new Aplikacja();
            Application.Run(program);


            program.panelGlowny.Show();
            //program.klienciStrona.Hide();
            //program.pracownicyStrona.Hide();

        }
    }
}