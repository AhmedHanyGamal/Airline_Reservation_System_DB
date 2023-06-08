namespace Airline_reservation_system
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
            //starting_form SF = new starting_form();
            ApplicationConfiguration.Initialize();
            Application.Run(new starting_form());
        }
    }
}