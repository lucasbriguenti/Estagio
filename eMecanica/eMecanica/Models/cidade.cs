namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cidade")]
    public partial class cidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cidade()
        {
            endereco = new HashSet<endereco>();
        }

        [Key]
        public int cid_id { get; set; }

        [Required]
        [StringLength(30)]
        public string cid_nome { get; set; }

        public int est_id { get; set; }

        [StringLength(20)]
        public string cid_cod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<endereco> endereco { get; set; }

        public virtual estado estado { get; set; }
    }
}
