using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    internal class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("Deliveries");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Grade)
                   .WithOne(x => x.Delivery)
                   .HasForeignKey<Delivery>(x => x.GradeId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
