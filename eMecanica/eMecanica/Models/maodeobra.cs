namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.maodeobra")]
    public partial class maodeobra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public maodeobra()
        {
            servico_maodeobra = new HashSet<servico_maodeobra>();
        }

        [Key]
        public int mdo_id { get; set; }

        public decimal mdo_valor { get; set; }

        [Required]
        [StringLength(40)]
        public string mdo_descricao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? mdo_tempoMedio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servico_maodeobra> servico_maodeobra { get; set; }
    }
}
