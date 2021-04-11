using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetManagement
{
    public class Result<T>
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage  { get; set; }
        public T Data { get; set; }
    }
}
