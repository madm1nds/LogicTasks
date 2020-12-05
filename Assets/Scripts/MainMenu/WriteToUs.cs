using UnityEngine;
/// <summary>
/// Actions with the game object WriteToUs.
/// </summary>
public static class WriteToUs
{
    /// <summary>
    /// Go to the menu WriteToUs.
    /// </summary>
    public static void Invoke()
    {
        MainMenu.Hide();

        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.WriteToUs;
    }
    /// <summary>
    /// Exit the menu WriteToUs.
    /// </summary>
    public static void Exit()
    {
        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);
        GlobalSceneObjects.writeToUs.transform.Find("Frame").GetComponent<Animator>().SetTrigger("HideTrigger");

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.MainMenu;
    }
}
