namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.modelo")]
    internal partial class modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal modelo()
        {
            veiculo = new HashSet<veiculo>();
        }

        [Key]
        internal int mod_id { get; set; }

        [Required]
        [StringLength(20)]
        internal string mod_nome { get; set; }

        internal int mar_id { get; set; }

        internal virtual marca marca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<veiculo> veiculo { get; set; }
    }
}
