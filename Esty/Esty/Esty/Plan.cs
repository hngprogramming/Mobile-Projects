using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Esty
{
    public class Plan : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public int RoutineID { get; set; }
    }
}
