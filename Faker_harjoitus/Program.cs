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
            string address = Faker.Address.StreetAddress();
            string personId = GeneratePersonId(lastName);

            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Адрес: {address}, Идентификационный номер: {personId}");
        }

    }

    static string GeneratePersonId(string lastName)
    {
        var firstLetter = lastName[0];
        var numberPart1 = Faker.RandomNumber.Next(1000, 10000);
        var numberPart2 = Faker.RandomNumber.Next(1000, 10000);

        return $"{firstLetter} {numberPart1} {numberPart2}";
    }

}

