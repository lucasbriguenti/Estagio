namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.fornecedor")]
    internal partial class fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal fornecedor()
        {
            compra = new HashSet<compra>();
        }

        [Key]
        internal int for_id { get; set; }

        [Required]
        [StringLength(30)]
        internal string for_nome { get; set; }

        internal int end_id { get; set; }

        [Required]
        [StringLength(50)]
        internal string for_email { get; set; }

        [Required]
        [StringLength(30)]
        internal string for_razaosocial { get; set; }

        [Required]
        [StringLength(25)]
        internal string for_cnpj { get; set; }

        [Required]
        [StringLength(25)]
        internal string for_telefone1 { get; set; }

        [StringLength(25)]
        internal string for_telefone2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<compra> compra { get; set; }

        internal virtual endereco endereco { get; set; }
    }
}
