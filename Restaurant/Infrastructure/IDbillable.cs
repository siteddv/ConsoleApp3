namespace Restaurant.Infrastructure
{
    public interface IDbillable<T> // CRUD
    {
        public void Write(T value);
        public int GetLastId();
        public List<T> ReadAll();
    }
}
