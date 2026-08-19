
internal class Program
{
    private static void Main(string[] args)
    {
        Shelter shelter = new Shelter();
        Dog dog = new Dog();

        dog.Name = "Max";
        dog.Age = 4;
        dog.Weight = 20;
        dog.Breed = "Golden Retriever";

        Cat cat = new Cat();

        cat.Name = "Luna";
        cat.Age = 2;
        cat.Weight = 5;
        cat.CanJump = true;

        Cow cow = new Cow();

        cow.Name = "Molly";
        cow.Age = 6;
        cow.Weight = 450;
        cow.Color = "Brown";

        shelter.AddAnimal(dog);
        shelter.AddAnimal(cat);
        shelter.AddAnimal(cow);
        shelter.ListAnimals();
        shelter.MakeAllSounds();
    }
}

abstract class Animal
{
    public string Name;
    public int Age;
    public double Weight;
    public void Eat()
    {
        Console.WriteLine("This animal can eat.");
    }
    public abstract void MakeSound();
}
interface ITrainable
{
    void Train();
}
class Dog : Animal, ITrainable
{
    public string Breed;
    public override void MakeSound()
    {
        Console.WriteLine("Dog says woof woof.");
    }
    public void Train()
    {
        Console.WriteLine("Dog can be trained.");
    }
}
class Cat : Animal, ITrainable
{
    public bool CanJump;
    public override void MakeSound()
    {
        Console.WriteLine("Cat says meow meow.");
    }
    public void Train()
    {
        Console.WriteLine("Cat can be trained.");
    }
}
class Cow : Animal
{
    public string Color;
    public override void MakeSound()
    {
        Console.WriteLine("Cow says moo.");
    }
}

class Shelter
{
    private List<Animal> animals = new List<Animal>();
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    public void ListAnimals()
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Weight: {animal.Weight}");
        }
    }
    public void MakeAllSounds()
    {
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}

/*
Animal animal = new Dog();
animal.MakeSound(); 
each dog is an animal => polymorphism.
Animal a = new Animal(); does not work as animal is an abstract class
*/
