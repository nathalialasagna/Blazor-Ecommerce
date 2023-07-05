using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Dune",
					Description = "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. In 2003, it was described as the world's best-selling science fiction novel.",
					ImageUlr = "https://upload.wikimedia.org/wikipedia/en/thumb/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg/220px-Dune-Frank_Herbert_%281965%29_First_edition.jpg",
					Price = 9.99m
				},
				new Product
				{
					Id = 2,
					Title = "Foundation",
					Description = "Foundation is a science fiction novel by American writer Isaac Asimov. It is the first published in his Foundation Trilogy (later expanded into the Foundation series). ",
					ImageUlr = "https://upload.wikimedia.org/wikipedia/en/thumb/2/25/Foundation_gnome.jpg/220px-Foundation_gnome.jpg",
					Price = 9.99m
				},
				new Product
				{
					Id = 3,
					Title = "Hobbit",
					Description = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published in 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction.",
					ImageUlr = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/TheHobbit_FirstEdition.jpg/220px-TheHobbit_FirstEdition.jpg",
					Price = 9.99m
				}
				);
		}
		public DbSet<Product> Products { get; set; }
    }
}
