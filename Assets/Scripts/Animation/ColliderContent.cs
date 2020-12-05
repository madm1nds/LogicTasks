using UnityEngine;

/// <summary>
/// Turns on the level buttons in the inspector when zooming in on the viewport.
/// Turns off the level buttons in the inspector when zooming out the viewport.
/// <remarks>
/// If the collider of an object crosses the collider of the viewable area, then the object is turned on in the inspector.
/// If the object collider leaves the viewport collider, the object is turned off in the inspector.
/// </remarks>
/// </summary>
public class ColliderContent : MonoBehaviour
{
#pragma warning disable CS0109
    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < other.transform.parent.childCount; i++)
        {
            if(other.transform.parent.GetChild(i).name.Contains("Level") || other.transform.parent.GetChild(i).name.Contains("Box"))
            {
                other.transform.parent.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        for (int i = 0; i < other.transform.parent.childCount; i++)
        {
            if (other.transform.parent.GetChild(i).name.Contains("Level") || other.transform.parent.GetChild(i).name.Contains("Box"))
            {
                other.transform.parent.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
