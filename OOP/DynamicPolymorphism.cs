namespace DynamicPolymorphism
{
    public abstract class Bird
    {
        abstract public void Fly();
    }

    public class Hen : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Flying like a Hen.");
        }
    }

    public class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Flying like an eagle.");
        }
    }

    public static class AngryBird
    {
        public static void Render(Bird b)
        {
            b.Fly();
        }
    }
}