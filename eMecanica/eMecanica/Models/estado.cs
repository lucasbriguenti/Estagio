namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.estado")]
    public partial class estado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estado()
        {
            cidade = new HashSet<cidade>();
        }

        [Key]
        public int est_id { get; set; }

        [StringLength(30)]
        public string est_cod { get; set; }

        [Required]
        [StringLength(20)]
        public string est_nome { get; set; }

        [Required]
        [StringLength(5)]
        public string est_sigla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cidade> cidade { get; set; }
    }
}
