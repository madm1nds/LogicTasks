using UnityEngine;
/// <summary>
/// Actions with the game object AboutUs.
/// </summary>
public static class AboutUs
{
    /// <summary>
    /// Go to the menu AboutUs.
    /// </summary>
    public static void Invoke()
    {
        SaveInGame.isCompleteAchievment[2] = true;
        MainMenu.Hide();

        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.AboutUs;
    }
    /// <summary>
    /// Following a link.
    /// </summary>
    /// <param name="URL"></param>
    public static void TransferURL(int URL)
    {
        switch (URL)
        {
            case 1: Application.OpenURL("https://www.instagram.com/madm1nd/"); break;
            case 2: Application.OpenURL("https://www.instagram.com/constellation_pilgrim/"); break;
            case 3: Application.OpenURL("https://incompetech.com/"); break;
            case 4: Application.OpenURL("https://www.instagram.com/raben_krausz/"); break;
            case 5: Application.OpenURL("https://vk.com/greengeviant/"); break;
        }
    }
    /// <summary>
    /// Exit the menu AboutUs.
    /// </summary>
    public static void Exit()
    {
        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);
        GlobalSceneObjects.aboutUs.transform.Find("Frame").GetComponent<Animator>().SetTrigger("HideTrigger");

        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.MainMenu;
    }
}
