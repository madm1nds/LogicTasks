using UnityEngine;
/// <summary>
/// A global class that contains all fields and enumerations that can be used at any time in the game.
/// </summary>
public static class GlobalVariables
{
    public static bool isFirstLaunchGame = true;
    public static bool isRussianLanguage = true;

    public static bool isPossessedHouse = true;
    public static bool isOnSound = true;
    public static bool isActiveDialogueCat = false;
    public static bool isSkipLevel = false;

    public static int stateForAnimation = 0;
    public static int activeNameLevel = 0;
    public enum NameAnimation
    {

        Achiev = 1,
        MainMenu = 2,
        PlayButton = 3,
        AboutUs = 4,
        WriteToUs = 5,
        Block = 6,
        LightTests = 7,
        BestPractices = 8,
        ScientistsNotes = 9,
        ExperimentalProcess = 10,
        AcademicDegree = 11,
        SimpleLever = 12,
        ElementaryLaws = 13,
        Mechanics = 14,
        LatestDevelopments = 15,
        GameLevel = 16,
        HelpBoard= 17,
        TableSkip = 18,
        TableRate = 19,
        AnswerCorrect = 20,
        ButtonContinue = 21,
        NewLevel = 22,
        Task = 23
    };
    public enum CountTask
    {
        LightTests = 23,
        BestPractices = 23,
        ScientistsNotes = 23,
        ExperimentalProcess = 23,
        AcademicDegree = 24,
        SimpleLever = 20,
        ElementaryLaws = 20,
        Mechanics = 20,
        LatestDevelopments = 19
    }
}
