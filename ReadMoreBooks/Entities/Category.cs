using System;
using System.Collections.Generic;
using System.Text;

namespace ReadMoreBooks.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}