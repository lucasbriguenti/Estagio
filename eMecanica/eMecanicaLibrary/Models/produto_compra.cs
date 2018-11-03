namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto_compra")]
    internal partial class produto_compra
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int com_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int prod_id { get; set; }

        internal decimal pc_valorCompra { get; set; }

        internal int pc_quantidade { get; set; }

        internal virtual compra compra { get; set; }

        internal virtual produto produto { get; set; }
    }
}
