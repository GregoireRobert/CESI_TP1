

using System.Net;

using System.Security.Cryptography;

namespace CESI_TP1;



public class Calculator

{


    public int valueDefault = 50;

    public int secondOperand = 100;

    public static Calculator operator -(Calculator c1, Calculator c2)

    {

        Calculator c = new();

        int firstOperand = c.valueDefault - c2.secondOperand;


        c.secondOperand = firstOperand;

        return c;

    }


    public static Calculator operator *(Calculator c1, Calculator c2)

    {

        return new Calculator();

    }



    public static Calculator operator +(Calculator c1, Calculator c2)

    {


        return new Calculator();

    }

    public int AddNumbers(int v1, int v2)

    {

        Console.WriteLine("Coucou je suis la surcharge int");

        return v1 + v2;

    }


    public double AddNumbers(double v1, double v2)

    {

        Console.WriteLine("Coucou je suis la surcharge double");

        return v1 + v2;

    }

    public float AddNumbers(float v1, float v2)

    {

        return v1 + v2;

    }

}


