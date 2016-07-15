using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Esty
{
    public class Routine : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public string Name { get; set; }

        // every unit / period: every 3 hour / day
        public int IUnit { get; set; }

        public string Unit { get; set; }

        // The period of the transaction: every day, every week, every bi-week, every month, every month, every year
        public int IPeriod { get; set; }

        public string Period { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
        // spending/earning/unknown
        public byte Type { get; set; }

        // day mode: working day / regular day
        public bool DayMode { get; set; }
    }
}
