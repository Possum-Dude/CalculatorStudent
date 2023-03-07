using CalculatorStudent.Operations;
using System.ComponentModel.DataAnnotations;

namespace CalculatorStudent.DTO
{
    public class Calculator
    {
        [Display(Name = "Enter your First number")]
        public string? Number1 { get; set; }
        [Display(Name = "Enter your Second number")]
        public string? Number2 { get; set; }
        [Display(Name = "Here Are your results")]
        public double Result { get; set; }

        public string? ErrorMessage { get; set; }
        [Display(Name = "Operation Type")]
        public EnumOperationType OperationType { get; set; }
    }
}
