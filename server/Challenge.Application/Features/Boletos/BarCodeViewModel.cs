using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Application.Features.Boletos
{
    public class BarCodeViewModel
    {
        [Key]
        [Required]
        public string BarCode { get; set; }
        [Required]
        public DateTime DueDate { get; set; }

    }
}
