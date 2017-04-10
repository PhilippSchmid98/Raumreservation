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

            //Creater DB with Dummy Data when not exists
            var entities = new entitiesDataContext();
            if (!entities.DatabaseExists())
            {
                entities.CreateDatabase();

                var bigroom = new TblRoom()
                {
                    Building = "VZA1",
                    Capacity = 12,
                    Description = "Big Room",
                    Floor = 2
                };
                var smallroom = new TblRoom()
                {
                    Building = "VZA1",
                    Capacity = 2,
                    Description = "Small Room",
                    Floor = 0
                };
                var littleroom = new TblRoom()
                {
                    Building = "VZA1",
                    Capacity = 4,
                    Description = "Little Room",
                    Floor = 1
                };
                var biggestroom = new TblRoom()
                {
                    Building = "VZA1",
                    Capacity = 60,
                    Description = "Biggest Room",
                    Floor = 2
                };
                var rooms = new List<TblRoom>();
                rooms.Add(bigroom);
                rooms.Add(smallroom);
                rooms.Add(littleroom);
                rooms.Add(biggestroom);

                entities.TblRoom.InsertAllOnSubmit(rooms);
                entities.SubmitChanges();

            }
            




            base.OnStartup(e);
        }
    }
}
