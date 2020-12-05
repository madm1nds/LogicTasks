using System;
using System.Text;
using TMPro;
using UnityEngine;
/// <summary>
/// Loading all save files from the file into the game.
/// </summary>
public static class LoadData
{

    public static void InitLoad()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;

        for (int i = 0; i < GlobalSaves.saveInGame.Length; i++)
        {
            GlobalSaves.saveInGame[i] = new SaveInGame();
        }
        TextAchievments.ChangeLanguage();

        string loadedData = null;


        if (!PlayerPrefs.HasKey("BestS"))
        {
            PlayerPrefs.SetString("BestS", "");
        }
        else
        {
            loadedData = PlayerPrefs.GetString("BestS");
            int charsCount = loadedData.Length;
            byte[] bytes = new byte[charsCount / 2];//
            for (int i = 0; i < charsCount; i += 2) bytes[i / 2] = Convert.ToByte(loadedData.Substring(i, 2), 16);
            loadedData = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

            GlobalSaves.sv = JsonUtility.FromJson<SaveInJson>(loadedData);  
            GlobalSaves.saveInGame = JsonHelper.FromJson<SaveInGame>(GlobalSaves.sv.saveInGame);
            GlobalVariables.isOnSound = GlobalSaves.sv.isOnSound;
            if (GlobalVariables.isOnSound == false)
            {
                GlobalVariables.isOnSound = true;
                Sounds.Invoke();
            }

            SaveInGame.SavesCountHelp = GlobalSaves.sv.SavesCountHelp;

            GlobalVariables.isPossessedHouse = GlobalSaves.sv.isPossessedHouse;            
        }

        for (int numberAchievments = 0; numberAchievments < 38; numberAchievments++)
        {
            SaveInGame.isCompleteAchievment[numberAchievments] = GlobalSaves.sv.completeAchievment[numberAchievments];
            SaveInGame.isPressCompleteAchievment[numberAchievments] = GlobalSaves.sv.isPressCompleteAchievment[numberAchievments];
           
            if (SaveInGame.isCompleteAchievment[numberAchievments] == true)
            {
                GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).Find("Fish").Find("CountHelpImage").gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).Find("Fish").Find("CheckMark").gameObject.SetActive(true);
            }
        }


        if (GlobalVariables.isRussianLanguage == true && GlobalVariables.isPossessedHouse == true)
        {
            GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Одержимые";
        }
        if (GlobalVariables.isRussianLanguage == false && GlobalVariables.isPossessedHouse == true)
        {
            GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Possessed";
        }
        if (GlobalVariables.isRussianLanguage == true && GlobalVariables.isPossessedHouse == false)
        {
            GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Логические";
        }

        if (GlobalVariables.isRussianLanguage == false && GlobalVariables.isPossessedHouse == false)
        {
            GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Logic";
        }

        CountImageHelp.Show();                   

        int currentLevel = 0;
        for (int nameLevels = 0; nameLevels < GlobalSceneObjects.contentBalls.transform.childCount; nameLevels++)
        {
            for (int row = 1; row < GlobalSceneObjects.contentBalls.transform.GetChild(nameLevels).GetChild(0).childCount - 1; row++)
            {
                for (int column = 0; column < GlobalSceneObjects.contentBalls.transform.GetChild(nameLevels).GetChild(0).GetChild(row).childCount - 1; column++)
                {
                    currentLevel++;

                    Reaction.SetReactionLevels(nameLevels, row, column, currentLevel);          
                }
            }
            currentLevel = 0;
        }
        for (int numberAchievments = 0; numberAchievments < GlobalSceneObjects.achievmentsContent.transform.childCount; numberAchievments++)
        {
            Reaction.SetReactionAchievments(numberAchievments);
        }

        Reaction.SetReactionButtons();   

        if (GlobalSaves.sv.firstLaunch == "false")
        {
            GlobalVariables.isFirstLaunchGame = false;
        }
        if (GlobalVariables.isFirstLaunchGame == true)
        {
            GlobalSaves.sv.SavesCountHelp = SaveInGame.SavesCountHelp;
            CountImageHelp.Show();
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                GlobalVariables.isRussianLanguage = true;

            }
            else
            {
                Language.SetEnglish(true);
            }
            GlobalSaves.sv.firstLaunch = "false";
            GlobalVariables.isFirstLaunchGame = false;
            GlobalSaves.sv.Language = GlobalVariables.isRussianLanguage;
            SaveData.Save();   
        }

        else
        {
            if (GlobalSaves.sv.Language == false)
            {
                Language.SetEnglish(true);
            }
        }
        SaveInGame.isPressRateGame = GlobalSaves.sv.isPressRate;
        SaveInGame.numberJokeTask = GlobalSaves.sv.numberJokeTask;

        coroutines.InvokeStartGameAndLoadAchievments();
    }
}
