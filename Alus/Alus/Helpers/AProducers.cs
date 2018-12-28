using System;
using System.Collections.Generic;
using System.Linq;
using Alus.Models;
using Alus.Services;
using SQLite;
namespace Alus.Helpers
{
    public class AProducers
    {
        static SQLiteConnection db = AData.database;

        public AProducers()
        {
        }

        public static List<AProducer> GetAll()
        {
            return db.Query<AProducer>("SELECT * FROM [AProducers]").ToList();
        }

        public static List<AProducer> GetProducerById(int ProducerId)
        {
            return db.Query<AProducer>("SELECT * FROM [AProducers] WHERE ProducerId = " + ProducerId);
        }
    }
}
