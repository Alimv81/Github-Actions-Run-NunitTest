﻿namespace Github_Actions_Run_NunitTest;

public class Calculator
{
    public double Add(double a, double b) => a + b + 5;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}