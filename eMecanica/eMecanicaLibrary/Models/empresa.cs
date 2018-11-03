namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.empresa")]
    internal partial class empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal empresa()
        {
            notafiscal = new HashSet<notafiscal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int emp_id { get; set; }

        [Required]
        [StringLength(20)]
        internal string emp_cnpj { get; set; }

        [Required]
        [StringLength(20)]
        internal string emp_inscestadual { get; set; }

        [Required]
        [StringLength(20)]
        internal string emp_inscmunicipal { get; set; }

        [Required]
        [StringLength(50)]
        internal string emp_razaosocial { get; set; }

        [Required]
        [StringLength(20)]
        internal string emp_telefone1 { get; set; }

        [StringLength(20)]
        internal string emp_telefone2 { get; set; }

        internal int end_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<notafiscal> notafiscal { get; set; }

        internal virtual endereco endereco { get; set; }
    }
}
