namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("maoDeObra")]
    public partial class maoDeObra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public maoDeObra()
        {
            servico_maoDeObra = new HashSet<servico_maoDeObra>();
        }

        [Key]
        public int mdo_id { get; set; }

        public decimal mdo_valor { get; set; }

        [Required]
        [StringLength(40)]
        public string mdo_descricao { get; set; }

        public DateTime? mdo_tempoMedio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servico_maoDeObra> servico_maoDeObra { get; set; }
    }
}
