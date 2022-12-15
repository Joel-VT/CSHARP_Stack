#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OneToMany.Models;

public class Maker
{
    [Key]
    public int MakerId {get;set;}

    public string Name {get;set;}

    public string Country {get;set;}

    // Navigation Property
    public List<Vehicle> AllVehicles {get;set;} = new List<Vehicle>();

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}