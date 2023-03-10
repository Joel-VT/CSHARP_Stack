#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OneToMany.Models;
public class Vehicle
{    
    [Key]    
    public int VehicleId { get; set; }
    
    [Required]
    public string ModelName {get;set;}
    
    [Required]
    public string Color {get;set;}
    
    [Required]
    [Range(1886,int.MaxValue)]
    public int Year {get;set;}
    
    [Required]
    public string Transmission {get;set;}
    
    [Required]
    public bool AWD {get;set;}

    [Required]
    public int MakerId {get;set;}

    // Navigation Property
    public Maker? Maker {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}
