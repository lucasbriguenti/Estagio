namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cliente_pf")]
    internal partial class cliente_pf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int cli_id { get; set; }

        [Column(TypeName = "date")]
        internal DateTime? cli_dtnasc { get; set; }

        [Required]
        [StringLength(20)]
        internal string cli_cpf { get; set; }

        [StringLength(20)]
        internal string cli_rg { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        internal string cli_sexo { get; set; }

        internal virtual cliente cliente { get; set; }
    }
}
