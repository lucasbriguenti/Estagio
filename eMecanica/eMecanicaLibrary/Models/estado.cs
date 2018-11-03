namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.estado")]
    internal partial class estado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal estado()
        {
            cidade = new HashSet<cidade>();
        }

        [Key]
        internal int est_id { get; set; }

        [StringLength(30)]
        internal string est_cod { get; set; }

        [Required]
        [StringLength(20)]
        internal string est_nome { get; set; }

        [Required]
        [StringLength(5)]
        internal string est_sigla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<cidade> cidade { get; set; }
    }
}
