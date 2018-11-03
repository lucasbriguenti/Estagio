namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.usuario")]
    internal partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal usuario()
        {
            compra = new HashSet<compra>();
            despesa = new HashSet<despesa>();
            servico = new HashSet<servico>();
            venda = new HashSet<venda>();
            servico1 = new HashSet<servico>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int usu_id { get; set; }

        internal int end_id { get; set; }

        [Required]
        [StringLength(20)]
        internal string usu_nome { get; set; }

        [Required]
        [StringLength(50)]
        internal string usu_email { get; set; }

        [Required]
        [StringLength(20)]
        internal string usu_senha { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        internal string usu_nivelacesso { get; set; }

        [Required]
        [StringLength(20)]
        internal string cli_rg { get; set; }

        [Required]
        [StringLength(25)]
        internal string cli_cpf { get; set; }

        [StringLength(20)]
        internal string usu_telfixo { get; set; }

        [Column(TypeName = "date")]
        internal DateTime usu_dtnasc { get; set; }

        [Required]
        [StringLength(20)]
        internal string usu_celular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<compra> compra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<despesa> despesa { get; set; }

        internal virtual endereco endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico> servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<venda> venda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico> servico1 { get; set; }
    }
}
