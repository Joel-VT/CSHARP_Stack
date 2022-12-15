#pragma warning disable CS8618
namespace FirstConnection.Models;
using System.ComponentModel.DataAnnotations;

public class Monster
{
    [Key]
    public int MonsterId {get;set;}

    [Required]
    [MinLength(2)]
    public string Name {get;set;}
    
    [Required]
    public int Height {get;set;}
    
    [Required]
    [MinLength(10)]
    public string Description {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}