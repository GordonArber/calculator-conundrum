using System;

public static class SimpleCalculator
{ 
    public static string Calculate(int operand1, int operand2, string operation)
    {
        int chosenOperation;
        
        switch (operation)
        {
            case "":
                throw new ArgumentException();
            case null:
                throw new ArgumentNullException();
            case "+":
                chosenOperation = SimpleOperation.Addition(operand1,operand2);
                break;
            case "*":
                chosenOperation = SimpleOperation.Multiplication(operand1,operand2);
                break;
            case "/":
                if (operand2 == 0)
                    return "Division by zero is not allowed.";
                chosenOperation = SimpleOperation.Division(operand1,operand2);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return $"{operand1} {operation} {operand2} = {chosenOperation}";
    }
}