using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    internal class ModuleConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Modules");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Teacher).WithMany(x => x.Modules).HasForeignKey(x => x.TeacherId);
        }
    }
}
