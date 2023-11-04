using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Proyecto.Final.Apec
{
    internal static class Program
    {
        public static string conn;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var builder = new ConfigurationBuilder()
            // .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            //var Configuration = builder.Build();
            //conn = Configuration.GetConnectionString("Database");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Inicio());
        }
    }
}