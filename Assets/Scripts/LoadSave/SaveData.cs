using System;
using System.Text;
using UnityEngine;
/// <summary>
/// Saves and encodes the current progress into a save file.
/// </summary>
public static class SaveData
{
    public static void Save()
    {
        GlobalSaves.sv.saveInGame = JsonHelper.ToJson(GlobalSaves.saveInGame);

        for (int i = 0; i < 38; i++)
        {
            GlobalSaves.sv.completeAchievment[i] = SaveInGame.isCompleteAchievment[i];
            GlobalSaves.sv.isPressCompleteAchievment[i] = SaveInGame.isPressCompleteAchievment[i];
        }

        GlobalSaves.sv.SavesCountHelp = SaveInGame.SavesCountHelp;
        GlobalSaves.sv.isPossessedHouse = GlobalVariables.isPossessedHouse;
        GlobalSaves.sv.isOnSound = GlobalVariables.isOnSound;
        GlobalSaves.sv.isPressRate = SaveInGame.isPressRateGame;
        GlobalSaves.sv.numberJokeTask = SaveInGame.numberJokeTask;

        byte[] bytes = Encoding.UTF8.GetBytes(JsonUtility.ToJson(GlobalSaves.sv));
        string hex = BitConverter.ToString(bytes);
        PlayerPrefs.SetString("BestS", hex.Replace("-", ""));
    }
}
