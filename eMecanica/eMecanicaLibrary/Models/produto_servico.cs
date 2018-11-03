namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto_servico")]
    internal partial class produto_servico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int ser_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int prod_id { get; set; }

        internal decimal? ps_desconto { get; set; }

        internal int ps_quantidade { get; set; }

        internal decimal ps_valorVenda { get; set; }

        internal virtual produto produto { get; set; }

        internal virtual servico servico { get; set; }
    }
}
