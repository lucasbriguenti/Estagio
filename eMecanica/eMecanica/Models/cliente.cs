namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cliente")]
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            servico = new HashSet<servico>();
            veiculo = new HashSet<veiculo>();
            venda = new HashSet<venda>();
        }

        [Key]
        public int cli_id { get; set; }

        [Required]
        [StringLength(30)]
        public string cli_nome { get; set; }

        [Required]
        [StringLength(30)]
        public string cli_email { get; set; }

        public int end_id { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string cli_tipo { get; set; }

        [Required]
        [StringLength(25)]
        public string cli_celular { get; set; }

        [StringLength(25)]
        public string cli_telfixo { get; set; }

        public virtual cliente_pf cliente_pf { get; set; }

        public virtual cliente_pj cliente_pj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servico> servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<veiculo> veiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda> venda { get; set; }

        public virtual endereco endereco { get; set; }
    }
}
