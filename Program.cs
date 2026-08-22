// Console.WriteLine("Hello, World!");


namespace OOPPractice
{
    internal class ProgramApp
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Person class
            Person person = new Person("Imran", 26);
            Dog dog = new Dog();

            // Call methods from both the base and derived classes
            dog.Eat();  // Inherited method from Animal class
            dog.Bark(); // Method from Dog class

            //calling polymorphism example
            PolymorphismExample.Run();
            


            // Call the Greet method
            person.Greet();
        }
    }

    // Define a Person class
    class Person
    {
        // Properties
        public string Name;
        public int Age;

        // Constructor
        public Person(string name, int age)
        {
            Console.WriteLine("Constructor called");
            Console.WriteLine($"Name: {name}, Age: {age}");

            Name = name;
            Age = age;
        }

        // Method to greet
        public void Greet()
        {
            // Concatinate using interpolation
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
