using System;
using SQLite;

namespace Alus.Models
{
    [Table("ABeer")]
    public class ABeer
    {
        [PrimaryKey, AutoIncrement]
        public int BeerId { get; set; }
        public string BeerName { get; set; }
        public string BeerProducer { get; set; }
        public string BeerType { get; set; }
    }
}
