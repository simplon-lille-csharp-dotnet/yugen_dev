namespace yugen_dev.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

public class CustomTimeReservationAttribute : ValidationAttribute
{
    private readonly string[] AllowedValues = { "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00" };

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