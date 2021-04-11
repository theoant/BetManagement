using BetManagement.Interface;
using BetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetManagement.Services
{
    public class Services : IServices
    {
        private BetDbContext dBcontext;

        public Services(BetDbContext BetDBcontect)
        {
            dBcontext = BetDBcontect;
        }

        public Result<bool> resultbool = new Result<bool>();

        public Result<bool> CreateMatch (int Identifier, string Description, string TeamA, string TeamB, string Sport)
        {
            var match = new Match();

            match.ID = Identifier;
            match.Description = Description;
            match.MatchTime = DateTime.Now;
            match.MatchDate = DateTime.Today.ToString();
            match.TeamA = TeamA;
            match.TeamB = TeamB;
            match.Sport = Sport;

            dBcontext.Add(match);
            if (dBcontext.SaveChanges() >= 1)
            {
                resultbool.ResponseCode = 0;
                resultbool.ResponseMessage = " DB Save : Successfully completed";
                resultbool.Data = true;
                return resultbool;
            }
            else
            {
                resultbool.ResponseCode = 4;
                resultbool.ResponseMessage = "DB Save : Could not save in db";
                resultbool.Data = false;
                return resultbool;
            }
        }

        public Result<bool> UpdateMatch(int Identifier, string Description, string TeamA, string TeamB, string Sport)
        {
            var match = dBcontext.Set<Match>().SingleOrDefault(ma => ma.ID == Identifier);
            //var match = matchExist.SingleOrDefault(pc => pc.ID == Identifier);
            if (match == null)
            {
                resultbool.ResponseCode = 12;
                resultbool.ResponseMessage = "There is not match with this id";
                resultbool.Data = false;
                return resultbool;
            }

            match.Description = Description;
            match.MatchTime = DateTime.Now;
            match.MatchDate = DateTime.Today.ToString();
            match.TeamA = TeamA;
            match.TeamB = TeamB;
            match.Sport = Sport;

            dBcontext.SaveChanges();
            if (dBcontext.SaveChanges() >= 1)
            {
                resultbool.ResponseCode = 0;
                resultbool.ResponseMessage = " DB Save : Successfully completed";
                resultbool.Data = true;
                return resultbool;
            }
            else
            {
                resultbool.ResponseCode = 4;
                resultbool.ResponseMessage = "DB Save : Could not save in db";
                resultbool.Data = false;
                return resultbool;
            }
        }

        public Result<bool> DeleteMatch(int Identifier, string Description, string TeamA, string TeamB, string Sport)
        {
            var match = dBcontext.Set<Match>().SingleOrDefault(m => m.ID == Identifier);
            if (match== null)
            {
                resultbool.ResponseCode = 12;
                resultbool.ResponseMessage = "There is not match with this id";
                resultbool.Data = false;
                return resultbool;
            }
            dBcontext.Remove(match);
            dBcontext.SaveChanges();
            if (dBcontext.SaveChanges() >= 1)
            {
                resultbool.ResponseCode = 0;
                resultbool.ResponseMessage = " DB Save : Successfully completed";
                resultbool.Data = true;
                return resultbool;
            }
            else
            {
                resultbool.ResponseCode = 4;
                resultbool.ResponseMessage = "DB Save : Could not save in db";
                resultbool.Data = false;
                return resultbool;
            }
        }

        public Result<bool> CreateOdd(int Identifier, int MatchIdendifier, string Specifier, decimal Odd)
        {

            var matchOdd = new MatchOdds();

            matchOdd.ID = Identifier;
            matchOdd.MatchId = MatchIdendifier;
            matchOdd.Specifier = Specifier;
            matchOdd.Odd = Odd;
      

            dBcontext.Add(matchOdd);
            if (dBcontext.SaveChanges() >= 1)
            {
                resultbool.ResponseCode = 0;
                resultbool.ResponseMessage = " DB Save : Successfully completed";
                resultbool.Data = true;
                return resultbool;
            }
            else
            {
                resultbool.ResponseCode = 4;
                resultbool.ResponseMessage = "DB Save : Could not save in db";
                resultbool.Data = false;
                return resultbool;
            }
        }

        public Result<bool> UpdateOdd(int Identifier, int MatchIdendifier, string Specifier, decimal Odd)
        {
            var matchOdd = dBcontext.Set<MatchOdds>().Where(ma => ma.ID == Identifier);
            var matchOddExist = matchOdd.SingleOrDefault(me => me.MatchId == MatchIdendifier);
            if (matchOddExist == null)
            {
                resultbool.ResponseCode = 12;
                resultbool.ResponseMessage = "There is not odd with this match id";
                resultbool.Data = false;
                return resultbool;
            }

            matchOddExist.Specifier = Specifier;
            matchOddExist.Odd = Odd;

            dBcontext.SaveChanges();
            if (dBcontext.SaveChanges() >= 1)
            {
                resultbool.ResponseCode = 0;
                resultbool.ResponseMessage = " DB Save : Successfully completed";
                resultbool.Data = true;
                return resultbool;
            }
            else
            {
                resultbool.ResponseCode = 4;
                resultbool.ResponseMessage = "DB Save : Could not save in db";
                resultbool.Data = false;
                return resultbool;
            }
        }

        public Result<bool> DeleteOdd(int Identifier, int MatchIdendifier, string Specifier, decimal Odd)
        {
            var matchOdd = dBcontext.Set<MatchOdds>().Where(ma => ma.ID == Identifier);
            var matchOddExist = matchOdd.SingleOrDefault(me => me.MatchId == MatchIdendifier); ;
            if (matchOddExist == null)
            {
                resultbool.ResponseCode = 12;
                resultbool.ResponseMessage = "There is not odd with this match id";
                resultbool.Data = false;
                return resultbool;
            }
            dBcontext.Remove(matchOddExist);
            dBcontext.SaveChanges();
            if (dBcontext.SaveChanges() >= 1)
            {
                resultbool.ResponseCode = 0;
                resultbool.ResponseMessage = " DB Save : Successfully completed";
                resultbool.Data = true;
                return resultbool;
            }
            else
            {
                resultbool.ResponseCode = 4;
                resultbool.ResponseMessage = "DB Save : Could not save in db";
                resultbool.Data = false;
                return resultbool;
            }
        }
    }
}
