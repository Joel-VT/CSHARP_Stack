#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class PastDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if((DateTime)value >= DateTime.Now)
        {
            return new ValidationResult("Invalid date");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}