﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetManagement.Models
{
    public class MatchOdds
    {
        public int ID { get; set; }
        public int MatchId { get; set; }
        public string Specifier { get; set; }
        public decimal Odd { get; set; }
    }
}
