using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetManagement.Models
{
    public class Match
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime MatchTime { get; set; }
        public string MatchDate { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public string Sport { get; set; }
        //public enum Sport
        //{
        //    Football,
        //    Basketball
        //}

    }
}
