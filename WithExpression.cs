internal class Program
    {
        public record Person(string Name, int Age);
        static void Main(string[] args)
        {
            Person adult = new Person("Esam", 27);
            Person child = adult with { Age = 5 };
            Console.WriteLine(child.Name);
        }
    }
