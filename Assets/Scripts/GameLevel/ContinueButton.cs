using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Handle clicking on the continue button in the level.
/// </summary>
public static class ContinueButton
{
    /// <summary>
    /// If the last open level was passed, then go to the contentBalls.
    /// Otherwise, turn on the next level.
    /// </summary>
    public static void Press()
    {
        int currentLevel = 0;

        GlobalSceneObjects.continueButton.GetComponent<Animator>().SetTrigger("HideTrigger");  
        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);
        int countTask = 0;
        switch (GlobalVariables.activeNameLevel)
        {
            case (int)GlobalVariables.NameAnimation.LightTests: countTask = (int)GlobalVariables.CountTask.LightTests; break;
            case (int)GlobalVariables.NameAnimation.BestPractices: countTask = (int)GlobalVariables.CountTask.BestPractices; break;
            case (int)GlobalVariables.NameAnimation.ScientistsNotes: countTask = (int)GlobalVariables.CountTask.ScientistsNotes; break;
            case (int)GlobalVariables.NameAnimation.ExperimentalProcess: countTask = (int)GlobalVariables.CountTask.ExperimentalProcess; break;
            case (int)GlobalVariables.NameAnimation.AcademicDegree: countTask = (int)GlobalVariables.CountTask.AcademicDegree; break;
            case (int)GlobalVariables.NameAnimation.SimpleLever: countTask = (int)GlobalVariables.CountTask.SimpleLever; break;
            case (int)GlobalVariables.NameAnimation.ElementaryLaws: countTask = (int)GlobalVariables.CountTask.ElementaryLaws; break;
            case (int)GlobalVariables.NameAnimation.Mechanics: countTask = (int)GlobalVariables.CountTask.Mechanics; break;
            case (int)GlobalVariables.NameAnimation.LatestDevelopments: countTask = (int)GlobalVariables.CountTask.LatestDevelopments; break;
        }
        currentLevel = 0;
        for (int row = 0; row < GlobalSceneObjects.contentBalls.transform.GetChild(GlobalVariables.activeNameLevel - 7).Find("Content").childCount; row++)
        {
            if (GlobalSceneObjects.contentBalls.transform.GetChild(GlobalVariables.activeNameLevel - 7).Find("Content").GetChild(row).name.Contains("Level"))
            {
                for (int column = 0; column < GlobalSceneObjects.contentBalls.transform.GetChild(GlobalVariables.activeNameLevel - 7).Find("Content").GetChild(row).childCount; column++)
                {
                    if (GlobalSceneObjects.contentBalls.transform.GetChild(GlobalVariables.activeNameLevel - 7).Find("Content").GetChild(row).GetChild(column).name.Contains("Level"))
                    {
                        currentLevel++;

                        if (currentLevel == SaveInGame.numberLvlClick + 1 || SaveInGame.numberLvlClick == countTask)
                        {                            
                            if (GlobalSceneObjects.contentBalls.transform.GetChild(GlobalVariables.activeNameLevel - 7).Find("Content").GetChild(row).GetChild(column).Find("Level").GetComponent<Button>().interactable == false
                            || SaveInGame.numberLvlClick == countTask)
                            {
                                HideLevelContent.Invoke();
                                GlobalVariables.stateForAnimation = GlobalVariables.activeNameLevel;
                                GlobalSounds.transfer.PlayDelayed(0.15f);
                            }
                            else
                            {
                                GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.NewLevel;
                            }
                        }
                    }
                }
            }
        }
    }
}
