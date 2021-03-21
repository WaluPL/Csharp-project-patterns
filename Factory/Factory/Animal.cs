using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    delegate Animal AnimalMake(string name);
    public class Animal
    {
        private string name;

        public Animal(string name) { this.name = name; }
        public virtual string path()
        {
            return "";
        }

        public override string ToString()
        {
            return path() + ": " + name;
        }
    }
    public abstract class AnimalFactory
    {
        private static Dictionary<string, AnimalMake> map = new Dictionary<string, AnimalMake>()
        {
            { "Crocodile", (string name) => new Crocodile(name)},
            { "Turtle", (string name) => new Turtle(name)},
            { "Snake", (string name) => new Snake(name)},
            { "Cat", (string name) => new Cat(name)},
            { "Dog", (string name) => new Dog(name)},
            { "Cow", (string name) => new Cow(name)},
            { "Fly", (string name) => new Fly(name)},
            { "Dragonfly", (string name) => new Dragonfly(name)},
            { "Spider", (string name) => new Spider(name)},
        };
        public static List<string> keys()
        {
            return map.Keys.OrderBy((name) => name).ToList();
        }
        public static Animal make(string kind, string name)
        {
            return map[kind](name);
        }
    }

    public class Reptale : Animal
    {
        public Reptale(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Reptale";
        }
    }
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Mammal";
        }
    }
    public class Insect : Animal
    {
        public Insect(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Insect";
        }
    }
    public class Crocodile : Reptale
    {
        public Crocodile(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Crocodile";
        }
    }

    public class Turtle : Reptale
    {
        public Turtle(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Turtle";
        }
    }

    public class Snake : Reptale
    {
        public Snake(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Snake";
        }
    }

    public class Cat : Mammal
    {
        public Cat(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Cat";
        }
    }
    public class Dog : Mammal
    {
        public Dog(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Dog";
        }
    }
    public class Cow : Mammal
    {
        public Cow(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Cow";
        }
    }
    public class Fly : Insect
    {
        public Fly(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Fly";
        }
    }
    public class Dragonfly : Insect
    {
        public Dragonfly(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Dragonfly";
        }
    }
    public class Spider : Insect
    {
        public Spider(string name) : base(name) { }

        public override string path()
        {
            return base.path() + "/Spider";
        }
    }
}
