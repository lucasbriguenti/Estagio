namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cliente")]
    internal partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal cliente()
        {
            notafiscal = new HashSet<notafiscal>();
            servico = new HashSet<servico>();
            veiculo = new HashSet<veiculo>();
            venda = new HashSet<venda>();
        }

        [Key]
        internal int cli_id { get; set; }

        [Required]
        [StringLength(30)]
        internal string cli_nome { get; set; }

        [Required]
        [StringLength(30)]
        internal string cli_email { get; set; }

        internal int end_id { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        internal string cli_tipo { get; set; }

        [Required]
        [StringLength(25)]
        internal string cli_celular { get; set; }

        [StringLength(25)]
        internal string cli_telfixo { get; set; }

        internal virtual cliente_pf cliente_pf { get; set; }

        internal virtual cliente_pj cliente_pj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<notafiscal> notafiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico> servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<veiculo> veiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<venda> venda { get; set; }

        internal virtual endereco endereco { get; set; }
    }
}
