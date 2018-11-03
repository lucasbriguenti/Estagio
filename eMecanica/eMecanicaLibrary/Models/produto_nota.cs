namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto_nota")]
    internal partial class produto_nota
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        internal string not_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int prod_id { get; set; }

        internal int pn_qtde { get; set; }

        internal decimal pn_valor { get; set; }

        internal decimal pn_valortributo { get; set; }

        internal virtual notafiscal notafiscal { get; set; }

        internal virtual produto produto { get; set; }
    }
}
