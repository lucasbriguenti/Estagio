namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("endereco")]
    public partial class endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public endereco()
        {
            cliente = new HashSet<cliente>();
            empresa = new HashSet<empresa>();
            fornecedor = new HashSet<fornecedor>();
            parametros = new HashSet<parametros>();
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

        [Required]
        [StringLength(10)]
        public string end_cep { get; set; }

        public virtual cidade cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empresa> empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fornecedor> fornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parametros> parametros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuario { get; set; }
    }
}
