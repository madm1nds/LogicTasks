using UnityEngine;
/// <summary>
/// Hides the contentBalls. Calls the method that loads the level.
/// </summary>
public static class LaunchLevel
{
    /// <param name="NumberClickParams">Loadable level number</param>
    public static void Invoke(int NumberClickParams)
    {
        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);
        HideContentBalls.Invoke();

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.GameLevel;

        SaveInGame.numberLvlClick = NumberClickParams;
        LoadLevel.Load(SaveInGame.numberLvlClick);
    }
}
