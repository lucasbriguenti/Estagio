namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("veiculo")]
    public partial class veiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public veiculo()
        {
            servico = new HashSet<servico>();
        }

        [Key]
        [StringLength(15)]
        public string vei_placa { get; set; }

        [StringLength(15)]
        public string vei_km { get; set; }

        public int mod_id { get; set; }

        public int cli_id { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual modelo modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servico> servico { get; set; }
    }
}
