using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Неведома зверушка
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кот", "Мяу!");
            Dog dog = new Dog("Пёс", "Гав!");
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }
        string say;

        public Animal(string name = "Хомяк", string say = "Му!")
        {
            this.Name = name;
            this.say = say;          
        }

        public abstract void Say();        

        public void ShowInfo()
        {           
            Console.WriteLine("Зверушка называется " + Name);
            Say();
        }
    } 
    class Cat : Animal
    {
        private string name;
        private string say;
        public override string Name { 
            get => name;
            set => name = value; 
        }

        public Cat(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public override void Say()
        {
            Console.WriteLine($"{name} говорит {say}");
        }
    }

    class Dog : Animal
    {
        private string name;
        private string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public override void Say()
        {
            Console.WriteLine($"{name} говорит {say}");
        }
    }

}
