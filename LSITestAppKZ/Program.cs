using LSITestApp.Forms;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace LSITestApp
{
    static class Program
    {
        private static Container container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureInjector();
            DbContextHelper.SeedData(container.GetInstance<AppContext>());

            Application.Run(new frmReport(container.GetInstance<AppContext>()));
        }

        private static void ConfigureInjector()
        {
            container = new Container();
            container.Register<AppContext>(Lifestyle.Singleton);
            container.Verify();
        }
    }
}
