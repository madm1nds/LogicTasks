using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// The player decided to skip the level.
/// </summary>
public static class Skip
{
    /// <summary>
    /// Checking whether the level is already passed and whether there are enough fish to skip the level.
    /// </summary>
    public static void PressSkip()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;

        if (SaveInGame.SavesCountHelp < 3)
        {
            coroutines.InvokeHideDialogue();

            if (GlobalVariables.isRussianLanguage == true)
            {
                GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Как только у тебя будет 3 рыбки, сразу поговорим! Хорошо?";
            }
            else
            {
                GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "As soon as you have 3 fish, we'll talk right away! Good?";
            }
            GlobalSceneObjects.helpButton.transform.Find("CountHelp").Find("PictureHelp").GetComponent<Animator>().Play("PictureHelp");
        }
        else
        {
            if (GlobalSaves.saveInGame[GlobalVariables.activeNameLevel - 7].isRateLevelsCheck[SaveInGame.numberLvlClick] == false
                && GlobalSaves.saveInGame[GlobalVariables.activeNameLevel - 7].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] == false)
                GlobalSceneObjects.tableSkip.gameObject.SetActive(true);
            else coroutines.PassedLevel();
        }
    }
    /// <summary>
    /// The player confirmed that he wants to skip the level.
    /// </summary>
    public static void PressYes()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.TableSkip;

        SaveInGame.SavesCountHelp = SaveInGame.SavesCountHelp - 3;
        GlobalSaves.sv.SavesCountHelp = SaveInGame.SavesCountHelp;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests)
            GlobalSaves.saveInGame[0].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices)
            GlobalSaves.saveInGame[1].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes)
            GlobalSaves.saveInGame[2].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess)
            GlobalSaves.saveInGame[3].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree)
            GlobalSaves.saveInGame[4].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever)
            GlobalSaves.saveInGame[5].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws)
            GlobalSaves.saveInGame[6].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics)
            GlobalSaves.saveInGame[7].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments)
            GlobalSaves.saveInGame[8].isSkipRateLevelsCheck[SaveInGame.numberLvlClick] = true;

        SaveData.Save();
        CountImageHelp.Show();
        GlobalSceneObjects.tableSkip.GetComponent<Animator>().SetTrigger("HideTrigger");

        coroutines.PassedAndShowAchievments1();
        GlobalVariables.isSkipLevel = true;
        Victory.Invoke();
    }
    /// <summary>
    /// The player changed his mind about skipping the level.
    /// </summary>
    public static void PressNo()
    {
        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.TableSkip;
        GlobalSceneObjects.tableSkip.GetComponent<Animator>().SetTrigger("HideTrigger");
    }
}
