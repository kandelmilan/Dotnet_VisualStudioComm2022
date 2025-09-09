namespace AnimalWebApp.Models
{
    public abstract class Animal
    {
        public abstract string MakeSound();
        public string Sleep() => "Sleeping...";
    }

    public class Dog : Animal
    {
        public override string MakeSound() => "Dog says: Woof! Woof!";
    }

    public class Cat : Animal
    {
        public override string MakeSound() => "Cat says: Meow! Meow!";
    }
}