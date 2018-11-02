namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.endereco")]
    public partial class endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public endereco()
        {
            cliente = new HashSet<cliente>();
            fornecedor = new HashSet<fornecedor>();
            usuario = new HashSet<usuario>();
        }

        [Key]
        public int end_id { get; set; }

        [Required]
        [StringLength(30)]
        public string end_rua { get; set; }

        public int end_numero { get; set; }

        [Required]
        [StringLength(30)]
        public string end_bairro { get; set; }

        [StringLength(30)]
        public string end_complemento { get; set; }

        [StringLength(30)]
        public string end_referencia { get; set; }

        public int cid_id { get; set; }

        public virtual cidade cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fornecedor> fornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuario { get; set; }
    }
}
