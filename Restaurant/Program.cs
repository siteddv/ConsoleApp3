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

Kitchen kitchen = new Kitchen(
    new List<Chief> { hotChief, coldChief });

Waiter bekaWaiter = new Waiter("Beka", Gender.Male);

//#endregion

//List<string> orders = new List<string>()
//    {
//        Settings.Manty,
//        Settings.Shaurma,
//        Settings.Morozhenoe
//    };

//sezimGuest.TakeWaiter(bekaWaiter, orders);
//kitchen.GetOrder(orders, bekaWaiter);
//bekaWaiter.GiveFoodToGuest();
//foreach (var order in orders)
//{
//    sezimGuest.Eat(order);
//}

//foreach (IDrinkable drunkPerson in staff)
//{
//    drunkPerson.Drink();
//}