using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Raumplaner
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var entities = new entitiesDataContext();
            if (!entities.DatabaseExists())
            {
                entities.CreateDatabase();
            }

            base.OnStartup(e);
        }
    }
}
