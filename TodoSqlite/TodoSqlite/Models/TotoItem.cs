using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TodoSqlite.Models
{
    [Table("TotoItem")]
    public class TotoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Step> Steps { get; set; }

    }
}
