using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_NetGameVN_STINGDAU.DPContext
{
    public class Client
    {
       
        public string ClientName { get; set; }
        public string GroupClientName { get; set; }
        public string StatusClient { get; set; }
        public string Note { get; set; }
        public TimeSpan? Starttime { get; set; }
        public TimeSpan? UseTime { get; set;}
    }
}
