﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.BBDD
{
    public class CatalystTemperatureB1S2
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Temperature { get; set; }
        public DateTime CreatedOn { get; set; }

        public CatalystTemperatureB1S2() { }
    }
}
