using System;
class AgeValidator
{
    public static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be at least 18.");
        }
        Console.WriteLine($"Возраст {age} подходит.");

    }
    
}