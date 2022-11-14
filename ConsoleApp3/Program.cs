using ConsoleApp3;


List<IBitable> crazyPeople = new List<IBitable>();
Animal askar = new Animal("Askar");
Animal ashir = new Animal("Ashir");
Animal dima = new Animal("Dima");
Person sergey = new Person("Sergey", "Goldysh");
Person atai = new Person("Atai", "Mamatov");

crazyPeople.Add(askar);
crazyPeople.Add(ashir);
crazyPeople.Add(dima);
crazyPeople.Add(sergey);
crazyPeople.Add(atai);

foreach(IBitable aiiiiii in crazyPeople)
{
    aiiiiii.Bite(atai);
}