using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.DueDate).IsRequired();

            builder.HasOne(x => x.Module).WithMany(x => x.Activities).HasForeignKey(x => x.ModuleId);
        }
    }
}
