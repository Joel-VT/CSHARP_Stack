#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MtMDemo.Models;

public class KnownMove
{
    [Key]
    public int KnownMoveId {get;set;}

    public int PokemonId {get;set;}

    public int MoveId {get;set;}

    public Pokemon? Pokemon {get;set;}
    public Move? Move {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}