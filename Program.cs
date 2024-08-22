//Excercício sistema de login
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        calculateAverage();
    }
    
    static double[] captureValues() 
    {
        Console.WriteLine("Bem vindo ao sistema!\n");
        Console.WriteLine("Digite 5 numeros para calcular a media dos mesmos.");

        double[] capturedValues = new double[5];
        for(int i = 0; i < 5 ; i ++)
        {
            try
            {
                string stringValue = Console.ReadLine();
                capturedValues[i] = Convert.ToDouble(stringValue);
            } 
            catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro durante a captura dos valores. ERRO: " + e.Message);
            }
        }
        
        Console.WriteLine("Valores lidos com sucesso!");
        return capturedValues;
    }

    static void calculateAverage()
    {
        double[] capturedValues = captureValues();
        double totalValue = 0;

        foreach(double value in capturedValues)
        {
            totalValue += value;
        }

        double avarageValue = totalValue/5;
        
        foreach(double value in capturedValues)
        {
            if(value < avarageValue)
            {
                Console.WriteLine("Valor: " + value + " é menor que a média: " + avarageValue);
                continue;
            }
            Console.WriteLine("Valor: " + value + " é maior ou igual a média: " + avarageValue);
        }
    }
}
