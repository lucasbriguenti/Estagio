namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cidade")]
    internal partial class cidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal cidade()
        {
            endereco = new HashSet<endereco>();
        }

        [Key]
        internal int cid_id { get; set; }

        [Required]
        [StringLength(30)]
        internal string cid_nome { get; set; }

        internal int est_id { get; set; }

        [StringLength(20)]
        internal string cid_cod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<endereco> endereco { get; set; }

        internal virtual estado estado { get; set; }
    }
}
