using TMPro;
using UnityEngine;

/// <summary>
/// Depending on the state of the animation, game objects are turned on and off.
/// </summary>
public static class SetVisible
{
    public static void SetVisibleObject()
    {
        switch (GlobalVariables.stateForAnimation)
        {
            case (int)GlobalVariables.NameAnimation.Achiev:
                GlobalSceneObjects.achievmentsInCanvas.gameObject.SetActive(true);
                GlobalSceneObjects.mainMenu.gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsButton.gameObject.SetActive(false);
                break;

            case (int)GlobalVariables.NameAnimation.MainMenu:

                GlobalSceneObjects.mainMenu.gameObject.SetActive(true);
                GlobalSceneObjects.achievmentsButton.gameObject.SetActive(true);
                GlobalSceneObjects.aboutUs.gameObject.SetActive(false);
                GlobalSceneObjects.writeToUs.gameObject.SetActive(false);             
                GlobalSceneObjects.logicTasks.gameObject.SetActive(false);
                GlobalSceneObjects.possessedTasks.gameObject.SetActive(false);
                GlobalSceneObjects.showNextPage.gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsInCanvas.gameObject.SetActive(false);

                GlobalSceneObjects.gameLevels.gameObject.SetActive(false);
                GlobalSceneObjects.level_4.gameObject.SetActive(false);
                GlobalSceneObjects.currentLevel.gameObject.SetActive(false);
                GlobalSceneObjects.continueButton.gameObject.SetActive(false);
                GlobalSceneObjects.helpBoard.gameObject.SetActive(false);
                GlobalSceneObjects.tableSkip.gameObject.SetActive(false);
                GlobalSceneObjects.tableRate.gameObject.SetActive(false);

                ReturnText();
                break;

            case (int)GlobalVariables.NameAnimation.PlayButton:
                CheckPassedLevel.Check();
                GlobalSceneObjects.showNextPage.gameObject.SetActive(true);
                GlobalSceneObjects.logicTasks.gameObject.SetActive(true);
                GlobalSceneObjects.possessedTasks.gameObject.SetActive(true);
                if (GlobalVariables.isPossessedHouse == false)
                {
                    GlobalSceneObjects.possessedTasks.GetComponent<Animator>().SetTrigger("ShowTrigger");
                    GlobalSceneObjects.showNextPage.GetComponent<Animator>().SetTrigger("ShowPossessedTrigger");
                }
                if (GlobalVariables.isPossessedHouse == true)
                {
                    GlobalSceneObjects.logicTasks.GetComponent<Animator>().SetTrigger("ShowTrigger");
                    GlobalSceneObjects.showNextPage.GetComponent<Animator>().SetTrigger("ShowLogicTrigger");
                }
                GlobalSceneObjects.mainMenu.gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsButton.gameObject.SetActive(false);
                for (int numberBall = 0; numberBall < GlobalSceneObjects.contentBalls.transform.childCount; numberBall++)
                {
                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).gameObject.SetActive(false);
                }
                OpenPassedLevels.Open();
                break;

            case (int)GlobalVariables.NameAnimation.AboutUs:
                GlobalSceneObjects.aboutUs.gameObject.SetActive(true);
                GlobalSceneObjects.mainMenu.gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsButton.gameObject.SetActive(false);
                break;

            case (int)GlobalVariables.NameAnimation.WriteToUs:
                GlobalSceneObjects.writeToUs.gameObject.SetActive(true);
                GlobalSceneObjects.mainMenu.gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsButton.gameObject.SetActive(false);
                break;

            case (int)GlobalVariables.NameAnimation.LightTests:
                DisableHousesAndGoToChooseLvl("LightTests");
                break;

            case (int)GlobalVariables.NameAnimation.BestPractices:
                DisableHousesAndGoToChooseLvl("BestPractices");
                break;

            case (int)GlobalVariables.NameAnimation.ScientistsNotes:
                DisableHousesAndGoToChooseLvl("ScientistsNotes");
                break;

            case (int)GlobalVariables.NameAnimation.ExperimentalProcess:
                DisableHousesAndGoToChooseLvl("ExperimentalProcess");
                break;

            case (int)GlobalVariables.NameAnimation.AcademicDegree:
                DisableHousesAndGoToChooseLvl("AcademicDegree");
                break;

            case (int)GlobalVariables.NameAnimation.SimpleLever:
                DisableHousesAndGoToChooseLvl("SimpleLever");
                break;

            case (int)GlobalVariables.NameAnimation.ElementaryLaws:
                DisableHousesAndGoToChooseLvl("ElementaryLaws");
                break;

            case (int)GlobalVariables.NameAnimation.Mechanics:
                DisableHousesAndGoToChooseLvl("Mechanics");
                break;

            case (int)GlobalVariables.NameAnimation.LatestDevelopments:
                DisableHousesAndGoToChooseLvl("LatestDevelopments");
                break;

            case (int)GlobalVariables.NameAnimation.GameLevel:
                for (int numberBall = 0; numberBall < GlobalSceneObjects.contentBalls.transform.childCount; numberBall++)
                {
                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).gameObject.SetActive(false);
                }
                GlobalSceneObjects.gameLevels.gameObject.SetActive(true);
                break;

