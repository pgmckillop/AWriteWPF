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
    
    public partial class AssessmentObjective
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentObjective()
        {
            this.TaskAOs = new HashSet<TaskAO>();
        }
    
        public int idAssessmentObjective { get; set; }
        public string AOShort { get; set; }
        public string AOName { get; set; }
        public Nullable<int> AOSortOrder { get; set; }
        public string AOFocus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAO> TaskAOs { get; set; }
    }
}
