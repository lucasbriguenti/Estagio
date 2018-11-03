namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.endereco")]
    internal partial class endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal endereco()
        {
            cliente = new HashSet<cliente>();
            empresa = new HashSet<empresa>();
            fornecedor = new HashSet<fornecedor>();
            usuario = new HashSet<usuario>();
        }

        [Key]
        internal int end_id { get; set; }

        [Required]
        [StringLength(30)]
        internal string end_rua { get; set; }

        internal int end_numero { get; set; }

        [Required]
        [StringLength(30)]
        internal string end_bairro { get; set; }

        [StringLength(30)]
        internal string end_complemento { get; set; }

        [StringLength(30)]
        internal string end_referencia { get; set; }

        internal int cid_id { get; set; }

        internal virtual cidade cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<cliente> cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<empresa> empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<fornecedor> fornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<usuario> usuario { get; set; }
    }
}
