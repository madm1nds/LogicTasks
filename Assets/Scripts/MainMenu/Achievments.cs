using UnityEngine;
/// <summary>
/// Actions with the game object Achievments.
/// </summary>
public static class Achievments
{
    /// <summary>
    /// Go to the menu Achievments.
    /// </summary>
    public static void Invoke()
    {
        SaveInGame.isCompleteAchievment[0] = true;
        MainMenu.Hide();

        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.Achiev;
    }
    /// <summary>
    /// Exit the menu Achievments.
    /// </summary>
    public static void Exit()
    {
        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);
        GlobalSceneObjects.achievmentsInCanvas.transform.Find("Frame").GetComponent<Animator>().SetTrigger("HideTrigger");

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.MainMenu;
    }
}
