#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId {get;set;}

    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters")]
    [Display(Name = "Wedder One")]
    public string WedderOne {get;set;}

    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters")]
    [Display(Name = "Wedder Two")]
    public string WedderTwo {get;set;}

    [Required]
    [PastDate]
    [DataType(DataType.Date)]
    public DateTime Date {get;set;}

    [Required]
    [MinLength(10, ErrorMessage = "Must be atleast 10 characters")]
    public string Address {get;set;}

    public int UserId {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public User? Planner {get;set;}

    public List<Reservation> RSVPedGuests {get;set;} = new List<Reservation>();

    public int responded(int uid)
    {
        foreach (Reservation guest in RSVPedGuests)
        {
            if(guest.UserId == uid)
            {
                return guest.ReservationId;
            }
        }
        return 0;
    }
}

public class PastDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value==null)
        {
            return new ValidationResult("Date of Birth is Required");
        }
        else if((DateTime)value < DateTime.Now)
        {
            return new ValidationResult("Invalid date");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}