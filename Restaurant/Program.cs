using Restaurant;

#region Declarations

Settings.Init();

Guest guest1 = new Guest("Sezim");
Guest guest2 = new Guest("Dima");
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

Kitchen kitchen = new Kitchen(
    new List<Chief> { hotChief, coldChief, pizzaChief });

Waiter waiter1 = new Waiter("Ashir");
Waiter waiter2 = new Waiter("Beka");

List<IDrinkable> staff = new List<IDrinkable>
{
    waiter1,
    waiter2,
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

guest1.GiveOrder(waiter2, orders);
kitchen.GetOrder(orders, waiter2);
waiter2.GiveFoodToGuest();
foreach(var order in orders)
{
    guest1.Eat(order);
}

foreach (IDrinkable drunkPerson in staff)
{
    drunkPerson.Drink();
}