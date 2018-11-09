namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("notaFiscal")]
    public partial class notaFiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public notaFiscal()
        {
            produto_nota = new HashSet<produto_nota>();
        }

        [Key]
        [StringLength(100)]
        public string not_id { get; set; }

        [StringLength(200)]
        public string not_dadosadic { get; set; }

        public int emp_id_emissora { get; set; }

        public int cli_id { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_nota> produto_nota { get; set; }
    }
}
