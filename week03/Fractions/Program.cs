using System;

public class Fraction
{
  private int   _numerator;
  private int   _denominator;
  public Fraction()
  { // Default constructor
    _numerator = 1; // Default numerator
    _denominator = 1;// Default denominator
  }
  public Fraction(int wholeNumber)
  { // Parameterized constructor
    _numerator = wholeNumber; // Set the numerator
    _denominator = 1; // Set the denominator
  }
  // Add the parameterized constructor here
  public Fraction(int numerator, int denominator)
  { // Parameterized constructor
    _numerator = numerator; // Set the numerator
    _denominator = denominator; // Set the denominator
  }
  public string GetDecimalString()// Method to get the decimal value of the fraction
    {// Method to get the decimal value of the fraction
        string text = $"{_numerator / _denominator}";// Get the decimal value
        return text;// Return the decimal value
    }
<<<<<<< HEAD
}
=======
    public double GetDecimalValue()
    {// Method to get the decimal value of the fraction
        return (double)_numerator / _denominator;// Return the decimal value
    }

}
>>>>>>> 9f66df048b98d914d354c73157f301ad1026c974
