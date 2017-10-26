﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.BBDD
{
    public class LongTermSecondaryOxygenSensorTrim1_3
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ValueBankA { get; set; }
        public string ValueBankB { get; set; }
        public DateTime CreatedOn { get; set; }

        public LongTermSecondaryOxygenSensorTrim1_3() { }
    }
}
