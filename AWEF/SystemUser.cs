//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemUser()
        {
            this.Assessments = new HashSet<Assessment>();
        }
    
        public int idSystemUser { get; set; }
        public Nullable<int> SystemUserType_idSystemUserType { get; set; }
        public string SystemUserForename { get; set; }
        public string SystemUserSurname { get; set; }
        public string SystemUserInitialPassword { get; set; }
        public string SystemUserLoginName { get; set; }
        public string SystemUserOrganisation { get; set; }
        public string SystemUserEmail { get; set; }
        public string SystemUserLandline { get; set; }
        public string SystemUserMobile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual SystemUserType SystemUserType { get; set; }
    }
}
