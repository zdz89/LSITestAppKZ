using DevExpress.XtraSplashScreen;
using LSITestAppKZ;
using System;
using System.Collections.Generic;

namespace LSITestApp
{
    public class DbContextHelper
    {
        public static void SeedData(AppContext appContext)
        {
            SplashScreenManager.ShowForm(typeof(frmWait));

            if (appContext.Database.EnsureCreated())
            {
                List<Export> export = new List<Export>
                {
                    new Export
                    {
                        Name = "Test1",
                        Date = DateTime.Now.Date,
                        Time = new TimeSpan(1, 1, 1),
                        User = "User",
                        Place = "Lokal 1"
                    },
                    new Export
                    {
                        Name = "Test2",
                        Date = DateTime.Now.Date.AddDays(2),
                        Time = new TimeSpan(1, 1, 1),
                        User = "User",
                        Place = "Lokal 2"
                    },
                    new Export
                    {
                        Name = "Test3",
                        Date = DateTime.Now.Date.AddDays(3),
                        Time = new TimeSpan(1, 1, 1),
                        User = "User",
                        Place = "Lokal 3"
                    },
                    new Export
                    {
                        Name = "Test4",
                        Date = DateTime.Now.Date.AddDays(4),
                        Time = new TimeSpan(1, 1, 1),
                        User = "User",
                        Place = "Lokal 4"
                    },
                    new Export
                    {
                        Name = "Test5",
                        Date = DateTime.Now.Date.AddDays(5),
                        Time = new TimeSpan(1, 1, 1),
                        User = "User",
                        Place = "Lokal 5"
                    },
                    new Export
                    {
                        Name = "Test6",
                        Date = DateTime.Now.Date.AddDays(5),
                        Time = new TimeSpan(1, 1, 1),
                        User = "User",
                        Place = "Lokal 55"
                    }
                };

                appContext.Exports.AddRange(export);
                appContext.SaveChanges();

                SplashScreenManager.CloseForm();
            }
        }
    }
}
