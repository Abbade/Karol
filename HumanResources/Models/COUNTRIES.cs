namespace HumanResources.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COUNTRIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COUNTRIES()
        {
            LOCATIONS = new HashSet<LOCATIONS>();
        }

        [Key]
        public int COUNTRY_ID { get; set; }

        [StringLength(50)]
        public string COUNTRY_NAME { get; set; }

        public int? REGION_ID { get; set; }

        public virtual REGIONS REGIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOCATIONS> LOCATIONS { get; set; }
    }
}
