namespace StaticPolymorphism
{
    public class Hen
    {
        public void Fly()
        {
            Console.WriteLine("Flying like a Hen.");
        }
    }

    public class Eagle
    {
        public void Fly()
        {
            Console.WriteLine("Flying like an eagle.");
        }
    }

    public static class AngryBird
    {
        public static void Render(Hen h)
        {
            h.Fly();
        }

        public static void Render(Eagle e)
        {
            e.Fly();
        }
    }
}