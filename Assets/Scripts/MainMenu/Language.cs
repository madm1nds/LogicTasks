using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Translation of the interface into Russian or English.
/// </summary>
public static class Language
{
    /// <summary>
    /// Translate the interface into Russian.
    /// </summary>
    public static void SetRussian()
    {
        GlobalSounds.pressButton.Play();
        GlobalSaves.sv.Language = true;
        SaveData.Save();
        if (GlobalVariables.isRussianLanguage == false)
        {

            GlobalSceneObjects.mainMenu.transform.Find("Language").Find("ButtonLanguageRus").GetComponent<Image>().sprite = GlobalSprites.spriteLanguageRusOn;
            GlobalSceneObjects.mainMenu.transform.Find("Language").Find("ButtonLanguageEng").GetComponent<Image>().sprite = GlobalSprites.spriteLanguageEngOff;

            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonPlay").GetComponent<Image>().sprite = GlobalSprites.spriteStartGameRus;
            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonAboutUs").GetComponent<Image>().sprite = GlobalSprites.spriteAboutUsRus;
            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonWriteToUs").GetComponent<Image>().sprite = GlobalSprites.spriteWriteUsRus;
            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonExit").GetComponent<Image>().sprite = GlobalSprites.spriteExitRus;

            GlobalSceneObjects.mainMenuBack.GetComponent<Image>().sprite = GlobalSprites.spriteMainMenuRus;
            GlobalSceneObjects.selectLvlBack.GetComponent<Image>().sprite = GlobalSprites.spriteChooseLvlRus;
            GlobalSceneObjects.continueButton.GetComponent<Image>().sprite = GlobalSprites.spriteContinueMenuRus;
            GlobalSceneObjects.helpButton.transform.Find("HelpButton").GetComponent<Image>().sprite = GlobalSprites.spriteHelpLvlRus;
            GlobalSceneObjects.skipLvl.GetComponent<Image>().sprite = GlobalSprites.spriteSkipRus;

            GlobalSceneObjects.tableSkip.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Всего за 3 рыбки я пропущу тебя дальше! Договорились?";
            GlobalSceneObjects.tableSkip.transform.Find("Yes").GetComponent<Image>().sprite = GlobalSprites.spriteSkipYesRus;
            GlobalSceneObjects.tableSkip.transform.Find("No").GetComponent<Image>().sprite = GlobalSprites.spriteSkipNoRus;

            GlobalSceneObjects.tableRate.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Оценить игру?";
            GlobalSceneObjects.tableRate.transform.Find("Yes").GetComponent<Image>().sprite = GlobalSprites.spriteSkipYesRus;
            GlobalSceneObjects.tableRate.transform.Find("Later").GetComponent<Image>().sprite = GlobalSprites.spriteRateLaterRus;
            GlobalSceneObjects.tableRate.transform.Find("No").GetComponent<Image>().sprite = GlobalSprites.spriteSkipNoRus;

            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("AboutUs").GetComponent<TextMeshProUGUI>().text = "Об авторах";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("ProgrammistAndDesign").GetComponent<TextMeshProUGUI>().text = "Программист \nхудожник и дизайнер";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Madm1ndAlex").GetComponent<TextMeshProUGUI>().text = "Алексей <color=#FF7600>\"madm1nd\"";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("CreatorTasks").GetComponent<TextMeshProUGUI>().text = "Творец задач\nгейм-дизайнер";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("constellationPilgrim").GetComponent<TextMeshProUGUI>().text = "Андрей <color=#FF7600>\"constellation_pilgrim\"";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Interpreter").GetComponent<TextMeshProUGUI>().text = "Переводчик";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("NameOleg").GetComponent<TextMeshProUGUI>().text = "Олег <color=#FF7600>\"greengeviant\"";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Music").GetComponent<TextMeshProUGUI>().text = "Музыка";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Artist").GetComponent<TextMeshProUGUI>().text = "Художник";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("rabenKrausz").GetComponent<TextMeshProUGUI>().text = "Ольга <color=#FF7600>\"raben_krausz\"";

            GlobalSceneObjects.writeToUs.transform.Find("Frame").Find("Table").Find("WriteToUsText").GetComponent<TextMeshProUGUI>().text = "Помощь проекту";
            GlobalSceneObjects.writeToUs.transform.Find("Frame").Find("Table").Find("HelpProject").GetComponent<TextMeshProUGUI>().text = "Если вы заметили ошибку в игре или ошибку в задаче(неправильно составлена, пунктуция или опечатка), или перевод на английский язык неправильный, то напишите нам пожалуйста:<size=95><color=#00FF49>\nWriteinfinityuniverse\n@gmail.com";

            if (GlobalVariables.isPossessedHouse == false) GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Логические";
            if (GlobalVariables.isPossessedHouse == true) GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Одержимые";

            GlobalSceneObjects.level_4.transform.Find("Level").Find("LevelTextRus").gameObject.SetActive(true);
            GlobalSceneObjects.level_4.transform.Find("Level").Find("LevelTextEng").gameObject.SetActive(false);

            GlobalSceneObjects.yourAnswer.GetComponent<Image>().sprite = GlobalSprites.spriteYourAnswerRus;

            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").Find("AcademicDegreeRus").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").Find("ExperimentalProcessRus").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").Find("ScientistsNotesRus").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").Find("BestPracticesRus").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallLightTests").Find("LightTestsRus").gameObject.SetActive(true);

            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").Find("LatestDevelopmentsRus").gameObject.SetActive(true);
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").Find("MechanicsRus").gameObject.SetActive(true);
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").Find("ElementaryLawsRus").gameObject.SetActive(true);
            GlobalSceneObjects.possessedTasks.transform.Find("BallSimpleLever").Find("SimpleLeverRus").gameObject.SetActive(true);


            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").Find("AcademicDegreeEng").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").Find("ExperimentalProcessEng").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").Find("ScientistsNotesEng").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").Find("BestPracticesEng").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallLightTests").Find("LightTestsEng").gameObject.SetActive(false);

            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").Find("LatestDevelopmentsEng").gameObject.SetActive(false);
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").Find("MechanicsEng").gameObject.SetActive(false);
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").Find("ElementaryLawsEng").gameObject.SetActive(false);
            GlobalSceneObjects.possessedTasks.transform.Find("BallSimpleLever").Find("SimpleLeverEng").gameObject.SetActive(false);

            GlobalSceneObjects.helpBoard.transform.Find("TextHelp").GetComponent<TextMeshProUGUI>().text = "Подсказка";

            GlobalSceneObjects.answerButton.GetComponent<Image>().sprite = GlobalSprites.spriteSubmitLvlRus;

            GlobalSceneObjects.inputField.transform.Find("Placeholder").GetComponent<Text>().text = "Нажмите для ввода";

            GlobalVariables.isRussianLanguage = !GlobalVariables.isRussianLanguage;

            TextAchievments.ChangeLanguage();
        }
    }
    /// <summary>
    /// Translate the interface into English.
    /// </summary>
    public static void SetEnglish(bool launchGame)
    {
        if (launchGame == false) GlobalSounds.pressButton.Play();
        GlobalSaves.sv.Language = false;
        SaveData.Save();
        if (GlobalVariables.isRussianLanguage == true)
        {
            TextAchievments.ChangeLanguage();

            GlobalSceneObjects.mainMenu.transform.Find("Language").Find("ButtonLanguageEng").GetComponent<Image>().sprite = GlobalSprites.spriteLanguageEngOn;
            GlobalSceneObjects.mainMenu.transform.Find("Language").Find("ButtonLanguageRus").GetComponent<Image>().sprite = GlobalSprites.spriteLanguageRusOff;

            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonPlay").GetComponent<Image>().sprite = GlobalSprites.spriteStartGameEng;
            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonAboutUs").GetComponent<Image>().sprite = GlobalSprites.spriteAboutUsEng;
            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonWriteToUs").GetComponent<Image>().sprite = GlobalSprites.spriteWriteUsEng;
            GlobalSceneObjects.mainMenu.transform.Find("Content").Find("ButtonExit").GetComponent<Image>().sprite = GlobalSprites.spriteExitEng;

            GlobalSceneObjects.mainMenuBack.GetComponent<Image>().sprite = GlobalSprites.spriteMainMenuEng;
            GlobalSceneObjects.selectLvlBack.GetComponent<Image>().sprite = GlobalSprites.spriteChooseLvlEng;
            GlobalSceneObjects.continueButton.GetComponent<Image>().sprite = GlobalSprites.spriteContinueMenuEng;
            GlobalSceneObjects.helpButton.transform.Find("HelpButton").GetComponent<Image>().sprite = GlobalSprites.spriteHelpLvlEng;
            GlobalSceneObjects.skipLvl.GetComponent<Image>().sprite = GlobalSprites.spriteSkipEng;

            GlobalSceneObjects.tableSkip.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "For just 3 fish I will let you go further! Agree?";
            GlobalSceneObjects.tableSkip.transform.Find("Yes").GetComponent<Image>().sprite = GlobalSprites.spriteSkipYesEng;
            GlobalSceneObjects.tableSkip.transform.Find("No").GetComponent<Image>().sprite = GlobalSprites.spriteSkipNoEng;

            GlobalSceneObjects.tableRate.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Rate the game?";
            GlobalSceneObjects.tableRate.transform.Find("Yes").GetComponent<Image>().sprite = GlobalSprites.spriteSkipYesEng;
            GlobalSceneObjects.tableRate.transform.Find("Later").GetComponent<Image>().sprite = GlobalSprites.spriteRateLaterEng;
            GlobalSceneObjects.tableRate.transform.Find("No").GetComponent<Image>().sprite = GlobalSprites.spriteSkipNoEng;

            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("AboutUs").GetComponent<TextMeshProUGUI>().text = "About Us";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("ProgrammistAndDesign").GetComponent<TextMeshProUGUI>().text = "Programmer \nartist and designer";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Madm1ndAlex").GetComponent<TextMeshProUGUI>().text = "Alex <color=#FF7600>\"madm1nd\"";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("CreatorTasks").GetComponent<TextMeshProUGUI>().text = "Task creator\ngame designer";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("constellationPilgrim").GetComponent<TextMeshProUGUI>().text = "Andrew <color=#FF7600>\"constellation_pilgrim\"";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Interpreter").GetComponent<TextMeshProUGUI>().text = "Interpreter";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("NameOleg").GetComponent<TextMeshProUGUI>().text = "Oleg <color=#FF7600>\"greengeviant\"";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Music").GetComponent<TextMeshProUGUI>().text = "Music";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("Artist").GetComponent<TextMeshProUGUI>().text = "Artist";
            GlobalSceneObjects.aboutUs.transform.Find("Frame").Find("Table").Find("rabenKrausz").GetComponent<TextMeshProUGUI>().text = "Olga <color=#FF7600>\"raben_krausz\"";

            GlobalSceneObjects.writeToUs.transform.Find("Frame").Find("Table").Find("WriteToUsText").GetComponent<TextMeshProUGUI>().text = "Help the project";
            GlobalSceneObjects.writeToUs.transform.Find("Frame").Find("Table").Find("HelpProject").GetComponent<TextMeshProUGUI>().text = "If you notice an error or mistake in the task (incorrectly composed, punctuation or typo), or the translation into English is incorrect, please write to us:<size=95><color=#00FF49>\nWriteinfinityuniverse\n@gmail.com";

            if (GlobalVariables.isPossessedHouse == false) GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Logic";
            if (GlobalVariables.isPossessedHouse == true) GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "Possessed";

            GlobalSceneObjects.level_4.transform.Find("Level").Find("LevelTextRus").gameObject.SetActive(false);
            GlobalSceneObjects.level_4.transform.Find("Level").Find("LevelTextEng").gameObject.SetActive(true);

            GlobalSceneObjects.yourAnswer.GetComponent<Image>().sprite = GlobalSprites.spriteYourAnswerEng;

            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").Find("AcademicDegreeEng").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").Find("ExperimentalProcessEng").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").Find("ScientistsNotesEng").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").Find("BestPracticesEng").gameObject.SetActive(true);
            GlobalSceneObjects.logicTasks.transform.Find("BallLightTests").Find("LightTestsEng").gameObject.SetActive(true);

            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").Find("LatestDevelopmentsEng").gameObject.SetActive(true);
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").Find("MechanicsEng").gameObject.SetActive(true);
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").Find("ElementaryLawsEng").gameObject.SetActive(true);
            GlobalSceneObjects.possessedTasks.transform.Find("BallSimpleLever").Find("SimpleLeverEng").gameObject.SetActive(true);


            GlobalSceneObjects.logicTasks.transform.Find("BallAcademicDegree").Find("AcademicDegreeRus").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallExperimentalProcess").Find("ExperimentalProcessRus").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallScientistsNotes").Find("ScientistsNotesRus").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallBestPractices").Find("BestPracticesRus").gameObject.SetActive(false);
            GlobalSceneObjects.logicTasks.transform.Find("BallLightTests").Find("LightTestsRus").gameObject.SetActive(false);

            GlobalSceneObjects.possessedTasks.transform.Find("BallLatestDevelopments").Find("LatestDevelopmentsRus").gameObject.SetActive(false);
            GlobalSceneObjects.possessedTasks.transform.Find("BallMechanics").Find("MechanicsRus").gameObject.SetActive(false);
            GlobalSceneObjects.possessedTasks.transform.Find("BallElementaryLaws").Find("ElementaryLawsRus").gameObject.SetActive(false);
            GlobalSceneObjects.possessedTasks.transform.Find("BallSimpleLever").Find("SimpleLeverRus").gameObject.SetActive(false);

            GlobalSceneObjects.helpBoard.transform.Find("TextHelp").GetComponent<TextMeshProUGUI>().text = "Help";

            GlobalSceneObjects.answerButton.GetComponent<Image>().sprite = GlobalSprites.spriteSubmitLvlEng;

            GlobalSceneObjects.inputField.transform.Find("Placeholder").GetComponent<Text>().text = "Press to enter";

            GlobalVariables.isRussianLanguage = !GlobalVariables.isRussianLanguage;
            TextAchievments.ChangeLanguage();
        }
    }
}
