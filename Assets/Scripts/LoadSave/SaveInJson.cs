using System;
/// <summary>
/// An intermediate storage location for game progress between the file and the game.
/// </summary>
[Serializable]
public class SaveInJson
{
    public string saveInGame;

    public bool[] completeAchievment = new bool[38];
    public bool[] isPressCompleteAchievment = new bool[38];

    public int SavesCountHelp;
    public bool Language;
    public string firstLaunch;
    public bool isPossessedHouse;
    public bool isOnSound;
    public int isPressRate;
    public int numberJokeTask;
}
