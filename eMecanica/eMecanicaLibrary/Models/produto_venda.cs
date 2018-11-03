namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto_venda")]
    internal partial class produto_venda
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int ven_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int prod_id { get; set; }

        internal decimal pv_valor { get; set; }

        internal int pv_quantidade { get; set; }

        internal decimal? pv_desconto { get; set; }

        internal virtual produto produto { get; set; }

        internal virtual venda venda { get; set; }
    }
}
