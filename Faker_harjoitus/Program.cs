using System;
using Faker;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            string firstName = Faker.Name.First();
            string lastName = Faker.Name.Last();

            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}");
        }
    }
}

