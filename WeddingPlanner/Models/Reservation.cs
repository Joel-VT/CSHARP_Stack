#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models;

public class Reservation
{
    [Key]
    public int ReservationId {get;set;}

    public int UserId {get;set;}

    public int WeddingId {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public User? User {get;set;}

    public Wedding? Wedding {get;set;}
}