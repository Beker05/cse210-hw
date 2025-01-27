using System;

public class Fraction
{
    // Atributos privados
    private int _numerator;
    private int _denominator;

    // Constructor sin parámetros, inicializa 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor con un parámetro para el numerador (denominador será 1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor con parámetros para numerador y denominador
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters y setters para el numerador
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getters y setters para el denominador
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _denominator = denominator;
    }

    // Método para obtener la representación como cadena "3/4"
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Método para obtener el valor decimal
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
