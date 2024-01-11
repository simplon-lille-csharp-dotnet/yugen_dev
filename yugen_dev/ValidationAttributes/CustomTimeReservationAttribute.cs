namespace yugen_dev.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

public class CustomTimeReservationAttribute : ValidationAttribute
{
    private readonly string[] AllowedValues = { "1.19:00:00", "1.19:30:00", "1.20:00:00", "1.20:30:00", "1.21:00:00", "1.21:30:00", "1.22:00:00" };

    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return true; // Null values are considered valid, you can adjust this based on your requirements
        }

        string stringValue = value.ToString();

        return AllowedValues.Contains(stringValue);
    }
}