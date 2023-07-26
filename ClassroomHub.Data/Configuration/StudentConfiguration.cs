using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Birthday).IsRequired();
            builder.HasOne(x => x.User).WithOne(x => x.Student).HasForeignKey<Student>(x => x.UserId);
            builder.HasOne(x => x.Class).WithMany(x => x.Students).HasForeignKey(x => x.ClassId);
        }
    }
}
