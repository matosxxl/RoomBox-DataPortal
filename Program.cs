using log4net;

namespace RoomBox___DataPortal
{
    internal static class Program
    {
        //private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [STAThread]
        static void Main()
        {
            //log4net.Config.XmlConfigurator.Configure();
            //logger.Info("Preparando el ambiente para ejecutar el programa...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            //logger.Info("Portal administrativo iniciado satisfactoriamente");
            Application.Run(new Login());
            //logger.Info("Portal administrativo cerrado satisfactoriamente");
        }
    }
}