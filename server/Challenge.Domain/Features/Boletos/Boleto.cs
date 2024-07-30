using Challenge.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Domain.Features.Boleto
{
    public abstract class Boleto
    {

        public int Id { get; set; }
        public string BarCode { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PaymentDate { get; set; }

        /** Juros */
        public decimal InterestAmountCalculated { get; set; }
        /** Multa */
        public decimal FineAmountCalculated { get; set; }

        public string RecipientName { get; set; }
        public string RecipientDocument { get; set; }
        public TypeBoleto BoletoType { get; set; }

        protected Boleto(int id, string barCode, decimal originalAmount, decimal amount, DateTime dueDate, DateTime paymentDate, decimal interestAmountCalculated, decimal fineAmountCalculated, string recipientName, string recipientDocument)
        {
            Id = id;
            BarCode = barCode;
            OriginalAmount = originalAmount;
            Amount = amount;
            DueDate = dueDate;
            PaymentDate = paymentDate;
            InterestAmountCalculated = interestAmountCalculated;
            FineAmountCalculated = fineAmountCalculated;
            RecipientName = recipientName;
            RecipientDocument = recipientDocument;
        }

        public void Validate()
        {

            if (BoletoType != TypeBoleto.NPC)
            {
                throw new NotNPCException();
            }

            if (DueDate < PaymentDate)
            {
                throw new NotExpiredYetException();
            }
        }

        public void CalculateNewAmount()
        {
           

        }

    }
}
