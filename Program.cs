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
GameSettings settings = new()
{
    PlayerName = "kqueej",
    Volume = 70,
    FullScreen = false,
    Difficulty = Difficulty.Lunatic
};

JsonSerializerOptions options = new()
{
    WriteIndented = true
};

string settingsJson = JsonSerializer.Serialize(settings, options);
File.WriteAllText("settings.json", settingsJson);

Console.WriteLine("Settings saved to settings.json");
Console.WriteLine("\nLoading settings...");

if (File.Exists("settings.json"))
{
    string loadedSettingsJson = File.ReadAllText("settings.json");
    GameSettings? loadedSettings =
        JsonSerializer.Deserialize<GameSettings>(loadedSettingsJson);

    if (loadedSettings != null)
    {
        Console.WriteLine($"Player: {loadedSettings.PlayerName}");
        Console.WriteLine($"Volume: {loadedSettings.Volume}");
        Console.WriteLine($"Fullscreen: {(loadedSettings.FullScreen ? "Yes" : "No")}");
        Console.WriteLine($"Difficulty: {loadedSettings.Difficulty}");
    }
}
else
{
    Console.WriteLine("Settings file not found.");
}

// Class of final task
class GameSettings
{
    public string PlayerName { get; set; } = "";
    public int Volume { get; set; }
    public bool FullScreen { get; set; }
    public Difficulty Difficulty { get; set; }
}

enum Difficulty
{
    Easy,
    Normal,
    Hard,
    Lunatic
}