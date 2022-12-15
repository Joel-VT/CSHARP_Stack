#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyModel.Models;

public class Form
{
    [Required]
    [MinLength(2, ErrorMessage = "Name must be atleast 2 Characters")]
    public string Name {get;set;}

    [FutureDate]
    [DataType(DataType.Date)]
    public DateTime DOB {get;set;}

    [Required]
    public string DojoLocation {get;set;}

    [Required]
    public string FavoriteLanguage {get;set;}

    [MinLength(20, ErrorMessage = "Comments must be atleast 20 Characters")]
    public string? Comments {get;set;}
}