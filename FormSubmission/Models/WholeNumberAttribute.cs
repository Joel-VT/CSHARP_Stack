#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;


public class WholeNumberAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null)
        {
            return new ValidationResult("Please enter a respones");
        }
        else if((int)value < 0)
        {
            return new ValidationResult("Invalid number");
        }
        else if((int)value % 2 == 0)
        {
            return new ValidationResult("Not an Odd Number");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}