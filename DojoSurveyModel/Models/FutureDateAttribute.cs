#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value==null)
        {
            return new ValidationResult("Date of Birth is Required");
        }
        else if((DateTime)value >= DateTime.Now)
        {
            return new ValidationResult("Invalid date");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}