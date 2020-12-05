using UnityEngine;
/// <summary>
/// Turns off the tableSkip in the inspector after the animation ends.
/// Inherits from StateMachineBehaviour and uses the OnStateUpdate method.
/// </summary>
public class FixBugWithTableSkip : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (GlobalSceneObjects.tableSkip.activeInHierarchy == true)
        {
            GlobalSceneObjects.tableSkip.gameObject.SetActive(false);
        }
    }
}
