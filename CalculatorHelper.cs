using System;
using System.Dynamic;

public class CalculatorHelper
{
    public double calcOperand {get;set;}
    public double CalcOPerator{get;set;}
    public double mathResult{get;set;}

    public CalculatorHelper(double calcOperand,double CalcOPerator)
    {
      this.calcOperand=calcOperand;
      this.CalcOPerator=CalcOPerator;



    }

    public double Addition()
    {
      this.mathResult= this.calcOperand+this.CalcOPerator;
      return mathResult;
    }

    public double Subtraction()
    {
        this.mathResult=this.calcOperand-CalcOPerator;
        return mathResult;
    }
    public double Division()
    {
        return 0;
    }

    public double Multiplication()
    {
        this.mathResult=this.calcOperand*this.CalcOPerator;
        return mathResult;
    }
}