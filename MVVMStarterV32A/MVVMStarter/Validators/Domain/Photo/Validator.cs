using MVVMStarter.Validators.App;

namespace MVVMStarter.Validators.Domain.Photo
{
    public static class Validator
    {
        public static ValidationOutcome ValidateTitle(string value)
        {
            return ValidationHandler.ValidateStringMinLength(value, 3);
        }

        public static ValidationOutcome ValidateYear(int value)
        {
            return ValidationHandler.ValidateIntInInterval(value, 1900, 2020);
        }
    }
}
