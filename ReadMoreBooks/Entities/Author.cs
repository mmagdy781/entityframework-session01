using System;
using System.Collections.Generic;
using System.Text;

namespace ReadMoreBooks.Entities;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Biography { get; set; }
    public DateTime DateOfBirth { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}