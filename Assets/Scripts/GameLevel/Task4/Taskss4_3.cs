using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Action when clicking on the third coin.
/// </summary>
public class Taskss4_3 : MonoBehaviour
{
#pragma warning disable CS0414
    public Sprite head;
    public Sprite tail;

    public Button cent1;
    public Button cent2;
    public Button cent3;
    public Button cent4;
    public Button cent5;

    static public bool isTail3 = true;
    bool lockCent = false;
    
    public void FlipCent3()
    {
        if (Taskss4_1.countFlip == 0)
        {
            Taskss4_1.pointerCent = 3;

            if (isTail3 == false)
            {
                cent3.GetComponent<Image>().sprite = tail;
                isTail3 = true;
            }
            else
            {
                cent3.GetComponent<Image>().sprite = head;
                isTail3 = false;
            }
            Taskss4_1.countFlip++;
            lockCent = true;
        }

        if ((Taskss4_1.pointerCent == 2 || Taskss4_1.pointerCent == 4) && Taskss4_1.countFlip == 1)
        {
            Taskss4_1.pointerCent2Step = 3;
            if (isTail3 == false)
            {
                cent3.GetComponent<Image>().sprite = tail;
                isTail3 = true;
            }
            else
            {
                cent3.GetComponent<Image>().sprite = head;
                isTail3 = false;
            }
            Taskss4_1.countFlip++;
            lockCent = true;
        }

        if (Taskss4_1.pointerCent == 1 && Taskss4_1.pointerCent2Step == 2 && Taskss4_1.countFlip == 2)
        {
            if (isTail3 == false)
            {
                cent3.GetComponent<Image>().sprite = tail;
                isTail3 = true;
            }
            else
            {
                cent3.GetComponent<Image>().sprite = head;
                isTail3 = false;
            }
            Taskss4_1.countFlip++;
            lockCent = true;
        }

        if (Taskss4_1.pointerCent == 5 && Taskss4_1.pointerCent2Step == 4 && Taskss4_1.countFlip == 2)
        {
            if (isTail3 == false)
            {
                cent3.GetComponent<Image>().sprite = tail;
                isTail3 = true;
            }
            else
            {
                cent3.GetComponent<Image>().sprite = head;
                isTail3 = false;
            }
            Taskss4_1.countFlip++;
            lockCent = true;
        }

        if (Taskss4_1.pointerCent == 2 && Taskss4_1.pointerCent2Step == 1 && Taskss4_1.countFlip == 2)
        {
            if (isTail3 == false)
            {
                cent3.GetComponent<Image>().sprite = tail;
                isTail3 = true;
            }
            else
            {
                cent3.GetComponent<Image>().sprite = head;
                isTail3 = false;
            }
            Taskss4_1.countFlip++;
            lockCent = true;
        }

        if (Taskss4_1.pointerCent == 4 && Taskss4_1.pointerCent2Step == 5 && Taskss4_1.countFlip == 2)
        {
            if (isTail3 == false)
            {
                cent3.GetComponent<Image>().sprite = tail;
                isTail3 = true;
            }
            else
            {
                cent3.GetComponent<Image>().sprite = head;
                isTail3 = false;
            }
            Taskss4_1.countFlip++;
            lockCent = true;
        }

        if (Taskss4_1.countFlip == 3)
        {
            Taskss4_1.countAttempt++;
            lockCent = false;
            Taskss4_1.countFlip = 0;
            Taskss4_1.pointerCent = 0;
            Taskss4_1.pointerCent2Step = 0;
        }

        if (Taskss4_1.countAttempt == 2 && Taskss4_1.isTail1 == true && Taskss4_2.isTail2 == true && Taskss4_3.isTail3 == true && Taskss4_4.isTail4 == true && Taskss4_5.isTail5 == true)
        {
            GlobalSaves.saveInGame[0].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;
            GlobalVariables.isSkipLevel = false;
            HideLevelButtons.Invoke();
            OpenPassedLevels.Open();
            GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.ButtonContinue;
            SaveData.Save();

            Taskss4_1.countAttempt = 0;
            Taskss4_1.countFlip = 0;
            lockCent = false;
            Taskss4_1.isTail1 = false;
            Taskss4_2.isTail2 = false;
            Taskss4_3.isTail3 = true;
            Taskss4_4.isTail4 = false;
            Taskss4_5.isTail5 = false;

            Taskss4_1.pointerCent = 0;
            Taskss4_1.pointerCent2Step = 0;

            cent1.GetComponent<Image>().sprite = head;
            cent2.GetComponent<Image>().sprite = head;
            cent3.GetComponent<Image>().sprite = tail;
            cent4.GetComponent<Image>().sprite = head;
            cent5.GetComponent<Image>().sprite = head;
        }
        else if (Taskss4_1.countAttempt == 2 && (Taskss4_1.isTail1 == false || Taskss4_2.isTail2 == false || Taskss4_3.isTail3 == false || Taskss4_4.isTail4 == false || Taskss4_5.isTail5 == false))
        {        
            Taskss4_1.countAttempt = 0;
            Taskss4_1.countFlip = 0;
            lockCent = false;
            Taskss4_1.isTail1 = false;
            Taskss4_2.isTail2 = false;
            Taskss4_3.isTail3 = true;
            Taskss4_4.isTail4 = false;
            Taskss4_5.isTail5 = false;

            Taskss4_1.pointerCent = 0;
            Taskss4_1.pointerCent2Step = 0;

            cent1.GetComponent<Image>().sprite = head;
            cent2.GetComponent<Image>().sprite = head;
            cent3.GetComponent<Image>().sprite = tail;
            cent4.GetComponent<Image>().sprite = head;
            cent5.GetComponent<Image>().sprite = head;
        }
    }
}
