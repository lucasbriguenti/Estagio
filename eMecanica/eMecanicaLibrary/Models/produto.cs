namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("produto")]
    public partial class produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produto()
        {
            produto_compra = new HashSet<produto_compra>();
            produto_nota = new HashSet<produto_nota>();
            produto_servico = new HashSet<produto_servico>();
            produto_venda = new HashSet<produto_venda>();
        }

        [Key]
        public int prod_id { get; set; }

        [Required]
        [StringLength(30)]
        public string prod_nome { get; set; }

        [StringLength(30)]
        public string prod_codigo { get; set; }

        public int prod_quantidade { get; set; }

        public int un_id { get; set; }

        public float prod_peso { get; set; }

        public float prod_aliquota_fed { get; set; }

        public float prod_aliquota_est { get; set; }

        public int prod_origem { get; set; }

        [Required]
        [StringLength(30)]
        public string prod_classeimposto { get; set; }

        [Required]
        [StringLength(8)]
        public string prod_ncm { get; set; }

        public decimal prod_valorVenda { get; set; }

        public decimal prod_valorCompra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_compra> produto_compra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_nota> produto_nota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_servico> produto_servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_venda> produto_venda { get; set; }

        public virtual unidade unidade { get; set; }
    }
}
