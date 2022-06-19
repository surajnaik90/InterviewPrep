namespace usingInterface
{
    interface IFlyable
    {
        void Fly();
    }

    public abstract class Bird
    {
        public abstract void Fly();
    }

    public abstract class Toy
    {
        abstract public void Describe();
    }

    public abstract class Insect
    {
        abstract public void Eat();
    }
    public class Hen : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Flying like a Hen");
        }
    }

    public class Drone : Toy, IFlyable
    {
        public override void Describe()
        {
            Console.WriteLine("I am a drone");
        }
        public void Fly()
        {
            Console.WriteLine("Drone is flying");
        }
    }

    public class Bat : Toy
    {
        public override void Describe()
        {
            Console.WriteLine("I am cricket bat");
        }
    }
    public class Mosquito : Insect, IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("Mosquito is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Mosquito is flying");
        }
    }
    public class Ant : Insect
    {
        public override void Eat()
        {
            Console.WriteLine("Ant is eating");
        }
    }
}