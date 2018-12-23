using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Alus.Models;
using Xamarin.Forms;


namespace Alus.Services
{
    public class AData
    {
        //public static readonly bool ResetDatabaseOnStart = false;

        static SQLiteConnection _database;
        static bool _databaseInitiated = false;
        public static SQLiteConnection database
        {
            get
            {
                if (!_databaseInitiated)
                {
                    initDatabase();
                }
                return _database;
            }
        }

        static void initDatabase()
        {
            _database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            _database.CreateTable<AUser>();
            _database.CreateTable<ABeer>();
        }

    }
}
