using Restaurant;

Guest guest1 = new Guest("Sezim");
Guest guest2 = new Guest("Dima");
Guest guest3 = new Guest("Ayim");
Guest guest4 = new Guest("Boris");

Chief hotChief = new Chief(
    "Askar",
    new List<string>
    {
        Settings.Carbonara,
        Settings.Lasania,
        Settings.Riggotta,
        Settings.Caporesso,
        Settings.Farfalle,
        Settings.Fetuchinni,
    }
);

Chief coldChief = new Chief(
    "Ayub",
    new List<string>
    {
        Settings.Caporesso,
        Settings.Semifredo,
    }
);

Chief pizzaChief = new Chief(
    "Nasrat",
    new List<string>
    {
        Settings.Pizza,
    }
);