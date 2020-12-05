using UnityEngine;
/// <summary>
/// Action when clicking on button ShowNextPage
/// </summary>
public static class NextPage
{
    /// <summary>
    /// Select another cat house.
    /// </summary>
    public static void Invoke()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        if (GlobalVariables.stateForAnimation == 0)
        {
            if (GlobalVariables.isRussianLanguage)
            {
                if (GlobalVariables.isPossessedHouse)
                {
                    coroutines.InvokeChangeTextLevelHouse("Одержимые", "Логические ");
                }
                else
                {
                    coroutines.InvokeChangeTextLevelHouse("Логические", "Одержимые ");
                }
            }
            else
            {
                if (GlobalVariables.isPossessedHouse)
                {
                    coroutines.InvokeChangeTextLevelHouse("Possessed", "Logic ");
                }
                else
                {
                    coroutines.InvokeChangeTextLevelHouse("Logic", "Possessed ");
                }
            }

            GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.Block;
            if (GlobalVariables.isPossessedHouse)
            {
                GlobalSceneObjects.logicTasks.GetComponent<Animator>().SetTrigger("NextPageTrigger");
                GlobalSceneObjects.possessedTasks.GetComponent<Animator>().SetTrigger("ReturnPossessed");

                GlobalSceneObjects.showNextPage.GetComponent<Animator>().SetTrigger("GoToPossessedTrigger");
            }
            else
            {
                GlobalSceneObjects.possessedTasks.GetComponent<Animator>().SetTrigger("NextPageTrigger");
                GlobalSceneObjects.logicTasks.GetComponent<Animator>().SetTrigger("ReturnLogic");

                GlobalSceneObjects.showNextPage.GetComponent<Animator>().SetTrigger("GoToLogicTrigger");
            }
            GlobalVariables.isPossessedHouse = !GlobalVariables.isPossessedHouse;
            SaveData.Save();
        }
    }
}
