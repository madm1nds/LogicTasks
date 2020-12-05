using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Actions with game objects in the hierarchy in the scene.
/// </summary>
public static class SceneСontrol
{
    private static GameObject result = null;
    /// <summary>
    /// Searches the list of game objects for the specified tag and, if matched, returns a reference to the game object.
    /// </summary>
    /// <param name="parent">List of game objects among which the search is performed.</param>
    /// <param name="tag">Object tag.</param>
    /// <returns>A GameObject with the required tag, or null.</returns>
    public static GameObject SetReferenceWithTag(List<GameObject> parent, string tag)
    {
        for (int i = 0; i < parent.Capacity; i++)
        {
            if (parent[i].transform.tag == tag)
            {
                return parent[i].gameObject;
            }
        }
        return null;
    }
    /// <summary>
    /// Searches for a game object with the required tag in all nesting in the hierarchy in the selected game object and, if it matches, returns a reference to the game object.
    /// </summary>
    /// <param name="parent">The selected object in the hierarchy that will be the root.</param>
    /// <param name="tag">Object tag</param>
    /// <returns>A GameObject with the required tag, or null.</returns>
    public static GameObject SetReferenceWithTag(GameObject parent, string tag)
    {
        result = null;
        FindObject(parent, tag);
        return result;
    }
    private static void FindObject(GameObject parent, string tag)
    {        
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            // If it is not null already, then the loop can be terminated.
            if (result != null)
            {
                break;
            }
            // If we find the required tag, then we assign the result!
            if (parent.transform.GetChild(i).tag == tag)
            {
                result = parent.transform.GetChild(i).gameObject;
            }
        }

        // If the childs do not have a tag, search the next nest in the hierarchy
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            // If found, then it's time to exit recursion.
            if (result != null)
            {
                break;
            }
            if (parent.transform.GetChild(i).childCount != 0)
            {
                FindObject(parent.transform.GetChild(i).gameObject, tag);
            }
        }
    }
}
