namespace HumanResources.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEPARTMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTMENTS()
        {
            EMPLOYEES1 = new HashSet<EMPLOYEES>();
            JOB_HISTORY = new HashSet<JOB_HISTORY>();
        }

        [Key]
        public int DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string DEPARTMENT_NAME { get; set; }

        public int? MANAGER_ID { get; set; }

        public int? LOCATION_ID { get; set; }

        public virtual EMPLOYEES EMPLOYEES { get; set; }

        public virtual LOCATIONS LOCATIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEES> EMPLOYEES1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_HISTORY> JOB_HISTORY { get; set; }
    }
}
