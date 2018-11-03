namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.venda")]
    internal class venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal venda()
        {
            contareceber = new HashSet<contareceber>();
            produto_venda = new HashSet<produto_venda>();
        }

        [Key]
        internal int ven_id { get; set; }

        internal decimal ven_valorTotal { get; set; }

        [Column(TypeName = "date")]
        internal DateTime ven_data { get; set; }

        internal int usu_id { get; set; }

        internal int cli_id { get; set; }

        internal virtual cliente cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<contareceber> contareceber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_venda> produto_venda { get; set; }

        internal virtual usuario usuario { get; set; }
    }
}
