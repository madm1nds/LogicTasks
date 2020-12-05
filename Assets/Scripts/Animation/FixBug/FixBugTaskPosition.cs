using UnityEngine;
/// <summary>
/// When passing a level, it fixes the coordinates of the task text.
/// Inherits from StateMachineBehaviour and uses the OnStateUpdate method.
/// </summary>
public class FixBugTaskPosition : StateMachineBehaviour
{

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GlobalSceneObjects.taskContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,0);
    }

}
