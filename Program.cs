// using System;

// public class Program
// {
//     public static void Main()
//     {
//             Console.WriteLine($"input your first number");
//             double CalcOperand = double.Parse(Console.ReadLine());
//             Console.WriteLine($"input your second number");
//             double CalcOPerator = double.Parse(Console.ReadLine());

//             CalculatorHelper calculatorHelper = new CalculatorHelper(CalcOperand,CalcOPerator);

//             Console.WriteLine($"input the math operation you want to perform");
//             Console.WriteLine($" +  , /  ,  * ");
//             string? mathOperation = Console.ReadLine();
//             double mathResult;

//             if(mathOperation=="+")
//             {
//                mathResult= calculatorHelper.Addition();
//                Console.WriteLine($"the result of the calculation is {mathResult}");
//             }

//             else if(mathOperation=="-")
//             {
//               mathResult=calculatorHelper.Subtraction();
//             //   Console.WriteLine(mathResult); 
//             Console.WriteLine($"the result of the calculation is {mathResult}");     
//             }

//             else if(mathOperation=="*")
//             {
//                 mathResult=calculatorHelper.Multiplication();
//                 Console.WriteLine(mathResult);
//             }

//             else if (mathOperation=="/")
//             {
//                 mathResult=calculatorHelper.Division();
//                Console.WriteLine($"the result of the calculation is {mathResult}");
//             }

//             else
//             {
//                 Console.WriteLine($"please input the right thing");
//             }
                


//     }
// }


public class Program 
{
    public static void Main()
    {
       
        
    }
}

public struct rectangle
{
    public double length;
    public double width;

    public rectangle(double length, double width)
    {
        this.length=length;
        this.width=width;
    }

    public double area()
    {
        return length*width;
    }
}