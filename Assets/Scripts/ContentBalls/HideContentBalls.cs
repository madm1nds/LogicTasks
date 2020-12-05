using UnityEngine;
/// <summary>
/// Starts an animation that hides all objects when a level is selected.
/// </summary>
public static class HideContentBalls
{
    public static void Invoke()
    {
        for (int numberBall = 0; numberBall < GlobalSceneObjects.contentBalls.transform.childCount; numberBall++)
        {
            GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).transform.Find("Content").Find("Pattern").Find("BoxForNumbers").GetComponent<Animator>().SetTrigger("HideTrigger");

            if (GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).gameObject.activeInHierarchy == true)
            {
                for (int row = 0; row < GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").childCount - 1; row++)
                {
                    for (int column = 0; column < GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).childCount - 1; column++)
                    {
                        try
                        {
                            GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column)
    .GetComponent<Animator>().SetTrigger("HideTrigger");
                        }
                        catch (System.Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}
