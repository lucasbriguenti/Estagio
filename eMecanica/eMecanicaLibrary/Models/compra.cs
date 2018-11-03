namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.compra")]
    internal partial class compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal compra()
        {
            contapagar = new HashSet<contapagar>();
            produto_compra = new HashSet<produto_compra>();
        }

        [Key]
        internal int com_id { get; set; }

        [Column(TypeName = "date")]
        internal DateTime com_data { get; set; }

        internal decimal com_valorTotal { get; set; }

        internal int usu_id { get; set; }

        internal int for_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<contapagar> contapagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_compra> produto_compra { get; set; }

        internal virtual fornecedor fornecedor { get; set; }

        internal virtual usuario usuario { get; set; }
    }
}
