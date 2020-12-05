using System;
using UnityEngine;
/// <summary>
/// A global class that contains all the main game objects in the scene hierarchy.
/// </summary>
[Serializable]
public static class GlobalSceneObjects
{
    //Root game objects
    public static GameObject mainCamera;
    public static GameObject background;
    public static GameObject myCanvas;
    //Child background
    public static GameObject achievmentsButton;
    //Childs myCanvas
    public static GameObject mainMenu;
    public static GameObject aboutUs;
    public static GameObject writeToUs;
    public static GameObject achievmentsInCanvas;
    public static GameObject possessedTasks;
    public static GameObject logicTasks;
    public static GameObject showNextPage;
    public static GameObject contentBalls;
    public static GameObject gameLevels;
    //Childs gameLevels
    public static GameObject level_4;
    public static GameObject currentLevel;
    public static GameObject topContent;
    public static GameObject catContent;
    public static GameObject continueButton;
    public static GameObject skipLvl;
    public static GameObject helpBoard;
    public static GameObject tableSkip;
    public static GameObject tableRate;
    //Childs currentLevel
    public static GameObject textLevel;
    public static GameObject task;
    public static GameObject inputField;
    public static GameObject answerButton;
    public static GameObject yourAnswer;
    //Child task
    public static GameObject taskContent;
    //Childs topContent
    public static GameObject mainMenuBack;
    public static GameObject selectLvlBack;
    public static GameObject helpButton;
    //Child catContent
    public static GameObject dialogue;
    //Child helpBoard
    public static GameObject helpContent;
    //Child achievmentsInCanvas
    public static GameObject achievmentsContent;
}
