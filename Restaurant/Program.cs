using ConsoleApp3;

//int a = 1; // 
//ch(a); // 1
//Console.WriteLine(a); // 1

//static void ch(int b)
//{
//    b++; // 2
//}

//Person p = new Person("Dima");
//chp(p);
//Console.WriteLine(p.Name); // Askar

//static void chp(Person b)
//{
//    b.Name = "Askar";
//}

//a = 1;
//chr(ref a);
//Console.WriteLine(a); // 

//static void chr(ref int b)
//{
//    b++;
//}

using Restaurant;
using Restaurant;

#region Declarations

Settings.Init();

Guest sezimGuest = new Guest("Sezim", Gender.Female);
Guest _ = new Guest("Dima", Gender.Female);
Guest guest3 = new Guest("Ayim", Gender.Female);
Guest guest4 = new Guest("Boris", Gender.Female);

Chief hotChief = new Chief(
    "Askar", Gender.Female,
    new List<string>
    {
        Settings.Plov,
        Settings.Beshbarmak,
        Settings.Shaurma,
        Settings.Kuksi,
        Settings.Manty,
    }
);

Chief coldChief = new Chief(
    "Ayub", Gender.Female,
    new List<string>
    {
        Settings.OliviePoxyi,
        Settings.Morozhenoe,
    }
);

Chief pizzaChief = new Chief(
    "Nasrat", Gender.Female,
    new List<string>
    {
        Settings.Pizza,
    }
);

var lst = new List<Person> { sezimGuest, hotChief };

Kitchen kitchen = new Kitchen(
    new List<Chief> { hotChief, coldChief, pizzaChief });

Waiter waiter1 = new Waiter("Ashir", Gender.Female);
Waiter bekaWaiter = new Waiter("Beka", Gender.Female);

List<IDrinkable> staff = new List<IDrinkable>
{
    waiter1,
    bekaWaiter,
    hotChief,
    coldChief,
    pizzaChief
};

#endregion

//hotChief.CurrentDish = "Shawerma";
//Console.WriteLine(hotChief.CurrentDish);
//Person person = hotChief;
//Chief newChief = (Chief)person;
//Console.WriteLine(newChief.CurrentDish);

GenericClass<int>