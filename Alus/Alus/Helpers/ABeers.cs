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
        public static List<ABeer> GetBeers()
        {
            return db.Query<ABeer>("SELECT bb.BeerProducer, bb.BeerId, bb.BeerType, bb.BeerName, (SELECT pp.ProducerName FROM [AProducers] pp WHERE pp.ProducerId = bb.BeerProducer) as ProducerName FROM [ABeer] as bb ORDER BY bb.BeerName ASC").ToList();
        }

        //Get all items in the database
        //public static List<ABeer> GetAll()
        //{
        //    return db.Table<ABeer>().ToList();
        //}

        public static List<ABeer> GetBeerById(int Id)
        {
            return db.Query<ABeer>("SELECT *, (SELECT * FROM [AProducers] pp WHERE pp.ProducerId = bb.BeerProducer FROM [ABeer] as bb WHERE bb.BeerId = " + Id);
        }

        public static List<ABeer> GetBeerByProducerId(int ProducerId)
        {
            return db.Query<ABeer>("SELECT bb.BeerId, bb.BeerProducer, bb.BeerName, bb.BeerType, (SELECT pp.ProducerName FROM [AProducers] pp WHERE pp.ProducerId = " + ProducerId + ") FROM [ABeer] as bb");

        }
        //return db.Query<ABeer>("SELECT * FROM [ABeer] WHERE BeerProducer = " + ProducerId);

    }
}