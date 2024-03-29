﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralGameBot.Entities
{
    public class General
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int HP { get; set; }
        public string TUsername { get; set; }
        public DateTime DateOfCreating { get; set; }
        public Stats Stats { get; set; }
        public int Exp { get; set; }
        public long ChatID { get; set; }

        public int maxHpAmount { get; set; }
        public DateTime CoolDown { get; set; }

        public DateTime HpRestorationTime { get; set; }
    }
}
