#region Declarations

using ConsoleApp3;
using Restaurant;

Settings.Init();

Guest sezimGuest = new Guest("Sezim", Gender.Female);

Chief hotChief = new Chief(
    "Askar",
    Gender.Male,
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
    "Ayub",
    Gender.Male,
    new List<string>
    {
        Settings.OliviePoxyi,
        Settings.Morozhenoe,
    }
);

Chief pizzaChief = new Chief(
    "Nasrat",
    Gender.Male,
    new List<string>
    {
        Settings.Pizza,
    }
);

var lst = new List<Person> { sezimGuest, hotChief };

Kitchen kitchen = new Kitchen(
    new List<Chief> { hotChief, coldChief, pizzaChief });

Waiter bekaWaiter = new Waiter("Beka", Gender.Male);

List<IDrinkable> staff = new List<IDrinkable>
{
    bekaWaiter,
    hotChief,
    coldChief,
    pizzaChief
};

#endregion

List<string> orders = new List<string>()
    {
        Settings.Manty,
        Settings.Shaurma,
        Settings.Morozhenoe
    };

sezimGuest.GiveOrder(bekaWaiter, orders);
kitchen.GetOrder(orders, bekaWaiter);
bekaWaiter.GiveFoodToGuest();
foreach (var order in orders)
{
    sezimGuest.Eat(order);
}

foreach (IDrinkable drunkPerson in staff)
{
    drunkPerson.Drink();
}

DbHelper<Guest> dbHelper = new DbHelper<Guest>();
dbHelper.Write(sezimGuest);

DbHelper<Chief> chiefDbHelper = new DbHelper<Chief>();
chiefDbHelper.Write(hotChief);

DbHelper<Waiter> waiterDbHelper = new DbHelper<Waiter>();
waiterDbHelper.Write(bekaWaiter);