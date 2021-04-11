using BetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetManagement.Interface
{
    public interface IServices
    {
        Result<bool> CreateMatch(int Identifier, string Description, string TeamA, string TeamB, string Sport);
        Result<bool> UpdateMatch(int Identifier, string Description, string TeamA, string TeamB, string Sport);
        Result<bool> DeleteMatch(int Identifier, string Description, string TeamA, string TeamB, string Sport);
        Result<bool> CreateOdd(int Identifier, int MatchIdendifier, string Specifier, decimal Odd);
        Result<bool> UpdateOdd(int Identifier, int MatchIdendifier, string Specifier, decimal Odd);
        Result<bool> DeleteOdd(int Identifier, int MatchIdendifier, string Specifier, decimal Odd);
    }
}
