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



Waiter bekaWaiter = new Waiter("Beka", Gender.Male);

List<string> orders = new List<string>()
    {
        Settings.Manty,
        Settings.Shaurma,
        Settings.Morozhenoe
    };

GuestManager sezimManager = new GuestManager(sezimGuest);
WaiterManager bekaManager = new WaiterManager(bekaWaiter);
ChiefManager hotManager = new ChiefManager(hotChief);
ChiefManager coldManager = new ChiefManager(coldChief);

Kitchen kitchen = new Kitchen(
    new List<ChiefManager> { hotManager, coldManager });

List<IDrinkable> drunks = new List<IDrinkable>
{
    hotManager,
    coldManager,
    bekaManager
};

bekaManager.GetOrder(sezimGuest, orders);
kitchen.GetOrder(bekaManager.Waiter);
List<string> cookedDishes = bekaManager.GetCookedDishes();
sezimManager.GetCookedDishes(cookedDishes);

sezimManager.Eat();

foreach (IDrinkable drinkable in drunks)
{
    drinkable.Drink();
}