using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


using OnlineStore.Categories;  // Ensure you have the correct namespace for Category

namespace OnlineStore.Settings.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.ConfigureByConvention();

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NameAr).HasMaxLength(OnlineStoreConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.NameEn).HasMaxLength(OnlineStoreConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionAr).HasMaxLength(OnlineStoreConsts.DescriptionTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionEn).HasMaxLength(OnlineStoreConsts.DescriptionTextMaxLength).IsRequired();

            builder.ToTable("Categories");
        }
    }
}
