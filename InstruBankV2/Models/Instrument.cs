using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InstruBankV2.Validator;


namespace InstruBankV2.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Descripcion{ get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "decimal(18,2)")]
        [CheckPrice]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Stock { get; set; }

    }
}
