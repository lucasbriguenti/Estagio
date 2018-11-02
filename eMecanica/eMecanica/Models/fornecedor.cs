namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.fornecedor")]
    public partial class fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fornecedor()
        {
            compra = new HashSet<compra>();
        }

        [Key]
        public int for_id { get; set; }

        [Required]
        [StringLength(30)]
        public string for_nome { get; set; }

        public int end_id { get; set; }

        [Required]
        [StringLength(50)]
        public string for_email { get; set; }

        [Required]
        [StringLength(30)]
        public string for_razaosocial { get; set; }

        [Required]
        [StringLength(25)]
        public string for_cnpj { get; set; }

        [Required]
        [StringLength(25)]
        public string for_telefone1 { get; set; }

        [StringLength(25)]
        public string for_telefone2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra> compra { get; set; }

        public virtual endereco endereco { get; set; }
    }
}
