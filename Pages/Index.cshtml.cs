using CalculatorStudent.DTO;
using CalculatorStudent.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CalculatorStudent.Pages
{

    [BindProperties]
    public class IndexModel : PageModel
    {
        //this calls in the calculation from calcoperations.cs
        public CalcOperations? calc { get; set; }
        //this calls in all the information from the calculator.cs class
        public Calculator? calculator { get; set; }

        public string? Operation { get; set; }
        [Display(Name = "Operation Type")]
        public EnumOperationType OperationType { get; set; }

        public void OnGet()
        {

        }

        public void OnPostAsync()
        {
            try
            {
                //calculator.ErrorMessage = "Try is Running";
                //converts both number 1 and 2 to a double class so it can be calculated together
                double Number1d = Convert.ToDouble(value: calculator.Number1);
                double Number2d = Convert.ToDouble(value: calculator.Number2);
                //[this sends the necceassery information from calculator.cs to calcoperations to be done with the correct equation
                calculator.Result = calc.Calculation(Number1d, Number2d, calculator.OperationType);
            }
            catch (Exception ex)
            {
                calculator.ErrorMessage += " Catch is running. We have an error and it is ..." + ex.ToString();
            }




        }
    }
}