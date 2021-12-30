using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.Validators
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = ValidateAge(minimumAge);
        }

        public string InvalidAgeError => $"The age of the person should be at least {_minimumAge}";

        public string NoValueError(string propName) => $"The {propName} must have a value.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime? dateOfBirth = (DateTime?)value;

            if (!dateOfBirth.HasValue)
            {
                return new ValidationResult(NoValueError(validationContext.MemberName));
            }

            var age = CalculateAge(dateOfBirth.Value);

            if (age < _minimumAge)
            {
                return new ValidationResult(InvalidAgeError);
            }

            return ValidationResult.Success;
        }

        private static int ValidateAge(int minimumAge)
        {
            if (minimumAge < 0 || minimumAge > 123)
            {
                throw new ArgumentOutOfRangeException(nameof(minimumAge), minimumAge, "The value of the age is outside 0 and 123.");
            }

            return minimumAge;
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int yearsDifference = (DateTime.Now - dateOfBirth).Days / 365;

            if (dateOfBirth < DateTime.Now)
            {
                --yearsDifference;
            }

            return yearsDifference;
        }
    }
}
