namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cliente_pf")]
    public partial class cliente_pf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cli_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cli_dtnasc { get; set; }

        [Required]
        [StringLength(20)]
        public string cli_cpf { get; set; }

        [StringLength(20)]
        public string cli_rg { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string cli_sexo { get; set; }

        public virtual cliente cliente { get; set; }
    }
}
