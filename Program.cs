namespace Wk3Assignment3._4
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
            Data.CoffeeList.Add(new Coffee("Daily Special"));
            Data.CoffeeList.Add(new Coffee("Afternoon Special",BeverageSize.Medium ));

            Application.Run(new Form1());
        }
    }
}