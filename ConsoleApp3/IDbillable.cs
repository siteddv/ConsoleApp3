namespace ConsoleApp3
{
    public interface IDbillable<T>
    {
        public void Write(T value);
    }
}
