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
    
    public partial class Curriculum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curriculum()
        {
            this.Qualifications = new HashSet<Qualification>();
        }
    
        public int idCurriculum { get; set; }
        public int AcademiclLevel_idAcadLevel { get; set; }
        public string CurriculumName { get; set; }
    
        public virtual AcademicLevel AcademicLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Qualification> Qualifications { get; set; }
    }
}