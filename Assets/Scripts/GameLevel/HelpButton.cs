using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Action when clicking on a hint.
/// </summary>
public static class HelpButton 
{
    public static void Press()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        // if we have at least 1 hint or more
        if ((SaveInGame.SavesCountHelp >= 1 && (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever)) ||
            (SaveInGame.SavesCountHelp >= 2 && (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws)) ||
            (SaveInGame.SavesCountHelp >= 3 && (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes)) ||
            (SaveInGame.SavesCountHelp >= 4 && (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics)) ||
            (SaveInGame.SavesCountHelp >= 5 && (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments)))
        {

            if (SaveInGame.numberLvlClick == 4 && GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests && GlobalSaves.saveInGame[0].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] != true) SaveInGame.SavesCountHelp++;//если у нас 4-ый лвл, то мы не уменшаем кол-во подсказок, так как для 4-го лвла нет подсказки

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests && GlobalSaves.saveInGame[0].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp--;
                GlobalSaves.saveInGame[0].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever && GlobalSaves.saveInGame[5].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp--;
                GlobalSaves.saveInGame[5].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices && GlobalSaves.saveInGame[1].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 2;
                GlobalSaves.saveInGame[1].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws && GlobalSaves.saveInGame[6].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 2;
                GlobalSaves.saveInGame[6].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes && GlobalSaves.saveInGame[2].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 3;
                GlobalSaves.saveInGame[2].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess && GlobalSaves.saveInGame[3].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 4;
                GlobalSaves.saveInGame[3].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics && GlobalSaves.saveInGame[7].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 4;
                GlobalSaves.saveInGame[7].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree && GlobalSaves.saveInGame[4].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 5;
                GlobalSaves.saveInGame[4].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments && GlobalSaves.saveInGame[8].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] == false)
            {
                SaveInGame.SavesCountHelp -= 5;
                GlobalSaves.saveInGame[8].isOpenHelpLevelsCheck[SaveInGame.numberLvlClick] = true;
            }
            coroutines.PassedHelpAndShowAchievments();
            CountImageHelp.Show();

            SaveData.Save();

            GlobalSceneObjects.helpBoard.SetActive(true);            
        }
        else
        {
            if (GlobalVariables.isRussianLanguage == true)
            {
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Послушай. Для этой задачки мне нужна всего лишь 1 рыбка!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Дашь мне 2 рыбки и я тебе помогу!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Что-то не вижу 3 рыбок!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Я много же не прошу! Всего лишь 4 рыбки!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Чтобы лучше думалось, мне нужно не меньше 5 рыбок!";
            }
            else
            {
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "For this task I only need 1 fish!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Give me 2 fish and I will help you!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "I don't see three fish!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "I don’t ask too much! Only 4 fish!";
                if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments)
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "To think better, I need at least 5 fish!";
            }

            GlobalSceneObjects.helpButton.transform.Find("CountHelp").Find("PictureHelp").GetComponent<Animator>().Play("PictureHelp");
        }
    }
}
