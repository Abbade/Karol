namespace HumanResources.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JOBS()
        {
            EMPLOYEES = new HashSet<EMPLOYEES>();
            JOB_HISTORY = new HashSet<JOB_HISTORY>();
        }

        [Key]
        public int JOB_ID { get; set; }

        [StringLength(50)]
        public string JOB_TITLE { get; set; }

        public decimal? MIN_SALARY { get; set; }

        public decimal? MAX_SALARY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEES> EMPLOYEES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_HISTORY> JOB_HISTORY { get; set; }
    }
}
