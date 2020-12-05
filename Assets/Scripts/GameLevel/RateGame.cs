using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Allows the user to choose whether to rate the game or not.
/// </summary>
public static class RateGame
{
    /// <summary>
    /// The player agreed to rate the game.
    /// </summary>
    public static void PressYes()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        coroutines.InvokeHideDialogue();

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.TableRate;
        GlobalSceneObjects.tableRate.GetComponent<Animator>().SetTrigger("HideTrigger");
        SaveInGame.isPressRateGame = 1;

        if (GlobalVariables.isRussianLanguage == true)
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Спасибо большое за отзыв!";
        }
        else
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Thank you very much for your feedback!";
        }

        SaveData.Save();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.infinityuniversestudio.logicbooster");
    }
    /// <summary>
    /// The player decided to answer this question later.
    /// </summary>
    public static void PressLater()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        coroutines.InvokeHideDialogue();

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.TableRate;
        GlobalSceneObjects.tableRate.GetComponent<Animator>().SetTrigger("HideTrigger");
        SaveInGame.isPressRateGame = 2;

        if (GlobalVariables.isRussianLanguage == true)
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Лааадно! Потом ещё разочек спрошу!";
        }
        else
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Okay! Then I'll ask you one more time!";
        }
        SaveData.Save();
    }
    /// <summary>
    /// The player doesn't want to rate the game.
    /// </summary>
    public static void PressNo()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;
        coroutines.InvokeHideDialogue();

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.TableRate;

        GlobalSceneObjects.tableRate.GetComponent<Animator>().SetTrigger("HideTrigger");
        SaveInGame.isPressRateGame = 3;

        if (GlobalVariables.isRussianLanguage == true)
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Так уж и быть, больше не буду тебя тревожить этим вопросом!";
        }
        else
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Well, I won't bother you with this question anymore!";
        }

        SaveData.Save();
    }
}
