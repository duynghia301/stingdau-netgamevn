//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJECT_NetGameVN_STINGDAU.DPContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbClient()
        {
            this.tbLoginUsers = new HashSet<tbLoginUser>();
        }
    
        public string ClientName { get; set; }
        public string GroupClientName { get; set; }
        public string StatusClient { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> Endtime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbLoginUser> tbLoginUsers { get; set; }
    }
}
