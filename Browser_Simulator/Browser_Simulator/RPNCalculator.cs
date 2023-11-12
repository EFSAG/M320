using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class RPNCalculator
    {
        private StringStack stack;

        public RPNCalculator(int stackCapacity)
        {
            stack = new StringStack(stackCapacity);
        }

        public void PerformOperation(string input)
        {
            if (IsNumeric(input))
            {
                stack.Push(input);
            }
            else if (IsOperator(input))
            {
                PerformBinaryOperation(input);
            }
            else
            {
                Console.WriteLine($"Ungültige Eingabe: {input}");
            }
        }

        private void PerformBinaryOperation(string operation)
        {
            if (stack.Count < 2)
            {
                Console.WriteLine("Fehler: Nicht genügend Operanden für die Operation.");
                return;
            }

            double operand2 = double.Parse(stack.Pop());
            double operand1 = double.Parse(stack.Pop());
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Division durch Null.");
                        return;
                    }
                    break;
                case "%":
                    result = operand1 % operand2;
                    break;
                default:
                    Console.WriteLine($"Ungültige Operation: {operation}");
                    return;
            }

            stack.Push(result.ToString());
        }

        public void PrintResult()
        {
            if (stack.Count == 1)
            {
                Console.WriteLine($"Ergebnis: {stack.Peek()}");
            }
            else
            {
                Console.WriteLine("Fehler: Der Stack enthält mehr als ein Ergebnis.");
            }
        }

        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        private bool IsOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/" || input == "%";
        }

    }
}
