using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

//Model for the Movie Entity that gets passed to the Controller and exposed in the Views
public class Movie
{
    public int Id { get; set; }


    [StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }


    [Display(Name = "Release Date"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }


    [StringLength(30)]
    public string? Genre { get; set; }


    [Display(Name = "Production Cost"), Range(1,2147483646), DataType(DataType.Currency)]
    [Column(TypeName = "bigint")]
    public long ProductionCost { get; set; }


    [StringLength(5)]
    public string? Rating { get; set; }
}