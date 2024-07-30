using Challenge.Domain.Features.Boleto;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Application.Features.Boletos
{
    public class BoletoViewModel
    {
        public int Id { get; set; }
        [Key]
        [Required]
        public string BarCode { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PaymentDate { get; set; }

        public decimal InterestAmountCalculated { get; set; }
        public decimal FineAmountCalculated { get; set; }
        public string RecipientName { get; set; }
        public string RecipientDocument { get; set; }
        public TypeBoleto BoletoType { get; set; }
    }
}
