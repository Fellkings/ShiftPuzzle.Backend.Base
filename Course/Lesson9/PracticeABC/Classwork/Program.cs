namespace Classwork;

class Program
{
    static void Main(string[] args)
    {
        Person[] arr = new Person[3];
        arr[0] = new Person("Данила", 21);
        arr[1] = new Person("Ярослав", 19);
        arr[2] = new Person("Максим", 20);
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].Introduce();
        }
    }

    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("Привет, моё имя " + name);
        }

        public void Set_age(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Возраст должен быть не меньше 0");
            }
        }
    }
    
    public class Employee : Person
    {
        public string position;

        public Employee(string name, int age, string position) : base(name, age)
        {
            this.position = position;
        }
    }
}
