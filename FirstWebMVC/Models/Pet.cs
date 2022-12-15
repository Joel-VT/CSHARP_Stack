#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models;

public class Pet
{
    [Required]
    public string Name {get; set;}
    // throw a ? after string if you want it to be nullable
    [Required]
    public string Species {get; set;}
    public bool IsFriendly {get;set;}
    [Required]
    public int Age {get;set;}
}