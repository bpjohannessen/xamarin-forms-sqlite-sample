using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Alus.Models;
using Alus.Services;

namespace Alus.Helpers
{
    public class ABeers
    {
        static SQLiteConnection db = AData.database;

        public ABeers()
        {

        }

        // Test query
        public static List<ABeer> GetIt()
        {
            return db.Query<ABeer>("SELECT * FROM [ABeer]").ToList();
        }

        //Get all items in the database
        public static List<ABeer> GetAll()
        {
            return db.Table<ABeer>().ToList();
        }

        public static List<ABeer> GetId(int Id)
        {
            return db.Query<ABeer>("SELECT * FROM [ABeer] WHERE BeerId = " + Id);
        }
    }
}