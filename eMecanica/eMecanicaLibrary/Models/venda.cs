namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("venda")]
    public partial class venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venda()
        {
            contaReceber = new HashSet<contaReceber>();
            produto_venda = new HashSet<produto_venda>();
        }

        [Key]
        public int ven_id { get; set; }

        public decimal ven_valorTotal { get; set; }

        public DateTime ven_data { get; set; }

        public int usu_id { get; set; }

        public int cli_id { get; set; }

        public virtual cliente cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contaReceber> contaReceber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_venda> produto_venda { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
