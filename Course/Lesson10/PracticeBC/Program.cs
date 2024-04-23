using System;
using System.Collections.Generic;
using System.IO;
//using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }
}

public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
}

public class PersonFileService
{
    public static void WritePeopleToFile(List<Person> people)
    {
        // Используем File.WriteAllLines для записи списка людей в файл
        File.WriteAllLines("test.txt", people.Select(p => p.Name + ", " + p.Age));
    }

    public static List<Person> ReadPeopleFromFile()
    {
        // Используем File.ReadLines для чтения файла построчно
        var lines = new List<string>();
        using (var reader = new StreamReader("test.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        var people = new List<Person>();
        foreach (var line in lines)
        {
            string[] per = line.Split(',');
            int age;
            if (int.TryParse(per[1], out age))
            {
                people.Add(new Person(per[0], age));
            }
        }
        return people;
    }
}

public class Program
{
    public static void Main()
    {
        // List of people to write to and read from the file
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };

        // Writing people to the file
        PersonFileService.WritePeopleToFile(people);

        // Reading people from the file
        var peopleFromFile = PersonFileService.ReadPeopleFromFile();

        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}