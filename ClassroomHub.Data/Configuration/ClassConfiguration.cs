using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Classes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Start).IsRequired();
            builder.Property(x => x.End).IsRequired();
            builder.Property(x => x.CourseId).IsRequired();
            builder.HasOne(x => x.Course)
                   .WithMany(x => x.Classes)
                   .HasForeignKey(x => x.CourseId);
        }
    }
}
