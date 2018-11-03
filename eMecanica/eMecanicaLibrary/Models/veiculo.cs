namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.veiculo")]
    internal partial class veiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal veiculo()
        {
            servico = new HashSet<servico>();
        }

        [Key]
        [StringLength(15)]
        internal string vei_placa { get; set; }

        [StringLength(15)]
        internal string vei_km { get; set; }

        internal int mod_id { get; set; }

        internal int cli_id { get; set; }

        internal virtual cliente cliente { get; set; }

        internal virtual modelo modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico> servico { get; set; }
    }
}
