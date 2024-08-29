using Library_Management_System.FORMS;

namespace Library_Management_System
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

            Application.Run(new interfaceSelect());
            //Application.Run(new Dashboard_Form());
            //Application.Run(new ViewStudentinfo());
        }
    }
}