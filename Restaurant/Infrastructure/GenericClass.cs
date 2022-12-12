using System.Security.Cryptography.X509Certificates;
using Restaurant.Entities;

namespace Restaurant.Infrastructure
{
    public class DbHelper<T> : IDbillable<T>
        where T : Person
    {
        public DbHelper()
        {
            Type entityType = typeof(T);
            string typeName = entityType.Name;
            _tableName = $"{typeName}.txt";
            _lastIdFileName = $"{typeName}Id.txt";
        }

        private readonly string _tableName;
        private readonly string _lastIdFileName;

        public void Write(T value)
        {
            using StreamWriter writer = new StreamWriter(_tableName, true);

            int currentId = GetLastId() + 1;

            writer.WriteLine($"{currentId}|{value}");

            IncreaseId(currentId);
        }

        public int GetLastId()
        {
            using StreamReader reader = 
                new StreamReader(_tableName);
            string lastId = reader.ReadToEnd();

            return Convert.ToInt32(lastId);
        }

        public List<T> ReadAll()
        {
            using StreamReader reader =
                new StreamReader(_tableName);

            List<T> result = new List<T>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] array = line.Split('|');
                if (typeof(T) == typeof(Chief))
                {
                    Chief chief = GetChief(array);
                    result.Add(chief);
                }
            }
        }

        private Chief GetChief(string[] array)
        {
            int id = Convert.ToInt32(array[0]);
            string name = array[1];
            Gender gender = GetGender(array[2]);
            string currentDish = array[3];
            Chief chief = new Chief(name, gender, null);
            chief.CurrentDish = currentDish;
            chief.Id = id;

            return chief;
        }

        private Gender GetGender(string gender)
        {
            string[] genders = Enum.GetNames(typeof(Gender));
            int genderId = Array.IndexOf(genders, gender);
            return (Gender)genderId;
        }

        private void IncreaseId(int lastId)
        {
            using StreamWriter writer = new StreamWriter(_lastIdFileName, false);
            writer.Write(lastId);
        }
    }
}
