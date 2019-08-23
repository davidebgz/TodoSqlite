using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace TodoSqlite.Models
{
    [Table ("Steps")]
   public class Step
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(typeof(TotoItem))]
        public int WorkerId { get; set; }
    }
}
