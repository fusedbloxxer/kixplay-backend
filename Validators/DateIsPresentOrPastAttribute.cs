using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.Validators
{
    public class DateIsPresentOrPastAttribute : ValidationAttribute
    {
        public string InvalidDateError => $"The date cannot be in the future.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dateValue = (DateTime)value;

            if (dateValue > DateTime.Now)
            {
                return new ValidationResult(InvalidDateError);
            }

            return ValidationResult.Success;
        }
    }
}
