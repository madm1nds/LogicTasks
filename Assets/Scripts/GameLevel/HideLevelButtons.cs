using UnityEngine;
/// <summary>
/// Start animation to hide the level.
/// <remarks>
/// Hides all game objects in Level_4 and in the CurrentLevel.
/// </remarks>
/// </summary>
public static class HideLevelButtons
{
    public static void Invoke()
    {
        GameObject textNumberLevel = GlobalSceneObjects.level_4.transform.Find("Level").gameObject;
        GameObject task = GlobalSceneObjects.level_4.transform.Find("Task").gameObject;
        GameObject centContent = GlobalSceneObjects.level_4.transform.Find("Content").gameObject;

        textNumberLevel.GetComponent<Animator>().SetTrigger("HideTrigger");
        task.GetComponent<Animator>().SetTrigger("HideTrigger");
        for (int numberCent = 0; numberCent < 5; numberCent++)
        {
            centContent.transform.GetChild(numberCent).GetComponent<Animator>().SetTrigger("HideTrigger");
        }

        GlobalSceneObjects.textLevel.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.task.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.inputField.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.answerButton.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.yourAnswer.GetComponent<Animator>().SetTrigger("HideTrigger");

        GlobalSceneObjects.helpBoard.GetComponent<Animator>().SetTrigger("HideTrigger"); 
        GlobalSceneObjects.tableSkip.GetComponent<Animator>().SetTrigger("HideTrigger");    
        GlobalSceneObjects.tableRate.GetComponent<Animator>().SetTrigger("HideTrigger");
    }
}
