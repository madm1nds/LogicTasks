using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Start action on victory.
/// </summary>
public static class Victory
{
    public static void Invoke()
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;       

        if (GlobalVariables.isSkipLevel == false)
        {
            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LightTests)
                GlobalSaves.saveInGame[0].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.BestPractices)
                GlobalSaves.saveInGame[1].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ScientistsNotes)
                GlobalSaves.saveInGame[2].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ExperimentalProcess)
                GlobalSaves.saveInGame[3].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.AcademicDegree)
                GlobalSaves.saveInGame[4].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.SimpleLever)
                GlobalSaves.saveInGame[5].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.ElementaryLaws)
                GlobalSaves.saveInGame[6].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.Mechanics)
                GlobalSaves.saveInGame[7].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            if (GlobalVariables.activeNameLevel == (int)GlobalVariables.NameAnimation.LatestDevelopments)
                GlobalSaves.saveInGame[8].isRateLevelsCheck[SaveInGame.numberLvlClick] = true;

            coroutines.PassedLevelAndShowAchievments();
        }
        GlobalVariables.isSkipLevel = false;
        HideLevelButtons.Invoke();
        OpenPassedLevels.Open();

        SaveData.Save();//сохраняем
        Text textDialogue = GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>();

        if (GlobalVariables.isRussianLanguage == true)
        {
            switch (GlobalVariables.activeNameLevel)
            {
                case (int)GlobalVariables.NameAnimation.LightTests:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Просто, как два пальца об асфальт."; break;
                        case 2: textDialogue.text = "А ты не КРУГЛЫЙ дурак!"; break;
                        case 3: textDialogue.text = "Ммм, ты прав. Обожаю мятное варенье"; break;
                        case 4: textDialogue.text = "Деньги любят умных."; break;
                        case 5: textDialogue.text = "Удивительная вещь!"; break;
                        case 6: textDialogue.text = "Не люблю холод. Бр-р-р!"; break;
                        case 7: textDialogue.text = "А тебя не запутать!"; break;
                        case 8: textDialogue.text = "Цифры - это просто, поздравляю!"; break;
                        case 9: textDialogue.text = "Всему ответ время..."; break;
                        case 10: textDialogue.text = "Отлично справляешься!"; break;
                        case 11: textDialogue.text = "Пальцы на руке, не дурно!"; break;
                        case 12: textDialogue.text = "Смотрю, алфавит ты не забыл!"; break;
                        case 13: textDialogue.text = "Ладно! Повеселились и хватит! Это была разминка!"; break;
                        case 14: textDialogue.text = "Ммм. Люблю поспать подольше!"; break;
                        case 15: textDialogue.text = "Один блин и ты уже не голоден!"; break;
                        case 16: textDialogue.text = "И снова тебя не провести!"; break;
                        case 17: textDialogue.text = "А ты не промах!"; break;
                        case 18: textDialogue.text = "Ждёшь квантовые часы!"; break;
                        case 19: textDialogue.text = "Ты просто супер!"; break;
                        case 20: textDialogue.text = "Щёлкаешь как семечки!"; break;
                        case 21: textDialogue.text = "Приятных сновидений!"; break;
                        case 22: textDialogue.text = "Слишком просто?"; break;
                        case 23: textDialogue.text = "Логично!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.BestPractices:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Чёрт побери, а ты способный!"; break;
                        case 2: textDialogue.text = "Тебя преследует удача!"; break;
                        case 3: textDialogue.text = "Мяу! :з"; break;
                        case 4: textDialogue.text = "Бесконечность - не предел!"; break;
                        case 5: textDialogue.text = "Здесь ты меня сделал…"; break;
                        case 6: textDialogue.text = "Ух, а ты в ударе!"; break;
                        case 7: textDialogue.text = "Отличный ответ!"; break;
                        case 8: textDialogue.text = "124,125,126… Да. Точно. Это правильно!"; break;
                        case 9: textDialogue.text = "Неплохо, автолюбитель!"; break;
                        case 10: textDialogue.text = "Мы, коты, терпеть не можем будильники!"; break;
                        case 11: textDialogue.text = "Три воробья - мой любимый завтрак!"; break;
                        case 12: textDialogue.text = "Иногда стоит веселиться..."; break;
                        case 13: textDialogue.text = "И собак не боишься, храбрый, хвалю!"; break;
                        case 14: textDialogue.text = "Как конструктор!"; break;
                        case 15: textDialogue.text = "Не забывай о времени!"; break;
                        case 16: textDialogue.text = "Земледелие - это сказка!"; break;
                        case 17: textDialogue.text = "Ого, ты даже не дал Джону обмануть себя!"; break;
                        case 18: textDialogue.text = "Главное не запутайся!"; break;
                        case 19: textDialogue.text = "Иногда приятно вспомнить детство."; break;
                        case 20: textDialogue.text = "Не люблю нечётные числа!"; break;
                        case 21: textDialogue.text = "Б-р-р... Вода грозное оружие против котов."; break;
                        case 22: textDialogue.text = "Вау! Просто огонь!"; break;
                        case 23: textDialogue.text = "Не забывай о грамотности!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ScientistsNotes:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Только т-с-с, не говори друзьям."; break;
                        case 2: textDialogue.text = "Не забывай о близких!"; break;
                        case 3: textDialogue.text = "Только не повторяй это в жизни!"; break;
                        case 4: textDialogue.text = "Может сыграем партию?!"; break;
                        case 5: textDialogue.text = "А ты далеко собрался?"; break;
                        case 6: textDialogue.text = "Свистать всех наверх!"; break;
                        case 7: textDialogue.text = "Время остановило свой ход!"; break;
                        case 8: textDialogue.text = "Не рой другому яму!"; break;
                        case 9: textDialogue.text = "Да ты гуру календарных загадок!"; break;
                        case 10: textDialogue.text = "Это было слишком легко для тебя..."; break;
                        case 11: textDialogue.text = "Да как же тебя запутать?"; break;
                        case 12: textDialogue.text = "Бульк!"; break;
                        case 13: textDialogue.text = "Я тоже удивился этому ответу..."; break;
                        case 14: textDialogue.text = "Ты превосходишь мои ожидания."; break;
                        case 15: textDialogue.text = "Хорошая стратегия!"; break;
                        case 16: textDialogue.text = "Идёшь на взлёт!"; break;
                        case 17: textDialogue.text = "Тень всегда рядом. Бу!"; break;
                        case 18: textDialogue.text = "Береги зубки!"; break;
                        case 19: textDialogue.text = "Не оглядывайся назад!"; break;
                        case 20: textDialogue.text = "Одному играть скучно!"; break;
                        case 21: textDialogue.text = "Дыхательная гимнастика!"; break;
                        case 22: textDialogue.text = "Иго-го! Кхм... То есть мяу!"; break;
                        case 23: textDialogue.text = "А ты попробуй!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ExperimentalProcess:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Лысые котики тоже не мочат шёрстку!"; break;
                        case 2: textDialogue.text = "Используешь дедукцию?"; break;
                        case 3: textDialogue.text = "Большая семейка!"; break;
                        case 4: textDialogue.text = "Такая хитрая и подлая вода, ничего не попишешь."; break;
                        case 5: textDialogue.text = "Молодец! Верно!"; break;
                        case 6: textDialogue.text = "Мысли позитивно!"; break;
                        case 7: textDialogue.text = "Какой... Необычный ответ! Принято!"; break;
                        case 8: textDialogue.text = "Эх. И снова тебя не запутать! Хвалю!"; break;
                        case 9: textDialogue.text = "В логике тебе не откажешь..."; break;
                        case 10: textDialogue.text = "Пора обратиться к алфавиту!"; break;
                        case 11: textDialogue.text = "Еей! Математично!"; break;
                        case 12: textDialogue.text = "Расслабься, послушай музыку!"; break;
                        case 13: textDialogue.text = "Ох уж этот Джонни!"; break;
                        case 14: textDialogue.text = "Интересно мыслишь. Продолжай в том же духе!"; break;
                        case 15: textDialogue.text = "Хитрый аукционер, хотел всех запутать!"; break;
                        case 16: textDialogue.text = "Такое чувство, будто ты болеешь ею!"; break;
                        case 17: textDialogue.text = "Странная служанка, да и методы для ограбления у неё интересные."; break;
                        case 18: textDialogue.text = "Вот ведь как бывает!"; break;
                        case 19: textDialogue.text = "Ого, даже мне не под силу было такое решить!"; break;
                        case 20: textDialogue.text = "Хорошо! С этим мы справились!"; break;
                        case 21: textDialogue.text = "Я бы похвалил бы тебя на китайском, но, к сожалению, я его не знаю..."; break;
                        case 22: textDialogue.text = "Математика удивительна и коварна!"; break;
                        case 23: textDialogue.text = "Удивительная краска!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.AcademicDegree:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Кстати, я тоже животное, как и ты! Только с шерстью и немного меньше!"; break;
                        case 2: textDialogue.text = "Думаю, это происходит в параллельном мире. Ну серьёзно! Воровать кактусы?"; break;
                        case 3: textDialogue.text = "Поэтому лучше всего взвешиваться в космосе!"; break;
                        case 4: textDialogue.text = "Дзинь-дзинь!"; break;
                        case 5: textDialogue.text = "А я смотрю, ты в таких делах профи?"; break;
                        case 6: textDialogue.text = "Платиновый ответ!"; break;
                        case 7: textDialogue.text = "Хорошая погода для прогулки!"; break;
                        case 8: textDialogue.text = "Если не веришь, то попробуй!"; break;
                        case 9: textDialogue.text = "Не повторяйте этот трюк!"; break;
                        case 10: textDialogue.text = "А ты много знаешь об этом мире!"; break;
                        case 11: textDialogue.text = "Время идёт, а человек всё ещё учится у природы!"; break;
                        case 12: textDialogue.text = "И чего тут странного? "; break;
                        case 13: textDialogue.text = "И чего это Джонни поехал по встречной полосе..."; break;
                        case 14: textDialogue.text = "Интересный ход мыслей. "; break;
                        case 15: textDialogue.text = "Следующий раз буду взвешиваться только на экваторе!"; break;
                        case 16: textDialogue.text = "Нелегко раньше было жить без всех этих технологий современности..."; break;
                        case 17: textDialogue.text = "И он ещё смеет называть себя ковбоем! Я возмущён!"; break;
                        case 18: textDialogue.text = "Химия и физика, сложные науки, но благодаря ним столько интересных вещей можно узнать!"; break;
                        case 19: textDialogue.text = "Именно! Иногда ответ слишком прост!"; break;
                        case 20: textDialogue.text = "Слишком легко было? Признавайся. Ты тоже учёный?"; break;
                        case 21: textDialogue.text = "Занимательный и абсолютно верный ответ!"; break;
                        case 22: textDialogue.text = "Неплохо управляешься с дробями!"; break;
                        case 23: textDialogue.text = "Незаурядно мыслишь - это хорошо!"; break;
                        case 24: textDialogue.text = "Владимир доволен твоим ответом. И не спрашивай, откуда он знает!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.SimpleLever:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "У меня ведь тоже лапки :з"; break;
                        case 2: textDialogue.text = "Слишком много собак, давай дальше!"; break;
                        case 3: textDialogue.text = "Ты быстро думаешь!"; break;
                        case 4: textDialogue.text = "Ты смог побороть бессонницу!"; break;
                        case 5: textDialogue.text = "Интересно, когда начнутся межпланетные гонки?"; break;
                        case 6: textDialogue.text = "Наверное вкусные яблочки!"; break;
                        case 7: textDialogue.text = "Простая математика!"; break;
                        case 8: textDialogue.text = "Игры со временем!"; break;
                        case 9: textDialogue.text = "Поздравляю, складывать числа ты умеешь!"; break;
                        case 10: textDialogue.text = "Хах. Простая математика!"; break;
                        case 11: textDialogue.text = "Так мало часов в одном дне..."; break;
                        case 12: textDialogue.text = "Сыграем?"; break;
                        case 13: textDialogue.text = "Тебя не остановить!"; break;
                        case 14: textDialogue.text = "Ты поразил меня своими способностями!"; break;
                        case 15: textDialogue.text = "А мне между прочим уже 8 лет!"; break;
                        case 16: textDialogue.text = "Сейчас ты меня удивил!"; break;
                        case 17: textDialogue.text = "Действительно Джон очень странный..."; break;
                        case 18: textDialogue.text = "Просто, как выпить стакан молока..."; break;
                        case 19: textDialogue.text = "Точный расчёт, поздравляю!"; break;
                        case 20: textDialogue.text = "Невероятная сообразительность, за столь короткое время!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ElementaryLaws:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Мм, боги смерти любят ананасы..."; break;
                        case 2: textDialogue.text = "7 - счастливое число!"; break;
                        case 3: textDialogue.text = "Ого, тебе не лень посчитать!"; break;
                        case 4: textDialogue.text = "Ты смог решить это хлопотное дело, хвалю!"; break;
                        case 5: textDialogue.text = "Котик всегда добивается своего! :з"; break;
                        case 6: textDialogue.text = "Поздравляю, ты отлично справляешься!"; break;
                        case 7: textDialogue.text = "Не перестаёшь меня удивлять..."; break;
                        case 8: textDialogue.text = "Котики в политике не участвуют! "; break;
                        case 9: textDialogue.text = "Ммм. Я бы не отказался от такого майонеза! А ты?"; break;
                        case 10: textDialogue.text = "Невероятной длины автобус! По-моему, таких на Этой Земле не существует! Хотя..."; break;
                        case 11: textDialogue.text = "Неплохо! Считать ты умеешь!"; break;
                        case 12: textDialogue.text = "Невероятный рост! Впрочем, ты тоже быстро развиваешься!"; break;
                        case 13: textDialogue.text = "Водохлёбы!"; break;
                        case 14: textDialogue.text = "Браво! Верное решение!"; break;
                        case 15: textDialogue.text = "Хм. Ты действительно способный!"; break;
                        case 16: textDialogue.text = "Никогда не мог понять этих птичек..."; break;
                        case 17: textDialogue.text = "Здравствуйте, сэр!"; break;
                        case 18: textDialogue.text = "Ты невероятен!"; break;
                        case 19: textDialogue.text = "Мне кажется, для тебя нет границ!"; break;
                        case 20: textDialogue.text = "Хоть я и кот, но… Эх. А ведь волки и так на грани вымирания… Их защищать нужно!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.Mechanics:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Хех, ладно, ты знатно потешил меня!"; break;
                        case 2: textDialogue.text = "Этот лесоруб совсем не щадит новых работников! Такие сложные задачки задаёт!"; break;
                        case 3: textDialogue.text = "И это правильный ответ! Совпадение? Случайность?"; break;
                        case 4: textDialogue.text = "Ты мастер в решении и логике!"; break;
                        case 5: textDialogue.text = "Даже в часах есть математика! Достаточно умно! Молодец!"; break;
                        case 6: textDialogue.text = "Ого! Это потрясающе правильный ответ!"; break;
                        case 7: textDialogue.text = "Когда-то я уже это говорил, но... Деньги любят умных!"; break;
                        case 8: textDialogue.text = "Ты думаешь и отвечаешь быстрее чем я! "; break;
                        case 9: textDialogue.text = "Только не повторяй этого дома! Тебя просто пытались запутать! Хорошо, что ты потрясающе справляешься!"; break;
                        case 10: textDialogue.text = "Часто в поездах ездишь?"; break;
                        case 11: textDialogue.text = "Фермеру нужно купить нормальные весы..."; break;
                        case 12: textDialogue.text = "Почему в этой задаче нет котов с очками! Я возмущён!"; break;
                        case 13: textDialogue.text = "Вероятность того, что это правильный ответ: 1. Неплохо!"; break;
                        case 14: textDialogue.text = "Как же много майонеза они наготовили!"; break;
                        case 15: textDialogue.text = "Ох и давно же это было..."; break;
                        case 16: textDialogue.text = "Хороший ответ! Я доволен тобой!"; break;
                        case 17: textDialogue.text = "А ты разбираешься в календарях!"; break;
                        case 18: textDialogue.text = "Дополнительные занятия тебе обеспечены!"; break;
                        case 19: textDialogue.text = "Кейт точно необходимо заменить эти часы!"; break;
                        case 20: textDialogue.text = "Интересно, а что в бочках?"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.LatestDevelopments:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Обожаю сундуки! "; break;
                        case 2: textDialogue.text = "С каждой минутой, запутать тебя всё труднее!"; break;
                        case 3: textDialogue.text = "Наверное, дело было лет двадцать назад. С такими-то зарплатами!"; break;
                        case 4: textDialogue.text = "Работать без выходных это неправильно! Надеюсь, этот работодатель всё поймёт и исправится!"; break;
                        case 5: textDialogue.text = "Если столько конфет давали пришедшим, то что было на самой вечеринке?"; break;
                        case 6: textDialogue.text = "Однако, какие прислужники у фараона! Вычислил 1000 грамм без весов!"; break;
                        case 7: textDialogue.text = "Эх, мне бы такой участок..."; break;
                        case 8: textDialogue.text = "Воровать плохо! Никогда так не делай! "; break;
                        case 9: textDialogue.text = "Молодец! У тебя получилось посчитать!"; break;
                        case 10: textDialogue.text = "Вау, ты можешь справиться с такой непростой задачей! Я недооценил тебя! Хвалю!"; break;
                        case 11: textDialogue.text = "Роскошно живёт Джонни, ничего не скажешь!"; break;
                        case 12: textDialogue.text = "Интересно, где этот отель находится?"; break;
                        case 13: textDialogue.text = "Ого, ты сэкономил около 100$ на одном лишь карандаше! Действительно хороший карандаш!"; break;
                        case 14: textDialogue.text = "Интересно, зачем они это делали?"; break;
                        case 15: textDialogue.text = "А ты любишь печеньки?"; break;
                        case 16: textDialogue.text = "А младшему-то в два раза меньше, чем мне! "; break;
                        case 17: textDialogue.text = "Ты смог пройти этот тяжёлый и тернистый путь! Невероятно!"; break;
                        case 18: textDialogue.text = "Твои умственные способности поражают!"; break;
                        case 19: textDialogue.text = "У меня нет слов, чтобы передать, насколько ты молодец!"; break;
                    }
                    break;
            }
        }
        else
        {
            switch (GlobalVariables.activeNameLevel)
            {
                case (int)GlobalVariables.NameAnimation.LightTests:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "As simple as 1+1."; break;
                        case 2: textDialogue.text = "So you are not a COMPLETE fool!"; break;
                        case 3: textDialogue.text = "Mmm , you're right. I love mint jam!"; break;
                        case 4: textDialogue.text = "Money loves smart people."; break;
                        case 5: textDialogue.text = "Escalator is an amazing thing!"; break;
                        case 6: textDialogue.text = "I don't like coldness. Br-r-r!"; break;
                        case 7: textDialogue.text = "It is hard to confuse you!"; break;
                        case 8: textDialogue.text = "Math is simple!"; break;
                        case 9: textDialogue.text = "Time is the answer to everything."; break;
                        case 10: textDialogue.text = "You're doing great!"; break;
                        case 11: textDialogue.text = "Fingers on the hand, not bad!"; break;
                        case 12: textDialogue.text = "Seems like you still remember the alphabet!"; break;
                        case 13: textDialogue.text = "Okay! We had fun but that's enough! It was just a warm-up!"; break;
                        case 14: textDialogue.text = "Mmm. I’d like to sleep longer!"; break;
                        case 15: textDialogue.text = "One pancake and you're not hungry anymore!"; break;
                        case 16: textDialogue.text = "And again you cannot be fooled!"; break;
                        case 17: textDialogue.text = "Haters miss but you don’t!"; break;
                        case 18: textDialogue.text = "Wait for the quantum clock!"; break;
                        case 19: textDialogue.text = "You're just awsome!"; break;
                        case 20: textDialogue.text = "You nibble tasks like seeds!"; break;
                        case 21: textDialogue.text = "Enjoy your dreams!"; break;
                        case 22: textDialogue.text = "Too easy?"; break;
                        case 23: textDialogue.text = "It is logical!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.BestPractices:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Damn it, you are capable!"; break;
                        case 2: textDialogue.text = "Luck pursues you!"; break;
                        case 3: textDialogue.text = "Meow ! :s"; break;
                        case 4: textDialogue.text = "Infinity is not the limit!"; break;
                        case 5: textDialogue.text = "Here you made me..."; break;
                        case 6: textDialogue.text = "Wow, you're on fire!"; break;
                        case 7: textDialogue.text = "Great answer!"; break;
                        case 8: textDialogue.text = "124,125,126... Yes. Exactly!"; break;
                        case 9: textDialogue.text = "Not bad, motorist!"; break;
                        case 10: textDialogue.text = "We cats hate alarm clocks!"; break;
                        case 11: textDialogue.text = "Three sparrows are my favorite breakfast!"; break;
                        case 12: textDialogue.text = "Sometimes it's worth having fun..."; break;
                        case 13: textDialogue.text = "And you are not afraid of dogs, brave, I praise!"; break;
                        case 14: textDialogue.text = "Like a constructor!"; break;
                        case 15: textDialogue.text = "Don't forget about time!"; break;
                        case 16: textDialogue.text = "Agriculture is a fairy tale!"; break;
                        case 17: textDialogue.text = "Wow, you didn't even let John fool you!"; break;
                        case 18: textDialogue.text = "The main thing is not to get confused!"; break;
                        case 19: textDialogue.text = "Sometimes it's nice to remember childhood."; break;
                        case 20: textDialogue.text = "I don't like odd numbers!"; break;
                        case 21: textDialogue.text = "Brr... Water is a formidable weapon against cats."; break;
                        case 22: textDialogue.text = "Wow! Just fire!"; break;
                        case 23: textDialogue.text = "Don't forget about literacy!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ScientistsNotes:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Don't tell even your friends."; break;
                        case 2: textDialogue.text = "Don't forget about your loved ones!"; break;
                        case 3: textDialogue.text = "Just don't repeat it in your life!"; break;
                        case 4: textDialogue.text = "Can we play a game?!"; break;
                        case 5: textDialogue.text = "And you're going away?"; break;
                        case 6: textDialogue.text = "Whistle everyone up!"; break;
                        case 7: textDialogue.text = "Za warudo toki wo tomare!"; break;
                        case 8: textDialogue.text = "There is no dirt in the pit!"; break;
                        case 9: textDialogue.text = "You are a guru of calendar mysteries!"; break;
                        case 10: textDialogue.text = "It was too easy for you, wasn’t it?"; break;
                        case 11: textDialogue.text = "How can confuse you?"; break;
                        case 12: textDialogue.text = "Bulbulbul!"; break;
                        case 13: textDialogue.text = "I was also surprised by this answer..."; break;
                        case 14: textDialogue.text = "You exceed my expectations."; break;
                        case 15: textDialogue.text = "Good strategy!"; break;
                        case 16: textDialogue.text = "You are taking off!"; break;
                        case 17: textDialogue.text = "The shadow is always there. Boo!"; break;
                        case 18: textDialogue.text = "Take care of your teeth!"; break;
                        case 19: textDialogue.text = "Don't look back!"; break;
                        case 20: textDialogue.text = "It's boring to play alone!"; break;
                        case 21: textDialogue.text = "Respiratory gymnastics!"; break;
                        case 22: textDialogue.text = "That is meow!"; break;
                        case 23: textDialogue.text = "Try it!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ExperimentalProcess:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Bald cats do not wet their fur either!"; break;
                        case 2: textDialogue.text = "Do you use deduction?"; break;
                        case 3: textDialogue.text = "Big family!"; break;
                        case 4: textDialogue.text = "Such cunning and mean water, nothing can be done."; break;
                        case 5: textDialogue.text = "Well done! Right!"; break;
                        case 6: textDialogue.text = "Think positive!"; break;
                        case 7: textDialogue.text = "What... An unusual answer! Received!"; break;
                        case 8: textDialogue.text = "Eh. And again, did not confuse you! Good job!"; break;
                        case 9: textDialogue.text = "You are good at logic..."; break;
                        case 10: textDialogue.text = "And you do not miss!"; break;
                        case 11: textDialogue.text = "Heey! Mathematical!"; break;
                        case 12: textDialogue.text = "Relax, listen to music!"; break;
                        case 13: textDialogue.text = "Oh, that Brad!"; break;
                        case 14: textDialogue.text = "You think interesting way. Keep up the good work!"; break;
                        case 15: textDialogue.text = "Cunning auctioneer wanted to confuse everyone!"; break;
                        case 16: textDialogue.text = "It feels like you are sick with it!"; break;
                        case 17: textDialogue.text = "A strange employee, and her methods for robbery are interesting."; break;
                        case 18: textDialogue.text = "That's how it happens!"; break;
                        case 19: textDialogue.text = "Wow, even I couldn't solve this!"; break;
                        case 20: textDialogue.text = "Good! We've done it!"; break;
                        case 21: textDialogue.text = "Chinese"; break;
                        case 22: textDialogue.text = "Mathematics is amazing and insidious!"; break;
                        case 23: textDialogue.text = "Amazing paint!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.AcademicDegree:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "By the way, I am also an animal, just like you! Only with wool and a little less!"; break;
                        case 2: textDialogue.text = "I think this is happening in a parallel world. Seriously! Steal cactus?"; break;
                        case 3: textDialogue.text = "Therefore, it is best to weigh yourself in space!"; break;
                        case 4: textDialogue.text = "Ding-ding!"; break;
                        case 5: textDialogue.text = "And I see, are you a pro in such matters?"; break;
                        case 6: textDialogue.text = "Platinum Answer!"; break;
                        case 7: textDialogue.text = "Nice weather for a walk!"; break;
                        case 8: textDialogue.text = "If you don't believe, then try it!"; break;
                        case 9: textDialogue.text = "Don't repeat this trick!"; break;
                        case 10: textDialogue.text = "And you know a lot about this world!"; break;
                        case 11: textDialogue.text = "Time passes, but man is still learning from nature!"; break;
                        case 12: textDialogue.text = "And what's strange?"; break;
                        case 13: textDialogue.text = "And why is Johnny driving in the oncoming lane..."; break;
                        case 14: textDialogue.text = "Interesting train of thought."; break;
                        case 15: textDialogue.text = "Next time I will weigh myself only at the equator!"; break;
                        case 16: textDialogue.text = "It was not easy to live  in past without all these modern technologies..."; break;
                        case 17: textDialogue.text = "And he still dares to call himself a cowboy! I'm outraged!"; break;
                        case 18: textDialogue.text = "Chemistry and physics, complex sciences, but thanks to them you can learn so many interesting things!"; break;
                        case 19: textDialogue.text = "Exactly! Sometimes the answer is too simple!"; break;
                        case 20: textDialogue.text = "Was it too easy? Confess. Are you a scientist too?"; break;
                        case 21: textDialogue.text = "An entertaining and absolutely correct answer!"; break;
                        case 22: textDialogue.text = "You are good with fractions!"; break;
                        case 23: textDialogue.text = "The original thought - it's good!"; break;
                        case 24: textDialogue.text = "Vladimir is pleased with your answer. And don't ask how he knows!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.SimpleLever:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "I also have paws :з"; break;
                        case 2: textDialogue.text = "Too many dogs, move on!"; break;
                        case 3: textDialogue.text = "You think fast!"; break;
                        case 4: textDialogue.text = "You were able to overcome insomnia!"; break;
                        case 5: textDialogue.text = "I wonder when the interplanetary races will start?"; break;
                        case 6: textDialogue.text = "Probably delicious apples!"; break;
                        case 7: textDialogue.text = "Simple math!"; break;
                        case 8: textDialogue.text = "Games with time!"; break;
                        case 9: textDialogue.text = "Congratulations, you can add numbers!"; break;
                        case 10: textDialogue.text = "Hah. Simple math!"; break;
                        case 11: textDialogue.text = "So few hours in one day..."; break;
                        case 12: textDialogue.text = "Let's play?"; break;
                        case 13: textDialogue.text = "You're unstoppable!"; break;
                        case 14: textDialogue.text = "You amazed me with your abilities!"; break;
                        case 15: textDialogue.text = "And by the way, I am already 8 years old!"; break;
                        case 16: textDialogue.text = "Now you surprised me!"; break;
                        case 17: textDialogue.text = "Indeed John is very strange..."; break;
                        case 18: textDialogue.text = "As simple as drinking a glass of milk..."; break;
                        case 19: textDialogue.text = "Exact calculation, congratulations!"; break;
                        case 20: textDialogue.text = "Incredible intelligence, you did it in such a short time!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.ElementaryLaws:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Um, the dead gods love pineapples..."; break;
                        case 2: textDialogue.text = "7 is a lucky number!"; break;
                        case 3: textDialogue.text = "Wow, you are not too lazy to count!"; break;
                        case 4: textDialogue.text = "You were able to solve this troublesome task, praise!"; break;
                        case 5: textDialogue.text = "Kitty always gets his way! : s"; break;
                        case 6: textDialogue.text = "Congratulations, you're doing great!"; break;
                        case 7: textDialogue.text = "Well done..."; break;
                        case 8: textDialogue.text = "Сats do not participate in politics!"; break;
                        case 9: textDialogue.text = "Mmm. I would not mind such mayonnaise! And you?"; break;
                        case 10: textDialogue.text = "Bus of incredible length! In my opinion, there are no such buses on this Earth! Though..."; break;
                        case 11: textDialogue.text = "Not bad ! You know how to count!"; break;
                        case 12: textDialogue.text = "Incredible growth! However, you are developing fast too!"; break;
                        case 13: textDialogue.text = "Waterlogs!"; break;
                        case 14: textDialogue.text = "Bravo! The right decision!"; break;
                        case 15: textDialogue.text = "Hmm. You are really capable!"; break;
                        case 16: textDialogue.text = "I could never understand these birds..."; break;
                        case 17: textDialogue.text = "Hello sir!"; break;
                        case 18: textDialogue.text = "You are incredible!"; break;
                        case 19: textDialogue.text = "It seems to me that there are no boundaries for you!"; break;
                        case 20: textDialogue.text = "Even though I am a cat, but... Eh. But wolves are already on the verge of extinction... They need to be protected!"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.Mechanics:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "Heh , okay, you really amused me!"; break;
                        case 2: textDialogue.text = "This lumberjack does not spare new workers at all! He asks such difficult tasks!"; break;
                        case 3: textDialogue.text = "And this is the correct answer! Coincidence? Accident?"; break;
                        case 4: textDialogue.text = "You are a master in logic!"; break;
                        case 5: textDialogue.text = "Even watches have math in it! You are smart enough! Well done!"; break;
                        case 6: textDialogue.text = "Wow! This is an amazingly correct answer!"; break;
                        case 7: textDialogue.text = "I have already said this once, but... Money loves smart people!"; break;
                        case 8: textDialogue.text = "You think and answer faster than me!"; break;
                        case 9: textDialogue.text = "Don't repeat this at home! They were just trying to confuse you! It's good that you are doing amazing!"; break;
                        case 10: textDialogue.text = "Do you often ride trains?"; break;
                        case 11: textDialogue.text = "The farmer needs to buy a normal scale..."; break;
                        case 12: textDialogue.text = "Why there are no cats with glasses in this problem! I'm outraged!"; break;
                        case 13: textDialogue.text = "The probability that this is the correct answer is: 1. Not bad!"; break;
                        case 14: textDialogue.text = "How much mayonnaise they made!"; break;
                        case 15: textDialogue.text = "Oh, and it was long ago..."; break;
                        case 16: textDialogue.text = "Good answer!"; break;
                        case 17: textDialogue.text = "You understand calendars well!"; break;
                        case 18: textDialogue.text = "Additional lessons are provided for you!"; break;
                        case 19: textDialogue.text = "Kate definitely needs to replace this watch!"; break;
                        case 20: textDialogue.text = "I wonder what is in the barrels?"; break;
                    }
                    break;
                case (int)GlobalVariables.NameAnimation.LatestDevelopments:
                    switch (SaveInGame.numberLvlClick)
                    {
                        case 1: textDialogue.text = "I love chests!"; break;
                        case 2: textDialogue.text = "Every minute, it becomes more difficult to confuse you!"; break;
                        case 3: textDialogue.text = "Probably it was twenty years ago. With such and such salaries!"; break;
                        case 4: textDialogue.text = "Working seven days a week is wrong! I hope this employer will understand everything and improve!"; break;
                        case 5: textDialogue.text = "If so many sweets were given to those who came, then what happened at the party itself?"; break;
                        case 6: textDialogue.text = "However, what servants Pharaoh has! Calculated 1000 grams without weights!"; break;
                        case 7: textDialogue.text = "Eh, I would have such a garden..."; break;
                        case 8: textDialogue.text = "Stealing is bad! Never do that!"; break;
                        case 9: textDialogue.text = "Well done! You managed it!"; break;
                        case 10: textDialogue.text = "Wow, you can handle such a difficult task! I underestimated you!"; break;
                        case 11: textDialogue.text = "Johnny lives luxuriously, you cant doubt that!"; break;
                        case 12: textDialogue.text = "I wonder where this hotel is located?"; break;
                        case 13: textDialogue.text = "Wow, you saved about $100 on just one pencil! A really good pencil!"; break;
                        case 14: textDialogue.text = "I wonder why they did it?"; break;
                        case 15: textDialogue.text = "Do you like cookies?"; break;
                        case 16: textDialogue.text = "And the youngest is half as small as me!"; break;
                        case 17: textDialogue.text = "You were able to go through this difficult and thorny path! Incredible!"; break;
                        case 18: textDialogue.text = "Your intelligence is amazing!"; break;
                        case 19: textDialogue.text = "I have no words to convey how great you are!"; break;
                    }
                    break;
            }
        }
        SaveData.Save();
        // The player has never rated the game.
        if (SaveInGame.tempAllCount >= 10 && SaveInGame.isPressRateGame == 0)
        {
            GlobalSceneObjects.tableRate.SetActive(true);
        }
        // If the player decides to rate the game later.
        if ((SaveInGame.tempAllCount == 25 || SaveInGame.tempAllCount == 50 || SaveInGame.tempAllCount == 100 ||
            SaveInGame.tempAllCount == 150 || SaveInGame.tempAllCount == 194) && SaveInGame.isPressRateGame == 2)
        {
            GlobalSceneObjects.tableRate.SetActive(true);
        }
        GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.ButtonContinue;
        
    }
}