            case (int)GlobalVariables.NameAnimation.HelpBoard:
                GlobalSceneObjects.helpBoard.gameObject.SetActive(false);
                break;

            case (int)GlobalVariables.NameAnimation.TableSkip:
                GlobalSceneObjects.tableSkip.gameObject.SetActive(false);
                break;

            case (int)GlobalVariables.NameAnimation.TableRate:
                GlobalSceneObjects.tableRate.gameObject.SetActive(false);
                break;

            case (int)GlobalVariables.NameAnimation.ButtonContinue:
                GlobalSceneObjects.continueButton.gameObject.SetActive(true);
                break;

            case (int)GlobalVariables.NameAnimation.NewLevel:
                GlobalSceneObjects.currentLevel.gameObject.SetActive(false);
                GlobalSceneObjects.level_4.gameObject.SetActive(false);
                SaveInGame.numberLvlClick++;
                LoadLevel.Load(SaveInGame.numberLvlClick);
                break;

            case (int)GlobalVariables.NameAnimation.Task:
                if (GlobalSceneObjects.currentLevel.activeInHierarchy == true)
                {
                    GlobalSceneObjects.task.gameObject.SetActive(false);
                    GlobalSceneObjects.task.gameObject.SetActive(true);
                }
                else
                {
                    GameObject task = GlobalSceneObjects.level_4.transform.Find("Task").gameObject;
                    GameObject centContent = GlobalSceneObjects.level_4.transform.Find("Content").gameObject;
                    task.gameObject.SetActive(false);
                    task.gameObject.SetActive(true);
                    centContent.gameObject.SetActive(false);
                    centContent.gameObject.SetActive(true);
                }
                LoadLevel.Load(SaveInGame.numberLvlClick);
                break;
        }
        GlobalVariables.stateForAnimation = 0;
    }
    static void DisableHousesAndGoToChooseLvl(string nameLevel)
    {
        GlobalSceneObjects.gameLevels.gameObject.SetActive(false);
        GlobalSceneObjects.level_4.gameObject.SetActive(false);    
        GlobalSceneObjects.currentLevel.gameObject.SetActive(false);
        GlobalSceneObjects.continueButton.gameObject.SetActive(false);
        GlobalSceneObjects.helpBoard.gameObject.SetActive(false);
        GlobalSceneObjects.tableSkip.gameObject.SetActive(false);
        GlobalSceneObjects.tableRate.gameObject.SetActive(false);

        GlobalSceneObjects.logicTasks.gameObject.SetActive(false);
        GlobalSceneObjects.possessedTasks.gameObject.SetActive(false);
        GlobalSceneObjects.showNextPage.gameObject.SetActive(false);
        GlobalSceneObjects.contentBalls.transform.Find(nameLevel).gameObject.SetActive(true);
        GlobalVariables.activeNameLevel = GlobalVariables.stateForAnimation;
        ReturnText();
    }
    static void ReturnText()
    {
        //return text for button
        if (GlobalVariables.isRussianLanguage)
        {
            if (GlobalVariables.isPossessedHouse)
            {
                GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Одержимые";
            }
            else
            {
                GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Логические";
            }
        }
        else
        {
            if (GlobalVariables.isPossessedHouse)
            {
                GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Possessed";
            }
            else
            {
                GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Logic";
            }
        }
    }
}
