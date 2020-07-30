﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_PMS.Models
{
    public class Attend
    {
        public int ID { get; set; }
        public int User_ID { get; set; }

        public DateTime Attend_Date { get; set; }
        public DateTime Login { get; set; }
        public DateTime Logout { get; set; }

        public string Status { get; set; }
        public string Shift { get; set; }
        public string Name { get; set; }
        public int Workingtime { get; set; }

        public int Amount { get; set; }
        public double Job_Time { get; set; }
        public double Pro_Time { get; set; }
        
        public int Efficiency { get; set; }
        public int Quality { get; set; }
    }
}
