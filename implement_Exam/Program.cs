using implement_Exam.csEpreuve;
namespace implement_Exam
{
    public static class Program
    {
        static public QSM qcm = new QSM();
        static public Form1 question = new Form1();
        static public Form2 epreuve = new Form2();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(epreuve);

        }


    }
}