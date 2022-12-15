#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;

public class Form
{
    [Required]
    [MinLength(2,ErrorMessage = "Name has to be atleast 2 characters long")]
    public string Name {get;set;}

    [Required]
    [EmailAddress]
    public string Email {get;set;}

    [DataType(DataType.Date)]
    [PastDate]
    public DateTime DOB {get;set;}

    [Required]
    [MinLength(8, ErrorMessage = "Password has to be atleast 8 characters long")]
    [DataType(DataType.Password)]
    public string Password {get;set;}

    [Required]
    [WholeNumber]
    public int OddNumber {get;set;}  
}