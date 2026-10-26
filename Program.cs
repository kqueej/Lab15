// Part 1
using System.Text.Json;
// Player player = new()
// {
//     Name = "Alexandr",
//     Level = 10
// };

// string json = JsonSerializer.Serialize(player);
// Console.WriteLine(json);

// JsonSerializerOptions options = new()
// {
//     WriteIndented = true
// };

// string formattedJson = JsonSerializer.Serialize(player, options);
// Console.WriteLine(formattedJson);

// Serialize имеет тип string, т.к JSON является текстом

// Part 2
// Player? restored = JsonSerializer.Deserialize<Player>(json);

// if (restored != null)
// {
//     Console.WriteLine($"{restored.Name}, level {restored.Level}");
// }

// string manualJson = """
// {
//     "Name": "Мария",
//     "Level": 60
// }
// """;

// Player? manualPlayer = JsonSerializer.Deserialize<Player>(manualJson);

// if (manualPlayer != null)
// {
//     Console.WriteLine($"{manualPlayer.Name}, level {manualPlayer.Level}");
// }

// Part 3
// string playerJson = JsonSerializer.Serialize(player, options);
// File.WriteAllText("player.json", playerJson);

// string loadedJson = File.ReadAllText("player.json");
// Player? filePlayer = JsonSerializer.Deserialize<Player>(loadedJson);

// if (filePlayer != null)
// {
//     Console.WriteLine($"{filePlayer.Name}, level {filePlayer.Level}");
// }

// Part 4
// List<Player> players =
// [
//     new Player { Name = "Alexandr", Level = 10 },
//     new Player { Name = "Dornan", Level = 50 },
//     new Player { Name = "Emperor", Level = 100 }
// ];

// string playersJson = JsonSerializer.Serialize(players);
// File.WriteAllText("players.json", playersJson);

// string loadedPlayersJson = File.ReadAllText("players.json");
// List<Player>? restoredPlayers =
//     JsonSerializer.Deserialize<List<Player>>(loadedPlayersJson);

// if (restoredPlayers != null)
// {
//     Console.WriteLine($"Players count: {restoredPlayers.Count}");
//     Console.WriteLine($"First player name: {restoredPlayers[0].Name}");
//     Console.WriteLine($"Level of second player: {restoredPlayers[1].Level}");
// }

// broken JSON
// try
// {
//     string loadedPlayersJson = File.ReadAllText("players.json");
//     JsonSerializer.Deserialize<List<Player>>(loadedPlayersJson);
// }
// catch (JsonException ex)
// {
//     Console.WriteLine($"Error JSON: {ex.Message}");
// }

// JsonException появляется тогда, когда JSON содержит ошибку в синтаксисе или структура 
// не соответсвует ожидаемому типу

// Class
// class Player
// {
//     public string Name { get; set; } = "";
//     public int Level { get; set; }
// }

// Final task
// GameSettings settings = new()
// {
//     PlayerName = "kqueej",
//     Volume = 70,
//     FullScreen = false,
//     Difficulty = Difficulty.Lunatic
// };

// JsonSerializerOptions options = new()
// {
//     WriteIndented = true
// };

// string settingsJson = JsonSerializer.Serialize(settings, options);
// File.WriteAllText("settings.json", settingsJson);

// Console.WriteLine("Settings saved to settings.json");
// Console.WriteLine("\nLoading settings...");

// if (File.Exists("settings.json"))
// {
//     string loadedSettingsJson = File.ReadAllText("settings.json");
//     GameSettings? loadedSettings =
//         JsonSerializer.Deserialize<GameSettings>(loadedSettingsJson);

//     if (loadedSettings != null)
//     {
//         Console.WriteLine($"Player: {loadedSettings.PlayerName}");
//         Console.WriteLine($"Volume: {loadedSettings.Volume}");
//         Console.WriteLine($"Fullscreen: {(loadedSettings.FullScreen ? "Yes" : "No")}");
//         Console.WriteLine($"Difficulty: {loadedSettings.Difficulty}");
//     }
// }
// else
// {
//     Console.WriteLine("Settings file not found.");
// }

// // Class of final task
// class GameSettings
// {
//     public string PlayerName { get; set; } = "";
//     public int Volume { get; set; }
//     public bool FullScreen { get; set; }
//     public Difficulty Difficulty { get; set; }
// }

// enum Difficulty
// {
//     Easy,
//     Normal,
//     Hard,
//     Lunatic
// }

// Self 1
// Game game = new()
// {
//     Title = "Warhammer 40,000: Dawn of War — Dark Crusade",
//     Company = "THQ",
//     Year = 2006
// };

// JsonSerializerOptions options = new()
// {
//     WriteIndented = true
// };
// string gameJson = JsonSerializer.Serialize(game, options);
// Console.WriteLine(gameJson);

// Game? restoredGame = JsonSerializer.Deserialize<Game>(gameJson);

// if (restoredGame != null)
// {
//     Console.WriteLine($"{restoredGame.Title}, {restoredGame.Company}, {restoredGame.Year}");
// }
// class Game
// {
//     public string Title { get; set; } = "";
//     public string Company { get; set; } = "";
//     public int Year { get; set; }
// }

// Self 2
// List<Game> games =
// [
//     new Game { Title = "Warhammer 40k: Dawn of War — Dark Crusade", Company = "THQ", Year = 2006 },
//     new Game { Title = "Fallout 2", Company = "Black Isle Studios", Year = 1998 },
//     new Game { Title = "System Shock", Company = "Looking Glass Studios", Year = 1994 }
// ];

// JsonSerializerOptions options = new()
// {
//     WriteIndented = true
// };

// File.WriteAllText("games.json", JsonSerializer.Serialize(games, options));

// List<Game>? loadedGames =
//     JsonSerializer.Deserialize<List<Game>>(File.ReadAllText("games.json"));

// if (loadedGames != null)
// {
//     Console.WriteLine($"Games count: {loadedGames.Count}");
//     Console.WriteLine($"First game: {loadedGames[0].Title}");
//     Console.WriteLine($"Company of second game: {loadedGames[1].Company}");
// }

// class Game
// {
//     public string Title { get; set; } = "";
//     public string Company { get; set; } = "";
//     public int Year { get; set; }
// }

// Self 3
Inventory inventory = new()
{
    Items = new List<string> { "Sword", "Shield", "Potion" },
    Quantities = new Dictionary<string, int>
    {
        ["Sword"] = 1,
        ["Shield"] = 1,
        ["Potion"] = 5
    }
};

JsonSerializerOptions options = new()
{
    WriteIndented = true
};

File.WriteAllText("inventory.json", JsonSerializer.Serialize(inventory, options));

Inventory? loadedInventory =
    JsonSerializer.Deserialize<Inventory>(File.ReadAllText("inventory.json"));

if (loadedInventory != null)
{
    Console.WriteLine($"Number of items: {loadedInventory.Items.Count}");
    Console.WriteLine($"Number of potions: {loadedInventory.Quantities["Potion"]}");
}
class Inventory
{
    public List<string> Items { get; set; } = [];
    public Dictionary<string, int> Quantities { get; set; } = [];
}

// Класс инвентаря содержит обе коллекции вместе, поэтому можно сериализовать одним объектом