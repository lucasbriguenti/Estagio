namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("compra")]
    public partial class compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra()
        {
            contaPagar = new HashSet<contaPagar>();
            produto_compra = new HashSet<produto_compra>();
        }

        [Key]
        public int com_id { get; set; }

        public DateTime com_data { get; set; }

        public decimal com_valorTotal { get; set; }

        public int usu_id { get; set; }

        public int for_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contaPagar> contaPagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_compra> produto_compra { get; set; }

        public virtual fornecedor fornecedor { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
