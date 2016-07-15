using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Esty
{
    public class Period : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public int Hour { get; set; }
    }
}
