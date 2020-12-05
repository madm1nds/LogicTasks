using UnityEngine;
/// <summary>
/// Action when you press the StartGame button.
/// </summary>
public static class StartGame
{
    /// <summary>
    /// Hide interface and enable LogicLevels or PossessedLevels.
    /// </summary>
    public static void Invoke()
    {
        MainMenu.Hide();

        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.PlayButton;
    }
}
