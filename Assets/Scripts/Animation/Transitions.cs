using UnityEngine;
/// <summary>
/// Safely calling the SetVisible method. It is called after the animation ends.
/// Inherits from StateMachineBehaviour and uses the OnStateExit method.
/// </summary>
public class Transitions : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {        
        SetVisible.SetVisibleObject();
    }
}