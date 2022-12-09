namespace Restaurant.Infrastructure
{
    public interface IDbillable<T>
    {
        public void Write(T value);
    }
}
