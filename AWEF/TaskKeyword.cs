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
    
    public partial class TaskKeyword
    {
        public int idTaskKeyword { get; set; }
        public int TopicKeyword_idTopicKeyword { get; set; }
        public int AssessmentTask_idAssessmentTask { get; set; }
    
        public virtual AssessmentTask AssessmentTask { get; set; }
        public virtual TopicKeyword TopicKeyword { get; set; }
    }
}
