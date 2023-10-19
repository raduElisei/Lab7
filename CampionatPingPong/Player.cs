namespace Lab7.CampionatPingPong;

public class Player
{
    public string Name { get; set; }
    public string Country { get; set; }
    private float _points;
    public float Points
    {
        get
        {
            return _points;
        }

        set
        {
            if(value >= 1.0F &&  value <=10.0F)
            {
                _points = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Points must be between 1.0 and 10.0");
            }
        }
    }

    public static void GenerateContest(int playerNumber)
    {
        List<Player> playerList = new List<Player>();

        for (int i = 0; i < playerNumber; i++)
        {
            Player player = new Player();
            Console.WriteLine("Type a name:");
            var name = Console.ReadLine();
            player.Name = name;

            Console.WriteLine("Type a country:");
            var country = Console.ReadLine();
            player.Country = country;

            Console.WriteLine("Type amount of points:");
            var points = float.Parse(Console.ReadLine());
            player.Points = points;

            playerList.Add(player);
        }

        var orderedNames = playerList.OrderBy(p => p.Name).ToList();

        foreach (Player player in orderedNames)
        {
            string row = String.Format("|{0,15}|", player.Name);

            Console.WriteLine("Player names:");
            Console.WriteLine(row);
        }

        Console.WriteLine();

        var orderedCountries = playerList.OrderBy(p => p.Country).ToList();
        foreach (Player player in orderedCountries)
        {
            string row = String.Format("|{0,15}|{1,15}|", player.Country, player.Name);

            Console.WriteLine("Player countries:");
            Console.WriteLine(row);
        }

        Console.WriteLine();

        var orderedPoints = playerList.OrderByDescending(p => p.Points).ToList();
        foreach (Player player in orderedPoints)
        {
            string row = String.Format("|{0,15}|{1,5}|", player.Name, player.Points);

            Console.WriteLine("Player points:");
            Console.WriteLine(row);
        }

        Console.WriteLine();
    }
}
