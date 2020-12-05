using UnityEngine;
/// <summary>
/// Go to the selected ball.
/// </summary>
public static class SelectBall
{
    public static void Invoke(string NameLevel)
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;

        GlobalSounds.transfer.PlayDelayed(0.15f);
        coroutines.InvokeHideTextLevelHouse(GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text);

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
        switch (NameLevel)
        {
            case "LightTests": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.LightTests; break;
            case "BestPractices": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.BestPractices; break;
            case "ScientistsNotes": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.ScientistsNotes; break;
            case "ExperimentalProcess": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.ExperimentalProcess; break;
            case "AcademicDegree": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.AcademicDegree; break;
            case "SimpleLever": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.SimpleLever; break;
            case "ElementaryLaws": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.ElementaryLaws; break;
            case "Mechanics": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.Mechanics; break;
            case "LatestDevelopments": GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.LatestDevelopments; break;
        }
    }
}
