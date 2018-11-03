namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.notafiscal")]
    internal partial class notafiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal notafiscal()
        {
            produto_nota = new HashSet<produto_nota>();
        }

        [Key]
        [StringLength(100)]
        internal string not_id { get; set; }

        [Required]
        [StringLength(4)]
        internal string not_cfop { get; set; }

        [StringLength(200)]
        internal string not_dadosadic { get; set; }

        [Required]
        [StringLength(4)]
        internal string not_cst { get; set; }

        [Required]
        [StringLength(2)]
        internal string not_cstpiscofins { get; set; }

        internal int emp_id_emissora { get; set; }

        internal int cli_id { get; set; }

        internal virtual cliente cliente { get; set; }

        internal virtual empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_nota> produto_nota { get; set; }
    }
}
