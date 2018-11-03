namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.despesa")]
    internal partial class despesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal despesa()
        {
            contapagar = new HashSet<contapagar>();
        }

        [Key]
        internal int des_id { get; set; }

        [Required]
        [StringLength(50)]
        internal string des_descricao { get; set; }

        internal decimal des_valor { get; set; }

        internal int des_tipo { get; set; }

        internal int usu_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<contapagar> contapagar { get; set; }

        internal virtual usuario usuario { get; set; }
    }
}
