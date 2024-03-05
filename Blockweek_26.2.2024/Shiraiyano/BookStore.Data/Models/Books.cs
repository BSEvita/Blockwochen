﻿namespace BookStore.Data.Models;
public class Books
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool IsAvailable { get; set; }
    public string CallNumber { get; set; }

}