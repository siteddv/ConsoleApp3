using ConsoleApp3;

Player pl = new Player("Dima", "Vinogradov", 185);

IMovable movable = pl;

Player p = (Player)pl;
Console.WriteLine(p.Firstname);
movable.Move();
Person p1 = new Player("1", "2", 3);