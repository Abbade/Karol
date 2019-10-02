namespace HumanResources.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REGIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGIONS()
        {
            COUNTRIES = new HashSet<COUNTRIES>();
        }

        [Key]
        public int REGION_ID { get; set; }

        [StringLength(255)]
        public string REGION_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COUNTRIES> COUNTRIES { get; set; }
    }
}
