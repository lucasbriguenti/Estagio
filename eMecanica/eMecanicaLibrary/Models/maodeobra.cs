namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.maodeobra")]
    internal partial class maodeobra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal maodeobra()
        {
            servico_maodeobra = new HashSet<servico_maodeobra>();
        }

        [Key]
        internal int mdo_id { get; set; }

        internal decimal mdo_valor { get; set; }

        [Required]
        [StringLength(40)]
        internal string mdo_descricao { get; set; }

        [Column(TypeName = "date")]
        internal DateTime? mdo_tempoMedio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico_maodeobra> servico_maodeobra { get; set; }
    }
}
