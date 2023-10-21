using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_NetGameVN_STINGDAU.DPContext
{
    public class Members
    {
        public int MemberID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string GroupUser { get; set; }
        public TimeSpan? CurrentTime { get; set; }
        public  double? CurrentMoney { get; set; }
        public string StatusAccount { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }



    }


}
