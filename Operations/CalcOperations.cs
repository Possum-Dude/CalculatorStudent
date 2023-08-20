namespace CalculatorStudent.Operations
{
    public class CalcOperations : CalcOperationsBase
    {
        public double Calculation(double Number1d, double Number2d, EnumOperationType OperationType)
        {
            if (OperationType == EnumOperationType.Addition)
            {
                return Add(Number1d, Number2d);
            }
            else if (OperationType == EnumOperationType.Subtraction)
            {
                return Subtract(Number1d, Number2d);
            }
            else if (OperationType == EnumOperationType.Division)
            {
                return Divide(Number1d, Number2d);
            }
            else if (OperationType == EnumOperationType.Multiplication)
            {
                return Multiply(Number1d, Number2d);
            }
            return 0;
        }
    }
}
