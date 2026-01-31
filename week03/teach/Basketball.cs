/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
         // Map: PlayerID -> Total Points
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // Skip header row

        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            // Add or update total points for player
            if (!players.ContainsKey(playerId))
            {
                players[playerId] = points;
            }
            else
            {
                players[playerId] += points;
            }
        }

        // Convert dictionary to list and sort by points descending
        var sortedPlayers = players
            .OrderByDescending(p => p.Value)
            .Take(10)
            .ToList();

        Console.WriteLine("Top 10 Players by Total Points:");
        foreach (var player in sortedPlayers)
        {
            Console.WriteLine($"{player.Key}: {player.Value}");
        }
    }
}