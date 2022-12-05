using Restaurant;

namespace ConsoleApp3
{
    public class DbHelper<T> : IDbillable<T>
        where T : Person
    {
        public void Write(T value)
        {
            var entityType = typeof(T);
            var a = entityType.Name;

            using var writer = new StreamWriter($"{a}.txt", true);
            writer.WriteLine(value);
        }
    }
}
