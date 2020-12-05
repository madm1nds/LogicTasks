using UnityEngine;

/// <summary>
/// Blocks the click on the ShowNextPage button until the animation ends.
/// Inherits from StateMachineBehaviour and uses the OnStateEnter method.
/// <remarks>
/// Blocking is ignored when going to the selected ball or when going to the main menu.
/// </remarks>
/// </summary>
public class BlockAnimation : StateMachineBehaviour
{    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {        
        if (GlobalVariables.stateForAnimation <= 6 || GlobalVariables.stateForAnimation >=16)
        {
            GlobalVariables.stateForAnimation = 0;
        }        
    }
}