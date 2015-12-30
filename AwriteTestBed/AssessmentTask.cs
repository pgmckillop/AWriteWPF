//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AwriteTestBed
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssessmentTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentTask()
        {
            this.TaskAOs = new HashSet<TaskAO>();
            this.TaskKeywords = new HashSet<TaskKeyword>();
            this.TaskTopicRanges = new HashSet<TaskTopicRange>();
        }
    
        public int idAssessmentTask { get; set; }
        public int Assessment_idAssessment { get; set; }
        public int TaskOrderNumber { get; set; }
        public string AssessTaskName { get; set; }
        public string CandidateInstructions { get; set; }
        public string EvidenceRequired { get; set; }
        public string CentreGuidance { get; set; }
        public int AssessmentTaskCondition_idAssessmentTaskCondition { get; set; }
        public Nullable<decimal> AssessmentTask_TaskTimeEstimate { get; set; }
    
        public virtual Assessment Assessment { get; set; }
        public virtual AssessmentTaskCondition AssessmentTaskCondition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAO> TaskAOs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskKeyword> TaskKeywords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskTopicRange> TaskTopicRanges { get; set; }
    }
}
