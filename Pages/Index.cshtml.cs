using CalculatorStudent.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CalculatorStudent.Pages
{

    [BindProperties]
    public class IndexModel : PageModel
    {
        [Display(Name = "Enter your First number")]
        public string? Number1 { get; set; }
        [Display(Name = "Enter your Second number")]
        public string? Number2 { get; set; }
        [Display(Name = "Here Are your results")]
        public double Result { get; set; }

        public string? Operation { get; set; }
        [Display(Name = "Operation Type")]
        public EnumOperationType OperationType { get; set; }

        public void OnGet()
        {

        }

        public void OnPostAsync()
        {
            double Number1d = Convert.ToDouble(value: Number1);
            double Number2d = Convert.ToDouble(value: Number2);

            if (OperationType == EnumOperationType.Addition)
            {
                Result = Number1d + Number2d;
            }
            else if (OperationType == EnumOperationType.Subtraction)
            {
                Result = Number1d - Number2d;
            }
            else if (OperationType == EnumOperationType.Division)
            {
                Result = Number1d / Number2d;
            }
            else if (OperationType == EnumOperationType.Multiplication)
            {
                Result = Number1d * Number2d;
            }


        }
    }
}