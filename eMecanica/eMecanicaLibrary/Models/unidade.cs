namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.unidade")]
    internal partial class unidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal unidade()
        {
            produto = new HashSet<produto>();
        }

        [Key]
        internal int un_id { get; set; }

        [Required]
        [StringLength(10)]
        internal string un_unidade { get; set; }

        [Required]
        [StringLength(5)]
        internal string un_abreviacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto> produto { get; set; }
    }
}
