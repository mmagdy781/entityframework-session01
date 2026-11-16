using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Data;
using ReadMoreBooks.Entities;

using var context = new BookStoreDbContext();

Console.WriteLine($"Can connect: {context.Database.CanConnect()}");

if (!context.Books.Any())
{
    var author = new Author
    {
        FirstName = "George",
        LastName = "Orwell",
        Email = "orwell@example.com",
        Biography = "English novelist and essayist.",
        DateOfBirth = new DateTime(1903, 6, 25)
    };

    var category = new Category
    {
        Name = "Fiction",
        Description = "Novels and stories",
        IsActive = true
    };

    context.Books.Add(new Book
    {
        Title = "1984",
        ISBN = "9780451524935",
        Price = 150m,
        NumberOfPages = 328,
        PublishedYear = 1949,
        IsInStock = true,
        Author = author,
        Category = category
    });

    context.SaveChanges();
}

foreach (var b in context.Books.Include(b => b.Author).Include(b => b.Category))
{
    Console.WriteLine($"{b.Title} | {b.Author.FirstName} {b.Author.LastName} | {b.Category.Name} | {b.Price}");
}
