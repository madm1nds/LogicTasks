using System;
using UnityEngine;
/// <summary>
/// Contains the current state of the game.
/// </summary>
[Serializable]
public class SaveInGame
{
    public static bool[] isCompleteAchievment = new bool[38];
    public static bool[] isPressCompleteAchievment = new bool[38];

    public static string[] textAchievments = new string[38];
    public static string[] howGetAchievments = new string[38];
    public static bool[] switchAchievments = new bool[38];

    public static int numberJokeTask = 0;

    public int tempCount;
    public static int tempAllCount = 0;
    public static int numberLvlClick = 1;

    public static int SavesCountHelp;

    public static int isPressRateGame = 0;

    public bool[] isRateLevelsCheck = new bool[100];
    public bool[] isSkipRateLevelsCheck = new bool[100];
    public bool[] isOpenHelpLevelsCheck = new bool[100];

    public SaveInGame()
    {
        for (int i = 0; i < isCompleteAchievment.Length; i++)
        {
            isCompleteAchievment[i] = false;
        }
        for (int i = 0; i < isPressCompleteAchievment.Length; i++)
        {
            isPressCompleteAchievment[i] = false;
        }

        for (int i = 0; i < switchAchievments.Length; i++)
        {
            switchAchievments[i] = false;
        }

        for (int i = 0; i < isRateLevelsCheck.Length; i++)
        {
            isRateLevelsCheck[i] = false;
        }
        for (int i = 0; i < isSkipRateLevelsCheck.Length; i++)
        {
            isSkipRateLevelsCheck[i] = false;
        }
        for (int i = 0; i < isOpenHelpLevelsCheck.Length; i++)
        {
            isOpenHelpLevelsCheck[i] = false;
        }
    }
}
