using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Action with sound.
/// </summary>
public static class Sounds
{
    /// <summary>
    /// Turn on or off sound in the game.
    /// </summary>
    public static void Invoke()
    {
        GlobalSounds.pressButton.Play();
        if (GlobalVariables.isOnSound == false)
        {
            GlobalSceneObjects.mainMenu.transform.Find("Sounds").GetComponent<Image>().sprite = GlobalSprites.spriteSoundOn;
            GlobalSounds.gameMusic.volume = 0.8f;
            GlobalSounds.pressButton.volume = 1f;
            GlobalSounds.transfer.volume = 0.3f;
        }
        if (GlobalVariables.isOnSound == true)
        {
            GlobalSceneObjects.mainMenu.transform.Find("Sounds").GetComponent<Image>().sprite = GlobalSprites.spriteSoundOff;
            GlobalSounds.gameMusic.volume = 0f;
            GlobalSounds.pressButton.volume = 0f;
            GlobalSounds.transfer.volume = 0f;
        }
        GlobalVariables.isOnSound = !GlobalVariables.isOnSound;
    }
}
