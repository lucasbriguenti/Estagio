namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.marca")]
    internal partial class marca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal marca()
        {
            modelo = new HashSet<modelo>();
        }

        [Key]
        internal int mar_id { get; set; }

        [Required]
        [StringLength(20)]
        internal string mar_nome { get; set; }

        internal byte[] mar_logo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<modelo> modelo { get; set; }
    }
}
