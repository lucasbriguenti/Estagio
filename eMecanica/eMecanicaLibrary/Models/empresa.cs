namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empresa")]
    public partial class empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empresa()
        {
            notaFiscal = new HashSet<notaFiscal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int emp_id { get; set; }

        [Required]
        [StringLength(20)]
        public string emp_cnpj { get; set; }

        [Required]
        [StringLength(20)]
        public string emp_inscestadual { get; set; }

        [Required]
        [StringLength(20)]
        public string emp_inscmunicipal { get; set; }

        [Required]
        [StringLength(50)]
        public string emp_razaosocial { get; set; }

        [Required]
        [StringLength(20)]
        public string emp_telefone1 { get; set; }

        [StringLength(20)]
        public string emp_telefone2 { get; set; }

        public int end_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notaFiscal> notaFiscal { get; set; }

        public virtual endereco endereco { get; set; }
    }
}
