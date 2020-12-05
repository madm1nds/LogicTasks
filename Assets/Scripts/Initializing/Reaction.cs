using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Subscribing listeners to events that will be called when buttons are clicked.
/// </summary>
public static class Reaction
{
    /// <summary>
    /// Subscribing listeners to each level transition button.
    /// </summary>
    /// <param name="numberBall"></param>
    /// <param name="row"></param>
    /// <param name="column"></param>
    /// <param name="currentLevel"></param>
    public static void SetReactionLevels(int numberBall, int row, int column, int currentLevel)
    {
        GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Level").GetComponent<Button>().onClick.AddListener(delegate { LaunchLevel.Invoke(currentLevel); });
    }
    /// <summary>
    /// Subscribing listeners to each achievement button.
    /// </summary>
    /// <param name="numberAchievments"></param>
    public static void SetReactionAchievments(int numberAchievments)
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).GetComponent<Button>().onClick.AddListener(delegate { coroutines.InvokeChangeTextAndGetAchievment(numberAchievments); });
    }
    /// <summary>
    /// Subscribing listeners to all other buttons.
    /// </summary>
    public static void SetReactionButtons()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;

        GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonPlay").GetComponent<Button>().onClick.AddListener(delegate { StartGame.Invoke(); });
        GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonAboutUs").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.Invoke(); });
        GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonWriteToUs").GetComponent<Button>().onClick.AddListener(delegate { WriteToUs.Invoke(); });
        GlobalSceneObjects.mainMenu.transform.Find("AchievmentButton").GetComponent<Button>().onClick.AddListener(delegate { Achievments.Invoke(); });
        GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Cross").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.Exit(); });
        GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("InstMadm1nd").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.TransferURL(1); });
        GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("InstPilgrim").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.TransferURL(2); });
        GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("CreditsButton").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.TransferURL(3); });
        GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("InstRaben_krausz").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.TransferURL(4); });
        GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("VKOleg").GetComponent<Button>().onClick.AddListener(delegate { AboutUs.TransferURL(5); });
        GlobalSceneObjects.writeToUs.transform.Find("Frame").Find("Cross").GetComponent<Button>().onClick.AddListener(delegate { WriteToUs.Exit(); });
        GlobalSceneObjects.achievmentsInCanvas.transform.Find("Frame").Find("Cross").GetComponent<Button>().onClick.AddListener(delegate { Achievments.Exit(); });
        GlobalSceneObjects.mainMenu.transform.Find("Sounds").GetComponent<Button>().onClick.AddListener(delegate { Sounds.Invoke(); SaveData.Save(); });
        GlobalSceneObjects.mainMenu.transform.Find("Language").Find("ButtonLanguageRus").GetComponent<Button>().onClick.AddListener(delegate { Language.SetRussian(); });
        GlobalSceneObjects.mainMenu.transform.Find("Language").Find("ButtonLanguageEng").GetComponent<Button>().onClick.AddListener(delegate { Language.SetEnglish(false); });

        GlobalSceneObjects.showNextPage.GetComponent<Button>().onClick.AddListener(delegate { NextPage.Invoke(); });
                                                                                                                   
        GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("LatestDevelopments"); });
        GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("Mechanics"); });
        GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("ElementaryLaws"); });
        GlobalSceneObjects.possessedTasks.transform.Find("BallSimpleLever").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("SimpleLever"); });

        GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("AcademicDegree"); });
        GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("ExperimentalProcess"); });
        GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("ScientistsNotes"); });
        GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("BestPractices"); });
        GlobalSceneObjects.logicTasks.transform.Find("BallLightTests").GetComponent<Button>().onClick.AddListener(delegate { SelectBall.Invoke("LightTests"); });

        GlobalSceneObjects.mainMenuBack.GetComponent<Button>().onClick.AddListener(delegate { GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.MainMenu; HideLevelContent.Invoke(); HideLevelButtons.Invoke(); }); 
        GlobalSceneObjects.selectLvlBack.GetComponent<Button>().onClick.AddListener(delegate { GlobalVariables.stateForAnimation = GlobalVariables.activeNameLevel; HideLevelContent.Invoke(); HideLevelButtons.Invoke(); }); 


        GlobalSceneObjects.continueButton.GetComponent<Button>().onClick.AddListener(delegate { ContinueButton.Press(); });
                                                                                                                          
        GlobalSceneObjects.helpButton.transform.Find("CountHelp").Find("PictureHelp").GetComponent<Button>().onClick.AddListener(delegate { coroutines.InvokePressHelp(); });

        GlobalSceneObjects.helpButton.transform.Find("HelpButton").GetComponent<Button>().onClick.AddListener(delegate { HelpButton.Press(); });

        GlobalSceneObjects.skipLvl.GetComponent<Button>().onClick.AddListener(delegate { Skip.PressSkip(); });

        GlobalSceneObjects.helpBoard.transform.Find("Cross").GetComponent<Button>().onClick.AddListener(delegate
        {
            GlobalSceneObjects.helpBoard.GetComponent<Animator>().SetTrigger("HideTrigger"); GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.HelpBoard;
        });

        GlobalSceneObjects.tableSkip.transform.Find("Yes").GetComponent<Button>().onClick.AddListener(delegate { Skip.PressYes(); });
        GlobalSceneObjects.tableSkip.transform.Find("No").GetComponent<Button>().onClick.AddListener(delegate { Skip.PressNo(); });

        GlobalSceneObjects.tableRate.transform.Find("Yes").GetComponent<Button>().onClick.AddListener(delegate { RateGame.PressYes(); });
        GlobalSceneObjects.tableRate.transform.Find("Later").GetComponent<Button>().onClick.AddListener(delegate { RateGame.PressLater(); });
        GlobalSceneObjects.tableRate.transform.Find("No").GetComponent<Button>().onClick.AddListener(delegate { RateGame.PressNo(); });
    }
}
