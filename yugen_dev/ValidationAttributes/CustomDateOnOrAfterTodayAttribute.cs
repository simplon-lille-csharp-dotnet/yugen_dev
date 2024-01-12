namespace yugen_dev.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

public class CustomDateOnOrAfterTodayAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date.Date < DateTime.Today)
            {
                return new ValidationResult("La date de réservation doit être aujourd'hui ou ultérieure.");
            }
        }

        return ValidationResult.Success;
    }
}