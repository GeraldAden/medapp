namespace MedApp.Infrastructure.Database.Entities;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Patient
{
    [Key]
    public int Id {get; set;}

    [Required]
    public string? FirstName {get; set;}

    [Required]
    public string? LastName {get; set;}

    [Required]
    [Column(TypeName = "date")]
    public DateTime DateOfBirth {get; set;}

    [Required]
    public string? Email {get; set;}

    public ICollection<Address>? Addresses {get; set;}

    [Required]
    public bool IsSmoker {get; set;}

    [Required]
    public bool HasCancer {get; set;}

    [Required]
    public bool HasDiabetes {get; set;}

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt {get; set;}

    [Column(TypeName = "timestamp")]
    public DateTime? UpdatedAt {get; set;}
}