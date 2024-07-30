using Challenge.Domain.Features.Boleto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Infra.ORM.Features.Boletos
{
    public class BoletoMapper : IEntityTypeConfiguration<Boleto>
    {
            public void Configure(EntityTypeBuilder<Boleto> builder)
        {
            builder.ToTable("TBBoleto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BarCode).HasColumnName("bar_code").HasColumnType("VARCHAR").HasMaxLength(44).IsRequired();
            builder.Property(x => x.DueDate).HasColumnName("due_date").HasColumnType("DATETIME2").IsRequired();
            builder.Property(x => x.PaymentDate).HasColumnName("payment_date").HasColumnType("DATETIME2").IsRequired();
            builder.Property(x => x.Amount).HasColumnName("amount").IsRequired();
            builder.Property(x => x.OriginalAmount).HasColumnName("original_amount").IsRequired();
            builder.Property(x => x.InterestAmountCalculated).HasColumnName("interest_amount_calculated").IsRequired();
            builder.Property(x => x.FineAmountCalculated).HasColumnName("fine_amount_calculated").IsRequired();
            builder.Property(x => x.RecipientDocument).HasColumnName("recipient_document").HasColumnType("VARCHAR").HasMaxLength(90);
            builder.Property(x => x.RecipientName).HasColumnName("recipient_name").HasColumnType("VARCHAR").HasMaxLength(90);
            builder.Property(x => x.BoletoType).HasColumnName("type").IsRequired();

        }
    }
}
