
using TMPro;
using UnityEngine;
/// <summary>
/// Hide interface and enable Logic Levels or
/// </summary>
public static class TextAchievments
{
    /// <summary>
    /// Change the language of all achievements to Russian or English.
    /// </summary>
    public static void ChangeLanguage()
    {
        if (GlobalVariables.isRussianLanguage == true)
        {
            SaveInGame.textAchievments[0] = "Нулевой уровень пройден!";
            SaveInGame.textAchievments[1] = "Белый флаг!";
            SaveInGame.textAchievments[2] = "Ну здравствуй, создатель!";
            SaveInGame.textAchievments[3] = "Начало положено!";
            SaveInGame.textAchievments[4] = "Как орешки щёлкать!";
            SaveInGame.textAchievments[5] = "Отличное начало!";
            SaveInGame.textAchievments[6] = "А говорили, что будет сложно!";
            SaveInGame.textAchievments[7] = "Освоение основ завершено!";
            SaveInGame.textAchievments[8] = "Невероятный разум!";
            SaveInGame.textAchievments[9] = "Половина пути!";
            SaveInGame.textAchievments[10] = "Путь одержимости!";
            SaveInGame.textAchievments[11] = "На волне одержимости!";
            SaveInGame.textAchievments[12] = "Познавший дзен и все тайны вселенной!";
            SaveInGame.textAchievments[13] = "Завершить вступительные!";
            SaveInGame.textAchievments[14] = "Закончить эскиз!";
            SaveInGame.textAchievments[15] = "По клочкам бумаги!";
            SaveInGame.textAchievments[16] = "Удачный эксперимент!";
            SaveInGame.textAchievments[17] = "Выпускной!";
            SaveInGame.textAchievments[18] = "Потрясающее логическое мышление!";
            SaveInGame.textAchievments[19] = "Приручить рычаг!";
            SaveInGame.textAchievments[20] = "Обуздать элементарные законы!";
            SaveInGame.textAchievments[21] = "Изучить механику!";
            SaveInGame.textAchievments[22] = "Презентовать новейшие разработки!";
            SaveInGame.textAchievments[23] = "Одержимость невероятным умом!";
            SaveInGame.textAchievments[24] = "Помощь друга!";
            SaveInGame.textAchievments[25] = "Друзья навеки!";
            SaveInGame.textAchievments[26] = "Товарищ в беде не бросит!";
            SaveInGame.textAchievments[27] = "Верный товарищ!";
            SaveInGame.textAchievments[28] = "Помощь его котейшества!";
            SaveInGame.textAchievments[29] = "Не задача, а детский сад какой-то!";
            SaveInGame.textAchievments[30] = "Интеллектуал высшего класса!";
            SaveInGame.textAchievments[31] = "Импровизация, импровизация и ещё раз импровизация!";
            SaveInGame.textAchievments[32] = "Настоящий гений!";
            SaveInGame.textAchievments[33] = "Начинающий ловец!";
            SaveInGame.textAchievments[34] = "Опытный ловец!";
            SaveInGame.textAchievments[35] = "Бывалый ловец!";
            SaveInGame.textAchievments[36] = "Ловец рыб!";
            SaveInGame.textAchievments[37] = "Бесконечность не предел!";

            //--------------------------------------------------------------
            SaveInGame.howGetAchievments[0] = "Cкачать игру и зайти в достижения!";
            SaveInGame.howGetAchievments[1] = "Пропустить один уровень!";
            SaveInGame.howGetAchievments[2] = "Прочитать об авторах!";
            SaveInGame.howGetAchievments[3] = "Пройти первый уровень!";
            SaveInGame.howGetAchievments[4] = "Пройти 10 уровней!";
            SaveInGame.howGetAchievments[5] = "Пройти 20 уровней!";
            SaveInGame.howGetAchievments[6] = "Пройти 40 уровней!";
            SaveInGame.howGetAchievments[7] = "Пройти 50 уровней!";
            SaveInGame.howGetAchievments[8] = "Пройти 75 уровней!";
            SaveInGame.howGetAchievments[9] = "Пройти 100 уровней!";
            SaveInGame.howGetAchievments[10] = "Пройти 125 уровней!";
            SaveInGame.howGetAchievments[11] = "Пройти 150 уровней!";
            SaveInGame.howGetAchievments[12] = "Пройти все уровни!";
            SaveInGame.howGetAchievments[13] = "Пройти лёгкие тесты!";
            SaveInGame.howGetAchievments[14] = "Пройти начальные наработки!";
            SaveInGame.howGetAchievments[15] = "Пройти записки ученого!";
            SaveInGame.howGetAchievments[16] = "Пройти экспериментальный процесс!";
            SaveInGame.howGetAchievments[17] = "Получить учёную степень!";
            SaveInGame.howGetAchievments[18] = "Пройти все логические уровни!";
            SaveInGame.howGetAchievments[19] = "Пройти первый шар одержимости!";
            SaveInGame.howGetAchievments[20] = "Пройти второй шар одержимости!";
            SaveInGame.howGetAchievments[21] = "Пройти третий шар одержимости!";
            SaveInGame.howGetAchievments[22] = "Пройти четвёртый шар одержимости!";
            SaveInGame.howGetAchievments[23] = "Пройти все одержимые уровни!";
            SaveInGame.howGetAchievments[24] = "Впервые воспользоваться подсказкой в уровне!";
            SaveInGame.howGetAchievments[25] = "Воспользоваться подсказкой 10 раз!";
            SaveInGame.howGetAchievments[26] = "Воспользоваться подсказкой 50 раз!";
            SaveInGame.howGetAchievments[27] = "Воспользоваться подсказкой 100 раз!";
            SaveInGame.howGetAchievments[28] = "Открыть все подсказки!";
            SaveInGame.howGetAchievments[29] = "Пройти первую шуточную задачу!";
            SaveInGame.howGetAchievments[30] = "Пройти 25 шуточных хе-хе задач!";
            SaveInGame.howGetAchievments[31] = "Пройти 50 шуточных задач!";
            SaveInGame.howGetAchievments[32] = "Его котейшество надеется, что настоящий гений!";
            SaveInGame.howGetAchievments[33] = "Накопить 10 рыбок!";
            SaveInGame.howGetAchievments[34] = "Накопить 20 рыбок!";
            SaveInGame.howGetAchievments[35] = "Накопить 35 рыбок!";
            SaveInGame.howGetAchievments[36] = "Накопить 50 рыбок!";
            SaveInGame.howGetAchievments[37] = "Получить бесконечное количество подсказок!";

            GlobalSceneObjects.achievmentsInCanvas.transform.Find("Frame").Find("newHelpBoard").Find("TextAchievments").GetComponent<TextMeshProUGUI>().text = "Достижения";
        }
        else
        {
            SaveInGame.textAchievments[0] = "Zero level passed!";
            SaveInGame.textAchievments[1] = "White flag!";
            SaveInGame.textAchievments[2] = "Well hello creator!";
            SaveInGame.textAchievments[3] = "A start!";
            SaveInGame.textAchievments[4] = "How to eat nuts!";
            SaveInGame.textAchievments[5] = "Great start!";
            SaveInGame.textAchievments[6] = "And they said it would be difficult!";
            SaveInGame.textAchievments[7] = "Mastering the basics is complete!";
            SaveInGame.textAchievments[8] = "Incredible mind!";
            SaveInGame.textAchievments[9] = "Half way!";
            SaveInGame.textAchievments[10] = "Obsession Path!";
            SaveInGame.textAchievments[11] = "On a wave of obsession!";
            SaveInGame.textAchievments[12] = "Knowing Zen and all the secrets of the universe!";
            SaveInGame.textAchievments[13] = "Complete introductory!";
            SaveInGame.textAchievments[14] = "Finish sketch!";
            SaveInGame.textAchievments[15] = "Over the pieces of paper!";
            SaveInGame.textAchievments[16] = "Successful experiment!";
            SaveInGame.textAchievments[17] = "High school graduation!";
            SaveInGame.textAchievments[18] = "Amazing logical thinking!";
            SaveInGame.textAchievments[19] = "Tame the lever!";
            SaveInGame.textAchievments[20] = "Curb elementary laws!";
            SaveInGame.textAchievments[21] = "Learn the mechanics!";
            SaveInGame.textAchievments[22] = "Present the latest developments!";
            SaveInGame.textAchievments[23] = "An obsession with an incredible mind!";
            SaveInGame.textAchievments[24] = "Help from a friend!";
            SaveInGame.textAchievments[25] = "Friends forever!";
            SaveInGame.textAchievments[26] = "A comrade in trouble will not quit!";
            SaveInGame.textAchievments[27] = "Faithful comrade!";
            SaveInGame.textAchievments[28] = "Help from the great cat!";
            SaveInGame.textAchievments[29] = "Not a task, but some kind of kindergarten!";
            SaveInGame.textAchievments[30] = "A top-class intellectual!";
            SaveInGame.textAchievments[31] = "Improvisation, improvisation and more improvisation!";
            SaveInGame.textAchievments[32] = "A real genius!";
            SaveInGame.textAchievments[33] = "Beginner catcher!";
            SaveInGame.textAchievments[34] = "An experienced catcher!";
            SaveInGame.textAchievments[35] = "Cool catcher!";
            SaveInGame.textAchievments[36] = "Fish catcher!";
            SaveInGame.textAchievments[37] = "To infinity and beyond!";

            //--------------------------------------------------------------
            SaveInGame.howGetAchievments[0] = "Download the game and go to the achievements!";
            SaveInGame.howGetAchievments[1] = "Skip one level!";
            SaveInGame.howGetAchievments[2] = "Read about the authors!";
            SaveInGame.howGetAchievments[3] = "Complete the first level!";
            SaveInGame.howGetAchievments[4] = "Complete 10 levels!";
            SaveInGame.howGetAchievments[5] = "Complete 20 levels!";
            SaveInGame.howGetAchievments[6] = "Complete 40 levels!";
            SaveInGame.howGetAchievments[7] = "Complete 50 levels!";
            SaveInGame.howGetAchievments[8] = "Complete 75 levels!";
            SaveInGame.howGetAchievments[9] = "Complete 100 levels!";
            SaveInGame.howGetAchievments[10] = "Complete 125 levels!";
            SaveInGame.howGetAchievments[11] = "Complete 150 levels!";
            SaveInGame.howGetAchievments[12] = "Complete all levels!";
            SaveInGame.howGetAchievments[13] = "Complete Light Tests!";
            SaveInGame.howGetAchievments[14] = "Complete Best Practies!";
            SaveInGame.howGetAchievments[15] = "Complete Scientist's notes!";
            SaveInGame.howGetAchievments[16] = "Complete Experimental Process!";
            SaveInGame.howGetAchievments[17] = "Complete Academic Degree!";
            SaveInGame.howGetAchievments[18] = "Complete all Logic levels!";
            SaveInGame.howGetAchievments[19] = "Complete the first ball of Obsession!";
            SaveInGame.howGetAchievments[20] = "Complete the second ball of Obsession!";
            SaveInGame.howGetAchievments[21] = "Complete the third ball of Obsession!";
            SaveInGame.howGetAchievments[22] = "Complete the fourth ball of Obsession!";
            SaveInGame.howGetAchievments[23] = "Complete all Possessed levels!";
            SaveInGame.howGetAchievments[24] = "Use the hint in the level for the first time!";
            SaveInGame.howGetAchievments[25] = "Use the hint 10 times!";
            SaveInGame.howGetAchievments[26] = "Use the hint 50 times!";
            SaveInGame.howGetAchievments[27] = "Use the hint 100 times!";
            SaveInGame.howGetAchievments[28] = "Open all hints!";
            SaveInGame.howGetAchievments[29] = "Complete the first comic tasks!";
            SaveInGame.howGetAchievments[30] = "Complete 25 comic (hehe) tasks!";
            SaveInGame.howGetAchievments[31] = "Complete 50 comic tasks!";
            SaveInGame.howGetAchievments[32] = "The great cat hopes that you are a real genius!";
            SaveInGame.howGetAchievments[33] = "Collect 10 Fish!";
            SaveInGame.howGetAchievments[34] = "Collect 20 Fish!";
            SaveInGame.howGetAchievments[35] = "Collect 35 Fish!";
            SaveInGame.howGetAchievments[36] = "Collect 50 Fish!";
            SaveInGame.howGetAchievments[37] = "Get endless hints!";
            GlobalSceneObjects.achievmentsInCanvas.transform.Find("Frame").Find("newHelpBoard").Find("TextAchievments").GetComponent<TextMeshProUGUI>().text = "Achievements";

        }
        for (int i = 0; i < 38; i++)
        {
            GlobalSceneObjects.achievmentsContent.transform.GetChild(i).Find("Achiv").GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[i];
        }

    }

}
