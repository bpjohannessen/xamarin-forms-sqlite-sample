using System;
using SQLite;

namespace Alus.Models
{
    [Table("AProducers")]
    public class AProducer
    {
        [PrimaryKey,AutoIncrement]
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public string ProducerCountry { get; set; }
        public string ProducerCity { get; set; }
        public int ProducerFounded { get; set; }
    }
}
