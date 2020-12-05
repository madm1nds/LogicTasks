using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Counts the number of levels passed in each ball.
/// Opens access to balls when passing the required number of levels.
/// </summary>
public static class CheckPassedLevel
{   
    public static void Check()
    {
        for (int i = 0; i < GlobalSaves.saveInGame.Length; i++)
        {
            GlobalSaves.saveInGame[i].tempCount = 0;
        }

        for (int i = 0; i < GlobalSaves.saveInGame.Length; i++)
        {
            for (int j = 0; j < GlobalSaves.saveInGame[0].isRateLevelsCheck.Length; j++)
            {
                if (GlobalSaves.saveInGame[i].isRateLevelsCheck[j] == true || GlobalSaves.saveInGame[i].isSkipRateLevelsCheck[j])
                    GlobalSaves.saveInGame[i].tempCount++;
            }
        }

        if (GlobalSaves.saveInGame[0].tempCount >= 15)
        {
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").Find("BestPracticesRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").Find("BestPracticesEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }
        if (GlobalSaves.saveInGame[1].tempCount >= 15)
        {
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").Find("ScientistsNotesRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").Find("ScientistsNotesEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }
        if (GlobalSaves.saveInGame[2].tempCount >= 15)
        {
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").Find("ExperimentalProcessRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").Find("ExperimentalProcessEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }
        if (GlobalSaves.saveInGame[3].tempCount >= 15)
        {
            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").Find("AcademicDegreeRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").Find("AcademicDegreeEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }

        if (GlobalSaves.saveInGame[5].tempCount >= 15)
        {
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").Find("ElementaryLawsRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").Find("ElementaryLawsEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }
        if (GlobalSaves.saveInGame[6].tempCount >= 15)
        {
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").Find("MechanicsRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").Find("MechanicsEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }
        if (GlobalSaves.saveInGame[7].tempCount >= 15)
        {
            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").GetComponent<Button>().interactable = true;
            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").Find("LatestDevelopmentsRus").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").Find("LatestDevelopmentsEng").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        }
        for (int nameLevel = 0; nameLevel < GlobalSceneObjects.contentBalls.transform.childCount; nameLevel++)
        {
            for (int allLevel = 0; allLevel < GlobalSceneObjects.contentBalls.transform.GetChild(nameLevel).GetChild(0).GetChild(0).GetChild(0).childCount; allLevel++)
            {
                GlobalSceneObjects.contentBalls.transform.GetChild(nameLevel).GetChild(0).GetChild(0).GetChild(0).GetChild(allLevel).gameObject.SetActive(false);
            }
        }
        for (int nameLevel = 0; nameLevel < GlobalSaves.saveInGame.Length; nameLevel++)
        {
            GlobalSceneObjects.contentBalls.transform.GetChild(nameLevel).GetChild(0).GetChild(0).GetChild(0).GetChild(GlobalSaves.saveInGame[nameLevel].tempCount).gameObject.SetActive(true);
        }

        SaveInGame.tempAllCount = GlobalSaves.saveInGame[0].tempCount + GlobalSaves.saveInGame[1].tempCount + GlobalSaves.saveInGame[2].tempCount + GlobalSaves.saveInGame[3].tempCount +
            GlobalSaves.saveInGame[4].tempCount + GlobalSaves.saveInGame[5].tempCount + GlobalSaves.saveInGame[6].tempCount + GlobalSaves.saveInGame[7].tempCount;
    }
}
