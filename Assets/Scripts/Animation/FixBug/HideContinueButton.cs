using UnityEngine;
/// <summary>
/// Turns off the continueButton in the inspector after the animation ends.
/// Inherits from StateMachineBehaviour and uses the OnStateEnter method.
/// </summary>
public class HideContinueButton : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (GlobalSceneObjects.continueButton.activeInHierarchy == true)
        {
            GlobalSceneObjects.continueButton.SetActive(false);
        }
    }
}
