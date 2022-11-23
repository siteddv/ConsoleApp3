using Restaurant;

#region Declarations

Settings.Init();

Guest sezimGuest = new Guest("Sezim");
Guest _ = new Guest("Dima");
Guest guest3 = new Guest("Ayim");
Guest guest4 = new Guest("Boris");

Chief hotChief = new Chief(
    "Askar",
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
    new List<string>
    {
        Settings.OliviePoxyi,
        Settings.Morozhenoe,
    }
);

Chief pizzaChief = new Chief(
    "Nasrat",
    new List<string>
    {
        Settings.Pizza,
    }
);

var lst = new List<Person> { sezimGuest, hotChief };

Kitchen kitchen = new Kitchen(
    new List<Chief> { hotChief, coldChief, pizzaChief});

Waiter waiter1 = new Waiter("Ashir");
Waiter bekaWaiter = new Waiter("Beka");

List<IDrinkable> staff = new List<IDrinkable>
{
    waiter1,
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
foreach(var order in orders)
{
    sezimGuest.Eat(order);
}

foreach (IDrinkable drunkPerson in staff)
{
    drunkPerson.Drink();
}