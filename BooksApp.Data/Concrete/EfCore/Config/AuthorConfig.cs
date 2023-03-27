using BooksApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksApp.Data.Concrete.EfCore.Config
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.Property(x => x.BirthDate).IsRequired();

            builder.Property(x => x.Gender).IsRequired();

            builder.HasData(
                new Author { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Merve Gülcemaln", Gender = "k", Url= "merve-gulcemal" },
                new Author { Id = 2, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Gamze Çelik", Gender = "k", Url= "gamze-celik" },
                new Author { Id = 3, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Hakan Türkçapar", Gender = "E", Url= "hakan-turkcapar" },
                new Author { Id = 4, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Hale Çokseven",  Gender = "K",Url="hale-cokseven" },
                new Author { Id = 5, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Kemal Devabulan", Gender = "E",Url="kemal-devabulan" },
                new Author { Id = 6, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Mary Wollstonecraft", Gender = "K",Url= "mary-wollstonecraft" }
            );
        }
    }
}