namespace ConsoleApp3
{
    public class DbHelper<T> : IDbillable<T>
        where T : Person
    {
        public string Path { get; set; }

        public DbHelper(string path)
        {
            Path = path;
        }

        public void Write(T value)
        {
            using var writer = new StreamWriter(Path);
            writer.Write(value);
        }
    }
}
