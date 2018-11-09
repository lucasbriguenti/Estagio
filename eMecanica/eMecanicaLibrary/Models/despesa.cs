namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("despesa")]
    public partial class despesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public despesa()
        {
            contaPagar = new HashSet<contaPagar>();
        }

        [Key]
        public int des_id { get; set; }

        [Required]
        [StringLength(50)]
        public string des_descricao { get; set; }

        public decimal des_valor { get; set; }

        public int des_tipo { get; set; }

        public int usu_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contaPagar> contaPagar { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
