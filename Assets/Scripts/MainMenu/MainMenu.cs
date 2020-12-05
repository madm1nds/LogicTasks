using UnityEngine;
/// <summary>
/// Actions with game objects in the main menu.
/// </summary>
public static class MainMenu
{
    /// <summary>
    /// Start animation of hiding the entire interface in the main menu.
    /// </summary>
    public static void Hide()
    {
        GlobalSceneObjects.mainMenu.transform.Find("ImageLogic").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Content").transform.Find("ButtonPlay").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Content").transform.Find("ButtonAboutUs").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Content").transform.Find("ButtonWriteToUs").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Content").transform.Find("ButtonExit").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Sounds").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Language").transform.Find("ButtonLanguageRus").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.mainMenu.transform.Find("Language").transform.Find("ButtonLanguageEng").GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.achievmentsButton.GetComponent<Animator>().SetTrigger("HideTrigger");
    }
}
