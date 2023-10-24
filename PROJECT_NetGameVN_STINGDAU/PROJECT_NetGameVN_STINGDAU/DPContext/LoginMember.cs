using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_NetGameVN_STINGDAU.DPContext
{
    public class LoginMember
    {
        public int MemberID { get; set; }
        public string ClientName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? UseTime { get; set; }
        public TimeSpan? LeftTime { get; set; }

        
    }
}
