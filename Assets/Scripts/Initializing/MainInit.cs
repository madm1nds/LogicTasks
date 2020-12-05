using UnityEngine;
using System;
using System.Collections.Generic;
using TMPro;

/// <summary>
/// Main script. Initializes all game object fields from the inspector and all sprites.
/// Loads game saves.
/// Contains an Update method that handles clicking on the back button in android.
/// <remarks>
/// Initializes: Root game objects, Childs mainCamera, Child background, Childs myCanvas, 
/// Childs gameLevels, Child task, Childs topContent, Child catContent, Child helpBoard, Child achievmentsInCanvas
/// </remarks>
/// </summary>
public class MainInit : MonoBehaviour
{
    Coroutines coroutines;
    void Start()
    {
        coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;

        UnityEngine.SceneManagement.Scene scene = gameObject.scene;
        List<GameObject> rootObjects = new List<GameObject>();
        scene.GetRootGameObjects(rootObjects);
        //Root game objects
        GlobalSceneObjects.mainCamera = SceneСontrol.SetReferenceWithTag(rootObjects, "MainCamera");
        GlobalSceneObjects.background = SceneСontrol.SetReferenceWithTag(rootObjects, "Background");
        GlobalSceneObjects.myCanvas = SceneСontrol.SetReferenceWithTag(rootObjects, "Canvas");
        //Childs mainCamera
        GlobalSounds.gameMusic = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.mainCamera, "GameMusic").GetComponent<AudioSource>();
        GlobalSounds.pressButton = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.mainCamera, "PressButton").GetComponent<AudioSource>();
        GlobalSounds.transfer = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.mainCamera, "Transfer").GetComponent<AudioSource>();
        //Child background
        GlobalSceneObjects.achievmentsButton = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.background, "Achievments");
        //Childs myCanvas
        GlobalSceneObjects.mainMenu = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "MainMenu");
        GlobalSceneObjects.aboutUs = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "AboutUs");
        GlobalSceneObjects.writeToUs = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "WriteToUs");
        GlobalSceneObjects.achievmentsInCanvas = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "AchievmentsInCanvas");
        GlobalSceneObjects.possessedTasks = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "PossessedTasks");
        GlobalSceneObjects.logicTasks = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "LogicTasks");
        GlobalSceneObjects.showNextPage = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "ShowNextPage");
        GlobalSceneObjects.contentBalls = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "ContentBalls");
        GlobalSceneObjects.gameLevels = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.myCanvas, "GameLevels");
        //Childs gameLevels
        GlobalSceneObjects.level_4 = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "Level_4");
        GlobalSceneObjects.currentLevel = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "CurrentLevel");
        GlobalSceneObjects.topContent = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "TopContent");
        GlobalSceneObjects.catContent = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "CatContent");
        GlobalSceneObjects.continueButton = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "Continue");
        GlobalSceneObjects.skipLvl = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "SkipLvl");
        GlobalSceneObjects.helpBoard = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "HelpBoard");
        GlobalSceneObjects.tableSkip = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "TableSkip");
        GlobalSceneObjects.tableRate = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "TableRate");
        //Childs currentLevel
        GlobalSceneObjects.textLevel = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.currentLevel, "TextLevel");
        GlobalSceneObjects.task = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.currentLevel, "Task");
        GlobalSceneObjects.inputField = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.currentLevel, "InputField");
        GlobalSceneObjects.answerButton = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.currentLevel, "AnswerButton");
        GlobalSceneObjects.yourAnswer = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.currentLevel, "YourAnswer");
        //Child task
        GlobalSceneObjects.taskContent = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.currentLevel, "TaskContent");
        //Childs topContent
        GlobalSceneObjects.mainMenuBack = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "MainMenuBack");
        GlobalSceneObjects.selectLvlBack = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "SelectLvlBack");
        GlobalSceneObjects.helpButton = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.gameLevels, "HelpButton");
        //Child catContent
        GlobalSceneObjects.dialogue = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.catContent, "Dialogue");
        //Child helpBoard
        GlobalSceneObjects.helpContent = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.helpBoard, "TaskContent");
        //Child achievmentsInCanvas
        GlobalSceneObjects.achievmentsContent = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.achievmentsInCanvas, "AchievmentsContent");

        GlobalSprites.InitializingGlobalSprites();     

        LoadData.InitLoad();
    }
    /// <summary>
    /// Handles pressing the back button in android.
    /// Go from aboutUs to the MainMenu.
    /// Go from writeToUs to the MainMenu.
    /// Go from achievmentsInCanvas to the MainMenu.
    /// Go from PossessedTasks to the MainMenu.
    /// Go from LogicTasks to the MainMenu.
    /// Go from ContentBalls to the PossessedTasks.
    /// Go from ContentBalls to the LogicTasks.
    /// Go from GameLevel to the ContentBalls.
    /// </summary>
    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.Escape))//МЫ НАЖАЛИ НА КНОПКУ НАЗАД
        {
            if (GlobalSceneObjects.aboutUs.activeInHierarchy == true)//если у нас открыто Об Игре
            {
                AboutUs.Exit();
                GlobalSounds.transfer.PlayDelayed(0.15f);
            }
            if (GlobalSceneObjects.writeToUs.activeInHierarchy == true)//если у нас открыто Об Игре
            {
                WriteToUs.Exit();
                GlobalSounds.transfer.PlayDelayed(0.15f);
            }
            if (GlobalSceneObjects.achievmentsInCanvas.activeInHierarchy == true)//если у нас открыто Об Игре
            {
                Achievments.Exit();
                GlobalSounds.transfer.PlayDelayed(0.15f);
            }
            if ((GlobalSceneObjects.logicTasks.activeInHierarchy == true || GlobalSceneObjects.possessedTasks.activeInHierarchy == true))
            {
                GlobalSounds.transfer.PlayDelayed(0.15f);
                coroutines.InvokeHideTextLevelHouse(GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text);

                if (GlobalVariables.isPossessedHouse)
                {
                    GlobalSceneObjects.showNextPage.GetComponent<Animator>().SetTrigger("HideLogicTrigger");
                    GlobalSceneObjects.logicTasks.GetComponent<Animator>().SetTrigger("HideTrigger");
                }
                else
                {
                    GlobalSceneObjects.showNextPage.GetComponent<Animator>().SetTrigger("HidePossessedTrigger");
                    GlobalSceneObjects.possessedTasks.GetComponent<Animator>().SetTrigger("HideTrigger");
                }
                GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.MainMenu;
            }
            for (int numberBall = 0; numberBall < GlobalSceneObjects.contentBalls.transform.childCount; numberBall++)
            {
                if (GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).gameObject.activeInHierarchy == true)//если мы в каком либо шаре , то есть выбираем номер уровня, то скрываем эти уровни и переходим к шарикам
                {
                    HideContentBalls.Invoke();
                    GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.PlayButton;
                    GlobalSounds.pressButton.Play();//звук нажатия
                    GlobalSounds.transfer.PlayDelayed(0.15f);//звук скрытия
                }
            }

            if (GlobalSceneObjects.gameLevels.activeInHierarchy == true)//если у нас открыт уровень, который мы проходим и мы нажали назад,то
            {
                HideLevelContent.Invoke();
                HideLevelButtons.Invoke();
                GlobalVariables.stateForAnimation = GlobalVariables.activeNameLevel;
                GlobalSounds.transfer.PlayDelayed(0.15f);
            }
        }
    }
}
