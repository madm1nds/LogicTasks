using UnityEngine;
/// <summary>
/// Displays the current number of available fish.
/// </summary>
public static class CountImageHelp
{
    public static void Show()
    {
        // Turn off all digits.
        for (int i = 1; i < 202; i++)
        {
            GlobalSceneObjects.gameLevels.transform.GetChild(2).GetChild(2).transform.GetChild(1).transform.GetChild(i).gameObject.SetActive(false);
        }
        // Turn on the required numbers.
        for (int i = 1; i < 202; i++)
        {
            if (SaveInGame.SavesCountHelp == i - 1) GlobalSceneObjects.gameLevels.transform.GetChild(2).GetChild(2).transform.GetChild(1).transform.GetChild(i).gameObject.SetActive(true);
        }
        if (SaveInGame.SavesCountHelp >= 199)
        {
            SaveInGame.SavesCountHelp = 8000;
            GlobalSaves.sv.SavesCountHelp = SaveInGame.SavesCountHelp;
            SaveData.Save();
            GlobalSceneObjects.gameLevels.transform.GetChild(2).GetChild(2).transform.GetChild(1).transform.GetChild(201).gameObject.SetActive(true);
        }
    }
}
