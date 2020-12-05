using TMPro;
using UnityEngine.UI;
using UnityEngine;
/// <summary>
/// Loads the selected level.
/// </summary>
public static class LoadLevel
{
    private static float positionCurrentElement = 0;
    private static float spaceBetweenElements = 10;
    private static void SetImageNumber(GameObject numberObject, string numberText)
    {
        switch (numberText)
        {
            case "0":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[0];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(66, 87);
                break;
            case "1":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[1];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(38, 92);
                break;
            case "2":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[2];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(59, 84);
                break;
            case "3":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[3];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(55, 91);
                break;
            case "4":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[4];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(69, 91);
                break;
            case "5":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[5];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(52, 84);
                break;
            case "6":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[6];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(61, 88);
                break;
            case "7":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[7];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(53, 82);
                break;
            case "8":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[8];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(51, 82);
                break;
            case "9":
                numberObject.GetComponent<Image>().sprite = GlobalSprites.spriteNumberLevel[9];
                numberObject.GetComponent<RectTransform>().sizeDelta = new Vector2(61, 89);
                break;
        }
    }
    private static void SetAnchoredPosition(GameObject previousElement, GameObject currentElement)
    {
        positionCurrentElement += ((previousElement.GetComponent<RectTransform>().sizeDelta.x) -
                                                           (currentElement.GetComponent<RectTransform>().sizeDelta.x) + spaceBetweenElements) / 2 +
                                                           currentElement.GetComponent<RectTransform>().sizeDelta.x;
        currentElement.GetComponent<RectTransform>().anchoredPosition = new Vector2(positionCurrentElement, 0);
    }
    private static void SetSizeDeltaContentLevel(GameObject level, float sumSpaceBetweenElements, int countNumbers)
    {

        float newSizeDelta = 0;
        level.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 100);
        for (int element = 0; element < 1 + countNumbers; element++)
        {
            newSizeDelta += level.transform.GetChild(element).gameObject.GetComponent<RectTransform>().sizeDelta.x;
        }
        level.GetComponent<RectTransform>().sizeDelta = new Vector2(newSizeDelta + sumSpaceBetweenElements, 100);
        for (int element = 0; element < 1 + countNumbers; element++)
        {
            level.transform.GetChild(element).gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0.5f);
            level.transform.GetChild(element).gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(0, 0.5f);
        }
        level.transform.Find("TextLevel").GetComponent<RectTransform>().anchoredPosition = new Vector2(GlobalSceneObjects.textLevel.transform.Find("TextLevel").GetComponent<RectTransform>().sizeDelta.x / 2, 0);
        positionCurrentElement += GlobalSceneObjects.textLevel.transform.Find("TextLevel").GetComponent<RectTransform>().sizeDelta.x / 2;
    }
    /// <param name="currentLevel">Loadable level number</param>
    public static void Load(int currentLevel)
    {
        positionCurrentElement = 0;
        GameObject taskContent = GlobalSceneObjects.taskContent;
        GameObject helpContent = GlobalSceneObjects.helpContent;
        TextMeshProUGUI taskText = GlobalSceneObjects.taskContent.transform.Find("Task").gameObject.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI helpTask = GlobalSceneObjects.helpContent.transform.Find("HelpTask").GetComponent<TextMeshProUGUI>();

        if (GlobalVariables.stateForAnimation != (int)GlobalVariables.NameAnimation.Task)
        {
            GlobalSceneObjects.currentLevel.gameObject.SetActive(false);
            GlobalSceneObjects.level_4.gameObject.SetActive(false);
        }

        if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests && currentLevel == 4)
        {
            GameObject centImage = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.level_4, "Cent");
            GameObject task4 = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.level_4, "Task");
            GameObject taskContent4 = SceneСontrol.SetReferenceWithTag(GlobalSceneObjects.level_4, "TaskContent");
            GlobalSceneObjects.level_4.gameObject.SetActive(true);
            if (GlobalVariables.isRussianLanguage == true)
            {                
                centImage.GetComponent<RectTransform>().localPosition = new Vector2(178.5764f, 76.28344f);
                task4.GetComponent<RectTransform>().anchoredPosition = new Vector2(168, 108);
                taskContent4.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Переверните 5 монет вверх орлом\n Разрешается переворачивать только 3 рядом " +
                                                                                                                                                        "лежащие монеты одновременно.";
                helpTask.text = "Рыбку у тебя не заберу! Однако и помощи здесь нет...";
            }
            else
            {
                task4.GetComponent<RectTransform>().anchoredPosition = new Vector2(142, 62);

                taskContent4.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Flip 5 coins upside down\n It is allowed to flip only 3 adjacent coins at a time.";
                helpTask.text = "I won't take the fish away from you! However, there is no help here either...";
                centImage.GetComponent<RectTransform>().localPosition = new Vector2(412f, 79f);
            }
        }
        else
        {
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests && currentLevel == 8)
            {
                taskContent.transform.Find("Task").Find("Line1").gameObject.SetActive(true);
                taskContent.transform.Find("Task").Find("Line2").gameObject.SetActive(true);
                taskContent.transform.Find("Task").Find("Numbers").gameObject.SetActive(true);
            }
            else
            {
                taskContent.transform.Find("Task").Find("Line1").gameObject.SetActive(false);
                taskContent.transform.Find("Task").Find("Line2").gameObject.SetActive(false);
                taskContent.transform.Find("Task").Find("Numbers").gameObject.SetActive(false);
            }

            GlobalSceneObjects.currentLevel.gameObject.SetActive(true);

            if (GlobalVariables.isRussianLanguage == true)
            {
                GlobalSceneObjects.textLevel.transform.Find("TextLevel").GetComponent<Image>().sprite = GlobalSprites.spriteLevelTextRus;
                GlobalSceneObjects.textLevel.transform.Find("TextLevel").GetComponent<RectTransform>().sizeDelta = new Vector2(367, 130);                
            }
            else
            {
                GlobalSceneObjects.textLevel.transform.Find("TextLevel").GetComponent<Image>().sprite = GlobalSprites.spriteLevelTextEng;
                GlobalSceneObjects.textLevel.transform.Find("TextLevel").GetComponent<RectTransform>().sizeDelta = new Vector2(211, 102);
            }

            char[] arrayNumbers = System.Convert.ToString(currentLevel).ToCharArray();
            GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject.SetActive(false);
            GlobalSceneObjects.textLevel.transform.Find("Number2").gameObject.SetActive(false);
            if (arrayNumbers.Length == 1)
            {
                GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject.SetActive(true);
                SetImageNumber(GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject, System.Convert.ToString(arrayNumbers[0]));

                SetSizeDeltaContentLevel(GlobalSceneObjects.textLevel, 30, arrayNumbers.Length);

                spaceBetweenElements = 30;
                SetAnchoredPosition(GlobalSceneObjects.textLevel.transform.Find("TextLevel").gameObject, GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject);

            }
            else
            {
                GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject.SetActive(true);
                SetImageNumber(GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject, System.Convert.ToString(arrayNumbers[0]));
                GlobalSceneObjects.textLevel.transform.Find("Number2").gameObject.SetActive(true);
                SetImageNumber(GlobalSceneObjects.textLevel.transform.Find("Number2").gameObject, System.Convert.ToString(arrayNumbers[1]));

                SetSizeDeltaContentLevel(GlobalSceneObjects.textLevel, 40, arrayNumbers.Length);

                spaceBetweenElements = 30;
                SetAnchoredPosition(GlobalSceneObjects.textLevel.transform.Find("TextLevel").gameObject, GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject);
                spaceBetweenElements = 10;
                SetAnchoredPosition(GlobalSceneObjects.textLevel.transform.Find("Number1").gameObject, GlobalSceneObjects.textLevel.transform.Find("Number2").gameObject);
            }

            taskText.text = "";
            helpTask.text = "";
            GlobalSceneObjects.answerButton.GetComponent<Button>().onClick.RemoveAllListeners();
            GlobalSceneObjects.answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(currentLevel); });


            taskContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices
                || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess
                || GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree)
            {
                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -697);
                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1395);
                helpTask.margin = new Vector4(35, 0, 35, 0);
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever && (currentLevel != 14))
            {
                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -697);
                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1395);
                helpTask.margin = new Vector4(35, 0, 35, 0);
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws && (currentLevel != 5))
            {
                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -697);
                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1395);
                helpTask.margin = new Vector4(35, 0, 35, 0);
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics && (currentLevel != 6))
            {
                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -697);
                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1395);
                helpTask.margin = new Vector4(35, 0, 35, 0);
            }
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments && currentLevel != 10 && currentLevel != 11 && currentLevel != 15 && currentLevel != 17 && currentLevel != 18)
            {
                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -697);
                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1395);
                helpTask.margin = new Vector4(35, 0, 35, 0);
            }

            switch (GlobalVariables.activeNameLevel)
            {
                case (int)GlobalVariables.NameAnimation.LightTests:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Составьте два слова из букв:\n<color=#F3FF00>Д А А С В О В Л";
                                helpTask.text = "Попробуй написать ДВА СЛОВА! Два слова. два слова...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Make two words from the letters: \n<color=#F3FF00>W O R D O S T W";
                                helpTask.text = "Try writing TWO WORDS! Two words. two words...";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 551);
                                taskText.margin = new Vector4(19, 53.3f, 19, 15);
                                taskText.text = "Закончите последовательность чисел:\n<color=#F3FF00><size=70>3+9+0+9 = 3   9+8+7+6 = 4\n5+4+0+0 = 2   3+2+1+0 = 1\n0+1+9+9 = 3   7+7+9+8 = 2\n8+8+6+6 = 6   5+4+7+1 = 0\n6+6+8+8 = 6   3+9+9+3 = </color>?";
                                helpTask.text = "Присмотрись к кружочкам! К каким? Нууу. Поищи их!";

                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 551);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Finish the sequence of numbers:\n<color=#F3FF00><size=65>3+9+0+9 = 3   9+8+7+6 = 4\n5+4+0+0 = 2   3+2+1+0 = 1\n0+1+9+9 = 3   7+7+9+8 = 2\n8+8+6+6 = 6   5+4+7+1 = 0\n6+6+8+8 = 6   3+9+9+3 = </color>?";
                                helpTask.text = "Look closely at the circles! Which ones? Ah... Just look for them!";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 578);
                                taskText.margin = new Vector4(40, 53.3f, 40, -16);
                                taskText.text = "В три тарелки с табличками \n\"<color=#00FF49>мятное</color>\", \"<color=#00B6FF>черничное</color>\" и \"<color=#00FF49>мятное </color>или <color=#00B6FF>черничное</color>\" налили <color=#F3FF00>облепиховое</color>, <color=#00FF49>мятное</color> и <color=#00B6FF>черничное</color> варенье. Все таблички были неправильными. Варенье какого типа налили в тарелку с табличкой \"<color=#00B6FF>черничное</color>\"?";
                                helpTask.text = "Прочитай внимательно с самого начала и сопоставь названия! Давай я верю в тебя!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 578);
                                taskText.margin = new Vector4(40, 53.3f, 40, -16);
                                taskText.text = "<color=#F3FF00>Sea buckthorn</color> jam, <color=#00FF49>mint</color> and  <color=#00B6FF>blueberry</color> jam was poured into three plates with signs <color=#00FF49>\"mint\"</color>, <color=#00B6FF>\"blueberry\"</color> and \"<color=#00FF49>mint</color> or <color=#00B6FF>blueberry</color>\". All the signs were wrong. What type of jam was poured into a plate with a <color=#00B6FF>blueberry</color> sign?";
                                helpTask.text = "Read carefully from the beginning and match the names! I believe in you!";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Это</color> не сдвигается с места, но при этом способно <color=#F3FF00>поднять</color> кого угодно наверх или <color=#F3FF00>опустить</color> вниз. О чём идёт речь?";
                                helpTask.text = "Эти ступеньки умеют поднимать или опускать что угодно!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>It</color> does not move, but at the same time it is able to lift anyone <color=#F3FF00>up or down</color>. What is it about?";
                                helpTask.text = "These rungs can lift anything!";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 730);
                                taskText.margin = new Vector4(40, 53.3f, 40, -182);
                                taskText.text = "Сосуд с <color=#F3FF00>неизвестным содержимым</color> поставили на край книжной полки без единой книги. Удивительно, но <color=#F3FF00>1/10</color> его часть оставалась на книжной полке и сосуд <color=#F3FF00>не падал</color>! Также сосуд был полостью закрыт со всех сторон. Спустя некоторое время сосуд упал и разбился. <color=#F3FF00>Что в нём было?</color>";
                                helpTask.text = "Это очень холодная жидкость!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 730);
                                taskText.margin = new Vector4(40, 53.3f, 40, -182);
                                taskText.text = "A vessel with <color=#F3FF00>unknown content</color> was placed on the edge of a bookshelf without a single book. Surprisingly, <color=#F3FF00>the 1/10</color> part of it remained on the bookshelf and the vessel  <color=#F3FF00>did not fall</color>! The vessel was also closed from all sides with a cavity. After some time, the vessel fell and broke. <color=#F3FF00>What was in it?</color>";
                                helpTask.text = "This is a very cold liquid!";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 545);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Александр путешествует, и он решает устроить <color=#F3FF00>небольшой отдых</color>. У него в рюкзаке есть бутылка с водой, термос с чаем и пакет с печеньем. <color=#F3FF00>Что Александр откроет первым?</color>";
                                helpTask.text = "Давай сделаем всё последовательно. Ты открываешь рюкзак, потом бутылку, потом термос... Дальше сам!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 545);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "While travelling, Alexander decided to arrange a <color=#F3FF00>little vacation</color>. He has a bottle of water, a thermos of tea and a bag of cookies in his backpack. <color=#F3FF00>What will Alexander open first?</color>";
                                helpTask.text = "Let's do everything in sequence. You open your backpack, then a bottle, then a thermos... Think for yourself!";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 708);
                                taskText.margin = new Vector4(40, 53.3f, 40, -91);
                                taskText.text = "Замените \"<color=#F3FF00>?</color>\" на правильный ответ:\n<line-height=50%><color=#F3FF00>\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |";
                                helpTask.text = "Так-с. Давай складывать первую строчку со второй! ";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 708);
                                taskText.margin = new Vector4(40, 53.3f, 40, -91);
                                taskText.text = "Replace \"<color=#F3FF00>?</color>\" with the correct answer:\n<line-height=50%><color=#F3FF00>\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |\n|     |     |     |     |     |";
                                helpTask.text = "So. Let's add up the first line to the second line!";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 661);
                                taskText.margin = new Vector4(40, 53.3f, 40, -103);
                                taskText.text = "В <color=#F3FF00>2020</color> году путешественник во времени запустил часть своей машины времени для тестирования. Секунды спустя экран показал <color=#F3FF00>2058</color>, затем <color=#F3FF00>2059</color> и вдруг на экране показалось число <color=#F3FF00>2100</color>. Что будет показываться на экране после <color=#F3FF00>2100</color>?";
                                helpTask.text = "Я думаю, тебе пора посмотреть на время!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 661);
                                taskText.margin = new Vector4(40, 53.3f, 40, -103);
                                taskText.text = "In <color=#F3FF00>2020</color> a time traveler launched part of his time machine for testing. Seconds later the screen showed <color=#F3FF00>2058</color>, then <color=#F3FF00>2059</color> and suddenly the number <color=#F3FF00>2100</color> appeared on the screen. What will be shown on the screen after <color=#F3FF00>2100</color>?";
                                helpTask.text = "I think it's time for you to look at the time!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Закончите последовательность:\n<color=#F3FF00>A</color>,<color=#F3FF00>B</color>,<color=#F3FF00>C</color>,<color=#F3FF00>D</color>,<color=#F3FF00>_</color>";
                                helpTask.text = "Что, если я тебе скажу, что тебе достаточно написать F?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Complete sequence:\n<color=#F3FF00>A</color>,<color=#F3FF00>B</color>,<color=#F3FF00>C</color>,<color=#F3FF00>D</color>,<color=#F3FF00>_</color>";
                                helpTask.text = "What if I told you that you just need to write F?";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Замените \"<color=#F3FF00>?</color>\" на правильный ответ:\n<color=#F3FF00>БП</color>, <color=#F3FF00>УП</color>, <color=#F3FF00>СП</color>, <color=#F3FF00>БП</color>, <color=#F3FF00>?</color>";
                                helpTask.text = "Ответ находится на твоих руках!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Replace \"<color=#F3FF00>?</color>\" with the required answer:\n<color=#F3FF00>T</color>, <color=#F3FF00>IF</color>, <color=#F3FF00>MF</color>, <color=#F3FF00>RF</color>, <color=#F3FF00>?</color>";
                                helpTask.text = "The answer is in your hands!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 904);
                                taskText.margin = new Vector4(40, 53.3f, 40, -336);
                                taskText.text = "Замените \"<color=#F3FF00>?</color>\" на правильный ответ из списка:\nАнанас - Барбарис\nВетер - Горошек\nДерево - Езда\nЖивотное - <color=#F3FF00>?</color>\n<color=#F3FF00>Список:</color> Колобок, Игра, Иней, Гадость, Морковка, Зараза, Драка, Сорока, Фиаско, Кирпич, Почки, Трамвай, Гололёд, Сани, Беда, Остеохондроз.";
                                helpTask.text = "Хм. Давай ещё раз пройдём азбуку...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 904);
                                taskText.margin = new Vector4(40, 53.3f, 40, -336);
                                taskText.text = "Replace \"<color=#F3FF00>?</color>\" with the correct answer from the list:\nArea - Beautiful\nClassroom - Director\nEggplant - Food\nGenius - <color=#F3FF00>?</color>\n<color=#F3FF00>List:</color> Billionaire, Pianist, Frost, Frustration, Carrot, Heart, Microbiology, Vanilla, Website, Quality, Kidney, Tram, Elk, Notepad, Toe, Osteochondrosis.";
                                helpTask.text = "Hmm. Let's go through the alphabet again...";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 629);
                                taskText.margin = new Vector4(40, 53.3f, 40, -83);
                                taskText.text = "\n\nНайди ответ самостоятельно...\n\n\n\n42";
                                helpTask.text = "Тебе действительно нужна подсказка? Тогда попробуй прокрутить условие задачи!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 629);
                                taskText.margin = new Vector4(40, 53.3f, 40, -83);
                                taskText.text = "\n\nFind the answer yourself...\n\n\n\n42";
                                helpTask.text = "Do you really need a hint? Then try scrolling the task condition!";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 555);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Александр может слышать и говорить. <color=#F3FF00>Он вполне здоровый человек</color>. Но Александр не может ответить честно на вопрос \"<color=#F3FF00>Да</color>\". Да и вообще <color=#F3FF00>ни один человек</color> не может. \n<color=#F3FF00>Что это за вопрос?</color>";
                                helpTask.text = "Слушай, а ты там не спишь случайно?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 555);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Alexander can hear and speak. <color=#F3FF00>He is a perfectly healthy person</color>. But Alexander cannot honestly answer the question \"<color=#F3FF00>Yes</color>\". And indeed, <color=#F3FF00>not a single person</color> can. \n<color=#F3FF00>What is this question?</color>";
                                helpTask.text = "Listen, don't you accidentally sleep there?";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 542);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Начинающий предприниматель проснулся рано утром и решил покушать <color=#F3FF00>блинов</color> перед началом работы. Напиши <color=#F3FF00>количество блинов</color>, которые он может скушать натощак.";
                                helpTask.text = "Второй блин уже не натощак будет... Так сколько?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 542);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The aspiring entrepreneur woke up early in the morning and decided to eat <color=#F3FF00>pancakes</color> before starting work. Write down <color=#F3FF00>the number of pancakes</color> he can eat on an empty stomach.";
                                helpTask.text = "The second pancake will no longer be on an empty stomach... So how much?";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Сколько гречки</color> в пустой посуде?";
                                helpTask.text = "Сделаю тебе подарок и скажу ответ! Нисколько!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>How much buckwheat</color> is in an empty dish?";
                                helpTask.text = "I'll give you a gift and tell you the answer! The dishes are EMPTY!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Известно, что <color=#F3FF00>Эверест</color> впервые был помечен на картах примерно в 1720-ых годах. Назови нивысшую существующую гору до его открытия...";
                                helpTask.text = "Невероятно, но факт! Гора Эверест существовала и много тысяч лет назад!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "It is known that <color=#F3FF00>Everest</color> was first marked on maps around the 1720s. What is the highest existing mountain before its discovery?";
                                helpTask.text = "Unbelievable, but true! Mount Everest existed many thousands of years ago!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 553);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Вместо <color=#F3FF00>солнца</color> начали использовать <color=#00FFF3>воду</color>. Спустя 6 веков вместо <color=#00FFF3>неё</color> использовали <color=#FF7600>песок</color>. По прошествии ещё 11 веков <color=#00FFF3>воду</color> и <color=#FF7600>песок</color> потеснил <color=#F3FF00>механизм</color>. О каком <color=#00FF49>процессе</color> или <color=#F3FF00>предмете</color> идёт речь?";
                                helpTask.text = "Это есть на руке почти у каждого человека! И процесс интересный в нём! Время ещё показывает!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 553);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Instead of the <color=#F3FF00>sun</color>, they began to use <color=#00FFF3>water</color>. After 6 centuries, <color=#FF7600>sand</color> was used instead. After another 11 centuries, <color=#00FFF3>water</color> and <color=#FF7600>sand</color> were replaced by the <color=#F3FF00>mechanism</color>. What <color=#00FF49>process</color> or <color=#F3FF00>subject</color> are you talking about?";
                                helpTask.text = "Almost every person has this on their hand! And the process in it is interesting! It shows the time!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 541);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Джимми</color> полностью сбривает бороду <color=#00FFF3>утром</color>, <color=#00FF49>днём</color> и <color=#FF7600>вечером</color>. \nОднако <color=#F3FF00>Джимми</color> мужчина не простой и всё равно ходит с бородой!\n<color=#F3FF00>Как Джимми это удаётся?</color>";
                                helpTask.text = "Джимми просто красавчик. Он барбер!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 541);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Jimmy</color> shaves his beard completely in the <color=#00FFF3>morning</color>, <color=#00FF49>afternoon</color> and <color=#FF7600>evening</color>. \nHowever, <color=#F3FF00>Jimmy</color> is not an ordinary man and still walks with a beard!\n<color=#F3FF00>How does Jimmy do it?</color>";
                                helpTask.text = "Jimmy is just handsome. He's a barber!";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1040);
                                taskText.margin = new Vector4(40, 53.3f, 40, -488);
                                taskText.text = "Однажды много веков назад, один путник искал затерянный город с сокровищами. В своих поисках, он проделал огромный путь. И вот, путешественник почти добрался до своей цели! Но чтобы пройти дальше, он должен был ответить на вопрос, написанный на таинственной табличке. \n<color=#F3FF00>Есть числа 8 и 9. Чего не хватает между числами, чтобы получилось число меньше девяти, но больше восьми?";
                                helpTask.text = "Знак? Меньше? Больше? Равно? Точка? Запятая? Что же тут поставить...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1068);
                                taskText.margin = new Vector4(40, 53.3f, 40, -498);
                                taskText.text = "Once upon a time, many centuries ago, a traveler was looking for a lost city with treasures. In his search, he has come a long way. And so, the traveler has almost reached his goal! But in order to go further, he had to answer a question written on a mysterious tablet. \n<color=#F3FF00>There were numbers 8 and 9. What is missing between the numbers to make a number less than nine but greater than eight?";
                                helpTask.text = "Sign? Smaller? More? Equally? Dot? Comma? What to put here...";
                            }
                            break;
                        case 21:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Почти все люди на Земле, закрывая глаза могут видеть. Что именно они видят?";
                                helpTask.text = "О, даже ты видишь их почти каждую ночь!";
                            }
                            else
                            {

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Almost all people on Earth can see this by closing their eyes. What exactly do they see?";
                                helpTask.text = "Oh, even you see them almost every night!";
                            }
                            break;
                        case 22:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Известно, что каждый месяц имеет определённое количество дней. Напиши количество месяцев, которые содержат двадцать восемь дней.";
                                helpTask.text = "Ты серьёзно? Все месяцы!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "It is known that each month has a certain number of days. Write down the number of months that contain twenty-eight days.";
                                helpTask.text = "Are you serious? All months contains 28 or more!";
                            }
                            break;
                        case 23:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 942);
                                taskText.margin = new Vector4(40, 53.3f, 40, -358);
                                taskText.text = "Один счастливчик провернул интересное, он на бумаге записал чернилами выигрышные числа лотереи, которая в скорее будет разыгрываться, кроме того, ничего не помешает ему в ней участвовать и победить! Но вот не задача, сейчас его шанс на победу абсолютно такой же, как и у остальных. Почему?";
                                helpTask.text = "Сейчас(!) у него нет билета и он в тех же условиях что и другие участники!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 942);
                                taskText.margin = new Vector4(40, 53.3f, 40, -358);
                                taskText.text = "One lucky guy did an interesting thing, he wrote down the winning numbers of the lottery on paper, which will soon be played out, in addition, nothing will prevent him from participating and winning! Unfortunately, now his chance of winning is exactly the same as the rest. Why?";
                                helpTask.text = "Right now(!) he has no ticket and is in the same conditions as the other participants!";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.BestPractices:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Один мудрец однажды спросил. Земля и вода. Что находится между ними?";
                                helpTask.text = "И?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "One wise man once asked. Land and water. \nWhat's in between?";
                                helpTask.text = "And?";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 539);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Неудачливый мужчина катился со склона горы <color=#F3FF00>пять минут</color> и в итоге сломал руку. Сколько рук сломает мужчина, если снова упадёт и будет катиться с горы уже целый <color=#F3FF00>час</color>?";
                                helpTask.text = "А рука-то у него одна осталась целой!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 539);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The unlucky man rolled down the mountainside for <color=#F3FF00>five minutes</color> and ended up breaking his arm. How many arms would a man break if he fell again and rolled down the mountain for an <color=#F3FF00>hour</color>?";
                                helpTask.text = "Remember that one of his hands remained intact!";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Котик сидит, но сесть на место котика не получится. Котик встаёт и уходит, но всё равно вы не можете присесть на место котика. Где котик сидел?";
                                helpTask.text = "Это часть твоего тела! Где же он был???";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The kitten sits, but it will not work to sit in the cat's place The cat gets up and leaves, but still you cannot sit down in the cat's place. Where was the cat sitting?";
                                helpTask.text = "This is part of your body! Where was the cat???";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Z = N\nV = <\n8 = <color=#F3FF00>?</color>";
                                helpTask.text = "Пора размять шею! Поверни голову!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Z = N\nV = <\n8 = <color=#F3FF00>?</color>";
                                helpTask.text = "Time to stretch your neck! Turn your head!";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Замените \"<color=#F3FF00>?</color>\" на правильный ответ:\nН, А, И, <color=#F3FF00>?</color>, Ь, Ь, Ь, Ь, Ь, Ь";
                                helpTask.text = "Посчитай количество элементов. Вслух!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Replace \"<color=#F3FF00>?</color>\" with the correct answer:\nE, O, E, <color=#F3FF00>?</color>, E, X, N, T, E, N";
                                helpTask.text = "Count the number of items. Aloud!";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Как ты думаешь, \nчто будет дальше\n<color=#F3FF00>КТД</color>";
                                helpTask.text = "Посмотри на первую букву каждого нового слова!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What do you think \nwill happen next\n<color=#F3FF00>WDYT</color>";
                                helpTask.text = "Look at the first letter of each new word!";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "В какой ситуации <color=#F3FF00>4</color> котика, <color=#F3FF00>5</color> овец, <color=#F3FF00>3</color> человека, стоя под зонтиком, останутся <color=#F3FF00>сухими</color>?";
                                helpTask.text = "Подумай, какая может быть погода? Так, когда же они будут сухими?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "In what situation will <color=#F3FF00>4</color> cats, <color=#F3FF00>5</color> sheep, <color=#F3FF00>3</color> people, standing under an umbrella, <color=#F3FF00>remain dry</color>?";
                                helpTask.text = "Think about the weather? So when will they dry?";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 904);
                                taskText.margin = new Vector4(40, 53.3f, 40, -333);
                                taskText.text = "В киберспортивном турнире <color=#F3FF00>127</color> команд. В первой стадии турнира <color=#F3FF00>126</color> команд образуют <color=#F3FF00>63</color> пары, победители которых попадут во вторую стадию. <color=#F3FF00>Один</color> везунчик, пройдёт дальше без игры. В третьей стадии - <color=#F3FF00>64</color> команды будут играть <color=#F3FF00>32</color> матча. Напиши количество игр, которые нужно сыграть, чтобы определить победившего!";
                                helpTask.text = "Лааадно. Подскажу! 126 матчей!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 904);
                                taskText.margin = new Vector4(40, 53.3f, 40, -333);
                                taskText.text = "There are <color=#F3FF00>127</color> teams in the eSports tournament. In the first stage of the tournament, <color=#F3FF00>126</color> teams form <color=#F3FF00>63</color> pairs, the winners of each will go to the second stage. <color=#F3FF00>One</color> lucky guy will go on without a game. In the third stage, <color=#F3FF00>64</color> teams will play <color=#F3FF00>32</color> matches. Write down the number of games you need to play to determine the winner!";
                                helpTask.text = "Fine. I will give you a hint! 126 matches!";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 984);
                                taskText.margin = new Vector4(40, 53.3f, 40, -414);
                                taskText.text = "Джон недавно получил водительские права и уже рассекает на своём новом автомобиле по миру! Такое удовольствие он ещё не испытывал! Казалось, что могло пойти не так? Джон немного зазевался и машину повело в крутой занос <color=#F3FF00>вправо</color>. К счастью, он смог вернуть управление и отделался лёгким испугом! Но он задумался, а какое же колесо <color=#F3FF00>не участвовало</color> в заносе?";
                                helpTask.text = "Запасное?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 984);
                                taskText.margin = new Vector4(40, 53.3f, 40, -414);
                                taskText.text = "John recently got his driver's license and is already driving his new car around the world! He had never experienced such pleasure! Seemed what could have gone wrong? John gaped a little and the car started to steep to the <color=#F3FF00>right</color>. Fortunately, he was able to regain control and escaped with a slight fright! But he wondered which wheel <color=#F3FF00>did not participate</color> in the skid?";
                                helpTask.text = "Spare?";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 546);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Ты хочешь, чтобы он зазвучал. Но когда он начинает работать, ты злишься и хочешь, чтобы он перестал это делать. Что это?";
                                helpTask.text = "Ты постоянно его заводишь! Так мерзко звенит постоянно по утрам!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 546);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "You want it to sound. But when it starts working, you get angry and you want him to stop doing it. What is it?";
                                helpTask.text = "You turn it on all the time! It rings so disgustingly in the morning!";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 553);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Летят воробьи. Двое <color=#F3FF00>позади</color> и ещё один <color=#F3FF00>перед</color> ними. При этом один <color=#F3FF00>позади</color> и двое <color=#F3FF00>перед</color> ним. Один находится <color=#F3FF00>между</color> двумя и трое в ряд. \nСколько их было?";
                                helpTask.text = "Совсем запутано? А их трое было!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 553);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Some sparrows are flying. Two are flying <color=#F3FF00>behind</color> and one is flying in <color=#F3FF00>front</color>. In this case, one flies <color=#F3FF00>from behind</color> and two flies <color=#F3FF00>in front</color> of him. One is <color=#F3FF00>between</color> between two and three in a row. \n<color=#F3FF00>How many were there?";
                                helpTask.text = "Very confused? And there were three of them!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "У Бенедикта Камбербэтча это <color=#F3FF00>длинное</color>. У Уилла Смита  <color=#F3FF00>короткое</color>, а Папа Римский этим давно <color=#F3FF00>не пользуется</color>...\nЧто это?";
                                helpTask.text = "Кстати, а тебя как зовут? У тебя же есть ИМЯ?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Benedict Cumberbatch has it <color=#F3FF00>long</color>. Will Smith has it <color=#F3FF00>short</color>, but the Pope <color=#F3FF00>does not use</color> it for a long time...\nWhat is it?";
                                helpTask.text = "By the way, what's your name? Do you have a NAME?";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Если <color=#F3FF00>две</color> тощие и голодные собачки могут съесть <color=#F3FF00>две</color> сочные косточки за <color=#F3FF00>две</color> минуты, то за сколько минут <color=#F3FF00>двадцать</color> голодных собачек управятся с <color=#F3FF00>двадцатью</color> сочными косточками?";
                                helpTask.text = "Мне кажется, что одна собачка справляется с косточкой за две минуты! И даже если их будет сотня, то каждой нужно будет лишь потратить по две минуты!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 562);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "If <color=#F3FF00>two</color> skinny and hungry dogs can eat <color=#F3FF00>two</color> juicy bones in <color=#F3FF00>two</color> two minutes, then in how many minutes will take for <color=#F3FF00>twenty</color> hungry dogs cope with <color=#F3FF00>twenty</color> juicy bones?";
                                helpTask.text = "It seems to me that one dog can handle a bone in two minutes! And even if there are hundreds of them, each will only need to spend two minutes!";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Сколько велосипедов можно собрать, если имеется <color=#F3FF00>322</color> колеса, <color=#F3FF00>154</color> сидений?";
                                helpTask.text = "Я смотрю тебе и руль не нужен! Как же ты без него велосипед сделаешь? Получается не сделаешь! Так каков же ответ?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "How many bicycles can be assembled with <color=#F3FF00>322</color> wheels, <color=#F3FF00>154</color> seats?";
                                helpTask.text = "I see you think the steering wheel is not needed! How can you make a bicycle without it? It turns out you can't do it! So what's the answer?";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Что это за устройство, дающий такой странный ответ? Мы видим на нём \"<color=#F3FF00>4</color>\", но говорим \"<color=#F3FF00>двадцать</color>\"?";
                                helpTask.text = "Не забывай про ЧАСЫ!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What is this device giving such a strange answer? We see \"<color=#F3FF00>4</color>\" on it, but we say  \"<color=#F3FF00>twenty</color>\"?";
                                helpTask.text = "Don't forget the WATCH!";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 685);
                                taskText.margin = new Vector4(40, 53.3f, 40, -108);
                                taskText.text = "Крестьянин прикрепил к <color=#F3FF00>двум лошадям</color> плуг, чтобы пахать поле. Утром, днём и вечером они пахали и наконец-то завершили этот тяжкий труд. По окончании крестьянину стало интересно, а сколько же лошади оставили <color=#F3FF00>следов</color> на поле?";
                                helpTask.text = "Так, представим ситуацию. Лошади идут и оставляют следы. А потом все они сразу стираются. Так сколько следов?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 685);
                                taskText.margin = new Vector4(40, 53.3f, 40, -108);
                                taskText.text = "A peasant attached a plow to <color=#F3FF00>two horses</color> to plow a field. In the morning, afternoon and evening, they plowed and finally completed this hard work. At the end, the peasant wondered how many horses had left <color=#F3FF00>traces</color> on the field?";
                                helpTask.text = "Let's imagine the situation. Horses go and make tracks. And then they are all erased at once. So how many tracks?";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 539);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "У матери Джона было четверо детей. Первого она назвала <color=#F3FF00>понедельник</color>. Второго она назвала <color=#F3FF00>вторник</color>. И третьего она назвала <color=#F3FF00>среда</color>.\n<color=#F3FF00>Как зовут</color> четвётого ребёнка?";
                                helpTask.text = "Джон! Да. Это так просто!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 539);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "John's mother has four children. She named the first <color=#F3FF00>Monday</color>. The second she named <color=#F3FF00>Tuesday</color>, and the third she named <color=#F3FF00>Wednesday</color>.\n<color=#F3FF00>What is the name of the fourth child?";
                                helpTask.text = "John! Yes. It is so simple!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "11=11 14=12 15=10 \n\n16=11 19=12 20=<color=#F3FF00>?</color>";
                                helpTask.text = "Одиннадцать состоит из 11 букв!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "13=8 9=4 15=7 \n\n16=7 19=8 20=<color=#F3FF00>?</color>";
                                helpTask.text = "Eleven has 6 letters!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 586);
                                taskText.margin = new Vector4(40, 53.3f, 40, -22);
                                taskText.text = "Гусь - <color=#F3FF00>2</color>\nЛягушка - <color=#F3FF00>3</color>\nВорона <color=#F3FF00>3</color>\nСова - <color=#F3FF00>4</color>\nЛиса - <color=#F3FF00>6</color>\nКурица - <color=#F3FF00>6</color>\nОсёл - <color=#F3FF00>?</color>";
                                helpTask.text = "А теперь давай будем звучать, как и они! Ква!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 586);
                                taskText.margin = new Vector4(40, 53.3f, 40, -22);
                                taskText.text = "Sheep - <color=#F3FF00>3</color>\nCows - <color=#F3FF00>3</color>\nDonkeys <color=#F3FF00>6</color>\nCats - <color=#F3FF00>4</color>\nMosquitoes - <color=#F3FF00>4</color>\nFrogs - <color=#F3FF00>?</color>";
                                helpTask.text = "Now let's sound like them! Ribbit!";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Какое число лишнее?\n<color=#F3FF00>3467</color>, 1346, <color=#F3FF00>6794</color>, 7946,\n8836, <color=#F3FF00>1236</color>, 9784";
                                helpTask.text = "Сумма цифр этого числа дает нечётное число...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Which number is superfluous?\n<color=#F3FF00>3467</color>, 1346, <color=#F3FF00>6794</color>, 7946,\n8836, <color=#F3FF00>1236</color>, 9784";
                                helpTask.text = "The sum of the digits of this number gives an odd number...";
                            }
                            break;
                        case 21:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Что содержит одни дырки, но всё ещё может удерживать воду?";
                                helpTask.text = "Губка?";
                            }
                            else
                            {

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What contains some holes but can still hold water?";
                                helpTask.text = "Sponge?";
                            }
                            break;
                        case 22:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 553);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Слушай, если ты угостишь меня <color=#FF7600>едой</color>, то я смогу существовать. Только не угощай <color=#00FFF3>водой</color> пожалуйста! Иначе я погибну! Кстати, я потерял память и забыл, как меня называют. <color=#F3FF00>Не подскажешь?</color>";
                                helpTask.text = "Ответ просто ОГОНЬ!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 553);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Listen, if you give me <color=#FF7600>food</color>, then I can exist. Just do not treat me with <color=#00FFF3>water</color>, please! Otherwise I will die! By the way, I lost my memory and forgot what they call me. <color=#F3FF00>Would you answer?</color>";
                                helpTask.text = "The answer is just FIRE!";
                            }
                            break;
                        case 23:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Где идёт сначала весна, а потом зима?";
                                helpTask.text = "Раз ты обратился за помощью... Думаю, что в словаре!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Where does spring come first, and then winter?";
                                helpTask.text = "Since you asked for help... I think it's in the dictionary!";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ScientistsNotes:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Ты жаждешь рассказать <color=#F3FF00>его</color>, когда <color=#F3FF00>его</color> имеешь. Но, если ты поведаешь <color=#F3FF00>его</color> другому, то он сразу пропадёт. Что это?";
                                helpTask.text = "Этот секрет я не могу тебе поведать! Это моя тайна!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "You crave to tell <color=#F3FF00>it</color> when you have <color=#F3FF00>it</color>. But, if you tell <color=#F3FF00>it</color> to another, then he will immediately disappear. What is it?";
                                helpTask.text = "This secret I cannot tell you! This is my secret!";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(19, 53.3f, 19, 15);
                                taskText.text = "Девочка едет в машине с доктором. Но вот парадокс, девочка - дочка доктора, но доктор <color=#F3FF00>не отец</color> девочки. Тогда кто такой доктор?";
                                helpTask.text = "Хорошо. Доктор не отец, а значит кто же ОНА?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 551);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The girl is in the car with the doctor. But here's the paradox, the girl is the doctor's daughter, but the doctor <color=#F3FF00>is not the girl's father</color>. Then who is the doctor?";
                                helpTask.text = "Okay. The doctor is not a father, so who is she?";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Угли могут гореть <color=#00FFF3>под водой</color>. \nГде именно?";
                                helpTask.text = "Не поверишь! Но в подводной лодке! \nХе-хе-хе...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Coals can burn <color=#00FFF3>under water</color>. \nWhere exactly?";
                                helpTask.text = "Won't Believe It! But in a submarine! \nHa-ha-ha...";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Удивительный и необычный <color=#F3FF00>конь</color> совсем не кушает <color=#00B6FF>овес</color>. Почему?";
                                helpTask.text = "Думаю нужно поиграть в шахматы, чтобы ответить на этот вопрос!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "An amazing and unusual <color=#F3FF00>horse</color> does not eat <color=#00B6FF>oats</color> at all. Why?";
                                helpTask.text = "I think you need to play chess to answer this question!";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Это великолепное место отправляет людей на <color=#00FFF3>небеса</color>. Что это за место?";
                                helpTask.text = "Буду краток: аэропорт.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "This great place sends people to <color=#00FFF3>sky</color>.";
                                helpTask.text = "To be brief: airport.";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 546);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Эту конструкцию бросают в том случае, когда это необходимо, и поднимают в том случае, когда ЭТО совсем без надобности. <color=#F3FF00>Что это?</color>";
                                helpTask.text = "Якорь. Якорь? Да точно!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 546);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "This thing is thrown when it is necessary, and raised when it is completely unnecessary. <color=#F3FF00>What is it?</color>";
                                helpTask.text = "Anchor. Anchor? Yes exactly!";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 562);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Мария носила очень странные часы. Никто кроме неё не знал, как они работают! Хотя и пользы от этих знаний было немного... Они показывали правильно только <color=#F3FF00>дважды</color> за <color=#F3FF00>24</color> часа. Почему?";
                                helpTask.text = "А теперь представь, что они остановились! Так каков твой ответ?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 562);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Maria wore a very strange watch. Nobody except her knew how they worked! Although there was little benefit from this knowledge... They showed correctly only <color=#F3FF00>twice</color> in <color=#F3FF00>24</color> hours. Why?";
                                helpTask.text = "Now imagine that they stopped! So what's your answer?";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 546);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Рабочие копали не очень глубокую и маленькую яму. Она была <color=#F3FF00>во все</color> стороны по <color=#F3FF00>30</color> сантиметров. Каков <color=#00FFF3>вес</color> земли, находящийся в ней?";
                                helpTask.text = "Как в яме может находится земля... Ты представляешь как это возможно? Нет? Вот и я нет!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 546);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The workers dug a small pit. It was <color=#F3FF00>30</color> centimeters deep <color=#F3FF00>in all</color> directions. What is the <color=#00FFF3>weight</color> of the ground in the pit?";
                                helpTask.text = "How can there be ground in the pit... Can you imagine how this is possible? No? I have no idea either!";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "25 - <color=#00FFF3>Я</color> \n63 - <color=#00FF49>М</color>\n124 - <color=#F3FF00>?</color>\n217 - <color=#FF7600>А</color>\n345 - Д";
                                helpTask.text = "Давай обратимся к календарю!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "25 - <color=#00FFF3>J</color> \n63 - <color=#00FF49>M</color>\n124 - <color=#F3FF00>?</color>\n217 - <color=#FF7600>A</color>\n345 - D";
                                helpTask.text = "Let's check a calendar!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "3 / 5 = <color=#FF7600>5</color>\n3 / 7 = <color=#FF7600>1</color>\n 7 / 2 = <color=#FF7600>4</color>\n 2 / 5 = <color=#F3FF00>?</color>";
                                helpTask.text = "Всё дело в умножении и толики внимательности!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "3 / 5 = <color=#FF7600>5</color>\n3 / 7 = <color=#FF7600>1</color>\n 7 / 2 = <color=#FF7600>4</color>\n 2 / 5 = <color=#F3FF00>?</color>";
                                helpTask.text = "It's all about multiplication and a little bit of consentration!";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "В одной деревне <color=#F3FF00>никогда не было</color> дождей. Но что-то произошло, и они начали постоянно идти в <color=#F3FF00>8 утра</color>! Через <color=#F3FF00>48</color> часов они закончились, но прекрасной <color=#00B6FF>лунной погоды</color> так и не видно! Почему?";
                                helpTask.text = "Сейчас 8 часов утра!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 528);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "It <color=#F3FF00>never</color> rained in one village. But something happened and rains began starting constantly at <color=#F3FF00>8 am</color>! After <color=#F3FF00>48</color> hours, they ended, but the beautiful <color=#00B6FF>lunar weather</color> is still not visible! <color=#F3FF00>Why?</color>";
                                helpTask.text = "It's 8:00 AM!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 547);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Бутылка с <color=#00FF49>вкусным напитком</color> весит <color=#F3FF00>10 килограмм</color>. Что нужно добавить, чтобы бутылка с <color=#00FF49>вкусным напитком</color> стала весить <color=#FF7600>2 килограмма</color>?";
                                helpTask.text = "Отверстие? Дырку? Дыру? Хм...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "A bottle with <color=#00FF49>a delicious drink</color> weighs <color=#F3FF00>10 kilograms</color>. What needs to be added to make a bottle with <color=#00FF49>a delicious drink</color> weigh <color=#FF7600>2 kilograms</color>?";
                                helpTask.text = "A hole? Hmm...";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 566);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Где впервые нашли <color=#FF7600>морковь</color>?";
                                helpTask.text = "Я редко бываю краток. Но нашли в земле...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 566);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Where was the first <color=#FF7600>carrot</color> found?";
                                helpTask.text = "I am rarely brief. But they found it in the ground...";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Замените \"<color=#F3FF00>?</color>\" на правильный ответ:\n<color=#F3FF00>М31</color>, <color=#F3FF00>А30</color>, <color=#F3FF00>М31</color>, <color=#F3FF00>?</color>";
                                helpTask.text = "И-Ю-Н-Ь";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Replace \"<color=#F3FF00>?</color>\" with the correct answer:\n<color=#F3FF00>M31</color>, <color=#F3FF00>A30</color>, <color=#F3FF00>M31</color>, <color=#F3FF00>?</color>";
                                helpTask.text = "J-U-N-E";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 805);
                                taskText.margin = new Vector4(40, 53.3f, 40, -248);
                                taskText.text = "В одной школьной поликлинике на мед. осмотре врачам надоело, что дети плохо себя ведут, и лезут вперёд друг друга без очереди. Тогда глав. врач придумал хитрый способ научить детей ждать своей очереди, а то и вообще вежливо уступать место на приём. Для этого он давал море конфет, но всего <color=#F3FF00>одному ребёнку. Какому?</color>";
                                helpTask.text = "Последнему пришедшему. Ну или последнему зашедшему!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 805);
                                taskText.margin = new Vector4(40, 53.3f, 40, -248);
                                taskText.text = "In one school clinic, during a medical examination doctors wanted children to calm down and stop misbehaving and pushing each other out of line. Then the chief physician came up with a way to teach children to wait their turn. For this he gave a lot of sweets, but <color=#F3FF00>only to one child. Which child?</color>";
                                helpTask.text = "Last Visitor...";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1030);
                                taskText.margin = new Vector4(40, 53.3f, 40, -476);
                                taskText.text = "Невероятно смелые <color=#00FFF3>лётчики</color>, решили разнообразить свой день и сделали <color=#00FFF3>воздушную кольцевую трассу</color>, по которой они будут <color=#00FF49>летать</color> и выяснять, <color=#00FF49>кто быстрее</color>. Первый лётчик пролетает круг за каких-то <color=#F3FF00>2 минуты</color>. Однако второй лётчик пролетает импровизированный круг за <color=#F3FF00>2 минуты и 3 секунды</color>. Посчитай количество кругов, которое потребуется <color=#00FFF3>второму лётчику</color>, чтобы догнать <color=#00FFF3>первого лётчика</color>.";
                                helpTask.text = "Никогда не догонит... Он же медленнее!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1043);
                                taskText.margin = new Vector4(40, 53.3f, 40, -476);
                                taskText.text = "Incredibly brave <color=#00FFF3>pilots</color>, decided to diversify their day and made <color=#00FFF3>an air ring track</color> along which they will <color=#00FF49>fly</color> and find out <color=#00FF49>who is faster</color>. The first pilot flied a circle in just <color=#F3FF00>2 minutes</color>. However, the second pilot flied an impromptu circle in <color=#F3FF00>2 minutes and 3 seconds</color>. Count the number of laps that the <color=#00FFF3>second pilot</color> needs to catch up with the <color=#00FFF3>first pilot</color>.";
                                helpTask.text = "Impossible! He's slower!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 534);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Всегда. <color=#00FFF3>Каждый день</color> <color=#FF7600>она</color> появляется у твоих ног и преследует тебя везде. Правда <color=#FF7600>она</color> очень сильно боится <color=#F3FF00>солнца</color>. <color=#FF7600>Она</color> едва выживает в <color=#F3FF00>лучах палящего солнца</color>. Кто <color=#FF7600>она</color>?";
                                helpTask.text = "Это тень!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 551);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#00FFF3>Every day</color> <color=#FF7600>it</color> appears at your feet and follows you everywhere. True, <color=#FF7600>it</color> is very much afraid of the <color=#F3FF00>sun</color>. <color=#FF7600>She</color> barely survives in <color=#F3FF00>the rays of the scorching sun</color>. Who <color=#FF7600>is it</color>?";
                                helpTask.text = "It's a shadow!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Тебе, как человеку, дарят это <color=#F3FF00>дважды</color> за всю жизнь <color=#F3FF00>бесплатно</color>. Но, к сожалению, почти у всех людей наступает <color=#F3FF00>третий момент</color> и в этот момент приходится <color=#F3FF00>платить</color>. <color=#F3FF00>Ты же понимаешь о чём я?";
                                helpTask.text = "Если не понимаешь, то спроси у стоматолога!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "You, as a person, are given this <color=#F3FF00>twice</color> in a lifetime for <color=#F3FF00>free</color>. But, unfortunately, almost all people have a <color=#F3FF00>third moment</color> and at this moment they have <color=#F3FF00>to pay</color>. <color=#F3FF00>Do you understand what I mean?</color>";
                                helpTask.text = "If you don't understand, then ask your dentist!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Каждый человек на Земле делает <color=#F3FF00>ЭТО одновременно</color> с другими людьми. \n<color=#F3FF00>Что именно?</color>";
                                helpTask.text = "К сожалению, все стареют...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Every person on Earth does <color=#F3FF00>THIS at the same time</color> as other people. \n<color=#F3FF00>What exactly?</color>";
                                helpTask.text = "Unfortunately, everyone is getting old...";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 573);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Пятеро</color> братьев собрались дома, где <color=#F3FF00>каждый</color> чем-то занят. <color=#00B6FF>Один</color> сидит с планшетом, <color=#00FF49>второй</color> - моей посуду, <color=#00FFF3>третий</color> - играет в шахматы, <color=#FF7600>четвёртый</color> - занимается спортом. \nА чем занимается <color=#F3FF00>пятый</color> брат?";
                                helpTask.text = "Стоп. А с кем это играет третий брат?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 573);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Five</color> brothers gathered at home, <color=#F3FF00>everyone</color> was busy with something.  <color=#00B6FF>The first</color> sits with a tablet, <color=#00FF49>the second</color> washes the dishes, <color=#00FFF3>the third</color> plays chess, <color=#FF7600>the fourth</color> goes in for sports. \n<color=#F3FF00>And what does the fifth brother do?</color>";
                                helpTask.text = "Stop. Who is the third brother playing with?";
                            }
                            break;
                        case 21:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Ты сможешь удержать\n<color=#F3FF00>ЭТО</color>\nтолько без рук. <color=#F3FF00>Что это?</color>";
                                helpTask.text = "А теперь задержи дыхание и напиши ответ!";
                            }
                            else
                            {

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "You can only hold \n<color=#F3FF00>IT</color>\n without hands. <color=#F3FF00>What is it?</color>";
                                helpTask.text = "Now hold your breath and write the answer!";
                            }
                            break;
                        case 22:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 518);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "У этого <color=#F3FF00>животного</color> нет никакой совести! Это <color=#F3FF00>животное</color> спит, не снимая обуви!";
                                helpTask.text = "Должен сказать многие люди верят, что подкова приносит удачу!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 518);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "This <color=#F3FF00>animal</color> has no conscience! This <color=#F3FF00>animal</color> sleeps without taking off his shoes!";
                                helpTask.text = "I have to say, many people believe, that a horseshoe brings good luck!";
                            }
                            break;
                        case 23:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 572);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Однажды в автобусе: \"Джон, я знаю, что ты можешь взять его в <color=#F3FF00>правую ладонь</color>, но ты не способен взять его в <color=#00FF49>левую</color>. Как ты думаешь, что я имею ввиду?\"";
                                helpTask.text = "Свой правый локоть!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 572);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Once on the bus: \"John, I know that you can take it in <color=#F3FF00>the right hand</color>, but you are not able to take it to <color=#00FF49>the left</color>. <color=#F3FF00>Do you think that I mean?</color>\"";
                                helpTask.text = "Your right elbow!";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ExperimentalProcess:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 569);
                                taskText.margin = new Vector4(40, 53.3f, 40, -9);
                                taskText.text = "Внезапно <color=#F3FF00>днём</color> пошёл дождь. Мужчина был <color=#FF7600>без зонтика</color> и ему негде было спрятаться. Добравшись до ближайшего кафе, мужчина был уже полностью <color=#00FFF3>мокрый</color>, но ни одна <color=#F3FF00>волосинка на голове</color> не промокла. Почему?";
                                helpTask.text = "Он был лысым!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 586);
                                taskText.margin = new Vector4(40, 53.3f, 40, -7);
                                taskText.text = "<color=#F3FF00>Suddenly</color> it started raining during the day. The man <color=#FF7600>had no umbrella</color> and had nowhere to hide. When he got to the nearest cafe, the man was already completely <color=#00FFF3>wet</color>, but not a single <color=#F3FF00>hair on his head</color> got wet. Why?";
                                helpTask.text = "He was bald!";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 558);
                                taskText.margin = new Vector4(19, 53.3f, 19, 15);
                                taskText.text = "<color=#FF7600>Бенджамин Франклин</color>, <color=#F3FF00>Шерлок Холмс</color>, <color=#00B6FF>Авраам Линкольн</color>, <color=#00FFF3>Гиппократ</color>, <color=#00FF49>Сократ</color> и <color=#00FF49>Дмитрий Иванович Менделеев</color>.\nПочему <color=#F3FF00>Шерлок Холмс</color> не похож на других?";
                                helpTask.text = "Он выдуманный!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 558);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#FF7600>Benjamin Franklin</color>, <color=#F3FF00>Sherlock Holmes</color>, <color=#00B6FF>Abraham Lincoln</color>, <color=#00FFF3>Hippocrates</color>, <color=#00FF49>Socrates</color> and <color=#00FF49>Dmitri Ivanovich Mendeleev</color>.\nWhy is Sherlock Holmes different?";
                                helpTask.text = "He is fictional!";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Родители Джона живут вместе с <color=#F3FF00>четырьмя</color> своими дочерями, и у каждой есть <color=#F3FF00>один</color> брат! \n<color=#F3FF00>Сколько человек в семье?</color>";
                                helpTask.text = "Так-с, давай считать. Мама и папа. Четыре дочери и брат. \nСколько же их?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "John's parents live with their <color=#F3FF00>four</color> daughters, and each has <color=#F3FF00>one</color> brother! \n<color=#F3FF00>How many people are there in the family?</color>";
                                helpTask.text = "Okay, let's count. Mom and Dad. Four daughters and a brother. \nHow many are there?";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Какой в озере камень?";
                                helpTask.text = "Мокрый.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What is the stone in the lake?";
                                helpTask.text = "Wet? Underwater?";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1200);
                                taskText.margin = new Vector4(40, 53.3f, 40, -640);
                                taskText.text = "Джонни решил сделать кругосветное путешествие на своей новенькой машине! Где он только не побывал! Однажды он заехал на автозаправку. После непродолжительного разговора ему сказали: \"Слушай, Джонни, я оплачу бензин, если скажешь какая <color=#F3FF00>часть</color> твоего автомобиля преодолела <color=#F3FF00>наибольшее</color> расстояние!\". Спустя 10 минут Джонни отправился с улыбкой на всё лицо дальше в путешествие, заполнив свой бак на максимум не отдав ни цента. <color=#F3FF00>Что ответил Джонни?</color>";
                                helpTask.text = "Колесо? Шина?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1200);
                                taskText.margin = new Vector4(40, 53.3f, 40, -640);
                                taskText.text = "Johnny decided to make a trip around the world in his brand new car! He visited a lot of places! One day he stopped by a gas station. After a short conversation, he was told:  \"Listen, Johnny, I'll pay for gasoline if you tell me which <color=#F3FF00>part</color> of your car covered <color=#F3FF00>the longest</color> distance!\". After 10 minutes, Johnny went on a journey with a smile on his face, filling his tank to the maximum and without giving a cent. <color=#F3FF00>What did Johnny say?</color>";
                                helpTask.text = "A wheel? Tire?";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Ты не сможешь сделать этого в космосе. <color=#F3FF00>Что же это?</color>";
                                helpTask.text = "Не думаю, что у тебя получится упасть в космосе! Гравитации-то нет!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "You cannot do this in space. <color=#F3FF00>What is this?</color>";
                                helpTask.text = "I don't think you'll be able to fall in space! There is no gravity!";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "В чём нет в принципе какого-либо содержания, но это всё равно можно видеть?";
                                helpTask.text = "Не подсказка здесь, а дырка от бублика!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What contains nothing, but it is still possible to see?";
                                helpTask.text = "Not a hint here, but a donut hole!";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 681);
                                taskText.margin = new Vector4(40, 53.3f, 40, -108);
                                taskText.text = "<color=#00FF49>Мария</color>, показывая своему другу фотографию, сделанную на море в прошлом году, сказала: \"<color=#00FF49>Сестрички</color> и <color=#00FFF3>братики</color> у меня отсутствуют, но <color=#00FF49>мать</color> того, кто был на этой фотографии была <color=#00FF49>дочерью</color> моего отца\". <color=#F3FF00>Кто был изображен на фотографии?</color>";
                                helpTask.text = "Ох. Что-то часто я тебе помогаю, за просто так... Сын Марии...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 653);
                                taskText.margin = new Vector4(40, 53.3f, 40, -108);
                                taskText.text = "<color=#00FF49>Mary</color>, showing her friend a photo taken at the sea last year, said: \"I have no little <color=#00FF49>sisters</color> and <color=#00FFF3>brothers</color>, but <color=#00FF49>the mother</color> of the one who was in this picture was a <color=#00FF49>daughter</color> of my father\". <color=#F3FF00>Who was shown in the photo?</color>";
                                helpTask.text = "Oh. I think I help you too much for nothing... Son of Mary? Daughter of Mary?";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>bath, angel, bell, alpaca, acrobat</color>";
                                helpTask.text = "Ну что же. Давай посчитаем количество букв в каждом слове!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>bath, angel, bell, alpaca, acrobat</color>";
                                helpTask.text = "Well then. Let's count the number of letters in each word!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Определи, по какому принципу расположены эти цифры:\n<color=#F3FF00>18, 12, 19, 11, 15</color>\nи напиши в правильной последовательности эти цифры\n<color=#F3FF00>16, 13, 17, 14</color>";
                                helpTask.text = "Пора обратиться к алфавиту!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 550);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Determine on what principle these numbers are located:\n<color=#F3FF00>18, 12, 19, 11, 15</color>\nand write these numbers in the correct sequence...\n<color=#F3FF00>16, 13, 17, 14</color>";
                                helpTask.text = "Time to turn to the alphabet!";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Замените \"<color=#F3FF00>?</color>\" на правильный ответ:\n<color=#94FFB3>3</color>, <color=#00B6FF>-9</color>, <color=#00FFF3>36</color>, <color=#00FF49>-180</color>, <color=#F3FF00>?</color>";
                                helpTask.text = "Опять сложная задачка. Помогу я тебе! 1080 твой ответ!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Replace \"<color=#F3FF00>?</color>\" with the correct answer:\n<color=#94FFB3>3</color>, <color=#00B6FF>-9</color>, <color=#00FFF3>36</color>, <color=#00FF49>-180</color>, <color=#F3FF00>?</color>";
                                helpTask.text = "Difficult task again. I will help you! 1080 is your answer!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(20, 53.3f, 30, 15);
                                taskText.text = "Какое слово пропущено? \n<color=#FF0000>Едок</color>, <color=#FF7600>Крем</color>, <color=#F3FF00>Мина</color>, <color=#00FF49>Фара</color>, <color=#00FFF3>. . .</color>, <color=#00FFF3>Пляс</color>, <color=#AD00FF>Носи</color>, <color=#00FF49>Фара</color>?";
                                helpTask.text = "Давай-ка попоём! До-ре-ми...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(20, 53.3f, 30, 15);
                                taskText.text = "What word is missing? \n<color=#FF0000>Dot</color>, <color=#FF7600>Rex</color>, <color=#F3FF00>Mid</color>, <color=#00FF49>Far</color>, <color=#00FFF3>. . .</color>, <color=#00FFF3>Law</color>, <color=#AD00FF>Sir</color>, <color=#00FF49>Far</color>?";
                                helpTask.text = "Let's sing! Do-re-mi...";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1002);
                                taskText.margin = new Vector4(40, 53.3f, 40, -424);
                                taskText.text = "<color=#FF7600>Джонни</color> говорит правду только <color=#F3FF00>один раз</color> в неделю. Интересно, в какой день он был искренен, если <color=#FF7600>Джонни</color> однажды сказал: \"Вы знаете, я люблю лгать в <color=#F3FF00>среду</color> и <color=#F3FF00>четверг</color>\". На следующий день <color=#FF7600>хитрец Джонни</color> сообщил: \"Вы в курсе, что сегодня или <color=#F3FF00>суббота</color>, или <color=#F3FF00>понедельник</color>, или <color=#F3FF00>вторник</color>?\". Ещё спустя день <color=#FF7600>хитрец Джонни</color> сказал: \"Какие же вы доверчивые! Я обожаю лгать по <color=#F3FF00>пятницам</color> и <color=#F3FF00>воскресеньям</color>!\"";
                                helpTask.text = "Первое высказывание было сделано во вторник...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1002);
                                taskText.margin = new Vector4(40, 53.3f, 40, -424);
                                taskText.text = "<color=#FF7600>Johnny</color> only tells the truth <color=#F3FF00>one day</color> a week. I wonder what day he was sincere if <color=#FF7600>Johnny</color> once said: \"You know I love to lie on <color=#F3FF00>Wednesday</color> and <color=#F3FF00>Thursday</color>\". The next day <color=#FF7600>the sly Johnny</color> said: \"Do you know that today is <color=#F3FF00>Saturday</color>, or <color=#F3FF00>Monday</color>, or <color=#F3FF00>Tuesday</color>?\". A day later, the <color=#FF7600>sly Johnny</color> said: \"How gullible you are! I love lying on <color=#F3FF00>Fridays</color> and <color=#F3FF00>Sundays</color>!\"";
                                helpTask.text = "The first statement was made on Tuesday";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "В <color=#F3FF00>1940</color> году ему было всего <color=#00FF49>30</color> лет, а в <color=#F3FF00>1945</color> году <color=#00FF49>25</color> лет. \n<color=#F3FF00>Как это возможно?</color>";
                                helpTask.text = "Ты в каком веке живёшь?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "In <color=#F3FF00>1940</color>, he was <color=#00FF49>30</color> years, and in <color=#F3FF00>1945</color> only <color=#00FF49>25</color> years old. \n<color=#F3FF00>How is this possible?</color>";
                                helpTask.text = "What century are you living in?";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 763);
                                taskText.margin = new Vector4(40, 53.3f, 40, -196);
                                taskText.text = "Аукционер объявил следующие: \"<color=#F3FF00>Cегодня</color> сделка отменяется. Следующая же сделка по расписанию будет в девять часов утра по прошествии <color=#00B6FF>пяти дней</color> со дня, который наступил на <color=#FF7600>четыре дня</color> раньше дня, который будет на день раньше <color=#00FF49>завтра</color>\".\n<color=#F3FF00> Так, когда будет аукцион?</color>";
                                helpTask.text = "Давай завтра подумаем?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 763);
                                taskText.margin = new Vector4(40, 53.3f, 40, -196);
                                taskText.text = "The auctioneer has declared the following: \"<color=#F3FF00>Today</color>, the deal is canceled, next deal will be scheduled at nine o'clock in the morning after <color=#00B6FF>five days</color> from the day that will come <color=#FF7600>four days</color> before the day that is one day earlier <color=#00FF49>tomorrow</color>.\" \n<color=#F3FF00>So when is the auction going to be?</color>";
                                helpTask.text = "Let's think about it tomorrow?";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 733);
                                taskText.margin = new Vector4(40, 53.3f, 40, -206);
                                taskText.text = "У древнего мудреца, что живёт высоко в горах, спросили:\n - Как вы считаете, <color=#00FF49>гениальность</color> является ли <color=#FF7600>болезнью</color>? \n- Однозначно, - ответил мудрец\n - но, к сожалению, <color=#00FF49>очень редкая</color>. \nТак же мудрец с сожалением добавил ещё одно высказывание.\n <color=#F3FF00>Какое?</color>";
                                helpTask.text = "Мудрец знал, что тебе понадобится подсказка. Он также просил передать, что гениальность - болезнь не заразная, так что бояться большинству людей не стоит!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 765);
                                taskText.margin = new Vector4(40, 53.3f, 40, -206);
                                taskText.text = "An ancient sage who lives high in the mountains was asked:\n - Do you think <color=#00FF49>genius</color> is <color=#FF7600>a disease</color>? \n- Definitely, - the sage replied - but, unfortunately, <color=#00FF49>very rare</color>. \nThe sage also added another statement with regret. \n<color=#F3FF00>Which one?</color>";
                                helpTask.text = "The sage knew you would need a hint. He also asked to convey that genius is not a contagious disease, so most people should not be afraid!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 991);
                                taskText.margin = new Vector4(40, 53.3f, 40, -421);
                                taskText.text = "Одна служанка решилась ограбить банк при помощи необычного приспособления. Она зашла в главное здание банка, угрожая <color=#FF7600>электропилой</color>. После этого началась паника, и кассир начал быстро собирать деньги, которые были в банковских ячейках. И всё бы пошло у неё по плану, если бы один очень сообразительный посетитель не заметил одну деталь. \n<color=#F3FF00>Какую деталь заметил посетитель?</color>";
                                helpTask.text = "Служанка была с электропилой, понимаешь? С ЭЛЕКТРОпилой!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 991);
                                taskText.margin = new Vector4(40, 53.3f, 40, -421);
                                taskText.text = "Employee of another bank decided to rob a bank with the help of an unusual device. She entered the main bank building, threatening with an <color=#FF7600>electric saw</color>. After that, panic began, and the cashier began to quickly collect money that was in safe deposit boxes. And everything went according to plan at it, if one very smart visitor had not noticed one detail. \n<color=#F3FF00>What detail did the visitor notice?</color>";
                                helpTask.text = "The employee had an electric saw, you know? WITH ELECTRIC SAW!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 586);
                                taskText.margin = new Vector4(40, 53.3f, 40, -29);
                                taskText.text = "Есть одна <color=#00FF49>дивная вещица</color>, что переплюнет любого путешественника, ведь она способна путешествовать <color=#F3FF00>по всему миру</color>, при этом она находится всё время в одном и том же <color=#FFFF00>углу</color>. <color=#F3FF00>Что же это такое?</color>";
                                helpTask.text = "Спроси у почтальона! ";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 586);
                                taskText.margin = new Vector4(40, 53.3f, 40, -29);
                                taskText.text = "There is one <color=#00FF49>wondrous little thing</color> that surpasses any traveler, because she is able to travel <color=#F3FF00>around the world</color>, while she is all the time in the same <color=#FFFF00>corner</color>. <color=#F3FF00>What is it?</color>";
                                helpTask.text = "Ask the postman!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#00FF49>150</color>  <color=#FF7600>159</color>  <color=#00FF49>195</color>  <color=#F3FF00>?</color>  <color=#FF7600>636</color>";
                                helpTask.text = "Хорошо. Подскажу. Но не полностью! Смотри. \n150 + 3*3 = 159 \n159 + 3*3 + 3*3*3 = 195\nЭто очень просто! Правда?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#00FF49>150</color>  <color=#FF7600>159</color>  <color=#00FF49>195</color>  <color=#F3FF00>?</color>  <color=#FF7600>636</color>";
                                helpTask.text = "Okay. I will give you a hint. But not completely! Look. \n150 + 3*3 = 159 \n159 + 3*3 + 3*3*3 = 195\nIt's very easy! True?";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Однажды в зоопарке в водоём случайно упал <color=#F3FF00>дикобраз</color>, но он не утонул. \n<color=#F3FF00>Почему?</color>";
                                helpTask.text = "Это довольной сложный вопрос, но я на него помогу ответить... Иголки у этого дикобраза были полые!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Once in a zoo, <color=#F3FF00>a porcupine</color> accidentally fell into a pond, but he did not drown? \n<color=#F3FF00>Why?</color>";
                                helpTask.text = "This is a pretty tricky question, but I'll help you answer it... This porcupine had hollow needles!";
                            }
                            break;
                        case 21:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 550);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Филологи долго бились над вопросом какой язык, является родным для наибольшего количества людей. Но в конце концов смогли дать однозначный ответ. \n<color=#F3FF00>Какой?</color>";
                                helpTask.text = "На 2020 год, Китай имеет самое большое население!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 550);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Philologists have long struggled with the question of which language is native to the largest number of people. But in the end they were able to give an unambiguous answer. \n<color=#F3FF00>Which one?</color>";
                                helpTask.text = "For 2020, China has the largest population!";
                            }
                            break;
                        case 22:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1286);
                                taskText.margin = new Vector4(40, 53.3f, 40, -711);
                                taskText.text = "На концерте случайным образом встретились две подруги. Они очень сильно любили задавать забавные задачки друг другу и этот случай не был исключением! Слово за слово и внезапно <color=#F3FF00>Кейт</color> предложила интересную задачку <color=#00FF49>Марии</color>: \"Смотри, у нас есть <color=#F3FF00>11111</color> записанных чисел. Если увеличить каждое число на <color=#F3FF00>2</color>, то произведение всех чисел <color=#F3FF00>не поменяется</color>. Если снова увеличить все числа на <color=#F3FF00>2</color>, то произведение снова <color=#F3FF00>не поменяется</color>! \n<color=#F3FF00>Сколько максимально раз я могу повторить эту операцию и число при этом не изменится?</color>\"";
                                helpTask.text = "Давай я подскажу диапазон чисел, в котором нужно решать?\n От -11110 до 0! \nСмотри сюда \n-11110*-11108...*0=0";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1286);
                                taskText.margin = new Vector4(40, 53.3f, 40, -711);
                                taskText.text = "At the concert, two friends met by chance. They were very fond of asking funny problems to each other and this case was no exception! Word for word, and suddenly <color=#F3FF00>Kate</color> proposed an interesting task to <color=#00FF49>Maria</color>: \"Look, we have <color=#F3FF00>11111</color> written numbers. If we increase each number by <color=#F3FF00>2</color>, then the product of all numbers <color=#F3FF00>will not change</color>. If we increase all the numbers by <color=#F3FF00>2</color> again, the product <color=#F3FF00>will not change</color> again!! \n<color=#F3FF00>What is the maximum number of repetitions of this operation at which this number will not change?</color>\"";
                                helpTask.text = "Let me tell you the range of numbers in which to solve. From -11110 to 0! \nLook here\n-11110*-11108...*0=0";
                            }
                            break;
                        case 23:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 969);
                                taskText.margin = new Vector4(40, 53.3f, 40, -418);
                                taskText.text = "У богатого человека была вечеринка, гости веселились, а заморские вина разливались на каждом углу. Когда вечеринка была окончена человек решил, что будет убирать последствия завтра и нажал на выключатель света, <color=#F3FF00>но свет почему-то не погас</color>. Это удивило его. Тогда он решил выкрутить эту бракованную лампочку, но лампочка <color=#F3FF00>продолжала светиться</color>. <color=#F3FF00>Почему?</color>";
                                helpTask.text = "Лампочка была не бракованная! Просто она была в люминесцентной краске!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 987);
                                taskText.margin = new Vector4(40, 53.3f, 40, -418);
                                taskText.text = "The rich man was having a party, guests were having fun, and overseas wines were poured on every corner. When the party was over, the man decided that he would remove the consequences tomorrow and pressed the light switch, <color=#F3FF00>but for some reason the light did not go out</color>. This surprised him, but then he decided to unscrew this defective bulb, but the bulb <color=#F3FF00>continued to glow</color>. <color=#F3FF00>Why?</color>";
                                helpTask.text = "The bulb was not defective! She was just in luminescent light bulb!";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.AcademicDegree:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 740);
                                taskText.margin = new Vector4(40, 53.3f, 40, -166);
                                taskText.text = "Много <color=#F3FF00>животных</color> добивались чего-то великого, <color=#F3FF00>зайцам</color> и <color=#F3FF00>лабораторным крысам</color>, те кто летали в космос или просто <color=#F3FF00>домашние питомцы</color>. Но есть одно <color=#F3FF00>животное</color>. Лидер среди всех животных и ему ставят памятники больше всех! \n<color=#F3FF00>Кто же это?</color>";
                                helpTask.text = "Учёные разделяют пять царств живых организмов, если ты не в курсе! Это Животные, Растения, Грибы, Вирусы и Бактерии! Человек вроде не Растение. Да и на Гриб с Вирусом не похож. И уж точно человек не является Бактерией. Что же получается? \nЧеловек - животное?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 700);
                                taskText.margin = new Vector4(40, 53.3f, 40, -166);
                                taskText.text = "Many <color=#F3FF00>animals</color> achieved something great, <color=#F3FF00>hares</color> and <color=#F3FF00>laboratory rats</color>, those who flew into space or just <color=#F3FF00>pets</color>. But there is one <color=#F3FF00>animal</color>. The leader among all animals and monuments are erected to him the most! \n<color=#F3FF00>Who is this?</color>";
                                helpTask.text = "Scientists share five kingdoms(someone 6) of living organisms, if you are not aware! These are Animalia(Animals), Plantae(Plant), Fungi, Protista(Viruses) and Monera(Bacteria)! Human is not like a plant. And it doesn't look like a Mushroom with a Virus. And certainly a human is not a Bacteria. So what happens? Is human an animal?";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 677);
                                taskText.margin = new Vector4(19, 53.3f, 19, -106);
                                taskText.text = "В штате <color=#F3FF00>Аризона</color> полиция прислала отряд для охраны <color=#F3FF00>пустыни</color> от воров. Казалось бы, что в <color=#F3FF00>пустыне</color> особо нечего воровать, но они забирают ту вещь, без которой <color=#F3FF00>пустыня</color> почти запустеет и опустошится. \n<color=#F3FF00>Что воруют разбойники?</color>";
                                helpTask.text = " А ты чего ожидаешь? Странные разбойники воруют кактусы!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 677);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "In the state of <color=#F3FF00>Arizona</color>, the police sent a detachment to guard the <color=#F3FF00>desert</color> from thieves. It would seem that there is nothing much to steal in the <color=#F3FF00>desert</color>, but they take that thing without which the <color=#F3FF00>desert</color> will almost become desolate and empty. \n<color=#F3FF00>What are the robbers stealing?</color>";
                                helpTask.text = "Strange robbers are stealing cactus! What did you expect?";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 555);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "На космической станции узнали, что космонавт кое-что потерял в полёте, но это никого не испугало и это считается даже нормальным. \n<color=#F3FF00>Что потерял космонавт?</color>";
                                helpTask.text = "Кстати, сколько ты весишь?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 555);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "At the space station learned that the astronaut lost something in flight, but this did not frighten anyone and it is considered even normal. What has the astronaut lost?";
                                helpTask.text = "By the way, how much do you weigh?";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Футбольный фанат гадает, а что же <color=#F3FF00>использовали</color> футбольные судьи до того, как стали использовать <color=#00FF49>свисток</color>.";
                                helpTask.text = "Я смотрю, ты тоже гадаешь, но никак не поймёшь, что использовали колокольчик. Я был в шоке, когда узнал!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The football fan is wondering what the football referees <color=#F3FF00>used</color> before they started using <color=#00FF49>the whistle</color>.";
                                helpTask.text = "I see you're wondering too, but you never know you used a bell. I was shocked when I found out!";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Каким приспособлением древние римляне <color=#F3FF00>мололи</color> муку?";
                                helpTask.text = "Хмм... А ничего, что мука уже перемолота?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "With what tool did the ancient Romans <color=#F3FF00>grind</color> flour?";
                                helpTask.text = "Hmm... is it okay that the flour has already been ground?";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Какое слово здесь лишнее?\n<color=#00B6FF>ПЛАТИНА</color> <color=#00B6FF>СЕРЕБРО</color> <color=#00FFF3>ОЗОН</color>\n <color=#F3FF00>ЗОЛОТО</color> <color=#00B6FF>РТУТЬ</color> <color=#00FF49>КРИПТОН</color>";
                                helpTask.text = "Давай-ка заглянем в периодическую таблицу химических элементов...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What word is superfluous here?\n<color=#00B6FF>PLATINUM</color> <color=#00B6FF>SILVER</color> <color=#00FFF3>OZONE</color>\n <color=#F3FF00>GOLD</color> <color=#00B6FF>MERCURY</color> <color=#00FF49>KRYPTON</color>";
                                helpTask.text = "Let's take a look at the periodic table!";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 735);
                                taskText.margin = new Vector4(40, 53.3f, 40, -183);
                                taskText.text = "Молодой джентльмен собирал вещи завтра на работу. Сегодня градусник показывает значение погоды <color=#00FFF3>0°C</color>. Но как же молодой джентльмен удивился, когда по прогнозу погоды передали, что температура завтра увеличится в <color=#FF7600>два раза</color>. \n<color=#F3FF00>Какая температура будет завтра?</color>";
                                helpTask.text = "Противостояние Цельсия и Фаренгейта!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 735);
                                taskText.margin = new Vector4(40, 53.3f, 40, -183);
                                taskText.text = "The young gentleman was packing his things for work tomorrow. Today, the thermometer indicates a value weather <color=#00FFF3>0°C</color> . But how surprised the young gentleman was when according to the weather forecast it was reported that the temperature would <color=#FF7600>double</color> tomorrow. \n<color=#F3FF00>What temperature will it be tomorrow?</color>";
                                helpTask.text = "Celsius versus Fahrenheit!";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Что за вещь, которую никогда не получится поднять с пола за кончик?";
                                helpTask.text = "Коты любят с этим играться. Ещё это используют при вязании одежды!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "What kind of thing can never be picked up from the floor by the tip?";
                                helpTask.text = "Cats love to play with it. It is also used when knitting clothes!";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Один экстремал решил прыгнуть из самолета <color=#00FFF3>без парашюта</color>. Он приземляется на асфальт, но остаётся <color=#00FF49>без единой царапинки</color>. <color=#F3FF00>Почему?</color>";
                                helpTask.text = "Ох уж этот экстремал! Не каждый сможет прыгнуть без парашюта, когда самолёт стоит на земле!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "One extreme athlete decided to jump out of the plane <color=#00FFF3>without a parachute</color>. He lands on the asphalt, but remains <color=#00FF49>without a scratch</color>. <color=#F3FF00>Why?</color>";
                                helpTask.text = "Not everyone can jump without a parachute when the plane is on the ground!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 582);
                                taskText.margin = new Vector4(40, 53.3f, 40, -31);
                                taskText.text = "Давным-давно в древности ещё до нашей эры один летописец составил <color=#F3FF00>список</color>, и этот <color=#F3FF00>список</color> до сих пор остался <color=#00FFF3>неизменным</color>, хотя было множество попыток изменить этот <color=#F3FF00>список</color>. \n<color=#00FFF3>Что за список такой?</color>";
                                helpTask.text = "Сколько чудес света существует?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 595);
                                taskText.margin = new Vector4(40, 53.3f, 40, -31);
                                taskText.text = "A long time ago, in antiquity, before our era, a chronicler made <color=#F3FF00>a list</color> and this <color=#F3FF00>list</color> has remained <color=#00FFF3>unchanged</color> to this day, although there have been many attempts to change this <color=#F3FF00>list</color>. \n<color=#00FFF3>What kind of list is this?</color>";
                                helpTask.text = "How many Wonders of the Ancient World are there?";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 893);
                                taskText.margin = new Vector4(40, 53.3f, 40, -344);
                                taskText.text = "Как-то раз в 18 веке олимпийский бегун был на соревнованиях по бегу. На соревнованиях все его конкуренты принимали положение стоя на старте и ждали команды начать бег, а наш герой истории решил начать забег с низкого старта и <color=#F3FF00>выиграл</color>! Он научился этому наблюдая за <color=#F3FF00>животным</color>. \n<color=#F3FF00>За каким животным наблюдал наш герой?</color>";
                                helpTask.text = "Это животное из Австралии и передвигается длинными прыжками!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 893);
                                taskText.margin = new Vector4(40, 53.3f, 40, -344);
                                taskText.text = "Once in the 18th century, an Olympic runner was in a running competition. At the competition, all his competitors took a standing position at the start and waited for the command to start running, and our hero of history decided to start the race from a low start and <color=#F3FF00>won</color>! He learned this by observing <color=#F3FF00>animals</color>. \n<color=#F3FF00>What animal was our hero watching?</color>";
                                helpTask.text = "This animal is from Australia and moves in long leaps!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 670);
                                taskText.margin = new Vector4(40, 53.3f, 40, -102);
                                taskText.text = "Одна девушка решила рассказать о той странной картине, которой ей пришлось наблюдать. Она увидела <color=#00FFF3>некое создание</color>, что имело <color=#F3FF00>две головы</color>, <color=#F3FF00>пару рук</color> и <color=#F3FF00>три пары ног</color>, но в ходьбе принимают участие только <color=#F3FF00>четыре</color>. \n<color=#F3FF00>Что за создание увидела она?</color>";
                                helpTask.text = "Согласись, интересное описание для всадника на лошади!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 670);
                                taskText.margin = new Vector4(40, 53.3f, 40, -102);
                                taskText.text = "One girl decided to tell about the strange picture she had to observe. She saw <color=#00FFF3>a creature</color> that had <color=#F3FF00>two heads</color>, <color=#F3FF00>a pair of arms</color> and <color=#F3FF00>three pairs of legs</color>, but only <color=#F3FF00>four</color> take part in walking. \n<color=#F3FF00>What kind of creature did she see?</color>";
                                helpTask.text = "Agree, an interesting description for a rider on a horse!";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1133);
                                taskText.margin = new Vector4(40, 53.3f, 40, -553);
                                taskText.text = "Джонни отличный водитель, он едет по дороге, на которой ограничение по скорости в <color=#F3FF00>90 км/ч</color>. Джонни абсолютно трезвый, и при нём есть все необходимые документы <color=#00FFF3>(права, паспорт и даже страховка)</color>. Джонни даже использует ремень безопасности и не едет на скорости выше <color=#F3FF00>40 км/ч</color>. Не смотря на всё это Джонни все же был <color=#F3FF00>оштрафован</color>.  \n<color=#F3FF00>Почему?</color> \n<color=#F3FF00>За что оштрафовали такого осторожного водителя как Джонни?</color>";
                                helpTask.text = "Джонни не соблюдал ВСЕ правила! Да и водители, которые ехали ему на встречу, были слегка недовольны, поведением Джонни!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1133);
                                taskText.margin = new Vector4(40, 53.3f, 40, -553);
                                taskText.text = "Johnny is a great driver, he drives on a road that has a speed limit of<color=#F3FF00> 90 km per hour</color>. Johnny is absolutely sober, and he has all the necessary documents <color=#00FFF3>(driving license, passport and even insurance)</color>. Johnny even uses a seat belt and does not travel at speeds higher than <color=#F3FF00>40 km per hour</color>. Despite all this, Johnny was still <color=#F3FF00>fined.</color>. \n<color=#F3FF00>Why? \nWhy was such a careful driver like Johnny fined?</color>";
                                helpTask.text = "Johnny didn't follow ALL the rules! And the drivers who drove to his meeting were slightly unhappy with Johnny's behavior!";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 660);
                                taskText.margin = new Vector4(40, 53.3f, 40, -86);
                                taskText.text = "Один сорванец, гуляющий по рельсам, вдруг услышал, что <color=#F3FF00>приближается скоростной поезд</color>. Чтобы не умереть под поездом, наш герой спрыгнет с рельсов, но сначала он берёт и бежит метров пять <color=#F3FF00>навстречу</color> поезду. \n<color=#F3FF00>Зачем?</color>";
                                helpTask.text = "Он выбегал из туннеля... Это же очевидно! Не понимаю, как тут можно не понять такой просто вещи!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 660);
                                taskText.margin = new Vector4(40, 53.3f, 40, -86);
                                taskText.text = "One tomboy was walking on the rails while suddenly heard that <color=#F3FF00>a high-speed train was approaching</color>. In order not to die under the train, our hero would jump off the rails, but first he takes and runs about five meters <color=#F3FF00>towards</color> the train. \n<color=#F3FF00>What for?</color>";
                                helpTask.text = "He ran out of the tunnel... It's obvious! I don't understand how you can not understand such a simple thing!";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 567);
                                taskText.margin = new Vector4(40, 53.3f, 40, -15);
                                taskText.text = "Одной девушке удалось получить меньший вес за <color=#F3FF00>пару дней</color>, просто взвесившись в особом месте на Земле. \n<color=#F3FF00>Что это за место?</color>";
                                helpTask.text = "Кстати, на экваторе есть ледник высотой 4,5 километра над уровнем моря...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 513);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "One girl managed to gain less weight in <color=#F3FF00>a couple of days</color> by simply weighing herself in a special place on Earth. \n<color=#F3FF00>What kind of place is it?</color>";
                                helpTask.text = "By the way, there is a glacier on the EQUATOR with a height of 4.5 kilometers above sea level...";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 738);
                                taskText.margin = new Vector4(40, 53.3f, 40, -173);
                                taskText.text = "Одному писателю в далёком прошлом среди ночи пришло вдохновение и ему срочно нужно было заканчивать писать мемуары. Он заходит в свой кабинет, чтобы продолжить работу и там из <color=#F3FF00>источников света</color> находится <color=#FF7600>свечка</color> и <color=#FF7600>факел</color>. \n<color=#F3FF00>Что писатель зажжет первым?</color>";
                                helpTask.text = "Мы, конечно, живём в современном мире с лампочками, но мне кажется, что ты знаешь, что такое спичка!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 738);
                                taskText.margin = new Vector4(40, 53.3f, 40, -173);
                                taskText.text = "One writer in the distant past in the middle of the night came to inspiration and he urgently needed to finish writing his memoirs. He enters his office to continue his work and there is <color=#FF7600>a candle</color> and <color=#FF7600>a torch</color> from <color=#F3FF00>light sources</color>. \n<color=#F3FF00>What does the writer light up first?</color>";
                                helpTask.text = "We, of course, live in a digital world with light bulbs, but it seems to me that you know what a match is!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 742);
                                taskText.margin = new Vector4(40, 53.3f, 40, -190);
                                taskText.text = "В далёкие времена. Один не очень известный ковбой привязал <color=#F3FF00>5 метровую верёвку</color> к своей лошади, но после того, как сходил в салун обнаружил, что его лошадь смогла уйти по прямой на <color=#F3FF00>50 метров</color>. \n<color=#F3FF00>Как ей это удалось, если учесть, что лошадь и верёвка были абсолютно невредимы?</color>";
                                helpTask.text = "А вот старик, который наблюдал в это время за лошадью, увидел, что ковбой просто забыл привязать лошадь!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 742);
                                taskText.margin = new Vector4(40, 53.3f, 40, -190);
                                taskText.text = "In ancient times. In the days of cowboys, one not-so- famous cowboy tied <color=#F3FF00>a 5 meter rope</color> to his horse, but after going to the saloon, he found that his horse was able to walk <color=#F3FF00>50 meters</color> in a straight line. \n<color=#F3FF00>How she did it, when you consider that a horse and a rope was and completely unharmed?</color>";
                                helpTask.text = "But the old man who was watching the horse at that time saw that the cowboy simply forgot to tie the horse!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 596);
                                taskText.margin = new Vector4(40, 53.3f, 40, -22);
                                taskText.text = "У химиков есть одно странное <color=#00FF49>секретное вещество</color>, которое обладает свойством того, что <color=#F3FF00>не горит в огне</color>, но на этом его причуды не заканчиваются, оно ещё и <color=#00FFF3>в воде не тонет</color>. \n<color=#F3FF00>Что это?</color>";
                                helpTask.text = "Подсказка заморожена. ";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 551);
                                taskText.margin = new Vector4(40, 53.3f, 40, -22);
                                taskText.text = "Chemists have one strange <color=#00FF49>secret substance</color>, which has the property of <color=#F3FF00>not burning in fire</color>, but his quirks do not end there, it also <color=#00FFF3>does not sink in water</color>. \n<color=#F3FF00>What is it?</color>";
                                helpTask.text = "Hint is frozen!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 536);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Социологи были озадачены вопросом какую руку использовать лучше, чтобы размешать чай? <color=#F3FF00>\nОтвет оказался однозначным. \nКакой?</color>";
                                helpTask.text = "Той в которой ложка";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 536);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Sociologists have been puzzled by the question which hand is the best to use to stir tea? <color=#F3FF00>\nThe answer was unambiguous. \nWhich one?</color>";
                                helpTask.text = "The one in which the spoon is...";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 607);
                                taskText.margin = new Vector4(40, 53.3f, 40, -37);
                                taskText.text = "В древности существовала легенда, о невидимом существе в пещере. Его никто не видел, но все слышали, как оно говорило. И говорило невидимое существо на всех языках! <color=#F3FF00>Учёные современности давно смогли понять, что это...</color>";
                                helpTask.text = "Подсказки-сказки-сказки нет-ет-ет!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 566);
                                taskText.margin = new Vector4(40, 53.3f, 40, -37);
                                taskText.text = "In ancient times, there was a legend about an invisible creature in a cave. Nobody saw it, but everyone heard it speak. And the invisible creature spoke in all languages! <color=#F3FF00>Scientists of our time have long been able to understand that this is...</color>";
                                helpTask.text = "No-o-o-o \nHint-int-int-t";
                            }
                            break;
                        case 21:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Есть пара <color=#F3FF00>загадочных величин</color>, у которых не имеется <color=#00FF49>длины</color>, не присутствует <color=#00FFF3>глубины</color>, <color=#FF7600>размерности ширины</color>, а также <color=#00B6FF>высоты</color>, но при этом их <color=#F3FF00>можно</color> измерить. <color=#F3FF00>Что это за величины?</color>";
                                helpTask.text = "Прости, но на подсказки нет времени! Мне нужно узнать какая температура будет завтра!";
                            }
                            else
                            {

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 540);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "There are a couple of <color=#F3FF00>mysterious quantities</color> that do not have <color=#00FF49>length</color>, <color=#00FFF3>depth</color>, <color=#FF7600>dimensions of width</color>, and <color=#00B6FF>height</color>, but they <color=#F3FF00>can be</color> measured. <color=#F3FF00>What is it?</color>";
                                helpTask.text = "Sorry, but there is no time for hints! I need to know what the temperature will be tomorrow!";
                            }
                            break;
                        case 22:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 535);
                                taskText.margin = new Vector4(40, 53.3f, 40, 19);
                                taskText.text = "1/1\n3/2\n7/5\n17/12\n41/29\n<color=#F3FF00>?</color>/<color=#F3FF00>?</color>";
                                helpTask.text = "Знаменатель каждой следующей дроби равен сумме числителя и знаменателя предыдущей. А числитель равен сумме знаменателей текущей дроби и предыдущей.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 535);
                                taskText.margin = new Vector4(40, 53.3f, 40, 19);
                                taskText.text = "1/1\n3/2\n7/5\n17/12\n41/29\n<color=#F3FF00>?</color>/<color=#F3FF00>?</color>";
                                helpTask.text = "The denominator of each next fraction is equal to the sum of the numerator and the denominator of the previous one. And the numerator is equal to the sum of the denominators of the current fraction and the previous one.";
                            }
                            break;
                        case 23:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1606);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1034);
                                taskText.text = "Джон должен был разбить концертный зал на <color=#F3FF00>четыре участка</color>. Причём максимальное количество людей для <color=#F3FF00>первых трёх участков</color> было известно! \n<color=#00FF49>Первый участок</color> для <color=#F3FF00>VIP-персон</color> мог вместить в себя всего лишь <color=#F3FF00>13 человек</color>. \n<color=#00FFF3>Второй участок</color> по соседству уже вмещает <color=#F3FF00>17 человек</color>. \n<color=#FF7600>Третий участок</color> <color=#F3FF00>31 человека</color>. \n<color=#F3FF00>Четвёртый участок</color> вмещает уже достаточно много людей, вот только никто не собирается сообщать сколько именно. А те, кто зайдёт на участок и превысит лимит будет <color=#FF7600>оштрафован на солидную сумму</color>. \n<color=#F3FF00>Интересно, сколько же помещается людей на четвёртом участке?</color>";
                                helpTask.text = "Данная последовательность включает в себя лишь простые числа. Причём такие числа, которые если прочитать с конца, также являются простыми числами. Таким образом для каждого просто числа в последовательности есть пара.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1600);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1034);
                                taskText.text = "John had to divide the concert hall into <color=#F3FF00>four sections</color>. Moreover, the maximum number of people for <color=#F3FF00>the first three sections</color> was known! \n<color=#00FF49>The first section</color> for <color=#F3FF00>VIP-persons</color> could accommodate only <color=#F3FF00>13 people</color>. \n<color=#00FFF3>The second</color> section next door already accommodates <color=#F3FF00>17 people</color>. \n<color=#FF7600>The third</color> section is <color=#F3FF00>31 people</color>. \n<color=#F3FF00>The fourth section</color> already accommodates a lot of people, but no one is going to say how many. And those who enter the section and exceed the limit will be <color=#FF7600>fined a substantial amount</color>. \n<color=#F3FF00>I wonder how many people fit in the fourth section?</color>";
                                helpTask.text = "This sequence includes only prime numbers. Moreover, such numbers, which, if read from the end, are also prime numbers. Thus, for each simple number in the sequence, there is a pair.";
                            }
                            break;
                        case 24:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1148);
                                taskText.margin = new Vector4(40, 53.3f, 40, -573);
                                taskText.text = "Каждый наступающий Новый год, начиная с самого начала <color=#F3FF00>нашей эры</color>, <color=#FF7600>бессмертный вампир Владимир</color>, который, кстати, <color=#F3FF00>до сих пор живой</color>, записывает на стене поздравления. При этом структура поздравления остаётся неизменной и сейчас. Она очень проста: \n<color=#00FFF3>\"С 1 Новым годом\"</color>, <color=#00FFF3>\"С 2 Новым годом\"</color>, <color=#00FFF3>\"С 3 Новым годом\"</color> и т.д., <color=#00FFF3>\"С 2019 Новым годом\"</color>, <color=#00FFF3>\"С 2020 Новым годом\"</color>. \n<color=#F3FF00>Какую цифру наш вампир использовал реже всего?</color>";
                                helpTask.text = "До 1000-го года все цифры были бы использованы одинаковое количество раз. ";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1148);
                                taskText.margin = new Vector4(40, 53.3f, 40, -573);
                                taskText.text = "Every coming New Year, starting from the very beginning <color=#F3FF00>of our era</color>, <color=#FF7600>the immortal vampire Vladimir</color>, who, by the way, <color=#F3FF00>is still alive</color>, writes congratulations on the wall. At the same time, the structure of the congratulation remains unchanged now. It is very simple: \n<color=#00FFF3>\"Happy New Year 1\", \"Happy New Year 2\"Happy New Year 3\"</color>, etc., <color=#00FFF3>\"Happy New Year 2019 \" \"Happy New Year 2020\"</color>. \n<color=#F3FF00>What number did our vampire use least often?</color>";
                                helpTask.text = "Before the 1000th year and all the nums would have been used the same amount of times.";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.SimpleLever:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "В сарае было <color=#F3FF00>15</color> поросят, <color=#F3FF00>6</color> баранов, <color=#F3FF00>10</color> котят. В сарай вошли шериф с женой. \n<color=#F3FF00>Посчитай количество ног в сарае.</color>";
                                helpTask.text = "Посчитай количество НОГ в сарае! Давай. Ты справишься!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 536);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "In the barn there were <color=#F3FF00>15</color> pigs, <color=#F3FF00>6</color> rams <color=#F3FF00>10</color> kittens. The sheriff and his wife entered the barn. \n<color=#F3FF00>Count the number of legs in the barn.</color>";
                                helpTask.text = "Count the number of LEGS in the barn! Come on. You can handle it!";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(19, 53.3f, 19, 15);
                                taskText.text = "В комнате интересного <color=#F3FF00>дизайнера</color> и <color=#F3FF00>архитектора</color> было <color=#FF7600>6</color> углов. <color=#FF7600>В каждом</color> углу лежит <color=#00FF49>собака</color>. Напротив каждой <color=#00FF49>собаки</color> по <color=#FF7600>пять</color> <color=#00FF49>собак</color>. Сколько <color=#00FF49>собак</color> в загадочной комнате?";
                                helpTask.text = "Их столько же сколько и углов!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 12);
                                taskText.text = "The room of an interesting <color=#F3FF00>designer</color> and <color=#F3FF00>architect</color> had <color=#FF7600>6</color> corners. There is <color=#00FF49>a dog</color> <color=#FF7600>in every corner</color>. Opposite each <color=#00FF49>dog</color> there are <color=#FF7600>five</color> <color=#00FF49>dogs</color>. How many <color=#00FF49>dogs</color> are there in the mystery room?";
                                helpTask.text = "There are as many dogs as there are corners!";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 582);
                                taskText.margin = new Vector4(40, 53.3f, 40, -32);
                                taskText.text = "В поединке-марафоне участвовало две самые быстрые команды в мире. Первая команда добралась до финиша за <color=#F3FF00>1 час</color> и <color=#F3FF00>40 минут</color> в то время, как вторая команда смогла справиться за <color=#F3FF00>100 минут. \nКакая у них была скорость?</color>";
                                helpTask.text = "1 час и 40 минут равняются 100 минутам. Не так ли?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 582);
                                taskText.margin = new Vector4(40, 53.3f, 40, -32);
                                taskText.text = "The two fastest teams in the world participated in the marathon duel. The first team reached the finish line in <color=#F3FF00>1 hour</color> and <color=#F3FF00>40 minutes</color>, while the second team was able to complete it in <color=#F3FF00>100 minutes. \nWhat was their speed?</color>";
                                helpTask.text = "1 hour and 40 minutes equals 100 minutes. Is not it?";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Ты ложишься спать в <color=#F3FF00>7 часов</color> вечера, и ты решаешь завести механический будильник на <color=#F3FF00>10 часов</color> утра. \n<color=#F3FF00>Сколько ты будешь спать?</color>";
                                helpTask.text = "А теперь представь себе вот этот круглый будильник. По-моему, там только 12 часов!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "You go to bed at <color=#F3FF00>7 pm</color> and you decide to start <color=#F3FF00>a mechanical alarm</color> at <color=#F3FF00>10 am. \nHow long will you sleep?</color>";
                                helpTask.text = "Now imagine this round alarm clock. I think it's only 12 hours there!";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 803);
                                taskText.margin = new Vector4(40, 53.3f, 40, -255);
                                taskText.text = "Внезапно ты оказываешься на корабле возле <color=#FF6100>Марса</color>. И вот перед тобой появляется <color=#00FFF3>голографическое табло</color>, и ты видишь информацию о <color=#F3FF00>двух</color> участвующих! <color=#00FF49>Пит</color> пролетает вокруг Марса за <color=#F3FF00>9 минут</color>, а <color=#00FFF3>Дейв</color> за 6 минут! Но тебя это уже не волнует, тебе стало интересно <color=#F3FF00>через сколько минут <color=#00FFF3>Дейв</color> обгонит <color=#00FF49>Пита</color>, если гонка только началась?</color>";
                                helpTask.text = "Дэйв пролетит 3 раза вокруг Марса, а Пит всего лишь 2 раза!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 827);
                                taskText.margin = new Vector4(40, 53.3f, 40, -255);
                                taskText.text = "Suddenly you are on a ship near <color=#FF6100>Mars</color>. And now <color=#00FFF3>a holographic display</color> appears in front of you, and you see information about <color=#F3FF00>two</color> participants! <color=#00FF49>Pete</color> flies around <color=#FF6100>Mars</color> in <color=#F3FF00>9 minutes</color> and <color=#00FFF3>Dave</color> in <color=#F3FF00>6 minutes</color>! But you don't care anymore, you wondered in <color=#F3FF00>how many minutes <color=#00FFF3>Dave</color> will overtake <color=#00FF49>Pete</color> if the race has just begun?</color>";
                                helpTask.text = "Dave will fly 3 times around Mars and Pete only 2 times!";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Изначально у хозяина фермы было <color=#F3FF00>24</color> яблока. <color=#F3FF00>Сколько у него осталось</color>, если количество отданных яблок в <color=#F3FF00>два раза</color> превышает количество оставшихся?";
                                helpTask.text = "24-8=16 \n16 - в два раза превышает какое число?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 560);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Initially, the owner of the farm had <color=#F3FF00>24</color> apples. <color=#F3FF00>How much does he have left</color> if the number of apples given is <color=#F3FF00>twice</color> the number of the remaining?";
                                helpTask.text = "24-8 = 16 \n16 - twice the number?";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 558);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "У продавца есть сыр длиной в <color=#F3FF00>21</color> метр. Каждый день продавец отрезает по <color=#F3FF00>3</color> метра. В какой день продавец <color=#F3FF00>отрежет последний кусок сыра</color>?";
                                helpTask.text = "И всё-таки это 6 дней! Кстати, а почему?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 558);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "The seller has a piece of cheese <color=#F3FF00>21</color> meters long. Every day the seller cuts off <color=#F3FF00>3</color> meters. What day will the seller <color=#F3FF00>cut the last piece of cheese?</color>";
                                helpTask.text = "It's still 6 days! By the way, why?";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 743);
                                taskText.margin = new Vector4(40, 53.3f, 40, -197);
                                taskText.text = "Один ковбой в Америке спросил: \"Вот смотри, дату <color=#F3FF00>3 сентября 2004</color> года у нас используют такой формат как: <color=#00FF49>9/3/2004</color>, а в других странах иначе: <color=#00FFF3>3/9/2004</color>. \nРасскажи мне тогда, если не знать об особенностях нашего формата, то <color=#F3FF00>сколько дат в году можно определить ошибочно?</color>\"";
                                helpTask.text = "В каждом месяце 11 двусмысленных дат.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 743);
                                taskText.margin = new Vector4(40, 53.3f, 40, -197);
                                taskText.text = "One cowboy in America asked: \n- Look, the date of <color=#F3FF00>September 3, 2004</color>, we use the following format: <color=#00FF49>9/3/2004</color>, and in other countries it is different: <color=#00FFF3>3/9/2004</color>. \nTell me then, if you do not know about the features of our format, then <color=#F3FF00>how many dates in a year can be determined by mistake?</color>";
                                helpTask.text = "There are 11 ambiguous dates in every month.";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "354   (71111)   467\n276   (31014)  138\n798      <color=#F3FF00>(?)</color>      215";
                                helpTask.text = "Складывай первую цифру левого столбика в строке с первой цифрой правого столбика той же строки, потом вторые цифры и так далее. Записывай результат! \n3+4=7 и 5+6=11. Вау! 711";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "354   (71111)   467\n276   (31014)  138\n798      <color=#F3FF00>(?)</color>      215";
                                helpTask.text = "Add the first number of the left column in a row with the first number of the right column of the same row, then the second numbers, and so on. Write down the result! \n3+4=7 and 5+6=11. Wow! 711";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Раздели <color=#F3FF00>60</color> на <color=#F3FF00>1/4</color> и отнимите <color=#F3FF00>5. \nСколько получится?</color>";
                                helpTask.text = "А ты вот так думал? \n60/(1/4)-5?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Divide <color=#F3FF00>60</color> by <color=#F3FF00>1/4</color> and subtract <color=#F3FF00>5. \nHow much will it turn out?</color>";
                                helpTask.text = "Did you think so? \n60/(1/4)-5?";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "21 + 7 = 4\n9 + 23 = <color=#F3FF00>?</color>";
                                helpTask.text = "Давай вернёмся к настоящим часам! Посчитай ответ при помощи часов!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "21 + 7 = 4\n9 + 23 = <color=#F3FF00>?</color>";
                                helpTask.text = "Let's go back to the real clock! Calculate the answer with your watch!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>Чему равно</color> \nдве двенадцатых \nот двух шестнадцатых \nот двух двадцатых \nот половины от <color=#F3FF00>960</color>?";
                                helpTask.text = "Смотри, как тут просто: \n2/12*2/16*2/20*1/2*960";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#F3FF00>What is</color> \ntwo twelfths \nof two sixteenths \nof two twenties \nof half of <color=#F3FF00>960</color>?";
                                helpTask.text = "Look, how can we simply: \n2/12*2/16*2/20*1/2*960";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "4    7     9     6     8     5\n61   94   18   63   46   <color=#F3FF00>?</color>";
                                helpTask.text = "Поменяй числа местами после возведения в квадрат!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "4    7     9     6     8     5\n61   94   18   63   46   <color=#F3FF00>?</color>";
                                helpTask.text = "Swap numbers after squaring!";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1364);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 2728);
                                helpTask.margin = new Vector4(35, 0, 35, -1352);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 570);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#FF7600>Брусок</color> и <color=#00B6FF>камень</color> весят столько, сколько лист <color=#F3FF00>металла</color>. \nДва <color=#FF7600>бруска</color> весят столько, сколько лист <color=#F3FF00>металла</color> и <color=#00B6FF>камень</color> вместе.<color=#F3FF00>\nСколько надо <color=#00B6FF>каменей</color>, чтобы уравнять в весе лист металла?";
                                helpTask.text = "Запишем брусок, как \"Б\", камень \"К\" и лист металла как \"Л\", и \"x\"-неизвестное количество камней. Тогда получается следующее:\nБ + К = Л\n2Б = Л + К\nНадо найти хК=Л\nПодставляем во второе уравнение \"Л\" из первого уравнения и получаем:\n2Б = Б + К + К\nПреобразовываем: \nБ = 2К\nПосле чего просто подставим получившиеся \"Б\" в самое первое уравнение и получаем:\n2К + К = Л\nТо есть 3 камня будут равны 1 листу металла.";

                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1364);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 2728);
                                helpTask.margin = new Vector4(35, 0, 35, -1352);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 570);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#FF7600>A bar</color> and <color=#00B6FF>a stone</color> weigh as much as a <color=#F3FF00>sheet of metal</color>. \nTwo <color=#FF7600>bars</color> weigh as much as a <color=#F3FF00>sheet of metal</color> and <color=#00B6FF>a stone</color> together. How many <color=#00B6FF>stones</color> do you need to equalize the weight of a <color=#F3FF00>sheet of metal</color>?";
                                helpTask.text = "Let's write the bar as \"B\", stone \"S\" and sheet of metal as \"M\", and \"x\" is an unknown number of stones. Then it turns out the following:\nB + S = M\n2B = M + S\nIt is necessary to find xS = M\nSubstituting into the second equation \"M\" from the first equation and we get:\n2B = B + S + S\nWe transform:\nB = 2S\nThen we simply substitute the resulting \"B\" into the very first equation and get:\n2S + S = M\nThat is, 3 stones will be equal to 1 sheet of metal.";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 562);
                                taskText.margin = new Vector4(40, 53.3f, 40, -15);
                                taskText.text = "У одной дамы спросили: \n- Сколько Вам лет?. \nОна ответила: \n - <color=#F3FF00>25</color>, если не учитывать <color=#00FF49>вторников</color> и <color=#00FF49>сред</color>. \n<color=#F3FF00>Сколько ей?</color>";
                                helpTask.text = "Нужно учитывать, что без двух дней, это 5/7 её жизни, и это будет 25 лет.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 562);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "One lady was asked: \n- How old are you? \nShe replied: \n- <color=#F3FF00>25</color>, excluding all <color=#00FF49>Tuesdays</color> and <color=#00FF49>Wednesdays</color>. \n<color=#F3FF00>How old is she?</color>";
                                helpTask.text = "It should be borne in mind that without two days, this is 5/7 of her life, and it will be 25 years.";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Закончите последовательность чисел:\n351, 316, 285, 257, 232, <color=#F3FF00>?</color>";
                                helpTask.text = "Всё что мне известно, так это то что \n351 - 35 = 316";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Finish the sequence of numbers:\n351, 316, 285, 257, 232, <color=#F3FF00>?</color>";
                                helpTask.text = "All I know is that \n351 - 35 = 316";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1126);
                                taskText.margin = new Vector4(40, 53.3f, 40, -545);
                                taskText.text = "Джон странный. У него дома есть <color=#F3FF00>больше одного</color> холодильника! \nПридя домой с магазина с вкуснейшими шоколадными тортами, он задумался. \nЕсли Джон поставит <color=#00FFF3>по одному торту</color> в <color=#F3FF00>каждый холодильник</color>, то <color=#00FFF3>один тортик</color> будет не в <color=#F3FF00>холодильнике</color>. Если он ставит в <color=#F3FF00>каждый холодильник</color> по <color=#00FFF3>два тортика</color>, то <color=#F3FF00>один холодильник</color> становится <color=#00FF49>свободный</color>. \n<color=#F3FF00>Сколько холодильников у Джона?</color>";
                                helpTask.text = "Четыре тортика и три холодильника!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1126);
                                taskText.margin = new Vector4(40, 53.3f, 40, -545);
                                taskText.text = "John is weird. He has <color=#F3FF00>more than one</color> refrigerator at home! \nArriving home from a shop with delicious chocolate cakes, he started thinking. \nIf John puts <color=#00FFF3>one cake</color> in <color=#F3FF00>each refrigerator</color>, then <color=#00FFF3>one cake</color> will not be in the <color=#F3FF00>refrigerator</color>. If he puts <color=#00FFF3>two cakes</color> in <color=#F3FF00>each refrigerator</color>, then <color=#F3FF00>one refrigerator</color> becomes <color=#00FF49>free</color>. \n<color=#F3FF00>How many refrigerators does John have?</color>";
                                helpTask.text = "Four cakes and three refrigerators!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1003);
                                taskText.margin = new Vector4(40, 53.3f, 40, -415);
                                taskText.text = "Идёт <color=#F3FF00>третий</color> ежегодный чемпионат города по самому медленному поеданию блинчиков. Из года в год все участники едят <color=#F3FF00>одинаково</color> медленно! В первом году <color=#F3FF00>шестеро участников</color> съедали все блинчики за <color=#F3FF00>двенадцать</color> часов! Во втором году <color=#F3FF00>пятеро участников</color> съедали за <color=#F3FF00>шестнадцать</color> часов! Сколько же понадобится участников в третьем году, чтобы скушать все блинчики за <color=#F3FF00>целые сутки</color>?";
                                helpTask.text = "Давай посчитаем! Один? Два? Три? А может четыре? Наверное, четыре!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1003);
                                taskText.margin = new Vector4(40, 53.3f, 40, -415);
                                taskText.text = "There is the <color=#F3FF00>third</color> annual city championship in the slowest eating pancakes. From year to year, all participants eat <color=#F3FF00>equally</color> slowly! In the first year, <color=#F3FF00>six participants</color> ate all the pancakes in <color=#F3FF00>twelve</color> hours! In the second year, <color=#F3FF00>five participants</color> ate in <color=#F3FF00>sixteen</color> hours! How many participants will it take in the third year to eat all the pancakes in <color=#F3FF00>a whole day?</color>";
                                helpTask.text = "Let's count! One ? Two ? Three? Or maybe four? Probably four!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 803);
                                taskText.margin = new Vector4(40, 53.3f, 40, -250);
                                taskText.text = " <color=#00FF49>Джонни</color> решил, что нужно чем-то выделиться и переделал колёса своего велосипеда! \nУ <color=#00FFF3>переднего колеса</color> было <color=#F3FF00>20</color> спиц, а у <color=#FF7600>заднего</color> <color=#F3FF00>36</color> спиц! \n<color=#F3FF00>Интересно, сколько раз прокрутится переднее колесо вместе с задним до возвращения их в начальное положение, при условии, что колёса находятся в сцеплении?</color>";
                                helpTask.text = "Думаю, если найти наименьшее общее кратное, то можно получить точный ответ!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 803);
                                taskText.margin = new Vector4(40, 53.3f, 40, -250);
                                taskText.text = "<color=#00FF49>Johnny</color> decided he needed something to stand out and redesigned the wheels of his bike. \nThe <color=#00FFF3>front wheel</color> had <color=#F3FF00>20</color> spokes and the <color=#FF7600>rear</color> had <color=#F3FF00>36</color> spokes! \n<color=#F3FF00>I wonder how many times the front wheel will spin together with the rear wheel until they return to their original position, provided that the wheels are in traction?</color>";
                                helpTask.text = "I think if you find the least common multiple, you can get the exact answer!";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 739);
                                taskText.margin = new Vector4(40, 53.3f, 40, -195);
                                taskText.text = "В одном почтовом отделении приняли партию из <color=#F3FF00>100 посылок</color>. Работники должны были пронумеровать их и повесить ярлычки. Константин в ожидании следующей партии посчитал количество <color=#00FF49>всех девяток</color>, которые есть в этих ярлычках. \n<color=#F3FF00>Сколько же у него вышло в итоге?</color>";
                                helpTask.text = "99\nЧто-то с этим числом не так...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 739);
                                taskText.margin = new Vector4(40, 53.3f, 40, -195);
                                taskText.text = "One post office accepted a batch of <color=#F3FF00>100 packages</color>. Workers had to number them and hang tags. Constantine, waiting for the next delivery, counted the number of <color=#00FF49>all nines</color> that are in these labels. \n<color=#F3FF00>How much did he get in the end?</color>";
                                helpTask.text = "99. \nSomething is wrong with this number...";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ElementaryLaws:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 758);
                                taskText.margin = new Vector4(40, 53.3f, 40, -192);
                                taskText.text = "У мамы и сына есть по <color=#F3FF00>несколько ананасов</color>. \nЕсли мама даст сыну <color=#F3FF00>2 ананаса</color>, то у мамы их станет в <color=#F3FF00>2 раза меньше, чем у сына</color>. \nА если сын даст маме <color=#F3FF00>2 ананаса</color>, то у мамы и сына их будет <color=#F3FF00>одинаковое количество</color>. \n<color=#F3FF00>Сколько ананасов у них в сумме?</color>";
                                helpTask.text = "У мамы 10, а у сына 14. Давай теперь сложим и получим ответ?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 758);
                                taskText.margin = new Vector4(40, 53.3f, 40, -192);
                                taskText.text = "Mom and son each have <color=#F3FF00>a few pineapples</color>. \nIf a mother gives her son <color=#F3FF00>2 pineapples</color>, then the mother will have <color=#F3FF00>2 times less of them than her son</color>. \nAnd if the son gives mom <color=#F3FF00>2 pineapples</color>, then mom and son will have the <color=#F3FF00>same amount</color>.\n<color=#F3FF00>How many pineapples do they have in total?</color>";
                                helpTask.text = "Mother has 10 and son has 14. Let's add it up and get the answer?";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1123);
                                taskText.margin = new Vector4(19, 53.3f, 19, -555);
                                taskText.text = "Экскурсоводу Марии необходимо было разбить <color=#F3FF00>868</color> людей на группы. Причём у Марии была странность, она могла организовать людей с таким условием, что численность людей в каждой группе должна состоять только из <color=#F3FF00>семёрок</color>, причём <color=#F3FF00>количество семёрок должно быть равно семи</color>. \nКаким же образом <color=#F3FF00>используя</color> только<color=#F3FF00> арифметические знаки суммы и семь семёрок</color> Мария смогла визуализировать правильное разбиение групп?";
                                helpTask.text = "777+77+... а дальше тебе продолжать! Итак, слишком много подсказал!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1123);
                                taskText.margin = new Vector4(40, 53.3f, 40, -555);
                                taskText.text = "Maria is a guide and once she had to divide <color=#F3FF00>868</color> people into groups. Moreover, Mary had an oddity, she could organize people under such a condition that the number of people in each group should consist only of <color=#F3FF00>sevens</color>, and <color=#F3FF00>the amount of sevens should be seven</color>. \nHow, <color=#F3FF00>using</color> only <color=#F3FF00>arithmetic signs of the sum and seven sevens</color>, was Maria able to visualize the correct division of the groups?";
                                helpTask.text = "777+77+... and then you continue! So, helped too much!";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 681);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "На улице стоит <color=#FF7600>столб</color> высотой <color=#F3FF00>100 метров</color>. Начиная от <color=#FF7600>асфальта</color> по нему взбирается <color=#00FFF3>ленивец</color>. За день <color=#00FFF3>ленивец</color> преодалевает <color=#F3FF00>30 метров</color>, а <color=#AD00FF>ночью</color>, пока он <color=#AD00FF>спит</color> - сползает на 20 метров. Через какоке время(<color=#F3FF00>в сутках</color>) <color=#00FFF3>ленивец</color> доберётся до точки в <color=#F3FF00>100 метров</color>?";
                                helpTask.text = "Ему понадобится всего 8 дней! Почему? Посчитай каждый ДЕНЬ и каждую НОЧЬ!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 681);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "On the street there is <color=#FF7600>a pillar</color> <color=#F3FF00>100 meters</color> high. Starting from <color=#FF7600>the asphalt</color>, <color=#00FFF3>a sloth</color> climbs it. During the day, <color=#00FFF3>the sloth</color> overcomes <color=#F3FF00>30 m</color>, and <color=#AD00FF>at night</color>, while he <color=#AD00FF>is sleeping</color>, he slides 20 m. How long (<color=#F3FF00>in days</color>) will <color=#00FFF3>the sloth</color> reach the point of <color=#F3FF00>100 meters</color>?";
                                helpTask.text = "He only needs 8 days! Why? Count on a piece of paper every DAY and NIGHT!";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 557);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Если <color=#00FF49>квадрат</color> веса Джона <color=#F3FF00>прибавить</color> к весу Марии, то получится <color=#00FF49>62кг</color>. Если наоборот <color=#00FF49>квадрат</color> веса Марии прибавить к весу Джона, то получится <color=#00FF49>176кг</color>. Сколько весят Джон и Мария <color=#F3FF00>вместе</color>?";
                                helpTask.text = "Джон - 7 килограмм. Мария - 13 килограмм. Так сколько же вместе они весят?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 557);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "If you <color=#F3FF00>add</color> <color=#00FF49>the square</color> of John's weight to Mary's weight, you get <color=#00FF49>62kg</color>. However, if you add <color=#00FF49>the square</color> of Mary's weight to John's weight, you get <color=#00FF49>176kg</color>. How much do John and Maria weigh <color=#F3FF00>together</color>?";
                                helpTask.text = "John is 7 kilograms. Maria - 13 kilograms. So how much together do they weigh?";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -871);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1742);
                                helpTask.margin = new Vector4(35, 0, 35, -342);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 558);
                                taskText.margin = new Vector4(40, 53.3f, 40, 0);
                                taskText.text = "Жирный кот увидел жирную крысу в <color=#F3FF00>двухстах</color> метрах от себя. Жирная крыса пробегает за <color=#FF7600>3 минуты</color> - <color=#00FF49>750 метров</color>, а жирный и ленивый кот за <color=#FF7600>6 минут</color> - <color=#00FF49>1560 метров</color>. \n <color=#F3FF00>Через сколько минут жирный кот догонит жирную крысу?</color>";
                                helpTask.text = "750 / 3 = 250 (метров) - пробегает за одну минуту жирная крыса,\nа 1560/6=260 (метров) - пробегает за одну минуту жирный кот, \nи 260 - 250 = 10 (метров) - за одну минуту сокращается расстояние между крысой и котом. \nДальше тебе решать! \nОдно действие осталось!";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -871);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1742);
                                helpTask.margin = new Vector4(35, 0, 35, -342);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 558);
                                taskText.margin = new Vector4(40, 53.3f, 40, 0);
                                taskText.text = "A fat cat saw a fat rat <color=#F3FF00>two hundred</color> meters away. The fat rat can run <color=#00FF49>750 meters</color> in <color=#FF7600>3 minutes</color>, and the fat and lazy cat can run <color=#00FF49>1560 meters</color> in <color=#FF7600>6 minutes</color>. \n <color=#F3FF00>How many minutes will the fat cat catch up with the fat rat?</color>";
                                helpTask.text = "750:3 = 250 (meters) - a fat rat runs in one minute, \nand 1560:6 = 260 (meters) - a fat cat runs in one minute, \nand 260 - 250 = 10 (meters) - the distance is reduced in one minute between a rat and a cat.\nThen decide for yourself! \nOne action left!";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 856);
                                taskText.margin = new Vector4(40, 53.3f, 40, -284);
                                taskText.text = "На распродаже вещей продавались синие и красные свитера. Красный свитер <color=#F3FF00>вдвое дороже</color> синего. Покупатель, который решился закупиться, купил <color=#F3FF00>5</color> красных свитеров и <color=#F3FF00>3</color> синих. Если бы вместо этого он купил <color=#F3FF00>3</color> красных свитера и <color=#F3FF00>5</color> синих, то сэкономил бы <color=#F3FF00>20 евро</color>.\n<color=#F3FF00>Сколько стоят свитера в сумме?</color>";
                                helpTask.text = "Цена красного свитера - 20 евро, синего - 10 евро. А в сумме?";

                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 856);
                                taskText.margin = new Vector4(40, 53.3f, 40, -284);
                                taskText.text = "Blue and red sweaters were on sale. A red sweater <color=#F3FF00>is twice as expensive as</color> a blue one. The shopper who decided to shop bought <color=#F3FF00>5</color> red sweaters and <color=#F3FF00>3</color> blue ones. If instead he bought <color=#F3FF00>3</color> red sweaters and <color=#F3FF00>5</color> blue sweaters, he would save <color=#F3FF00>20 euros</color>.\n<color=#F3FF00>How much do the sweaters cost in total?</color>";
                                helpTask.text = "The price of a red sweater is 20 euros, a blue one is 10 euros. And in total?";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1262);
                                taskText.margin = new Vector4(40, 53.3f, 40, -715);
                                taskText.text = "Джимми предстояла сложная задача. \nУ него было <color=#F3FF00>двадцать четыре колбы</color> с химическими веществами. Их вес был <color=#F3FF00>абсолютно равный</color>. \nВ ходе экспериментов, ему позвонили и сказали, что в <color=#F3FF00>одной колбе</color> чуть больше вещества, и что нельзя смешивать содержимое с другими веществами! Но у Джимми были чашечные весы, и он <color=#F3FF00>минимально возможным количеством взвешиваний</color> определил, где больше вещества. \n<color=#F3FF00>Сколько раз ему понадобилось взвесить, чтобы определить это?</color>";
                                helpTask.text = "Это сложная задачка, так что скажу тебе ответ! Три взвешивания!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1287);
                                taskText.margin = new Vector4(40, 53.3f, 40, -715);
                                taskText.text = "Jimmy had a difficult task. \nHe had <color=#F3FF00>twenty-four flasks</color> with chemical matic substances. Their weight was <color=#F3FF00>absolutely equal</color>. \nDuring the experiments, he received a call and was told that there is a little more substance in <color=#F3FF00>one flask</color>, and that the contents should not be mixed with other substances! But Jimmy had a weighing scale, and he determined with <color=#F3FF00>the minimum possible number of weighings</color> where the substance was more. \n<color=#F3FF00>How many times did it take him to weigh to determine this?</color>";
                                helpTask.text = "This is a difficult task, so I'll tell you the answer! Three weighings!";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 683);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "В сенате работает <color=#F3FF00>650</color> чиновников. Так уж случается, что хотя бы <color=#F3FF00>один</color> из чиновников никогда за свою жизнь не нарушал закон. Но так складывается, что в <color=#F3FF00>каждой паре</color> чиновников хотя бы <color=#F3FF00>один</color> нарушал закон. \n<color=#F3FF00>Сколько всего чиновников никогда не брали взятку?</color>";
                                helpTask.text = "Подумав немного я пришёл к выводу, что если честных депутатов будет больше одного, то образуется пара, не соответствующая условию задачи. А следующий вывод делай самостоятельно.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 683);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "There are <color=#F3FF00>650</color> officials in the Senate. It so happens that at least <color=#F3FF00>one</color> of the officials has never broken the law in his life. But it so happens that in <color=#F3FF00>every pair</color> of officials at least <color=#F3FF00>one</color> broke the law. \n<color=#F3FF00>How many officials have never taken a bribe?</color>";
                                helpTask.text = "After thinking a little, I came to the conclusion that if there are more than one honest deputies, then a pair will be formed that does not correspond to the condition of the task. Make the next conclusion yourself.";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1040);
                                taskText.margin = new Vector4(40, 53.3f, 40, -491);
                                taskText.text = "Мария отправилась в магазин за <color=#00FF49>невероятно вкусным майонезом</color>! Зайдя в магазин, Мария очень сильно удивилась настолько <color=#00FFF3>низкой цене</color>. <color=#00FF49>Невероятно вкусный майонез</color> продавался в <color=#F3FF00>специальной сберегающей упаковке</color> всего за <color=#F3FF00>15 долларов</color>! Мария задумалась. <color=#00FF49>Вкуснейший майонез</color> стоит на <color=#F3FF00>14 долларов больше</color>, чем <color=#F3FF00>специальная сберегающая упаковка</color>. \n<color=#F3FF00>Сколько же стоит сам невероятный майонез?</color>";
                                helpTask.text = "По моим скромным расчётам, этот майонез стоит всего лишь 14.50 долларов!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1067);
                                taskText.margin = new Vector4(40, 53.3f, 40, -491);
                                taskText.text = "Maria went to the store for <color=#00FF49>an incredibly tasty mayonnaise</color>! Having entered the store, Maria was very surprised with such <color=#00FFF3>a low price</color>. <color=#00FF49>The incredibly delicious</color> mayonnaise was sold in <color=#F3FF00>a special conservation pack</color> for only <color=#F3FF00>15$</color>! Maria thought about it. <color=#00FF49>The delicious mayonnaise</color> costs <color=#F3FF00>14$ more</color> than <color=#F3FF00>the special conservation pack</color>. \n<color=#F3FF00>How much is the incredible mayonnaise itself?</color>";
                                helpTask.text = "In my conservative estimate, this mayonnaise costs only $ 14.50!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 870);
                                taskText.margin = new Vector4(40, 53.3f, 40, -294);
                                taskText.text = "Два <color=#00FFF3>элитных автобуса</color> едут по шоссе навстречу друг другу с невероятными скоростями\n <color=#F3FF00>V=72 км/ч</color> и <color=#F3FF00>V2=90 км/ч</color>. \nЛюди, находящийся в первом <color=#00FFF3>элитном автобусе</color>, замечают, что второй <color=#00FFF3>элитный автобус</color> проезжает мимо него за <color=#F3FF00>4 секунды</color>. <color=#F3FF00>Какой же длины был второй <color=#00FFF3>элитный автобус</color>?</color>";
                                helpTask.text = "72 КМ/Ч = 20 М/С и 90 КМ/ч = 25 М/С \nЭлитные автобусы ехали навстречу, поэтому скорости складываются и получается 45 М/С. \nВспоминаем, что t=4c и делаем правильные расчёты!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 870);
                                taskText.margin = new Vector4(40, 53.3f, 40, -294);
                                taskText.text = "Two <color=#00FFF3>elite buses</color> travel towards each other along the highway at incredible speeds of \n <color=#F3FF00>V=72 km/h</color> \nand <color=#F3FF00>V2=90 km/h</color>. \nPeople on the first <color=#00FFF3>elite bus</color> notice that the second <color=#00FFF3>elite bus</color> passes by it in <color=#F3FF00>t=4s</color>. <color=#F3FF00>How long was the second <color=#00FFF3>elite bus</color>?</color>";
                                helpTask.text = "72 KM/H = 20 M/S and 90 KM/h = 25M /S\nElite buses drove towards each other, so the velocities are added and the obtained 45 M/S. \nRemember that t=4c and do the correct calculations!";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 630);
                                taskText.margin = new Vector4(40, 53.3f, 40, -79);
                                taskText.text = "Один знаменитый брокер торговал акциями на бирже. Он спросил, неопытного брокера. \nДопустим, одна акция стоила <color=#F3FF00>10$</color>. Изначально акции стали <color=#F3FF00>дороже</color> на <color=#F3FF00>10%</color>, а потом резко <color=#F3FF00>подешевели</color> на <color=#F3FF00>10%</color>. \n<color=#F3FF00>Сколько теперь стоит одна акция?</color>";
                                helpTask.text = "Упали на одну сотую от стоимости, так как дорожало и дешевело в процентном соотношении.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 630);
                                taskText.margin = new Vector4(40, 53.3f, 40, -79);
                                taskText.text = "One famous broker traded stocks on the stock exchange. He asked an inexperienced broker. \nLet's say one share was worth <color=#F3FF00>10$</color>. Initially, the shares <color=#F3FF00>rose</color> in price by <color=#F3FF00>10%</color>, and then <color=#F3FF00>fell</color> sharply by <color=#F3FF00>10%</color>. \n<color=#F3FF00>How much is one share now?</color>";
                                helpTask.text = "We have fallen by one hundredth of the cost, since it was getting more expensive and cheaper as a percentage.";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 638);
                                taskText.margin = new Vector4(40, 53.3f, 40, -82);
                                taskText.text = "В теплице неожиданно оказалась спора, и через <color=#F3FF00>33 минуты</color> вся теплица смогла разрастись спорами, причем мы точно знаем, что количество спор <color=#F3FF00>каждую минуту</color> становилось <color=#F3FF00>вдвое больше</color>. <color=#F3FF00>За сколько минут теплица была наполнена на половину?</color>";
                                helpTask.text = "А ты знаешь, что обычно у человека 32 зуба?";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 655);
                                taskText.margin = new Vector4(40, 53.3f, 40, -82);
                                taskText.text = "A spore appeared in the greenhouse surprisingly, and after <color=#F3FF00>33 minutes</color> entire greenhouse is able to grow spores, and we know that the number of spores <color=#F3FF00>per minute</color> became <color=#F3FF00>twice as initial</color>. <color=#F3FF00>In how many minutes was the greenhouse half full of spores?</color>";
                                helpTask.text = "Did you know that usually a person has 32 teeth?";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 638);
                                taskText.margin = new Vector4(40, 53.3f, 40, -90);
                                taskText.text = "Давайте представим ситуацию, где один <color=#F3FF00>жираф</color> выпивает одну цистерну воды за <color=#00FF49>14 дней</color>, а вместе со вторым <color=#F3FF00>жирафом</color>, выпивают одну цистерну с водой за <color=#00FF49>10 дней</color>. \nЗа сколько дней второй <color=#F3FF00>жираф</color> в одиночку сможет выпить одну цистерну с водой?";
                                helpTask.text = "Люблю быть иногда краток! 35 дней.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 655);
                                taskText.margin = new Vector4(40, 53.3f, 40, -90);
                                taskText.text = "Let's imagine a situation where one <color=#F3FF00>giraffe</color> drinks one tank of water in <color=#00FF49>14 days</color>, and together with <color=#F3FF00>a second giraffe</color>, they drink one tank of water in <color=#00FF49>10 days</color>. \nHow many days will it take for the second <color=#F3FF00>giraffe</color> to drink one tank of water alone?";
                                helpTask.text = "I like to be short! 35 days.";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 589);
                                taskText.margin = new Vector4(40, 53.3f, 40, -10);
                                taskText.text = "Студент Джон решил взять <color=#F3FF00>одно число</color>, <color=#FF7600>разделил</color> его на <color=#F3FF00>9</color>, после чего <color=#00FFF3>сложил</color> его на <color=#F3FF00>9</color>, а после даже <color=#00FF49>умножил</color> на <color=#F3FF00>9</color>, и в качестве результата получилось число <color=#F3FF00>99</color>. <color=#F3FF00>Какое число выбрал Джон с самого начала?</color>";
                                helpTask.text = "Хорошо, допустим ты не хочешь решать это при помощи уравнения. Тогда давай идти с конца к началу, меняя все действия наоборот. \n99/9=11 \nДальше самостоятельно справишься!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 561);
                                taskText.margin = new Vector4(40, 53.3f, 40, -10);
                                taskText.text = "Student John decided to take <color=#F3FF00>one number</color>, <color=#FF7600>divided</color> it by <color=#F3FF00>9</color>, then <color=#00FFF3>added</color> it by <color=#F3FF00>9</color>, and then <color=#00FF49>multiplied</color> by <color=#F3FF00>9</color>, and the result was <color=#F3FF00>99</color>. <color=#F3FF00>What number did John choose from the very beginning?</color>";
                                helpTask.text = "Okay, let's say you don't want to solve this with an equation. Then let's go from end to beginning, changing all actions in reverse. \n99/9=11. \nThen you can do it yourself!";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 895);
                                taskText.margin = new Vector4(40, 53.3f, 40, -317);
                                taskText.text = "Джимми только что вернулся с магазина. Он купил <color=#00B6FF>чёрный</color>, <color=#00FF49>зелёный</color> и <color=#FF7600>красный</color> чай. \n<color=#F3FF00>Вместе они весят 200 грамм.</color> <color=#FF7600>красный</color> чай весит <color=#F3FF00>на 30 грамм больше</color>, чем <color=#00FF49>зелёный</color> чай, а <color=#F3FF00>вместе</color> <color=#FF7600>красный</color> и <color=#00FF49>зелёный</color> чай <color=#F3FF00>суммарно</color> весят <color=#F3FF00>на 20 грамм больше</color>, чем <color=#00B6FF>чёрный</color> чай. \n<color=#F3FF00>Сколько грамм <color=#00B6FF>чёрного</color> чая купил Джимми?</color>";
                                helpTask.text = "Он купил 90 грамм!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 919);
                                taskText.margin = new Vector4(40, 53.3f, 40, -371);
                                taskText.text = "Jimmy just got back from the store. He bought <color=#00B6FF>black</color>, <color=#00FF49>green</color> and <color=#FF7600>red</color> tea. \n<color=#F3FF00>Together they weigh 200 grams.</color> <color=#FF7600>Red</color> tea weighs <color=#F3FF00>30 grams more</color> than <color=#00FF49>green</color> tea, and <color=#F3FF00>together</color> <color=#FF7600>red</color> and <color=#00FF49>green</color> tea weighs <color=#F3FF00>20 grams more</color> than <color=#00B6FF>black</color> tea. \n<color=#F3FF00>How many grams of <color=#00B6FF>black</color> tea did Jimmy buy?</color>";
                                helpTask.text = "He bought 90 grams!";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 891);
                                taskText.margin = new Vector4(40, 53.3f, 40, -322);
                                taskText.text = "Очень странные и принципиальные птицы не хотели улетать в тёплые края. <color=#F3FF00>1/5</color> <color=#00FF49>уток</color> решили остаться. Также и <color=#F3FF00>1/3</color> <color=#00FF49>лебедей</color> остаются. Учетверённая разность ранее перечисленных чисел птиц отправились на юг, и ещё <color=#00FFF3>одна птичка</color> не могла определиться и летала то на юг, то обратно в холодные края. \n<color=#F3FF00>Сколько всего было птиц?</color>";
                                helpTask.text = "Всего было 17 птиц!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 859);
                                taskText.margin = new Vector4(40, 53.3f, 40, -322);
                                taskText.text = "Very strange and principled birds did not want to fly away to warm lands. <color=#F3FF00>1/5</color> of <color=#00FF49>the ducks</color> decided to stay. Also <color=#F3FF00>1/3</color> of the <color=#00FF49>swans</color> remain. The quadrupled difference of the previously listed numbers of birds went south, and <color=#00FFF3>another bird</color> could not decide and flew either south or back to the cold regions. \n<color=#F3FF00>How many birds were there?</color>";
                                helpTask.text = "There were 17 birds in total!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 672);
                                taskText.margin = new Vector4(40, 53.3f, 40, -116);
                                taskText.text = "Вы пришли на заседание директоров, но вам было скучно в этот день, поэтому вы решили проявить наблюдательность. Вы увидели, что все поздоровались <color=#F3FF00>каждый с каждым</color> и получилось <color=#00FF49>91 приветствие</color>. \n<color=#F3FF00>Сколько всего было директоров?</color>";
                                helpTask.text = "Только себя не забудь посчитать! Так что... + 13 + 14. Итого Было 14 директоров!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 647);
                                taskText.margin = new Vector4(40, 53.3f, 40, -116);
                                taskText.text = "You came to the CEO meeting, but you were bored that day, so you decided to be observant. You saw that everyone greeted <color=#F3FF00>with each other</color> and there were <color=#00FF49>91 greetings</color>. \n<color=#F3FF00>How many directors were there?</color>";
                                helpTask.text = "Just don't forget to count yourself! So... + 13 + 14. There were 14 directors in total!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1150);
                                taskText.margin = new Vector4(40, 53.3f, 40, -578);
                                taskText.text = "От <color=#F3FF00>полной</color> чашки с <color=#00FF49>фруктовым соком</color> я выпил <color=#F3FF00>половину</color> и долил <color=#F3FF00>столько же</color> <color=#FF7600>томатного сока</color>. Затем я выпил <color=#F3FF00>третью часть</color> получившегося из этой смеси <color=#00FF49>фруктового</color> с <color=#FF7600>томатным</color> соком и потом долил <color=#F3FF00>столько же</color> <color=#FF7600>томатного сока</color>. После чего я выпил <color=#F3FF00>шестую часть</color> получившегося <color=#00FF49>фруктового</color> с <color=#FF7600>томатным</color> соком, долил чашку <color=#FF7600>томатным</color> соком <color=#F3FF00>доверху</color> и выпил <color=#F3FF00>абсолютно все</color>. \n<color=#F3FF00>Чего я выпил меньше: <color=#00FF49>фруктового</color> или <color=#FF7600>томатного</color> сока?</color>";
                                helpTask.text = "Одинаково. Хе-хе";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1150);
                                taskText.margin = new Vector4(40, 53.3f, 40, -578);
                                taskText.text = "From <color=#F3FF00>a full cup</color> of <color=#00FF49>fruit juice</color>, I drank <color=#F3FF00>half</color> and added <color=#F3FF00>the same</color> amount of <color=#FF7600>tomato juice</color>. Then I drank <color=#F3FF00>a third</color> of the resulting <color=#00FF49>fruit</color> and <color=#FF7600>tomato</color> juice mixture and then added <color=#F3FF00>the same</color> amount of <color=#FF7600>tomato juice</color>. After that I drank <color=#F3FF00>a sixth</color> of the resulting <color=#00FF49>fruit</color> with <color=#FF7600>tomato</color>  juice, <color=#F3FF00>topped up</color> the cup with <color=#FF7600>tomato</color> juice and drank <color=#F3FF00>absolutely everything</color>. \n<color=#F3FF00>What did I drink less: <color=#00FF49>fruit</color> juice or <color=#FF7600>tomato</color> juice?</color>";
                                helpTask.text = "Same. Hehe";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1020);
                                taskText.margin = new Vector4(40, 53.3f, 40, -471);
                                taskText.text = "Начинающий и перспективный предприниматель пришёл продавать хлеб. <color=#00FF49>Первый</color> пришедший забрал у него <color=#F3FF00>половину</color> всех буханок хлеба. <color=#00FF49>Второй</color> человек купил <color=#F3FF00>половину оставшихся</color> буханок хлеба и ещё <color=#F3FF00>полбуханки</color>. <color=#00FF49>Третий</color> решил закупиться всего лишь <color=#F3FF00>одной</color> буханкой хлеба. После этого у начинающего предпринимателя <color=#00FFF3>ничего не осталось</color>. \n<color=#F3FF00>Сколько буханок хлеба у него было изначально в наличии?</color>";
                                helpTask.text = "Очень сложная задачка! Но я тебе помогу! Всего 6 буханок хлеба!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1000);
                                taskText.margin = new Vector4(40, 53.3f, 40, -471);
                                taskText.text = "An aspiring and promising entrepreneur came to sell bread. <color=#00FF49>The first</color> customer took <color=#F3FF00>half</color> of all the loaves of bread from him. <color=#00FF49>The second</color> person bought <color=#F3FF00>half of the remaining</color> loaves of bread and another <color=#F3FF00>half loaf</color>. <color=#00FF49>The third</color> decided to stock up on just <color=#F3FF00>one</color> loaf of bread. After that, the aspiring entrepreneur had <color=#00FFF3>nothing left</color>. \n<color=#F3FF00>How many loaves of bread did he have initially?</color>";
                                helpTask.text = "Very difficult task! But I'll help you! Only 6 loaves of bread!";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 755);
                                taskText.margin = new Vector4(40, 53.3f, 40, -186);
                                taskText.text = "В лесу воют <color=#F3FF00>30</color> очень изголодавшихся волков. \nТак получилось, что пищи больше нет, и им приходится кушать себе подобных. Волк считается наевшимся только тогда, когда, съел <color=#F3FF00>трёх волков</color>.  \n<color=#F3FF00>Сколько больше всего волков смогут насытиться и выжить?</color>";
                                helpTask.text = "Давай условимся и представим, что у каждого волка есть свой номер. Получается четвёртый волк кушает 1-го, 2-го и 3-го и наедается! Седьмой волк кушает уже 4-го, 5-го, 6-го и так далее до тридцати. ";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 755);
                                taskText.margin = new Vector4(40, 53.3f, 40, -186);
                                taskText.text = "<color=#F3FF00>30</color> very hungry wolves were howling in the forest. \nThere were no more food, and they have to eat their own kind. A wolf is considered not hungry only when it has eaten <color=#F3FF00>three wolves</color>.\n<color=#F3FF00>How many wolvel will survive?</color>";
                                helpTask.text = "Let's agree and imagine that each wolf has its own number. It turns out the fourth wolf eats the 1st, 2nd and 3rd! The seventh wolf eats the 4th, 5th, 6th, and so on until thirty.";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.Mechanics:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 946);
                                taskText.margin = new Vector4(40, 53.3f, 40, -396);
                                taskText.text = "Один <color=#FF0013><uppercase>безумный учёный</color></uppercase> купил <color=#00FF49>пару</color> крыс для своих экспериментов и посадил их в огромную клетку. Он понимал, что такого количества ему не хватит для его работ, поэтому он начал ждать <color=#F3FF00>целый год</color>. Сколько крыс будет <color=#F3FF00>через год</color>, если <color=#F3FF00>каждый месяц</color> <color=#00FF49>одна пара</color> даёт в качестве приплода <color=#00FF49>новую пару</color> крыс, которые <color=#F3FF00>со второго месяца</color> жизни, также начинают приносить приплод?";
                                helpTask.text = "Тут всё очень сложно! Без последовательности чисел Фибоначчи не разобраться! Но у меня есть ответ! 377!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 946);
                                taskText.margin = new Vector4(40, 53.3f, 40, -396);
                                taskText.text = "One <color=#FF0013><uppercase>mad scientist</color></uppercase> bought <color=#00FF49>a couple</color> of rats for his experiments and put them in a huge cage. He understood that this amount would not be enough for his work, so he began to wait for <color=#F3FF00>a whole year</color>. How many rats will there be <color=#F3FF00>in a year</color> if <color=#F3FF00>every month</color> <color=#00FF49>one pair</color> gives birth to <color=#00FF49>a new pair</color> of rats, which from <color=#F3FF00>the second</color> month of life also begin to bear offspring?";
                                helpTask.text = "This is very complicated! You can't figure it out without a sequence of Fibonacci numbers! But I have an answer! 377!";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 919);
                                taskText.margin = new Vector4(19, 53.3f, 19, -339);
                                taskText.text = "На лесопилке один старый лесоруб задал простую задачку новому работнику. \n- Посмотри, этот пенёк идеальной <color=#F3FF00>цилиндрической</color> формы весит <color=#F3FF00>50 кг</color>. А теперь скажи мне сколько весит вот этот пенёк рядом, имеющий тоже идеальную <color=#F3FF00>цилиндрическую</color> форму, но у него <color=#F3FF00>диаметр</color> больше раза эдак в <color=#F3FF00>2</color>, но и в <color=#F3FF00>2</color> раза короче первого пня?";
                                helpTask.text = "От утолщения пня вдвое, объем первого пня увеличивается в 4 раза, а от укорочения вдвое объем пня уменьшается в 2 раза.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 919);
                                taskText.margin = new Vector4(40, 53.3f, 40, -339);
                                taskText.text = "At the sawmill, an old lumberjack gave a simple problem to a new worker. \n- Look, this perfectly <color=#F3FF00>cylindrical</color> stump weighs <color=#F3FF00>50kg</color>. Now tell me how much this stump next to it weighs, which also has an ideal <color=#F3FF00>cylindrical</color> shape, but its <color=#F3FF00>diameter</color> is <color=#F3FF00>2</color> times larger, but also <color=#F3FF00>2</color> times shorter than the first stump?";
                                helpTask.text = "From thickening the stump by half, the volume of the first stump increases by 4 times, and from shortening by half, the volume of the stump decreases by 2 times.";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 543);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Марии и Джону <color=#F3FF00>в сумме 65 лет</color>! И вот какое совпадение! Количество <color=#F3FF00>лет</color> Марии, совпадает с количеством <color=#F3FF00>месяцев</color> Джона! <color=#F3FF00>Интересно, сколько сейчас лет Джону?</color>";
                                helpTask.text = "Очевидно, что больше 65 месяцев не может быть Джону по условию. Истина, где-то в этом диапазоне!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 543);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "Mary and John are <color=#F3FF00>65 years old in sum</color>! And what a coincidence! Mary's <color=#F3FF00>number of years</color> is the same as John's <color=#F3FF00>months</color>! <color=#F3FF00>I wonder how old is John now?</color>";
                                helpTask.text = "Obviously, John cannot be more than 65 months old on condition. Truth, somewhere in this range!";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 677);
                                taskText.margin = new Vector4(40, 53.3f, 40, -95);
                                taskText.text = "В загадочной группе в колледже учатся <color=#F3FF00>шесть пар близнецов</color>. При получении диплома об окончании обучения, присутствовали <color=#F3FF00>все родители</color> студентов. Суммарно родителей и студентов было <color=#F3FF00>93 человека</color>. \n<color=#F3FF00>Сколько студентов в группе?</color>";
                                helpTask.text = "Шесть пар близнецов - это 12 студентов. \nУ каждой пары - по два родителя, итого - 12 близнецов и их 12 родителей. \n93 - 24 = 69 обычных студентов с двумя родителями. \n69/3 = 23 обычных студентов. \nДальше тебе считать!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 677);
                                taskText.margin = new Vector4(40, 53.3f, 40, -95);
                                taskText.text = "In the enigmatic group in college there <color=#F3FF00>are six pairs of twins</color>. <color=#F3FF00>All parents</color> of the students were present when receiving the graduation diploma. There were <color=#F3FF00>93</color> parents and students in total. \n<color=#F3FF00>How many students are there in the group?</color>";
                                helpTask.text = "Six pairs of twins are 12 students. \nEach couple has two parents, for a total of 12 twins and their 12 parents. \n93 - 24 = 69 regular students with two parents. \n69/3 = 23 regular students. \nThen you count!";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1009);
                                taskText.margin = new Vector4(40, 53.3f, 40, -425);
                                taskText.text = "Начальник одного магазина сказал подчинённому: \"Послушай, Джон, если скажешь какой <color=#F3FF00>угол</color> между стрелками часов, то я выплачу тебе премию в <color=#F3FF00>100 раз больше этого угла!</color>\". Начальник не думал, что его новый подчинённый настолько умный. Джону потребовалось несколько секунд, чтобы ответить правильно! \n<color=#F3FF00>Сколько начальник выплатил премии, если на часах 2 часа 20 минут?</color>";
                                helpTask.text = "Весь циферблат 360°. За 1 минуту часовая стрелка проходит:\n360/60=6°. \nДальше самостоятельно!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1009);
                                taskText.margin = new Vector4(40, 53.3f, 40, -425);
                                taskText.text = "The manager of one store said to a subordinate: \n- Look, John, if you tell me what the <color=#F3FF00>angle</color> between the clock hands is, then I will pay you a bonus <color=#F3FF00>100 times that angle</color>! \nThe boss didn't think his new subordinate was that smart. It took John a few seconds to answer correctly! \n<color=#F3FF00>How much did the boss pay bonuses if the clock shows 2 hours and 20 minutes?</color>";
                                helpTask.text = "The whole dial is 360°. In 1 minute, the hour hand passes:\n360/60 = 6°.\nFurther myself!";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -958);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1916);
                                helpTask.margin = new Vector4(35, 0, 35, -555);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 921);
                                taskText.margin = new Vector4(40, 53.3f, 40, -351);
                                taskText.text = "Компания которая выпускала журналы, на собеседовании задавали один вопрос! Если на него не отвечали, то человеку отказывали и не брали на работу. Претенденту говорили следующее: \"Чтобы пронумеровать страницы самого популярного журнала, мы использовали всего лишь <color=#F3FF00>735 цифры</color>. \n<color=#F3FF00>Как вы думаете сколько всего страниц в журнале?</color>\"";
                                helpTask.text = "Задачка непростая. Смотри. Для нумерации первых 9-ти страниц журнала использованы 9 цифр. 90 страниц занумерованы двузначными числами. Для этого потребовалось \n90 * 2 = 180 \nцифр. Остаток, приходящийся на трехзначные номера, составляет 546 цифр. \nДальше самостоятельно досчитай и сложи все ответы! ";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -958);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 1916);
                                helpTask.margin = new Vector4(35, 0, 35, -555);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 921);
                                taskText.margin = new Vector4(40, 53.3f, 40, -351);
                                taskText.text = "The company that produced the magazines asked one question during the interview! If people did not answer it, then the person was refused and was rejected to work there. The applicant was told the following: \n- To number the pages of the most popular magazine, we used only <color=#F3FF00>735 digits</color>. \n<color=#F3FF00>How many pages do you think there are in the magazine?</color>";
                                helpTask.text = "This is not an easy task. Look. For the numbering of the first 9 pages of the magazine, 9 numbers are used. 90 pages are numbered in two-digit numbers. This required \n90*2 = 180 \ndigits. The remainder of the three-digit numbers is 546 digits. \nThen count and add up all the answers yourself!";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 983);
                                taskText.margin = new Vector4(40, 53.3f, 40, -435);
                                taskText.text = "В магазине продавец выставлял цену за мебель <color=#F3FF00>2300$</color>, но ее не покупали. После долгих раздумий было решено понизить цену до <color=#F3FF00>1610$</color>. Но её и в этот раз не купили. Последовало ещё одно снижение до <color=#F3FF00>1127$</color>. К сожалению, и за такую цену купить её никто не решился. Еще раз снизив цену, мебель <color=#F3FF00>всё-таки продалась</color>. \n<color=#F3FF00>За сколько же продали мебель, после стольких снижений цен?</color>";
                                helpTask.text = "Попробуй применить процент % к своим расчётам!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1007);
                                taskText.margin = new Vector4(40, 53.3f, 40, -435);
                                taskText.text = "In the store, the seller charged <color=#F3FF00>2300$</color> for the furniture, but people did not buy it. After much deliberation, it was decided to lower the price to <color=#F3FF00>1610$</color>. But it was not bought this time either. Another decline followed to <color=#F3FF00>1127$</color>. Unfortunately, no one dared to buy it for such a price. Having lowered the price once again, the furniture <color=#F3FF00>was sold</color>. \n<color=#F3FF00>For how much did the furniture sell after so many price cuts?</color>";
                                helpTask.text = "Try applying percent % to your calculations!";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 632);
                                taskText.margin = new Vector4(40, 53.3f, 40, -80);
                                taskText.text = "Марии было всего 6 лет. Но несмотря на то, что она была очень маленькой, Мария была умной и любознательной. К примеру, она задалась таким нелёгким вопросом. Вот в месяце есть <color=#F3FF00>30 дней</color>.\n <color=#F3FF00>Какая же вероятность будет, что в этом месяце будет 5 четвергов?</color>";
                                helpTask.text = "В первых 28 днях будет 4 четверга. Значит, нужно определить вероятность того, что один из двух оставшихся дней придется на четверг.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 650);
                                taskText.margin = new Vector4(40, 53.3f, 40, -80);
                                taskText.text = "Mary was 6 years old. But despite the fact that she was very small, Maria was smart and inquisitive. For example, she asked herself a difficult question. There are <color=#F3FF00>30 days</color> in a month. \n<color=#F3FF00>What is the probability that there will be 5 Thursdays this month?</color>";
                                helpTask.text = "The first 28 days will be 4 Thursdays. This means that we need to determine the probability that one of the two remaining days will fall on Thursday.";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 706);
                                taskText.margin = new Vector4(40, 53.3f, 40, -157);
                                taskText.text = "Если мерять овечку с её скальпа до хвостика, то она <color=#F3FF00>длинной 72 см</color>. Если с хвостика до вдоль живота - <color=#F3FF00>81 см</color>. Если верить статистике овечка имеет плотность на единицу боковой проекции <color=#F3FF00>9 гр./кв.см.</color> Средняя высота овечки на боковой поверхности <color=#F3FF00>25 см</color>.\n<color=#F3FF00>Сколько весит килограмм овечки?</color>";
                                helpTask.text = "Сколько же весит килограмм? Хмм... \nНаверное, ровно килограмм!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 706);
                                taskText.margin = new Vector4(40, 53.3f, 40, -157);
                                taskText.text = "If you measure the lamb from its scalp to the tail, then it <color=#F3FF00>is 72cm long</color>. If from the tail to along the belly - <color=#F3FF00>81cm</color>. According to the statistics, the sheep has a density per unit of lateral projection of <color=#F3FF00>9 g/sq.cm.</color> The average height of a sheep on the side surface <color=#F3FF00>is 25 cm</color>.\n<color=#F3FF00>How much does a kilo of lamb weigh?</color>";
                                helpTask.text = "How much does a kilogram weigh? Hmm... \nProbably exactly a kilogram!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1101);
                                taskText.margin = new Vector4(40, 53.3f, 40, -554);
                                taskText.text = "Один важный бизнесмен ехал в поезде на бизнес-встречу. Он решил расслабиться и отвлечься, но его голова всё равно постоянно работала и жаждала что-либо посчитать! Он обратил внимание на то, что <color=#F3FF00>каждые 10 минут</color> мимо их поезда проезжает <color=#F3FF00>встречный поезд</color>. Проведя несложные вычисления, он смог посчитать сколько <color=#F3FF00>за сутки</color> прибудет поездов на вокзал, при условии, что <color=#F3FF00>скорости</color> всех поездов <color=#F3FF00>одинаковы</color>. \n<color=#F3FF00>Сколько именно он насчитал?</color>";
                                helpTask.text = "Это не так уж и трудно... Ведь если немного подумать, то получается, что один поезд приезжает каждые 20 минут...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1101);
                                taskText.margin = new Vector4(40, 53.3f, 40, -554);
                                taskText.text = "An important businessman was on the train to a business meeting. He decided to relax and distract, but his head was still constantly working and craving to count something! He drew attention to the fact that <color=#F3FF00>every 10 minutes an oncoming train</color> passes by their train. Having carried out simple calculations, he was able to calculate how many trains will arrive at the station <color=#F3FF00>per day</color>, provided that the <color=#F3FF00>speeds</color> of all trains are <color=#F3FF00>the same</color>. \n<color=#F3FF00>How much did he count?</color>";
                                helpTask.text = "It's not that difficult... After all, if you think a little, it turns out that one train arrives every 20 minutes...";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 830);
                                taskText.margin = new Vector4(40, 53.3f, 40, -260);
                                taskText.text = "На ферме образовалась дилемма. Весы не воспринимали животных по отдельности, вот и пришлось <color=#F3FF00>взвешивать</color> по несколько животных <color=#F3FF00>одновременно</color>. Получилось взвесить <color=#FF7600>4 барашка</color> и <color=#00FFF3>3 курочки</color>, что <color=#F3FF00>вместе весят 15 кг</color>, но при этом <color=#FF7600>3 барашка</color> и <color=#00FFF3>4 курочки</color> <color=#F3FF00>13 кг</color>.\n <color=#F3FF00>Сколько весит одна курочка и один барашек?</color>";
                                helpTask.text = "Не знаю, как курочка, но барашек выглядит на все 3 кг!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 830);
                                taskText.margin = new Vector4(40, 53.3f, 40, -260);
                                taskText.text = "There is a dilemma on the farm. The scales did not perceive the animals separately, so they had to <color=#F3FF00>weigh</color> several animals at <color=#F3FF00>the same time</color>. It turned out to weigh <color=#FF7600>4 lambs</color> and <color=#00FFF3>3 chickens</color>, which <color=#F3FF00>together weigh 15kg</color>, but at the same time <color=#FF7600>3 lambs</color> and <color=#00FFF3>4 chickens</color> are <color=#F3FF00>13kg</color>.\n <color=#F3FF00>How much does one chicken and one lamb weigh?</color>";
                                helpTask.text = "I don't know how the chicken is, but the lamb looks at all 3kg!";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 840);
                                taskText.margin = new Vector4(40, 53.3f, 40, -256);
                                taskText.text = "В клубе по футболу <color=#F3FF00>209 членов</color>.\n <color=#F3FF00>11 -</color> находятся в клубе <color=#FF7600>до 3 лет</color>\n <color=#F3FF00>15 -</color> <color=#FF7600>моложе 20 лет</color> \n<color=#F3FF00>75 -</color> <color=#00FFF3>носят очки</color> \n<color=#F3FF00>170</color> - это конкретно <color=#00B6FF>мужчины</color>. \n<color=#F3FF00>Сколько человек подходит под такое описание</color>: состоят в клубе <color=#FF7600>не меньше трёх лет</color>, их возраст <color=#FF7600>больше 20</color>, <color=#00FFF3>носят очки</color> и являются <color=#00B6FF>мужчинами</color>?";
                                helpTask.text = "Если даже все 39 женщин носили бы очки, то 36 мужчин тоже бы их носили. Если даже 15 из этих мужчин были бы моложе 20 лет, то 21 были бы старше и носили очки. Тогда получается...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 840);
                                taskText.margin = new Vector4(40, 53.3f, 40, -256);
                                taskText.text = "There are <color=#F3FF00>209 members</color> in the football club: \n <color=#F3FF00>11</color> are <color=#FF7600>under 3 years old</color> \n<color=#F3FF00>15</color> <color=#FF7600>under 20 years old</color> \n<color=#F3FF00>75</color> <color=#00FFF3>wear glasses</color> \n<color=#F3FF00>170</color> are specifically <color=#00B6FF>men</color>.\n<color=#F3FF00>How many people fit this description</color>: have been members of the club for <color=#FF7600>at least three years</color>, their age <color=#FF7600>is over 20</color>, <color=#00FFF3>wear glasses</color> and are <color=#00B6FF>men?</color>";
                                helpTask.text = "If even all of 39 women would wear glasses, the 36 men would have worn them. Even if 15 of these men were under 20, 21 would be older and wear glasses. Then it turns out...";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 769);
                                taskText.margin = new Vector4(40, 53.3f, 40, -185);
                                taskText.text = "Мартышки сидят по <color=#F3FF00>одной</color> в каждом <color=#F3FF00>углу</color> комнаты, что представляет собой равносторонний <color=#F3FF00>треугольник</color>. Каждая из мартышек начнёт двигаться в другой <color=#F3FF00>случайно выбранный угол</color> по прямой. \n<color=#F3FF00>Какая вероятность, что ни одна из мартышек не столкнётся с другой?</color>";
                                helpTask.text = "Есть два способа движения, при котором мартышки не встретятся друг с другом: они все должны двигаться по часовой стрелке или все против часовой стрелки. В противном случае встречи им не избежать.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 769);
                                taskText.margin = new Vector4(40, 53.3f, 40, -185);
                                taskText.text = "Monkeys sit <color=#F3FF00>one</color> at each <color=#F3FF00>corner</color> of the room, which is an equilateral <color=#F3FF00>triangle</color>. Each of the monkeys will begin to move to another <color=#F3FF00>randomly selected corner</color> in a straight line. \n<color=#F3FF00>What is the probability that none of the monkeys will collide with another?</color>";
                                helpTask.text = "There are two ways of moving the monkeys to avoid each other: they must all move clockwise or all counterclockwise. Otherwise, they cannot avoid meeting.";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 951);
                                taskText.margin = new Vector4(40, 53.3f, 40, -400);
                                taskText.text = "<color=#00FF49>Джон</color> и <color=#FF7600>Мария</color> решили совместно попробовать сделать <color=#00FFF3>майонез</color>! У <color=#00FF49>Джона</color> получилось сделать <color=#F3FF00>8 литров</color> <color=#00FFF3>майонеза</color>, жирность которого составляла <color=#F3FF00>5%</color>. <color=#FF7600>Мария</color> при этом умудрилась сделать <color=#F3FF00>12 литров</color> <color=#00FFF3>майонеза</color>, жирность которого составляла <color=#F3FF00>8%</color>. Потом они взяли и смешали то, что они наготовили! \n<color=#F3FF00>Сколько теперь процентов жирности в <color=#00FFF3>майонезе</color>, после смешивания?</color>";
                                helpTask.text = "Я не буду тебя испытывать в этой задачке и нагружать расчётами! Поэтому лови ответ: 6,8%";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 951);
                                taskText.margin = new Vector4(40, 53.3f, 40, -400);
                                taskText.text = "<color=#00FF49>John</color> and <color=#FF7600>Maria</color> decided to try to make <color=#00FFF3>mayonnaise</color> together! <color=#00FF49>John</color> managed to make <color=#F3FF00>8 liters</color> of <color=#00FFF3>mayonnaise</color>, the fat content of which was <color=#F3FF00>5%</color>. At the same time, <color=#FF7600>Maria</color> managed to make <color=#F3FF00>12 liters</color> of <color=#00FFF3>mayonnaise</color>, the fat content of which was <color=#F3FF00>8%</color>. Then they took and mixed what they prepared! \n<color=#F3FF00>What is the percentage of fat in the <color=#00FFF3>mayonnaise</color> now, after mixing?</color>";
                                helpTask.text = "I will not test you in this problem and load you with calculations! So, catch the answer: 6,8%";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 572);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#00FF49>Франк</color> умер через <color=#F3FF00>149 лет</color> спустя рождения <color=#00FFF3>Каина</color>. Так получается, что их суммарный возраст <color=#F3FF00>120 лет</color>. <color=#00FFF3>Каин</color> умер в<color=#00FFF3> 30г. до н.э.</color> \n<color=#F3FF00>Когда родился Франк?</color>";
                                helpTask.text = "Между рождением Каина и смертью Франка прошло 150 лет, но, поскольку их суммарный возраст равнялся всего лишь 121 годам, был период времени в 29 лет, когда ни одного из них не было на свете Следовательно, Франк родился через 29 лет после смерти Каина.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 572);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#00FF49>Frank</color> died <color=#F3FF00>149 years</color>  after the birth of <color=#00FFF3>Cain</color>. It turns out that their total age is <color=#F3FF00>120 years</color>. <color=#00FFF3>Cain</color> died in <color=#00FFF3>30 BC.</color> \n<color=#F3FF00>When was Frank born?</color>";
                                helpTask.text = "150 years passed between the birth of Cain and the death of Frank, but since their total age was only 121 years, there was a time period of 29 years when neither of them was in the world. Consequently, Frank was born 29 years after Cain's death...";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1299);
                                taskText.margin = new Vector4(40, 53.3f, 40, -725);
                                taskText.text = "Один состоятельный мужчина завещал несколько миллионов долларов своим сыновьям. Но чтобы получить наследство нужно было открыть сейф. У сейфа было <color=#00FF49>двузначное число</color>. Число же это состояло из <color=#F3FF00>двух последовательных</color> кубов чисел, разница которых является <color=#F3FF00>квадратом полученного числа</color>. Так же было известно, что сумма этих чисел не превышает <color=#F3FF00>20</color>. \nК примеру, <color=#F3FF00>2^3 = 8, 3^3 = 27 \n27-8=19</color>, но <color=#F3FF00>19</color> не является квадратом. \n<color=#F3FF00>Так какой же у сейфа код?</color>";
                                helpTask.text = "Попробуй использовать восьмёрку и соседнее с ним число!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1299);
                                taskText.margin = new Vector4(40, 53.3f, 40, -725);
                                taskText.text = "One wealthy man bequeathed several million dollars to his sons. But to receive the inheritance it was necessary to open the safe. The safe had <color=#00FF49>a two-digit number</color>. This number consisted <color=#F3FF00>of two consecutive</color> cubes of numbers, the difference of which is <color=#F3FF00>the square of the resulting number</color>. It was also known that the sum of these numbers does not exceed <color=#F3FF00>20</color>. \nFor example, <color=#F3FF00>2^3 = 8 \n3^3 = 27  \n27-8 = 19</color>, but <color=#F3FF00>19</color> is not a square. \n<color=#F3FF00>So what's the code for the safe?</color>";
                                helpTask.text = "Try using an eight and the adjacent number!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 678);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "<color=#00FFF3>Яхт-клуб</color> работает только по <color=#F3FF00>понедельникам</color>, <color=#F3FF00>пятницам</color> и по всем <color=#F3FF00>нечетным числам в месяце</color>. Это продолжается уже на протяжении года.  \n<color=#F3FF00>Сколько максимально дней за неделю <color=#00FFF3>Яхт-клуб</color> может работать без выходных?</color>";
                                helpTask.text = "Представим, что в месяце 31 день. \nПонедельник это 26-ое число. \nТогда нечётные дни будут вторник 27-го, четверг 29-го, суббота 31-го и воскресенье 1-го числа. \nПодставляем оставшиеся дни и получаем искомый ответ!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 678);
                                taskText.margin = new Vector4(40, 53.3f, 40, -106);
                                taskText.text = "<color=#00FFF3>The Yacht Club</color> is open only <color=#F3FF00>on Mondays</color>, <color=#F3FF00>Fridays</color> and all <color=#F3FF00>odd days in the month</color>. This has been going on for a year now. \n<color=#F3FF00>How many days per week can the <color=#00FFF3>Yacht Club</color> operate seven days a week?</color>";
                                helpTask.text = "Let's imagine that there are 31 days in a month. \nMonday is the 26th. \nThen the odd days will be Tuesday 27th, Thursday 29th, Saturday 31st and Sunday 1st. \nSubstitute the remaining days and get the desired answer!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1349);
                                taskText.margin = new Vector4(40, 53.3f, 40, -799);
                                taskText.text = "В конце урока учительница математики сказала: \n- Вы хотите узнать мой адрес, чтобы дополнительно позаниматься? Что же, если вы такой же <color=#00FF49>умный</color>, как и <color=#00FFF3>настойчивый</color>, то пожалуйста. \nУлица та на которой мы сейчас находимся, а вот номер дома вы узнаете если вы разделите его на <color=#F3FF00>2, 3, 4, 5 или 6</color>, при этом получите в остатке <color=#F3FF00>1</color>, а на <color=#F3FF00>11</color> он <color=#FF7600>разделится без остатка</color>. Скажу еще, что из всех возможных номеров мой номер самый <color=#FF7600>маленький</color>. \n<color=#F3FF00>Какой номер дома был у учительницы?</color>";
                                helpTask.text = "Всё же ты не настолько хорош! Но настойчивый! \nТак что твой ответ 121!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1349);
                                taskText.margin = new Vector4(40, 53.3f, 40, -799);
                                taskText.text = "At the end of the lesson, the math teacher said: \n- Do you want to know my address in order to study additionally? Well, if you are as <color=#00FF49>smart</color> as you are <color=#00FFF3>persistent</color>, then please. \nShe named the street and the apartment, but you will find out the house number if you divide it by <color=#F3FF00>2, 3, 4, 5 or 6</color>, you will get <color=#F3FF00>1</color> in the remainder, and it will be divided by <color=#F3FF00>11</color> <color=#FF7600>without a remainder</color>. \n- I will also say that of all possible numbers, my number is <color=#FF7600>the smallest</color>. \n<color=#F3FF00>What was the teacher's house number?</color>";
                                helpTask.text = "You're not that good after all! But persistent! So your answer is 121!";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 755);
                                taskText.margin = new Vector4(40, 53.3f, 40, -186);
                                taskText.text = "Кейт встаёт на работу в <color=#00FFF3>8 часов утра</color>. У будильника, которым она пользуется, есть особенность, что <color=#F3FF00>через 3 дня</color> он будет отставать <color=#F3FF00>на 9 минут</color>. \n<color=#F3FF00>Во сколько сработает будильник в четверг утром, если Кейт установит на нем правильное время в 00:00 во вторник?</color>";
                                helpTask.text = "Часы отстают на 3 минуты ежедневно, или на 1 минуту каждые 8 часов. Между 11 часами воскресного вечера 7 часами утра во вторник пройдет \n24 + 8 часов. Следовательно...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 755);
                                taskText.margin = new Vector4(40, 53.3f, 40, -186);
                                taskText.text = "Kate gets up at <color=#00FFF3>8 AM</color> to get to work in time. The alarm clock she uses has a peculiarity that <color=#F3FF00>after 3 days</color> it will be <color=#F3FF00>9 minutes</color> behind. \n<color=#F3FF00>What time will the alarm go off on Thursday morning if Kate sets it to the correct time at 00:00 on Tuesday?</color>";
                                helpTask.text = "The clock is 3 minutes behind every day, or 1 minute every 8 hours. Between 11 o'clock Sunday evening 7 o'clock on Tuesday morning there will be 24 + 8 hours Therefore...";
                            }
                            break;
                        case 20:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#FF7600>Фанеру</color>, которая лежит на <color=#00FFF3>двух бочках</color>, толкают на <color=#F3FF00>44 см в одну сторону. \nКакое расстояние преодолеют бочки?</color>";
                                helpTask.text = "Добрый я сегодня. Твой ответ: 22 см.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "<color=#FF7600>The plywood</color>, which lies on <color=#00FFF3>two barrels</color>, is pushed <color=#F3FF00>44cm to one side. \nHow far will the barrels travel?</color>";
                                helpTask.text = "I'm kind today. Your answer: 22cm.";
                            }
                            break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.LatestDevelopments:
                    switch (currentLevel)
                    {
                        case 1:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 561);
                                taskText.margin = new Vector4(40, 53.3f, 40, -6);
                                taskText.text = "Археологи нашли <color=#F3FF00>6 сундуков</color> с дублонами. \nПервый сундук имел <color=#F3FF00>180 дублонов</color>, следующий - <color=#F3FF00>90</color>, за ним - <color=#F3FF00>60</color>, после него - <color=#F3FF00>45</color>, а в предпоследнем - <color=#F3FF00>36</color>. \nСколько дублонов содержал в себе последний сундук?";
                                helpTask.text = "Во втором сундуке 1/2 от количества дублонов в первом сундуке. А в третьем уже 2/3 от количества дублонов во втором. Ничего сложного!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 574);
                                taskText.margin = new Vector4(40, 53.3f, 40, -6);
                                taskText.text = "Archaeologists have found <color=#F3FF00>6 chests</color> with doubloons. \nThe first chest had <color=#F3FF00>180 doubloons</color>, the next one had <color=#F3FF00>90</color>, followed by <color=#F3FF00>60</color>, followed by <color=#F3FF00>45</color>, and the last but one had <color=#F3FF00>36</color>. \nHow many doubloons did the last chest contain?";
                                helpTask.text = "In the second chest, 1/2 of the number of doubloons in the first chest. And in the third, already 2/3 of the number of doubloons in the second. Nothing complicated!";
                            }
                            break;
                        case 2:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 661);
                                taskText.margin = new Vector4(19, 53.3f, 19, -110);
                                taskText.text = "Один банкир сказал: \n- Я положил в эти пять ячеек <color=#F3FF00>сто монет</color>. \nВ первой и второй ячейках <color=#F3FF00>52 монеты</color>, во второй и третьей - <color=#F3FF00>43</color>, в третьей и четвертой - <color=#F3FF00>34</color>, в четвертой и пятой - <color=#F3FF00>30</color>. \n<color=#F3FF00>Сколько монет в третьей ячейке?</color>";
                                helpTask.text = "Тут совсем просто! Нужно лишь из общего количества вычесть сумму других монет. Ничего сложного, тем более что все суммы уже известны!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 661);
                                taskText.margin = new Vector4(40, 53.3f, 40, -110);
                                taskText.text = "One banker said: \n- I put <color=#F3FF00>one hundred</color> coins in these five cells. \nIn the first and second cells there are <color=#F3FF00>52 coins</color>, in the second and third - <color=#F3FF00>43</color>, in the third and fourth - <color=#F3FF00>34</color>, in the fourth and fifth -  <color=#F3FF00>30</color>. \n<color=#F3FF00>How many coins are in the third cell?</color>";
                                helpTask.text = "It's easy! You just need to subtract the amount of other coins from the total. Nothing complicated, especially since all the amounts are already known!";
                            }
                            break;
                        case 3:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1840);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1270);
                                taskText.text = "Один начинающий бизнесмен имел определённую сумму денег, которую необходимо было <color=#F3FF00>всю вложить</color> в рабочих на <color=#F3FF00>два дня</color>. Бизнесмен был очень оптимистичен, и подумал, что если люди будут быстро и качественно выполнять работу, то на второй день можно будет сократить количество работников <color=#F3FF00>на пять человек</color>, но так как отчёт о затратах необходимо было предоставить начальству, необходимо было выплатить каждому <color=#F3FF00>на два доллара больше</color>. Но, увы, по прошествии целого дня работники, не только не стали быстрее выполнять свои задачи, но и пришлось <color=#F3FF00>четырёх человек</color> нанять дополнительно! Бизнесмен рассчитал, что теперь каждый получит <color=#F3FF00>на один доллар меньше</color>. \n<color=#F3FF00>Сколько получил каждый из работников во второй день?</color>";
                                helpTask.text = "Изначально было 20 работников.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1840);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1270);
                                taskText.text = "One novice businessman had a certain amount of money that needed to be invested <color=#F3FF00>all in workers for two days</color>. Businessman was very optimistic, and thought that If people will quickly and efficiently carry out the work, then on the second day it will be possible to reduce the number to <color=#F3FF00>five workers</color>, but as the report on the costs needed to provide the authorities, it was necessary to pay for each <color=#F3FF00>two dollars more</color>. But, alas, after a whole day, the workers not only did not begin to complete their tasks faster, but also had to hire <color=#F3FF00>four additional people</color>! The businessman calculated that now everyone will receive <color=#F3FF00>one dollar less</color>. \n<color=#F3FF00>How many each of the workers got on the second day?</color>";
                                helpTask.text = "There were originally 20 workers.";
                            }
                            break;
                        case 4:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1034);
                                taskText.margin = new Vector4(40, 53.3f, 40, -480);
                                taskText.text = "Один работодатель смог уговорить местного <color=#00FFF3>лодыря Брюса</color> взяться за работу. По условию контракта <color=#00FFF3>Брюс</color> должен работать в течение <color=#F3FF00>30 дней без выходных</color>, получая по <color=#F3FF00>4 евро</color> за работу <color=#F3FF00>в день</color> при условии, что за <color=#F3FF00>каждый день</color>, когда <color=#00FFF3>он</color> не работает, <color=#00FFF3>он</color> платит штраф <color=#F3FF00>6 евро</color>. В конце месяца выяснилось, что размер штрафа был <color=#F3FF00>такой же</color>, как и размер зарплаты.\n <color=#F3FF00>Сколько же дней <color=#00FFF3>лодырь Брюс</color> работал?</color>";
                                helpTask.text = "Лодырь Брюс умудрился проработать целых 18 дней! Жаль, что у него выходных нет...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1034);
                                taskText.margin = new Vector4(40, 53.3f, 40, -480);
                                taskText.text = "One employer was able to persuade local <color=#00FFF3>quitter Bruce</color> to take the job. According to the terms of the contract, <color=#00FFF3>Bruce</color> must work for <color=#F3FF00>30 days</color> seven days a week, receiving <color=#F3FF00>4 euros</color> for work <color=#F3FF00>per day</color>, provided that for <color=#F3FF00>each day</color> <color=#00FFF3>he does not work</color>, <color=#00FFF3>he</color> pays a fine of <color=#F3FF00>6 euros</color>. At the end of the month, it turned out that the fine was <color=#F3FF00>the same</color> as the salary. \n <color=#F3FF00>How many days did <color=#00FFF3>Bruce the quitter</color> work?</color>";
                                helpTask.text = "Bruce the quitter managed to work for 18 days! It is a pity that he has no days off...";
                            }
                            break;
                        case 5:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1103);
                                taskText.margin = new Vector4(40, 53.3f, 40, -548);
                                taskText.text = "Первым <color=#F3FF00>четырём</color> пришедшим на вечеринку давали <color=#FF7600>конфетки</color>! Томми дали <color=#00FF49>одну</color> <color=#FF7600>конфетку</color> и <color=#00FFF3>четверть оставшихся</color>, Кейт дали <color=#00FF49>одну</color> <color=#FF7600>конфетку</color> и <color=#00FFF3>четверть оставшихся</color>, Боб также получил <color=#00FF49>одну</color> <color=#FF7600>конфетку</color> и <color=#00FFF3>четверть оставшихся</color>, последняя гостья Мария получила <color=#00FF49>одну</color> <color=#FF7600>конфетку</color> и <color=#00FFF3>четверть оставшихся</color>. Оказалось, что Томми и Боб получили на <color=#F3FF00>100</color> <color=#FF7600>конфеток</color> <color=#F3FF00>больше</color>, чем Кейт и Мария. \n<color=#F3FF00>Сколько осталось конфет у организатора вечеринки?</color>";
                                helpTask.text = "Пока не пришли гости, у организатора было 1021 конфеток.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1128);
                                taskText.margin = new Vector4(40, 53.3f, 40, -548);
                                taskText.text = "The first <color=#F3FF00>four</color> to attend the party were given <color=#FF7600>candy</color>! Tommy was given <color=#00FF49>one</color> <color=#FF7600>candy</color> and <color=#00FFF3>a quarter of the remaining</color>, Kate was given <color=#00FF49>one</color> <color=#FF7600>candy</color> and <color=#00FFF3>a quarter of the remaining</color>, Bob also received <color=#00FF49>one</color> <color=#FF7600>candy</color> and <color=#00FFF3>a quarter of the remaining</color>, the last guest Maria received <color=#00FF49>one</color> <color=#FF7600>candy</color> and <color=#00FFF3>a quarter of the remaining</color>. It turned out that Tommy and Bob got <color=#F3FF00>100</color> <color=#F3FF00>more</color> <color=#FF7600>candy</color> than Kate and Maria. \n<color=#F3FF00>How many sweets does the party organizer have left?</color>";
                                helpTask.text = "Until the guests arrived, the organizer had 1021 candy.";
                            }
                            break;
                        case 6:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 764);
                                taskText.margin = new Vector4(40, 53.3f, 40, -186);
                                taskText.text = "В египетских покоях фараона прислужник заметил, что амфора, наполненная <color=#00FFF3>водой</color>, весит <color=#F3FF00>1000 грамм</color>. Но амфора, которую, наполняют <color=#FF7600>мистическим маслом</color>, весит <color=#F3FF00>1600 грамм</color>. <color=#FF7600>Мистическое масло</color> же оказывается <color=#F3FF00>в 2 раза тяжелее</color> <color=#00FFF3>воды</color>. \n<color=#F3FF00>Каков же вес амфоры?</color>";
                                helpTask.text = "X - вес амфоры, Y - вес воды и М - вес масла, \n(по условию М= 2Y) \nСоставляем систему уравнений \nX + Y = 1000 г \nX + 2Y = 1600 г \nВычитаем из второго уравнения первое и получаем, что \nY = 600 \nДальше можешь самостоятельно решить концовку...";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 764);
                                taskText.margin = new Vector4(40, 53.3f, 40, -186);
                                taskText.text = "In the Egyptian chambers of the pharaoh, the attendant noticed that the amphora, filled with <color=#00FFF3>water</color>, weighs <color=#F3FF00>1000 grams</color>. But the amphora, which is filled with <color=#FF7600>mystical oil</color>, weighs <color=#F3FF00>1600 grams</color>. But <color=#FF7600>mystical oil</color> turns out to be <color=#F3FF00>2 times heavier</color> than <color=#00FFF3>water</color>. \n<color=#F3FF00>What is the weight of the amphora?</color>";
                                helpTask.text = "X - amphora weight, Y - water weight and O - oil weight, \n(by condition O = 2Y) \nWe compose a system of equations \nX + Y = 1000g \nX + 2Y = 1600g \nWe subtract the first from the second equation and get that \nY = 600 \nThen you can decide the ending yourself...";
                            }
                            break;
                        case 7:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 730);
                                taskText.margin = new Vector4(40, 53.3f, 40, -147);
                                taskText.text = "<color=#F3FF00>Два квадратных участка</color> огорода необходимо вскопать ямами размером 1 м^2. \nВсего для этого потребуется <color=#F3FF00>2120 ям</color>, при этом одна сторона участка <color=#F3FF00>на 12 м больше</color>, чем сторона другого. \n<color=#F3FF00>Какова сумма размеров этих участков?</color>";
                                helpTask.text = "Суммируем площади и находим неизвестные: \nx^2+(x+12)^2=2120 \nЛибо, если ты не знаешь, что такое дискриминант, то можешь методом подбора найти!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 685);
                                taskText.margin = new Vector4(40, 53.3f, 40, -147);
                                taskText.text = "<color=#F3FF00>Two square areas</color> of the garden must be dug up with pits measuring 1 m^2. \nIn total, this will require <color=#F3FF00>2120 pits</color>, with one side of the area <color=#F3FF00>12m larger</color> than the side of the other. \n<color=#F3FF00>What is the sum of the sizes of these areas?</color>";
                                helpTask.text = "We sum up the areas and find the unknowns: \nx^2+(x+12)^2=2120. \nOr, if you do not know what a discriminant is, then you can find it by selection!";
                            }
                            break;
                        case 8:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1295);
                                taskText.margin = new Vector4(40, 53.3f, 40, -744);
                                taskText.text = "Трое известных парней в своей округе, зашли в салун и решили украсть вино. \n<color=#00FF49>Макс</color> взял <color=#F3FF00>половину</color> от всех бутылок вина, но понял, что <color=#F3FF00>10</color> из них он точно не донесёт и оставил их. \n<color=#00FFF3>Боб</color> решил украсть <color=#F3FF00>треть</color> оставшихся, но вернул назад <color=#F3FF00>2</color> бутылки белого вина, ведь он его не любит. \n<color=#FF7600>Шон</color> взял <color=#F3FF00>половину</color> от оставшихся бутылок, но сразу решил оставить <color=#F3FF00>одно</color> сухое. После их грабежа в салуне осталось <color=#F3FF00>7</color> бутылок. \n<color=#F3FF00>Сколько изначально было бутылок?</color>";
                                helpTask.text = "Считай с конца! \nОсталось 7 бутылок. \nДо того, как Шон забрал было \n(7-1)*2 \nбутылок! \nА теперь продолжай считать!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1317);
                                taskText.margin = new Vector4(40, 53.3f, 40, -744);
                                taskText.text = "Three famous people in their area entered the saloon and decided to steal wine. \n<color=#00FF49>Max</color> took <color=#F3FF00>half</color> of all the bottles of wine, but realized that <color=#F3FF00>10</color> of them he definitely сould not deliver and left them. \n<color=#00FFF3>Bob</color> decided to steal a <color=#F3FF00>third</color> part of the remaining, but returned back <color=#F3FF00>2</color> bottles of white wine, because he does not like it. \n<color=#FF7600>Sean</color> took <color=#F3FF00>half</color> of the remaining bottles, but immediately decided to leave <color=#F3FF00>one</color> dry. After their robbery, <color=#F3FF00>7</color> bottles remained in the saloon. \n<color=#F3FF00>How many bottles were there originally?</color>";
                                helpTask.text = "Count from the end! 7 bottles left. \nBefore Sean took \n(7-1)*2 \nbottles! \nNow keep counting!";
                            }
                            break;
                        case 9:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 960);
                                taskText.margin = new Vector4(40, 53.3f, 40, -409);
                                taskText.text = "Одна компания наняла <color=#00FFF3>10 начинающих программистов</color> и <color=#00FF49>1 программиста с небольшим опытом работы</color>. \n<color=#00FFF3>Начинающие программисты</color> получали по <color=#F3FF00>25$/час</color>, а <color=#00FF49>программист с небольшим опытом работы</color> на <color=#F3FF00>5$/час больше</color>, чем <color=#F3FF00> каждый</color> из <color=#00FFF3>начинающих программистов</color>. \n<color=#F3FF00>Сколько получал программист с небольшим опытом работы?</color>";
                                helpTask.text = "Для такой задачки подсказка? Удивительно... Твой ответ 30!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 960);
                                taskText.margin = new Vector4(40, 53.3f, 40, -409);
                                taskText.text = "One company hired <color=#00FFF3>10 novice programmers</color> and <color=#00FF49>1 programmer with little experience</color>. \n<color=#00FFF3>Novice programmers</color> received <color=#F3FF00>25$/hour</color>, and <color=#00FF49>the programmer with little experience</color> earned <color=#F3FF00>5$/hour</color> more than <color=#F3FF00>each</color> of <color=#00FFF3>the novice programmers</color>. \n<color=#F3FF00>How much did the programmer with little work experience get?</color>";
                                helpTask.text = "For such a problem, a hint? Amazing... Your answer is 30!";
                            }
                            break;
                        case 10:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1275);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 2549);
                                helpTask.margin = new Vector4(35, 0, 35, -1181);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "(x-y)/(x+y)=0.6 \n\n<color=#F3FF00>Какие должны быть X и Y?</color>";
                                helpTask.text = "Раз ответ является отличающимся от нуля вещественным числом, то \"x\" и \"y\" отличны от нуля (представим если \ny=0 \nтогда: \nx/x=0.6 - что невозможно.) \nИтак. Умножаем обе части уравнения на (x+y) и после элементарных преобразовании получаем \n 0,4x=1,6y \nОтсюда следует, что x=4y. Далее подставляем в первоначальное значение вместо \"x\" и находим \"y\". Последнее значение подставляем в x=4y и получаем искомые числа.";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1275);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 2549);
                                helpTask.margin = new Vector4(35, 0, 35, -1181);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
                                taskText.margin = new Vector4(40, 53.3f, 40, 15);
                                taskText.text = "(x-y)/(x+y)=0.6 \n\n<color=#F3FF00>What should be X and Y?</color>";
                                helpTask.text = "Since the answer is a nonzero real number, then \"x \" and \"y \" are nonzero (imagine if \ny=0 \nthen: \nx/x=0.6 - which is impossible.) \nSo. We multiply both sides of the equation by (x+y) and after elementary transformations we get \n 0,4x=1,6y \n From this it follows that x=4y. Then we substitute \"x \" into the initial value and find \"y \". We substitute the last value in x=4y and get the required numbers.";
                            }
                            break;
                        case 11:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1506);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3013);
                                helpTask.margin = new Vector4(35, 0, 35, -1613);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1410);
                                taskText.margin = new Vector4(40, 53.3f, 40, -838);
                                taskText.text = "<color=#00FF49>Джонни</color> решил на этой недели закупиться в магазинах на <color=#F3FF00>все деньги</color>! \n<color=#F3FF00>Перед тем</color> как пойти за покупками, <color=#00FF49>Джонни</color> заходит в небольшой ресторанчик и кушает на <color=#F3FF00>100$</color>. \nТолько после того, как <color=#00FF49>Джонни</color> <color=#F3FF00>покушает</color>, <color=#00FF49>он</color> заходит в разные магазины и тратит <color=#F3FF00>половину всех оставшихся денег</color>! \nПосле чего возвращается в свой любимый небольшой ресторанчик и снова кушает на <color=#F3FF00>100$</color>. \nСпустя <color=#F3FF00>неделю</color> такой жизни у <color=#00FF49>Джонни</color> закончились деньги. \n<color=#F3FF00>Сколько денег у <color=#00FF49>Джонни</color> было изначально?</color>";
                                helpTask.text = "Решение простое. Решать надо с конца, то есть начиная с 7-го дня. Так как у него не осталось совсем денег, то у Джонни было 0$. Перед тем как остаться без денег Джонни кушал. Это 100$. Перед тем, как покушать, Джонни тратил половину всех денег. Поэтому количество денег надо увеличивать вдвое. Это 200$. Перед тем как потратить деньги в магазинчиках, Джонни кушал ещё на 100$. Теперь у Джонни в начале 7-го дня 300$. В начале шестого дня у Джонни было \n(300+100)*2+100\nПовторяем расчёты, пока не доберёмся до начала первого дня.";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1506);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3013);
                                helpTask.margin = new Vector4(35, 0, 35, -1613);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1410);
                                taskText.margin = new Vector4(40, 53.3f, 40, -838);
                                taskText.text = "<color=#00FF49>Johnny</color> decided to spend <color=#F3FF00>all the money</color> he had in stores this week! \n<color=#F3FF00>Before</color> going shopping, <color=#00FF49>Johnny</color>  walked into a small restaurant and eats for <color=#F3FF00>100$</color>. \nOnly after <color=#00FF49>Johnny</color> has <color=#F3FF00>eaten</color> does <color=#00FF49>he</color> went to various stores and spend <color=#F3FF00>half of all the remaining money</color>! \nThen he returns to his favorite small restaurant and again ate for <color=#F3FF00>100$</color>. \nAfter <color=#F3FF00>a week</color> of this life, <color=#00FF49>Johnny</color> ran out of money. \n<color=#F3FF00>How much money did <color=#00FF49>Johnny</color> have initially?</color>";
                                helpTask.text = "The solution is simple. It is necessary to decide from the end, that is, starting from the 7th day. Since he had no money left at all, Johnny had 0$. Johnny ate before running out of money. It's 100$. Johnny spent half of his money before eating. Therefore, the amount of money must be doubled. It's 200$. Before spending money in shops, Johnny ate 100$ more. Johnny now has 300$ at the start of day 7. Johnny had \n(300+100)*2+100 \nat the beginning of the sixth day, we repeat the calculations until we get to the beginning of the first day.";
                            }
                            break;
                        case 12:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1962);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1411);
                                taskText.text = "Совсем недавно, один молодой человек, купил дом с увлекательной историей. \n<color=#F3FF00>Четверть своего существования</color> этот дом принадлежал настоящим <color=#00FF49>богачам</color>. Снаружи казалось, что он был сделан из <color=#F3FF00>чистого золота</color>, а внутри красовались люстры с небольшим количеством <color=#00FFF3>алмазов</color>. \nПосле этого промежутка времени, дальнейшее существование были не самыми хорошими. Прежний владелец забрал всё богатство и переехал в другую страну, и здание пустовало <color=#F3FF00>одну пятую своего существования</color>, пока его не купил один предприниматель... \n<color=#F3FF00>Следующие треть времени существования</color> дома были потрачены на <color=#FF7600>ремонт</color> и <color=#FF7600>подготовку к использованию</color>. \n<color=#F3FF00>Последние 13 лет</color> этот дом используют в качестве <color=#00FF49>отеля</color>. \n<color=#F3FF00>Сколько этот дом простоял со дня основания?</color>";
                                helpTask.text = "Допустим, дому \"x\" лет. \nУ богачей он был х/4, \nпустовал - х/5 \nи был на ремонте х/3. \nТогда получаем простое уравнение: \nх/4+х/5+х/3+13=х";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1962);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1411);
                                taskText.text = "More recently, a young man bought a house with a fascinating history. \n<color=#F3FF00>For a quarter of its existence</color>, this house belonged to the real <color=#00FF49>rich</color>. From the outside it looked like it was made of <color=#F3FF00>pure gold</color>, while inside there were chandeliers with a small amount of <color=#00FFF3>diamonds</color>. \nAfter this period of time, it's existence was not the best. The previous owner took all the wealth and moved to another country, and the building was empty for <color=#F3FF00>one-fifth of its existence</color> until one entrepreneur bought it. \n<color=#F3FF00>The next third of the house's existence</color> was spent on <color=#FF7600>renovation</color> and <color=#FF7600>preparation for use</color>. \nThe house has been used as <color=#00FF49>a hotel</color> for <color=#F3FF00>the past 13 years</color>.\n<color=#F3FF00> How long has this house stood since its foundation?</color>";
                                helpTask.text = "Let's say the house is \"x\" years old. \nThe rich had x/4, \nit was empty - x/5 \nand was being repaired x/3. \nThen we get a simple equation: \nx/4+x/5+x/3+13=x";
                            }
                            break;
                        case 13:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2085);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1509);
                                taskText.text = "Один магазин проводил <color=#F3FF00>незабываемую акцию</color>! Этот магазинчик продавал просто <color=#00FF49>потрясные карандаши</color> от <color=#F3FF00>лучших</color> производителей!\n Но у него было <color=#F3FF00>одно условие</color>. \nЦенник на всех карандашах <color=#FF7600>отсутствует</color>, и нужно самому догадаться <color=#F3FF00>сколько стоит тот или иной карандаш.</color> \nЗа <color=#F3FF00>5 минут</color> было совершено <color=#00FFF3>две сделки</color>. \n<color=#00FFF3>В первой сделке</color> <color=#FF7600>шесть красных карандашей с изображением оленя</color> и <color=#00FFF3>два синих карандаша с изображением солнца</color> были проданы за ту же сумму, что и <color=#F3FF00>четыре золотых карандаша</color>. \n<color=#00FFF3>Во второй сделке</color> <color=#FF7600>два красных карандаша с изображением оленя</color>, <color=#00FFF3>четыре синих карандаша с изображением солнца</color> и <color=#F3FF00>шесть золотых карандашей</color> проданы вместе за <color=#F3FF00>50 долларов. \nСколько стоит <color=#00FFF3>1 синий карандаш с изображением солнца</color>?</color>";
                                helpTask.text = "Красный карандаш с изображением оленя стоит 2 доллара, а золотой карандаш стоит 5 долларов.";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2085);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1509);
                                taskText.text = "One store held <color=#F3FF00>an unforgettable promotion</color>! This shop sold some <color=#00FF49>amazing pencils</color> from <color=#F3FF00>the best</color> brands! \nBut he had <color=#F3FF00>one condition</color>. \nThere is <color=#FF7600>no price</color> tag on all pencils, and you yourself need to guess <color=#F3FF00>how much this or that pencil costs</color>. \n<color=#00FFF3>Two deals</color> were made in <color=#F3FF00>5 minutes</color>. \n<color=#00FFF3>In the first deal</color>, <color=#FF7600>six red deer pencils</color> and <color=#00FFF3>two blue sun pencils</color> were sold for the same amount as <color=#F3FF00>four gold pencils</color>. \n<color=#00FFF3>In the second deal</color>, <color=#FF7600>two red deer pencils</color>, <color=#00FFF3>four blue sun pencils</color>, and <color=#F3FF00>six gold pencils</color> are sold together for <color=#F3FF00>50$. \nHow much is <color=#00FFF3>1 blue sun pencil</color>?</color>";
                                helpTask.text = "A red deer pencil costs 2$ and a gold pencil costs 5$.";
                            }
                            break;
                        case 14:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1287);
                                taskText.margin = new Vector4(40, 53.3f, 40, -737);
                                taskText.text = "Однажды в школе ученики решили провернуть вот такую вещь.\n <color=#F3FF00>Девять мальчиков</color> и <color=#00FF49>три девочки</color> решили собрать все свои деньги и разделить <color=#F3FF00>поровну</color>. При этом <color=#F3FF00>каждый мальчик</color> передал <color=#F3FF00>одинаковую</color> сумму <color=#00FF49>каждой девочке</color>, а каждая из <color=#00FF49>девочек</color> отдала также <color=#FF7600>одинаковую между собой</color>, но отличающуюся от денег <color=#F3FF00>мальчиков</color>, сумму <color=#F3FF00>каждому мальчику</color>. \nУ всех детей после этого денег <color=#F3FF00>стало поровну</color>. \n<color=#F3FF00>Какова же может быть наименьшая сумма, которая могла быть первоначально у каждого из них?</color>";
                                helpTask.text = "Знаешь, а я подсмотрел и у каждой девочки было 36 центов, из которых каждая дала по 3 цента каждому мальчику... Только тсс. Никому!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1315);
                                taskText.margin = new Vector4(40, 53.3f, 40, -737);
                                taskText.text = "Once at school, the students decided to do this kind of thing. \n <color=#F3FF00>Nine boys</color> and <color=#00FF49>three girls</color> decided to collect all their money and divide it <color=#F3FF00>equally</color>. Moreover, <color=#F3FF00>each boy</color> gave the <color=#F3FF00>same</color> amount to <color=#00FF49>each girl</color>, and each of the <color=#00FF49>girls</color> also gave the <color=#FF7600>same amount</color>, but different from the <color=#F3FF00>boys'</color> money, to <color=#F3FF00>each boy</color>. \nAfter that, all the children <color=#F3FF00>had equal money</color>. \n<color=#F3FF00>What could be the smallest amount that each of them could have originally?</color>";
                                helpTask.text = "You know, I spied on and each girl had 36 cents, of which each gave 3 cents to each boy... Just shh. Nobody!";
                            }
                            break;
                        case 15:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1506);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3013);
                                helpTask.margin = new Vector4(35, 0, 35, -1613);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2029);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1483);
                                taskText.text = "Этой зимой встретилось два друга. Интересно то, что оба <color=#F3FF00>невероятно сильно</color> любят <color=#00FF49>печеньки</color> и используют их <color=#F3FF00>вместо денег</color>! Встретившись <color=#00FFF3>Джек</color> сказал: \n- Это моя корзинка рядом с тобой? <color=#FF7600>Алекс</color>, дай мне столько <color=#00FF49>печенек</color>, сколько найдёшь внутри! \n<color=#FF7600>Алекс</color> отдал <color=#F3FF00>содержимое</color> корзинки, добавил <color=#F3FF00>столько же</color> сколько у него было в тайном кармане пиджака и заметил: \n- <color=#00FFF3>Джек</color>, послушай, теперь если ты отдашь столько <color=#00FF49>печенек</color>, сколько у меня осталось в тайном кармане, то ни ты, ни я не будем должны друг другу. Идёт? \nПосле расплаты долга таким интересным способом, у <color=#00FFF3>Джека</color> на руках было <color=#00FF49>7 печенек</color>. Но вот у <color=#FF7600>Алекса</color>, который расплатился с долгом, осталось всего лишь <color=#00FF49>6 печенек</color>. \n<color=#F3FF00>Сколько было <color=#00FF49>печенек</color> с самого начала разговора у каждого из приятелей?</color>";
                                helpTask.text = "Давай идти с самого конца, так как конечный результат известен. Вот смотри. У Алекса стало 6 печенек после того, как Джек отдал ему столько, сколько было у Алекса в кармане. Значит у Алекса было 3 печеньки, а у Джека 10. Перед этим всем Алекс отдал содержимое корзинки плюс столько же из кармана. Это одинаковое число печенек. Так же известно, что у Джека изначально на руках было 0 печенек, а сумма корзинки и тайного кармана равна 10. Единственная сумма равных чисел, которая даёт результат 10, является 5 и 5. Соответственно, до расплаты долга у Алекса было 8, а у Джека 5 печенек!";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1506);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3013);
                                helpTask.margin = new Vector4(35, 0, 35, -1613);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2056);
                                taskText.margin = new Vector4(40, 53.3f, 40, -1483);
                                taskText.text = "Two friends met this winter. Interestingly, both are <color=#F3FF00>incredibly fond</color> of <color=#00FF49>cookies</color> and use them <color=#F3FF00>instead of money</color>! <color=#00FFF3>Jack</color> said: \n- Is this my basket next to you? <color=#FF7600>Alex</color>, give me as many <color=#00FF49>cookies</color> as you find inside! \n<color=#FF7600>Alex</color> handed over <color=#F3FF00>the contents</color> of the basket, added <color=#F3FF00>as many as he had</color> in his secret jacket pocket and remarked: \n- <color=#00FFF3>Jack</color>, listen, now if you give as many <color=#00FF49>cookies</color> as I have left in my secret pocket, then neither you nor I will owe a friend friend. Is it going? \nAfter reckoning debt such an interesting way, in <color=#00FFF3>Jack</color> and in his arms was <color=#00FF49>7 cookies</color>. But here at <color=#FF7600>Alex</color> and who paid the debt, it remains only <color=#00FF49>6 cookies</color>. \n<color=#F3FF00>How many <color=#00FF49>cookies</color> did each of your friends have since the beginning of the conversation?</color>";
                                helpTask.text = "Let's go from the very end, as the end result is known. Here look. Alex got 6 cookies after Jack gave him as much as Alex had in his pocket. So Alex had 3 cookies, and Jack had 10. Before that Alex gave everyone the contents of the basket plus the same amount from his pocket. This is the same number of cookies. It is also known that Jack initially had 0 cookies on his hands, and the sum of the basket and the secret pocket was 10. The only sum of equal numbers that gives the result of 10 is 5 and 5. Accordingly, before paying off the debt, Alex had 8, and Jack 5 cookies!";
                            }
                            break;
                        case 16:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 857);
                                taskText.margin = new Vector4(40, 53.3f, 40, -276);
                                taskText.text = "Как-то между двумя друзьями завязался разговор: \n- Слушай, <color=#00FF49>Джонни</color>, а ты знал, что если сложить <color=#F3FF00>возраст каждого</color> из твоей семьи, а вас целых <color=#F3FF00>пятеро</color> в семье, то получается <color=#F3FF00>80</color>, а <color=#F3FF00>пять лет</color> назад было всего лишь <color=#F3FF00>56</color>. \n<color=#F3FF00>Сколько младшему уже исполнилось то?</color> \nСам помнишь или подсказать?";
                                helpTask.text = "Ух, добрый я сегодня котик. Не буду грузить расчётами! Просто скажу, что младшему всего лишь 4 годика!";
                            }
                            else
                            {
                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 857);
                                taskText.margin = new Vector4(40, 53.3f, 40, -276);
                                taskText.text = "Once a conversation started between two friends: \n- Listen, <color=#00FF49>Johnny</color>, did you know that if you add up <color=#F3FF00>the age of each</color> of your family member, while there <color=#F3FF00>are five</color> of you in the family, then you get <color=#F3FF00>80</color>, and <color=#F3FF00>five years</color> ago it was only <color=#F3FF00>56</color>. \n<color=#F3FF00>How many years the youngest has already turned if so?</color> \nDo you remember or should I suggest?";
                                helpTask.text = "Wow, I'm a good cat today. I will not load with calculations! I'll just say that the youngest is only 4 years old!";
                            }
                            break;
                        case 17:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1506);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3013);
                                helpTask.margin = new Vector4(35, 0, 35, -1613);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2764);
                                taskText.margin = new Vector4(40, 53.3f, 40, -2202);
                                taskText.text = "Три подруги <color=#00FF49>Кейт</color>, <color=#FF7600>Мария</color> и <color=#00FFF3>Виолетта</color>, купили <color=#F3FF00>литр великолепного кваса</color>! Но он был <color=#00B6FF>тёплым</color>, так что они оставили его в <color=#00B6FF>холодильнике</color> и пошли гулять по городу. \nПервым пришла домой <color=#00FF49>Кейт</color>. <color=#F3FF00>Жара была невыносимой!</color> И хоть подруги и договорились, что выпьют этот <color=#F3FF00>прекрасный квас</color> вместе, <color=#00FF49>Кейт</color> не смогла удержаться и выпила <color=#F3FF00>целый бокал кваса</color>! А чтобы скрыть следы своего преступления, она добавила столько же <color=#00B6FF>воды</color>, сколько выпила <color=#F3FF00>кваса</color> и пошла смотреть телевизор в ожидании подруг. \nЧерез полчаса пришла <color=#FF7600>Мария</color> и сделала <color=#F3FF00>тоже самое</color>, что и <color=#00FF49>Кейт</color>! \nКогда пришла <color=#00FFF3>Виолетта</color>, она с <color=#F3FF00>ужасом(!)</color> обнаружила, что квас <color=#00B6FF>разбавлен водой</color> ровно <color=#F3FF00>на половину</color>! \n\n<color=#00FFF3>Виолетта</color> обожала квас. Она не могла простить своих подруг просто так... Всё равно ей не хотелось с ними общаться, поэтому <color=#00FFF3>Виолетта</color> решила, что должна точно <color=#F3FF00>посчитать с точностью до грамма вместимость бокала</color>, чтобы потом предъявить счёт, где один бокал кваса равняется одному грамму бокала! \n<color=#F3FF00>Сколько же у <color=#00FFF3>неё</color> получилось после всех расчётов?</color>";
                                helpTask.text = "1000 - X - ( X - X * X/1000) = 500, где:\n1000 - объем кваса в начале; \nX - количество кваса выпитого в первый раз Кейт(и он же объем стакана); \n( X - X * X/1000 ) - количество выпитого Марией \n(Мария выпила не чистый квас, а смесь кваса и воды, которую сделала Кейт: \nX/1000 - вода в этой смеси, получается \nX*X/1000 - количество воды примешанного в стакане у Марии). \nДальше формула сокращается, преобразовывается в квадратное уравнение, с решением через дискриминант!";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1506);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3013);
                                helpTask.margin = new Vector4(35, 0, 35, -1613);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2764);
                                taskText.margin = new Vector4(40, 53.3f, 40, -2202);
                                taskText.text = "Three friends <color=#00FF49>Kate</color>, <color=#FF7600>Maria</color> and <color=#00FFF3>Violetta</color>, bought <color=#F3FF00>a liter of excellent kvass</color>! But it was <color=#00B6FF>warm</color>, so they left it in the <color=#00B6FF>refrigerator</color> and went for a walk around the city. \n<color=#00FF49>Kate</color> came home first. <color=#F3FF00>The heat was unbearable!</color> And although her friends agreed that they would drink this <color=#F3FF00>wonderful kvass</color> together, <color=#00FF49>Kate</color> could not resist and drank <color=#F3FF00>a whole glass of kvass</color>! And to hide the traces of her crime, she added <color=#00B6FF>water</color> and went to watch TV while waiting for her friends. \nHalf an hour later, <color=#FF7600>Maria</color> came and did the <color=#F3FF00>same</color> as <color=#00FF49>Kate</color>! \nWhen <color=#00FFF3>Violetta</color> came, she was <color=#F3FF00>horrified(!)</color> to find that the kvass was <color=#00B6FF>diluted with water</color> exactly <color=#F3FF00>half</color>! \n\n<color=#00FFF3>Violetta</color> loved kvass. She could not forgive her friends just like that... She didn't want to communicate with them anyway, so <color=#00FFF3>Violetta</color> decided that she had <color=#F3FF00>to accurately calculate the capacity of a glass to the nearest gram</color>, so that she could then present an invoice where one glass of kvass equals one gram of a glass! \n<color=#F3FF00>How much did <color=#00FFF3>she</color> get after all the calculations?</color>";
                                helpTask.text = "1000 - X - (X - X * X / 1000) = 500, where:\n1000 - volume of kvass at the beginning;\nX - the amount of kvass drunk for the first time by Keith ( and also the volume of the glass);\n(X-X*X/1000) - the amount of Maria's drink \n(Maria drank not pure kvass, but a mixture of kvass and water that Kate made: \nX/1000 - water in this mixture, it turns out \nX*X/1000 - the amount of water mixed in glass from Mary). \nFurther, the formula is reduced, transformed into a quadratic equation, with a solution through the discriminant!";
                            }
                            break;
                        case 18:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1747);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3494);
                                helpTask.margin = new Vector4(35, 0, 35, -2078);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2572);
                                taskText.margin = new Vector4(40, 53.3f, 40, -2030);
                                taskText.text = "В центре загадочного города находилось <color=#FF7600>старинное здание</color>. Совсем небольшого размера, однако в нём было всего лишь <color=#F3FF00>одна прямоугольная комната</color>, стороны которой равны <color=#F3FF00>целому числу</color> метров! <color=#00FFF3>Мэр</color> этого загадочного города долго собирал деньги на <color=#00FF49>реконструкцию</color> и наконец-то это свершилось. \n<color=#F3FF00>После реконструкции площадь комнаты изменилась</color>, хотя всё ещё оставалась <color=#F3FF00>прямоугольной формы</color>. <color=#00FFF3>Меньшая сторона</color> оставалась <color=#F3FF00>неизменной</color>, а <color=#FF7600>большая сторона</color> комнаты <color=#F3FF00>увеличилась</color> настолько метров, сколько квадратных метров составляла площадь комнаты <color=#00B6FF>до реконструкции</color>. \nК сожалению, рабочие <color=#F3FF00>забыли</color> задокументировать площадь комнаты <color=#00B6FF>до реконструкции</color>. Теперь необходимо <color=#F3FF00>найти</color> <color=#00FF49>минимально</color> и <color=#00FF49>максимально</color> возможные площади комнаты <color=#00B6FF>до реконструкции</color>. Единственное, что <color=#F3FF00>удалось узнать</color> от рабочих так это то, что площадь комнаты <color=#00B6FF>до реконструкции</color> составляла <color=#F3FF00>столько процентов</color> от площади комнаты <color=#F3FF00>после реконструкции</color>, сколько <color=#F3FF00>квадратных метров</color> составляла <color=#F3FF00>площадь комнаты</color> <color=#00B6FF>до реконструкции.</color>";
                                helpTask.text = "Готовься! Решение будет сложным! Итак, допустим \"x\" м - большая сторона комнаты до реконструкции, \"y\" м - меньшая сторона. Тогда площадь комнаты до реконструкции равна \"xy\" м, площадь комнаты после реконструкции - \"(x + (xy))y\" м . Тогда получается:\nxy / (x + (xy))y = 0,01xy можно ещё так записать \n100xy / (x + (xy))y = xy\nДавай сделаем это попроще:\n100x / (x + (xy)) = xy;\n100x / (x(1 + y)) = xy;\n100 / (1 + y) = xy.\nОтлично, теперь можно сказать, что это уравнение имеет в натуральных числах только две пары корней \n(x; y): (5; 4) и (50; 1).\nПлощадь комнаты до реконструкции равна \"xy\". Для первой пары корней она составит:\n5*4 = 20 (м).\nДля второй пары:\n50*1 = 50 (м).\nПоздравляю! Решено! \nХоть я и очень умный котик, если я где-то допустил ошибку - напишешь мне потом. Хорошо?";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1747);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3494);
                                helpTask.margin = new Vector4(35, 0, 35, -2078);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 2597);
                                taskText.margin = new Vector4(40, 53.3f, 40, -2030);
                                taskText.text = "In the center of the mysterious city there was <color=#FF7600>an old building</color>. Very small in size, but it had only <color=#F3FF00>one rectangular room</color>, the sides of which are equal to <color=#F3FF00>an integer number</color> of meters! <color=#00FFF3>The mayor</color> of this mysterious city has been collecting money for <color=#00FF49>reconstruction</color> for a long time and finally it happened. \n<color=#F3FF00>After the renovation, the area of ​​the room changed</color>, although it still remained <color=#F3FF00>rectangular</color>. <color=#00FFF3>The smaller side</color> remained <color=#F3FF00>unchanged</color>, while the <color=#FF7600>larger side</color> of the room <color=#F3FF00>increased</color> as much as the square meters of the room <color=#00B6FF>before the reconstruction</color>. \nUnfortunately, the workers <color=#F3FF00>forgot</color> to document the area of ​​the room before <color=#00B6FF>the reconstruction</color>. Now it is necessary <color=#F3FF00>to find</color> <color=#00FF49>the minimum</color> and <color=#00FF49>maximum</color> possible area of ​​the room <color=#00B6FF>before reconstruction</color>. The only thing that we <color=#F3FF00>managed to learn</color> from the workers is that the area of ​​the room <color=#00B6FF>before the reconstruction</color> was <color=#F3FF00>as many percent</color> of the area of ​​the room <color=#F3FF00>after the reconstruction</color> as the <color=#F3FF00>square meters</color> of the <color=#F3FF00>area of ​​the room</color> <color=#00B6FF>before the reconstruction.</color>";
                                helpTask.text = "Get ready! The decision will be difficult! So, let's say \"x\"m is the large side of the room before reconstruction, \"y\"m is the smaller side. Then the area of ​​the room before the reconstruction is equal to \"xy\"m, the area of ​​the room after the reconstruction is \"(x+(xy))y\"m. Then it turns out:\nxy/(x+(xy))y=0.01xy can also be written like this \n100xy/(x+(xy))y=xy\nLet's make it simpler:\n100x/(x+(xy))=xy;\n100x/(x(1+y))=xy;\n100/(1+y)=xy.\nGreat, now we can say that this equation has only two pairs of roots (x; y) in natural numbers: (5; 4) and (50; 1).\nThe area of ​​the room before reconstruction is \"xy\". For the first pair of roots, it will be:\n5 * 4 = 20(m).\nFor the second pair:\n50 * 1 = 50(m).\nCongratulations! Resolved! \nEven though I am a very smart cat, if I made a mistake somewhere, you will write to me later. Good?";
                            }
                            break;
                        case 19:
                            if (GlobalVariables.isRussianLanguage == true)
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -2169);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 4338);
                                helpTask.margin = new Vector4(35, 0, 35, -2962);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1344);
                                taskText.margin = new Vector4(40, 53.3f, 40, -794);
                                taskText.text = "Играя в гольф, один <color=#00FF49>знаменитый гольфист</color> загадал задачку. Необходимо забить <color=#00FF49>9 лунок</color>, которые находятся на расстоянии соответственно в <color=#F3FF00>300, 250, 200, 325, 275, 350, 225, 375 и 400 метров друг от друга</color>. \nПри этом человек может всегда ударить мяч строго по прямой на расстояние в <color=#F3FF00>125 или 10 метров</color> и точно на <color=#F3FF00>одно из двух расстояний</color> так, чтобы он либо шел прямо к лунке и <color=#F3FF00>проходил над ней, либо попадал в нее.</color> \n<color=#F3FF00>Имея такие расстояния, за какое <color=#00FF49>наименьшее число ударов</color> можно закончить всю игру?</color>";
                                helpTask.text = "Всегда можно так ударить мячик, чтобы он полетел строго по прямой на расстояние либо в 125, либо в 100 метров, и тогда игрок сможет закончить игру за 26 ударов. Для упрощения назовём \"сильный удар\", который будет соответствовать 125 метрам, и \"слабый удар\", на 100 метров. Первой лунки можно достичь за 3 \"слабых удара\", второй - за 2 \"сильных удара\", третьей - за 2 \"слабых удара\", четвертой за 2 \"слабых удара\" и один \"сильный удар\", пятой - за 3 \"сильных удара\" и 1 обратный \"слабый удар\", шестой - за 2 \"сильных удара\" и 1 \"слабый удар\", седьмой - за 1 \"сильный удар\" и 1 \"слабый удар\", восьмой - за 3 \"сильных удара\" и, наконец, до девятой лунки можно добраться за 4 \"слабых удара\". Получилось 26 ударов. За меньшее число ударов игру закончить невозможно.";
                            }
                            else
                            {
                                helpContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1755);
                                helpContent.GetComponent<RectTransform>().sizeDelta = new Vector2(712, 3510);
                                helpTask.margin = new Vector4(35, 0, 35, -2097);

                                taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1344);
                                taskText.margin = new Vector4(40, 53.3f, 40, -794);
                                taskText.text = "While playing golf, <color=#00FF49>a famous golfer</color> asked a puzzle. It is necessary to score <color=#00FF49>9 holes</color>, which are at a distance of respectively <color=#F3FF00>300, 250, 200, 325, 275, 350, 225, 375 and 400 meters from each other</color>. \nIn this case, a person can always hit the ball strictly in a straight line at a distance of <color=#F3FF00>125 or 10 meters</color> and exactly one of <color=#F3FF00>two distances</color> so that it either goes directly to the hole and <color=#F3FF00>passes over it, or falls into it</color>. \n<color=#F3FF00>Given such distances, what is the <color=#00FF49>smallest number</color> of strokes to complete the entire game?</color>";
                                helpTask.text = "You can always hit the ball so that it flies in a straight line at a distance of either 125 or 100 meters, and then the player can finish the game in 26 hits. For the sake of simplicity, let's call \"hard hit\", which will correspond to 125 meters, and \"weak hit\", at 100 meters. The first hole can be achieved in 3 \"weak hits\", the second - in 2 \"strong hits\", the third - in 2 \"weak hits\", the fourth in 2 \"weak hits\" and one \"strong hit\", the fifth - in 3 \"strong hits\" and 1 reverse \"weak blow\", the sixth - for 2 \"strong blows\" and 1 \"weak blow\", the seventh - for 1 \"strong blow\" and 1 \"weak blow\", the eighth - for 3 \"strong blows\" and, finally, the ninth hole can be reached in 4 \"weak hits\". It turned out 26 hits. It is impossible to finish the game in fewer strokes.";
                            }
                            break;
                    }
                    break;
            }
            taskContent.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -4000);
        }
    }
}
