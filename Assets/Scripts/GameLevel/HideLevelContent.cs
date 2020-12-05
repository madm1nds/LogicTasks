using UnityEngine;
/// <summary>
/// Hides all game objects related to the interface.
/// </summary>
public static class HideLevelContent
{
    public static void Invoke()
    {
        GlobalSounds.pressButton.Play();
        GlobalSounds.transfer.PlayDelayed(0.15f);
        GlobalSceneObjects.mainMenuBack.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.selectLvlBack.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.helpButton.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.catContent.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.dialogue.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.continueButton.GetComponent<Animator>().SetTrigger("HideTrigger");
        GlobalSceneObjects.skipLvl.GetComponent<Animator>().SetTrigger("HideTrigger");
    }
}
