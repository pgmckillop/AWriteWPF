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
    
    public partial class TopicTestingMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicTestingMethod()
        {
            this.LOTopics = new HashSet<LOTopic>();
        }
    
        public int idTopicTestingMethod { get; set; }
        public string TestingMethodFull { get; set; }
        public string TestingMethodShort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOTopic> LOTopics { get; set; }
    }
}
