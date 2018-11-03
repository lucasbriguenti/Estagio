namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto")]
    internal partial class produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal produto()
        {
            produto_compra = new HashSet<produto_compra>();
            produto_nota = new HashSet<produto_nota>();
            produto_servico = new HashSet<produto_servico>();
            produto_venda = new HashSet<produto_venda>();
        }

        [Key]
        internal int prod_id { get; set; }

        [Required]
        [StringLength(30)]
        internal string prod_nome { get; set; }

        [StringLength(30)]
        internal string prod_codigo { get; set; }

        internal int prod_quantidade { get; set; }

        internal int un_id { get; set; }

        internal double prod_peso { get; set; }

        internal double prod_aliquota_fed { get; set; }

        internal double prod_aliquota_est { get; set; }

        internal int prod_origem { get; set; }

        [Required]
        [StringLength(30)]
        internal string prod_classeimposto { get; set; }

        [Required]
        [StringLength(8)]
        internal string prod_ncm { get; set; }

        internal decimal prod_valorVenda { get; set; }

        internal decimal prod_valorCompra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_compra> produto_compra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_nota> produto_nota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_servico> produto_servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_venda> produto_venda { get; set; }

        internal virtual unidade unidade { get; set; }
    }
}
