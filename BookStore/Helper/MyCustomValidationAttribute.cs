using System.ComponentModel.DataAnnotations;

namespace BookStore.Helper
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {
        public string Text { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string bookName = value.ToString();
                if (bookName.Contains(Text))
                {
                    return ValidationResult.Success;
                }

            }
            return new ValidationResult(ErrorMessage ?? "BookName does not contain the desired value");
        }
    }
}
