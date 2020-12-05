using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// It contains all the coroutines of the game, as well as methods for safely calling these coroutines.
/// </summary>
public class Coroutines : MonoBehaviour
{
    /// <summary>
    /// Action when answering a joke task.
    /// </summary>
    /// <param name="howManyGetCountHelp">The number of fish received per answer.</param>
    /// <param name="currentJokeTask">The number of the joke task that was completed.</param>
    /// <param name="userAnswer">The answer given by the player.</param>
    IEnumerator GetJokeAnswer(int howManyGetCountHelp, int currentJokeTask, string userAnswer)
    {
        GlobalSceneObjects.answerButton.GetComponent<Button>().onClick.RemoveAllListeners();
        Text dialogue = GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>();

        if (currentJokeTask != 1050)
        {
            for (int i = 0; i < howManyGetCountHelp; i++)
            {
                SaveInGame.SavesCountHelp++;
                CountImageHelp.Show();
                GlobalSceneObjects.helpButton.transform.Find("CountHelp").Find("PictureHelp").GetComponent<Animator>().Play("PictureHelp");
                if (howManyGetCountHelp <= 10) yield return new WaitForSeconds(0.15f);
                else if (howManyGetCountHelp <= 50) yield return new WaitForSeconds(0.05f);
                else yield return new WaitForSeconds(0.02f);
            }
            StartCoroutine(HideDialogue());
            switch (SaveInGame.numberJokeTask)
            {
                case 0:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 7)
                            dialogue.text = "Ту-ту-ру! Член лаборатории номер один на месте!";
                        else
                            dialogue.text = "Да-да, приветик! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 7)
                            dialogue.text = "Tuturu! Lab member number one in place!";
                        else
                            dialogue.text = "Yes, hello! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 1:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 25)
                            dialogue.text = "Чиж, ты ли это? Привет! Мы тебе тут завезли немного подсказок ;)";
                        else if (howManyGetCountHelp == 7)
                            dialogue.text = "Оу! Приятно познакомится отаку!";
                        else
                            dialogue.text = "Приятно познакомиться! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 25)
                            dialogue.text = "Cchizh, is it you? Hello! We brought you some tips here ;)";
                        else if (howManyGetCountHelp == 7)
                            dialogue.text = "Oh! Nice to meet you otaku!";
                        else
                            dialogue.text = "Nice to meet you! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 2:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Я рад, что ты не член Организации!";
                        else
                            dialogue.text = "Пароль принят! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "I'm glad you're not a member of the Organization!";
                        else
                            dialogue.text = "Password accepted! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 3:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 4)
                            dialogue.text = "Тогда я тебе немного помогу! Лови рыбок!";
                        else
                            dialogue.text = "Всё равно держи! Пригодятся! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 4)
                            dialogue.text = "Then I'll help you a little! Catch the fish!";
                        else
                            dialogue.text = "Take it anyway! Come in handy! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 4:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 2)
                            dialogue.text = "Так! Размялись, пора и за настоящую задачку!";
                        else
                            dialogue.text = "Сказать, что я разочарован, значит ничего не сказать! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 2)
                            dialogue.text = "So! Warm up, it's time for a real challenge!";
                        else
                            dialogue.text = "To say that I am disappointed is to say nothing! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 5:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 6)
                            dialogue.text = "Молодец! Это правильный ответ!";
                        else
                            dialogue.text = "Это не правильно. Дам половину от правильного ответа! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 6)
                            dialogue.text = "Well done! This is the correct answer!";
                        else
                            dialogue.text = "It is not right. I'll give you half of the correct answer! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 6:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 7)
                            dialogue.text = "Похвально!";
                        else
                            dialogue.text = "Я надеюсь, ты это исправишь? Если нет аллергии, конечно! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 7)
                            dialogue.text = "Commendable!";
                        else
                            dialogue.text = "I hope you fix it? If there is no allergy, of course! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 7:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "Я тоже считаю, что возможны! Но я кот! Я знаю чуть больше, чем Люди!";
                        else
                            dialogue.text = "Лично я считаю, что возможны! Но я кот! Я знаю чуть больше, чем Люди! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "I also think they are possible! But I'm a cat! I know a little more than People!";
                        else
                            dialogue.text = "Personally, I think they are possible! But I'm a cat! I know a little more than People! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 8:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Неплохо. Осталось шесть секунд...";
                        else
                            dialogue.text = "Твой ответ принят, хоть это немного не то, что хотелось услышать! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Not bad. Six seconds left...";
                        else
                            dialogue.text = "Your answer is accepted, even though it's not what I wanted to hear! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 9:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 12)
                            dialogue.text = "Я вот, хожу только по комнатам в доме!";
                        else
                            dialogue.text = "Я вот, хожу только по комнатам в доме! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 12)
                            dialogue.text = "I only go to rooms in the house!";
                        else
                            dialogue.text = "I only go to rooms in the house! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 10:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 12)
                            dialogue.text = "Спасибо за доверие!";
                        else
                            dialogue.text = "Не поддаёшься на провакации! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 12)
                            dialogue.text = "Thank you for your trust!";
                        else
                            dialogue.text = "And I wanted to hear yes... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 11:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 32)
                            dialogue.text = "Именно! Улыбка на все 32 зуба!";
                        else
                            dialogue.text = "Эммм.... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 32)
                            dialogue.text = "Exactly! Smile for all 32 teeth!";
                        else
                            dialogue.text = "??? Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 12:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 33)
                            dialogue.text = "За такой ответ дарю 33 рыбки!";
                        else
                            dialogue.text = "Совершенно. Абсолютно. Нет. В качестве утешительного приза - плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 26)
                            dialogue.text = "For this answer I give 26 fish!";
                        else
                            dialogue.text = "Absolutely. Absolutely. Not. As a consolation prize - plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 13:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Это радует! Расскажу как-нибудь на досуге!";
                        else
                            dialogue.text = "Грустно. Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "This makes me happy! I'll tell you sometime at my leisure!";
                        else
                            dialogue.text = "It's sad. Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 14:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Вау! Ты знаешь!";
                        else
                            dialogue.text = "Нет... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Wow! You know!";
                        else
                            dialogue.text = "Not... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 15:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Солнышко принесло тебе 10 рыбок!";
                        else if (howManyGetCountHelp == 9)
                            dialogue.text = "Дождик принёс тебе 9 рыбок!";
                        else if (howManyGetCountHelp == 8)
                            dialogue.text = "Снежок принёс тебе 8 рыбок!";
                        else
                            dialogue.text = "Где-то произошла ошибка... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "The sun has brought you 10 fish!";
                        else if (howManyGetCountHelp == 9)
                            dialogue.text = "The rain has brought you 9 fish!";
                        else if (howManyGetCountHelp == 8)
                            dialogue.text = "The snow has brought you 8 fish!";
                        else
                            dialogue.text = "Something went wrong! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 16:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 15)
                            dialogue.text = "Люблю все сезоны года одинаково сильно!";
                        else
                            dialogue.text = "Где-то произошла ошибка... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 15)
                            dialogue.text = "I love all seasons of the year equally!";
                        else
                            dialogue.text = "Something went wrong! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 17:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "Однако!";
                        else
                            dialogue.text = "Странный ответ... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "Awesome!";
                        else
                            dialogue.text = "Strange answer... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 18:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 9)
                            dialogue.text = "Пообщаемся побольше?";
                        else
                            dialogue.text = "Что-что? Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 9)
                            dialogue.text = "Let's talk a little more?";
                        else
                            dialogue.text = "I'm sorry, what? Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 19:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 18)
                            dialogue.text = "Всем любви!";
                        else
                            dialogue.text = "Я абсолютно не понимаю тебя... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 18)
                            dialogue.text = "Love to all!";
                        else
                            dialogue.text = "I absolutely don't understand you... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 20:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Абсолютный ноль по цельсию именно таков!";
                        else if (howManyGetCountHelp == 6)
                            dialogue.text = "Абсолютный ноль по Фаренгейту? Вау! Как необычно!";
                        else
                            dialogue.text = "Мимо. Неправильно! Плюс " + howManyGetCountHelp + ".";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Absolute zero celsius is just that!";
                        else if (howManyGetCountHelp == 6)
                            dialogue.text = "Fahrenheit absolute zero? Wow! How unusual!";
                        else
                            dialogue.text = "Wrong! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 21:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Земля, конечно не плоская, но и не идеально круглая!";
                        else if (howManyGetCountHelp == 10)
                            dialogue.text = "Ух ты, какие познания! Вот тебе 10 рыбок!";
                        else if (howManyGetCountHelp == 1)
                            dialogue.text = "У меня для тебя плохие новости... Одна рыбка тебе за такой ответ...";
                        else
                            dialogue.text = "Я немного не понял, что тут написано... Но допустим плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "The earth is certainly not flat, but not perfectly round either!";
                        else if (howManyGetCountHelp == 10)
                            dialogue.text = "Wow, what knowledge! Here are 10 fish for you!";
                        else if (howManyGetCountHelp == 1)
                            dialogue.text = "I have bad news for you... One fish for you for such an answer...";
                        else
                            dialogue.text = "I didn't understand a little what is written here... But let's say a plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 22:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 4)
                            dialogue.text = "<3 Надеюсь ты сможешь пройти её всю!";
                        else
                            dialogue.text = "Ты заставляешь меня сильно грустить из-за этого... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 4)
                            dialogue.text = "<3 I hope you can complete it!";
                        else
                            dialogue.text = "You make me really sad about it... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 23:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 2)
                            dialogue.text = "Я рад!";
                        else
                            dialogue.text = "Жаль... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 2)
                            dialogue.text = "I am glad!";
                        else
                            dialogue.text = "It's a pity... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 24:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Следи за временем!";
                        else
                            dialogue.text = "И как же в твою разум пришёл такой гениальный ответ? Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Keep track of the time!";
                        else
                            dialogue.text = "And how did such an ingenious answer come into your mind? Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 25:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Отлично! Это ты знаешь!";
                        else
                            dialogue.text = "Ты не знаешь? Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Fine! You know that!";
                        else
                            dialogue.text = "You do not know? Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 26:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Не забывай основы кредо!";
                        else
                            dialogue.text = "Ладно, забыли... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "I just have one question. Why cucumber?";
                        else
                            dialogue.text = "Bitter cucumber... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 27:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Именно! Молодец! Правильный ответ!";
                        else
                            dialogue.text = "Правильный ответ \"Я самый умный\". Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Exactly! Well done! Correct answer!";
                        else
                            dialogue.text = "The correct answer is \"I am the smartest\". Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 28:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 20)
                            dialogue.text = "Хорош! Поколение миллениалов пронзит небеса!";
                        else
                            dialogue.text = "Допустим... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 20)
                            dialogue.text = "Good! Millennials will pierce the skies!";
                        else
                            dialogue.text = "Let's say... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 29:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Синий мне больше всего нравится!";
                        else
                            dialogue.text = "Интересный выбор... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Blue is my favorite!";
                        else
                            dialogue.text = "Interesting choice... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 30:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Хорошо, что с тобой всё в порядке!";
                        else
                            dialogue.text = "Грустно... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "It's good that you're all right!";
                        else
                            dialogue.text = "It is sad... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 31:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Ладно, поигрались с вопросами, можно и дальше решать сложные задачки!";
                        else
                            dialogue.text = "Грустно... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Okay, play with the questions, you can continue to solve complex tasks!";
                        else
                            dialogue.text = "It is sad... Plus " + howManyGetCountHelp + " fish...";
                    }
                    break;
                case 32:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 1)
                            dialogue.text = "Тогда, тебе моя помощь врядли пригодится! Но вот тебе одна рыбка! На всякий случай!";
                        else
                            dialogue.text = "Тогда держи побольше рыбок! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 1)
                            dialogue.text = "Then, my help will hardly be useful to you! But here's one fish for you! Just in case!";
                        else
                            dialogue.text = "Then keep more fish! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 33:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        dialogue.text = "Мы можем продолжать решать сложный задачи?";
                    }
                    else
                    {
                        dialogue.text = "Are we continuing to solve difficult tasks?";
                    }
                    break;
                case 34:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "Восемь планет? Значит будет 8 рыбок!";
                        else
                            dialogue.text = "Стоп, что? Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "Eight planets? So there will be 8 fish!";
                        else
                            dialogue.text = "Stop what? Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 35:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "А вот за Андромеду дам тебе ещё 5 рыбок!";
                        else
                            dialogue.text = "Мне кажется, что это неправильно... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "For Andromeda I will give you 5 more fish!";
                        else
                            dialogue.text = "It seems to me that this is wrong... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 36:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Правильно! Держи 10 рыбок!";
                        else
                            dialogue.text = "О чём ты... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Right! Keep 10 fish!";
                        else
                            dialogue.text = "What are you talking about... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 37:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Какие познания! Держи 5 рыбок!";
                        else
                            dialogue.text = "О чём ты... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "What knowledge! Keep 5 fish!";
                        else
                            dialogue.text = "What are you talking about... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 38:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "А ты действительно молодец! Держи 8 рыбок!";
                        else
                            dialogue.text = "Нет... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 8)
                            dialogue.text = "And you are really great! Keep 8 fish!";
                        else
                            dialogue.text = "Nope... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 39:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "London is the capital of Great Britain!";
                        else
                            dialogue.text = "Нет... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "London is the capital of Great Britain! Yes!";
                        else
                            dialogue.text = "Nope... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 40:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Токио столица Японии. Это действительно так!";
                        else
                            dialogue.text = "Нет... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Tokyo is the capital of Japan. It really is!";
                        else
                            dialogue.text = "Nope... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 41:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Тебя не остановить! Это правильно!";
                        else
                            dialogue.text = "Для меня очевидно, то что ты ошибаешься! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Can't stop you! It is right!";
                        else
                            dialogue.text = "It's obvious to me that you're wrong! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 42:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Невероятно, правда?";
                        else
                            dialogue.text = "Лифты передвигаются вверх и вниз! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "Incredible, right?";
                        else
                            dialogue.text = "Elevators move up and down! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 43:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "А ты откуда знаешь?";
                        else
                            dialogue.text = "Самое сильное существо на планете - это муравей! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 10)
                            dialogue.text = "How do you know that?";
                        else
                            dialogue.text = "The most powerful creature on the planet is an ant! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 44:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "А сколько у тебя градусов на улице?";
                        else
                            dialogue.text = "Термометр... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "How many degrees are you outside?";
                        else
                            dialogue.text = "Thermometer... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 45:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 7)
                            dialogue.text = "Элементарно Ватсон!";
                        else
                            dialogue.text = "Здесь без Шерлока Холмса не разобраться! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 7)
                            dialogue.text = "Elementary Watson!";
                        else
                            dialogue.text = "You can't figure it out without Sherlock Holmes! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 46:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Сам в шоке!";
                        else
                            dialogue.text = "Что-то в твоих рассуждениях пошло не так! Но всё равно плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Himself in shock!";
                        else
                            dialogue.text = "Something in your reasoning went wrong! But still a plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 47:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 25)
                            dialogue.text = "Это самый лучший твой ответ за всё время!";
                        else
                            dialogue.text = "Хорошо, пусть будет так! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 25)
                            dialogue.text = "This is your best answer ever!";
                        else
                            dialogue.text = "Okay, so be it! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 48:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "Какой банальный ответ! За него только 5 рыбок отдам!";
                        else
                            dialogue.text = "Неплохой ответ! Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 5)
                            dialogue.text = "What a banal answer! I will give only 5 fish for it!";
                        else
                            dialogue.text = "Not a bad answer! Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 49:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 20)
                            dialogue.text = "Ответ засчитан!";
                        else
                            dialogue.text = "Ладно... Плюс " + howManyGetCountHelp + "!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 20)
                            dialogue.text = "The answer is valid!";
                        else
                            dialogue.text = "Okay... Plus " + howManyGetCountHelp + " fish!";
                    }
                    break;
                case 50:
                    if (GlobalVariables.isRussianLanguage == true)
                    {
                        if (howManyGetCountHelp == 200)
                            dialogue.text = "Хо-хо, действительно на зелёный! За такой ответ даю тебе бесконечное количество рыбок!";
                        else
                            dialogue.text = "Даю тебе бесконечное количество рыб. Только запомни, что правильный ответ ЗЕЛЁНЫЙ!";
                    }
                    else
                    {
                        if (howManyGetCountHelp == 200)
                            dialogue.text = "Wow, really green! For this answer I give you an infinite number of fish!";
                        else
                            dialogue.text = "I give you an infinite number of fish. Just remember that the correct answer is GREEN!";
                    }
                    break;
            }
            SaveInGame.numberJokeTask++;
            StartCoroutine(LoadAllAchievments());
            SaveData.Save();

            if (GlobalSceneObjects.currentLevel.activeInHierarchy == true)
            {
                GlobalSceneObjects.task.GetComponent<Animator>().SetTrigger("HideTrigger");
            }
            else
            {
                GameObject task = GlobalSceneObjects.level_4.transform.Find("Task").gameObject;
                GameObject centContent = GlobalSceneObjects.level_4.transform.Find("Content").gameObject;
                task.GetComponent<Animator>().SetTrigger("HideTrigger");
                for (int numberCent = 0; numberCent < 5; numberCent++)
                {
                    centContent.transform.GetChild(numberCent).GetComponent<Animator>().SetTrigger("HideTrigger");
                }
            }

            GlobalVariables.stateForAnimation = (int)GlobalVariables.NameAnimation.Task;
            yield return new WaitForSeconds(1f);
        }
        else
        {
            if (GlobalVariables.isRussianLanguage == true)
            {
                dialogue.text = "Послушай, уже пройдены все шуточные задачи!\n Мне больше нечего предложить :c";
            }
            else
            {
                dialogue.text = "Listen, all the comic tasks have already been completed! I have nothing more to offer :c";
            }
        }
        yield return new WaitForSeconds(1f);
    }
    /// <summary>
    /// Calls all methods for loading acquired achievements.
    /// </summary>
    IEnumerator LoadAllAchievments()
    {
        yield return new WaitForSeconds(2f);
        PassedLevelAndShowAchievments();
        PassedHelpAndShowAchievments();
        PassedJokeTasksAndShowAchievments();
        PassedGetCountFish();
    }
    /// <summary>
    /// Loads all achievements in the game. Displaying the achieved achievement on the screen.
    /// </summary>
    public void PassedLevelAndShowAchievments()
    {
        CheckPassedLevel.Check();
        if (SaveInGame.isCompleteAchievment[3] == false && SaveInGame.tempAllCount >= 1)
        {
            SaveInGame.isCompleteAchievment[3] = true;
            Instantiate(Resources.Load("Achiv3"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv3 = GameObject.Find("Achiv3(Clone)");
            Achiv3.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[3];
            Achiv3.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(3, Achiv3)); });
        }
        if (SaveInGame.isCompleteAchievment[4] == false && SaveInGame.tempAllCount >= 10)
        {
            SaveInGame.isCompleteAchievment[4] = true;
            Instantiate(Resources.Load("Achiv4"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv4 = GameObject.Find("Achiv4(Clone)");
            Achiv4.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[4];
            Achiv4.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(4, Achiv4)); });
        }
        if (SaveInGame.isCompleteAchievment[5] == false && SaveInGame.tempAllCount >= 20)
        {
            SaveInGame.isCompleteAchievment[5] = true;
            Instantiate(Resources.Load("Achiv5"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv5 = GameObject.Find("Achiv5(Clone)");
            Achiv5.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[5];
            Achiv5.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(5, Achiv5)); });
        }
        if (SaveInGame.isCompleteAchievment[6] == false && SaveInGame.tempAllCount >= 40)
        {
            SaveInGame.isCompleteAchievment[6] = true;
            Instantiate(Resources.Load("Achiv6"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv6 = GameObject.Find("Achiv6(Clone)");
            Achiv6.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[6];
            Achiv6.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(6, Achiv6)); });
        }
        if (SaveInGame.isCompleteAchievment[7] == false && SaveInGame.tempAllCount >= 50)
        {
            SaveInGame.isCompleteAchievment[7] = true;
            Instantiate(Resources.Load("Achiv7"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv7 = GameObject.Find("Achiv7(Clone)");
            Achiv7.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[7];
            Achiv7.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(7, Achiv7)); });
        }
        if (SaveInGame.isCompleteAchievment[8] == false && SaveInGame.tempAllCount >= 75)
        {
            SaveInGame.isCompleteAchievment[8] = true;
            Instantiate(Resources.Load("Achiv8"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv8 = GameObject.Find("Achiv8(Clone)");
            Achiv8.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[8];
            Achiv8.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(8, Achiv8)); });
        }
        if (SaveInGame.isCompleteAchievment[9] == false && SaveInGame.tempAllCount >= 100)
        {
            SaveInGame.isCompleteAchievment[9] = true;
            Instantiate(Resources.Load("Achiv9"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv9 = GameObject.Find("Achiv9(Clone)");
            Achiv9.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[9];
            Achiv9.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(9, Achiv9)); });
        }
        if (SaveInGame.isCompleteAchievment[10] == false && SaveInGame.tempAllCount >= 125)
        {
            SaveInGame.isCompleteAchievment[10] = true;
            Instantiate(Resources.Load("Achiv10"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv10 = GameObject.Find("Achiv10(Clone)");
            Achiv10.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[10];
            Achiv10.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(10, Achiv10)); });
        }
        if (SaveInGame.isCompleteAchievment[11] == false && SaveInGame.tempAllCount >= 150)
        {
            SaveInGame.isCompleteAchievment[11] = true;
            Instantiate(Resources.Load("Achiv11"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv11 = GameObject.Find("Achiv11(Clone)");
            Achiv11.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[11];
            Achiv11.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(11, Achiv11)); });
        }
        if (SaveInGame.isCompleteAchievment[12] == false && SaveInGame.tempAllCount >= 195)
        {
            SaveInGame.isCompleteAchievment[12] = true;
            Instantiate(Resources.Load("Achiv12"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv12 = GameObject.Find("Achiv12(Clone)");
            Achiv12.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[12];
            Achiv12.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(12, Achiv12)); });
        }

        if (SaveInGame.isCompleteAchievment[13] == false && GlobalSaves.saveInGame[0].tempCount >= 23)
        {
            SaveInGame.isCompleteAchievment[13] = true;
            Instantiate(Resources.Load("Achiv13"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv13 = GameObject.Find("Achiv13(Clone)");
            Achiv13.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[13];
            Achiv13.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(13, Achiv13)); });
        }
        if (SaveInGame.isCompleteAchievment[14] == false && GlobalSaves.saveInGame[1].tempCount >= 23)
        {
            SaveInGame.isCompleteAchievment[14] = true;
            Instantiate(Resources.Load("Achiv14"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv14 = GameObject.Find("Achiv14(Clone)");
            Achiv14.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[14];
            Achiv14.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(14, Achiv14)); });
        }
        if (SaveInGame.isCompleteAchievment[15] == false && GlobalSaves.saveInGame[2].tempCount >= 23)
        {
            SaveInGame.isCompleteAchievment[15] = true;
            Instantiate(Resources.Load("Achiv15"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv15 = GameObject.Find("Achiv15(Clone)");
            Achiv15.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[15];
            Achiv15.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(15, Achiv15)); });
        }
        if (SaveInGame.isCompleteAchievment[16] == false && GlobalSaves.saveInGame[3].tempCount >= 23)
        {
            SaveInGame.isCompleteAchievment[16] = true;
            Instantiate(Resources.Load("Achiv16"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv16 = GameObject.Find("Achiv16(Clone)");
            Achiv16.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[16];
            Achiv16.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(16, Achiv16)); });
        }
        if (SaveInGame.isCompleteAchievment[17] == false && GlobalSaves.saveInGame[4].tempCount >= 24)
        {
            SaveInGame.isCompleteAchievment[17] = true;
            Instantiate(Resources.Load("Achiv17"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv17 = GameObject.Find("Achiv17(Clone)");
            Achiv17.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[17];
            Achiv17.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(17, Achiv17)); });
        }
        if (SaveInGame.isCompleteAchievment[18] == false && ((GlobalSaves.saveInGame[0].tempCount + GlobalSaves.saveInGame[1].tempCount + GlobalSaves.saveInGame[2].tempCount + GlobalSaves.saveInGame[3].tempCount + GlobalSaves.saveInGame[4].tempCount) >= 116))
        {
            SaveInGame.isCompleteAchievment[18] = true;
            Instantiate(Resources.Load("Achiv18"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv18 = GameObject.Find("Achiv18(Clone)");
            Achiv18.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[18];
            Achiv18.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(18, Achiv18)); });
        }
        if (SaveInGame.isCompleteAchievment[19] == false && GlobalSaves.saveInGame[5].tempCount >= 20)
        {
            SaveInGame.isCompleteAchievment[19] = true;
            Instantiate(Resources.Load("Achiv19"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv19 = GameObject.Find("Achiv19(Clone)");
            Achiv19.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[19];
            Achiv19.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(19, Achiv19)); });
        }
        if (SaveInGame.isCompleteAchievment[20] == false && GlobalSaves.saveInGame[6].tempCount >= 20)
        {
            SaveInGame.isCompleteAchievment[20] = true;
            Instantiate(Resources.Load("Achiv20"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv20 = GameObject.Find("Achiv20(Clone)");
            Achiv20.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[20];
            Achiv20.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(20, Achiv20)); });
        }
        if (SaveInGame.isCompleteAchievment[21] == false && GlobalSaves.saveInGame[7].tempCount >= 20)
        {
            SaveInGame.isCompleteAchievment[21] = true;
            Instantiate(Resources.Load("Achiv21"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv21 = GameObject.Find("Achiv21(Clone)");
            Achiv21.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[21];
            Achiv21.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(21, Achiv21)); });
        }
        if (SaveInGame.isCompleteAchievment[22] == false && GlobalSaves.saveInGame[8].tempCount >= 19)
        {
            SaveInGame.isCompleteAchievment[22] = true;
            Instantiate(Resources.Load("Achiv22"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv22 = GameObject.Find("Achiv22(Clone)");
            Achiv22.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[22];
            Achiv22.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(22, Achiv22)); });
        }
        if (SaveInGame.isCompleteAchievment[23] == false && ((GlobalSaves.saveInGame[5].tempCount + GlobalSaves.saveInGame[6].tempCount + GlobalSaves.saveInGame[7].tempCount + GlobalSaves.saveInGame[8].tempCount) >= 79))
        {
            SaveInGame.isCompleteAchievment[23] = true;
            Instantiate(Resources.Load("Achiv23"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv23 = GameObject.Find("Achiv23(Clone)");
            Achiv23.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[23];
            Achiv23.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(23, Achiv23)); });
        }
    }
    /// <summary>
    /// Loads achievements in the game. Displaying the achieved achievement on the screen.
    /// </summary>
    public void PassedHelpAndShowAchievments()
    {
        int tempCountAllOpenHelp = 0;
        for (int i = 0; i < GlobalSaves.saveInGame.Length; i++)
        {
            for (int j = 0; j < GlobalSaves.saveInGame[0].isOpenHelpLevelsCheck.Length; j++)
            {
                if (GlobalSaves.saveInGame[i].isOpenHelpLevelsCheck[j] == true)
                    tempCountAllOpenHelp++;
            }
        }

        if (SaveInGame.isCompleteAchievment[24] == false && tempCountAllOpenHelp >= 1)
        {
            SaveInGame.isCompleteAchievment[24] = true;
            Instantiate(Resources.Load("Achiv24"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv24 = GameObject.Find("Achiv24(Clone)");
            Achiv24.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[24];
            Achiv24.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(24, Achiv24)); });
        }
        if (SaveInGame.isCompleteAchievment[25] == false && tempCountAllOpenHelp >= 10)
        {
            SaveInGame.isCompleteAchievment[25] = true;
            Instantiate(Resources.Load("Achiv25"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv25 = GameObject.Find("Achiv25(Clone)");
            Achiv25.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[25];
            Achiv25.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(25, Achiv25)); });
        }
        if (SaveInGame.isCompleteAchievment[26] == false && tempCountAllOpenHelp >= 50)
        {
            SaveInGame.isCompleteAchievment[26] = true;
            Instantiate(Resources.Load("Achiv26"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv26 = GameObject.Find("Achiv26(Clone)");
            Achiv26.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[26];
            Achiv26.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(26, Achiv26)); });
        }
        if (SaveInGame.isCompleteAchievment[27] == false && tempCountAllOpenHelp >= 100)
        {
            SaveInGame.isCompleteAchievment[27] = true;
            Instantiate(Resources.Load("Achiv27"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv27 = GameObject.Find("Achiv27(Clone)");
            Achiv27.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[27];
            Achiv27.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(27, Achiv27)); });
        }
        if (SaveInGame.isCompleteAchievment[28] == false && tempCountAllOpenHelp >= 194)
        {
            SaveInGame.isCompleteAchievment[28] = true;
            Instantiate(Resources.Load("Achiv28"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv28 = GameObject.Find("Achiv28(Clone)");
            Achiv28.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[28];
            Achiv28.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(28, Achiv28)); });
        }

    }
    /// <summary>
    /// Loads achievements in the game. Displaying the achieved achievement on the screen.
    /// </summary>
    public void PassedJokeTasksAndShowAchievments()
    {
        if (SaveInGame.isCompleteAchievment[29] == false && SaveInGame.numberJokeTask >= 1)
        {
            SaveInGame.isCompleteAchievment[29] = true;
            Instantiate(Resources.Load("Achiv29"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv29 = GameObject.Find("Achiv29(Clone)");
            Achiv29.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[29];
            Achiv29.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(29, Achiv29)); });
        }
        if (SaveInGame.isCompleteAchievment[30] == false && SaveInGame.numberJokeTask >= 25)
        {
            SaveInGame.isCompleteAchievment[30] = true;
            Instantiate(Resources.Load("Achiv30"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv30 = GameObject.Find("Achiv30(Clone)");
            Achiv30.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[30];
            Achiv30.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(30, Achiv30)); });
        }
        if (SaveInGame.isCompleteAchievment[31] == false && SaveInGame.numberJokeTask >= 50)
        {
            SaveInGame.isCompleteAchievment[31] = true;
            Instantiate(Resources.Load("Achiv31"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv31 = GameObject.Find("Achiv31(Clone)");
            Achiv31.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[31];
            Achiv31.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(31, Achiv31)); });
        }
        if (SaveInGame.isCompleteAchievment[32] == false && SaveInGame.numberJokeTask >= 51)
        {
            SaveInGame.isCompleteAchievment[32] = true;
            Instantiate(Resources.Load("Achiv32"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv32 = GameObject.Find("Achiv32(Clone)");
            Achiv32.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[32];
            Achiv32.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(32, Achiv32)); });
        }
    }
    /// <summary>
    /// Loads achievements in the game. Displaying the achieved achievement on the screen.
    /// </summary>
    public void PassedGetCountFish()
    {
        if (SaveInGame.isCompleteAchievment[33] == false && SaveInGame.SavesCountHelp >= 10)
        {
            SaveInGame.isCompleteAchievment[33] = true;
            Instantiate(Resources.Load("Achiv33"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv33 = GameObject.Find("Achiv33(Clone)");
            Achiv33.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[33];
            Achiv33.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(33, Achiv33)); });
        }
        if (SaveInGame.isCompleteAchievment[34] == false && SaveInGame.SavesCountHelp >= 20)
        {
            SaveInGame.isCompleteAchievment[34] = true;
            Instantiate(Resources.Load("Achiv34"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv34 = GameObject.Find("Achiv34(Clone)");
            Achiv34.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[34];
            Achiv34.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(34, Achiv34)); });
        }
        if (SaveInGame.isCompleteAchievment[35] == false && SaveInGame.SavesCountHelp >= 35)
        {
            SaveInGame.isCompleteAchievment[35] = true;
            Instantiate(Resources.Load("Achiv35"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv35 = GameObject.Find("Achiv35(Clone)");
            Achiv35.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[35];
            Achiv35.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(35, Achiv35)); });
        }
        if (SaveInGame.isCompleteAchievment[36] == false && SaveInGame.SavesCountHelp >= 50)
        {
            SaveInGame.isCompleteAchievment[36] = true;
            Instantiate(Resources.Load("Achiv36"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv36 = GameObject.Find("Achiv36(Clone)");
            Achiv36.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[36];
            Achiv36.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(36, Achiv36)); });
        }
        if (SaveInGame.isCompleteAchievment[37] == false && SaveInGame.SavesCountHelp >= 250)
        {
            SaveInGame.isCompleteAchievment[37] = true;
            Instantiate(Resources.Load("Achiv37"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv37 = GameObject.Find("Achiv37(Clone)");
            Achiv37.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[37];
            Achiv37.GetComponent<Button>().onClick.AddListener(delegate { StartCoroutine(ChangeTextAndGetAchievmentInLevel(37, Achiv37)); });
        }
    }
    /// <summary>
    /// Loads achievements in the game. Displaying the achieved achievement on the screen.
    /// </summary>
    public void PassedAndShowAchievments1()
    {
        if (SaveInGame.isCompleteAchievment[1] == false)
        {
            SaveInGame.isCompleteAchievment[1] = true;
            Instantiate(Resources.Load("Achiv1"), GlobalSceneObjects.myCanvas.transform.position, GlobalSceneObjects.myCanvas.transform.rotation, GlobalSceneObjects.myCanvas.transform);
            GameObject Achiv1 = GameObject.Find("Achiv1(Clone)");
            Achiv1.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[1];
            Achiv1.GetComponent<Button>().onClick.AddListener(delegate { InvokeChangeTextAndGetAchievmentInLevel(1, Achiv1); });
        }
    }
    /// <summary>
    /// Changes the name of the achievement to the way it was obtained. Method for achievements in the main menu.
    /// </summary>
    /// <param name="numberAchievments">The achievement number for which the text will change.</param>
    IEnumerator ChangeTextAndGetAchievment(int numberAchievments)
    {
        GameObject currentAchievments;

        currentAchievments = GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).Find("Achiv").gameObject;

        if (currentAchievments.GetComponent<TextMeshProUGUI>().text == SaveInGame.howGetAchievments[numberAchievments] || currentAchievments.GetComponent<TextMeshProUGUI>().text == SaveInGame.textAchievments[numberAchievments])
        {
            while (currentAchievments.GetComponent<TextMeshProUGUI>().text.Length != 0)
            {
                try
                {
                    currentAchievments.GetComponent<TextMeshProUGUI>().text =
                                    currentAchievments.GetComponent<TextMeshProUGUI>().text.Substring(0, currentAchievments.GetComponent<TextMeshProUGUI>().text.Length - 1);
                }
                catch (ArgumentOutOfRangeException)
                {

                }
                yield return new WaitForSeconds(0.02f);
            }
            int writeNumber = 0;
            if (SaveInGame.switchAchievments[numberAchievments] == false)
            {
                while (currentAchievments.GetComponent<TextMeshProUGUI>().text.Length != SaveInGame.howGetAchievments[numberAchievments].Length)
                {
                    writeNumber++;
                    try
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.howGetAchievments[numberAchievments].Substring(0, writeNumber);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.howGetAchievments[numberAchievments];
                        break;
                    }
                    yield return new WaitForSeconds(0.02f);
                }
            }
            else
            {
                while (currentAchievments.GetComponent<TextMeshProUGUI>().text.Length != SaveInGame.textAchievments[numberAchievments].Length)
                {
                    writeNumber++;
                    try
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[numberAchievments].Substring(0, writeNumber);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[numberAchievments];
                        break;
                    }
                    yield return new WaitForSeconds(0.02f);
                }
            }
            SaveInGame.switchAchievments[numberAchievments] = !SaveInGame.switchAchievments[numberAchievments];
            if (SaveInGame.isCompleteAchievment[numberAchievments] == true && SaveInGame.isPressCompleteAchievment[numberAchievments] == false)
            {
                SaveInGame.isPressCompleteAchievment[numberAchievments] = true;
                GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).GetChild(1).GetChild(0).gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).GetChild(1).GetChild(1).gameObject.SetActive(true);
                if (numberAchievments == 0) SaveInGame.SavesCountHelp++;
                if (numberAchievments == 2) SaveInGame.SavesCountHelp += 5;
                if (numberAchievments == 3) SaveInGame.SavesCountHelp++;
                if (numberAchievments == 4) SaveInGame.SavesCountHelp += 5;
                if (numberAchievments == 5) SaveInGame.SavesCountHelp += 7;
                if (numberAchievments == 6) SaveInGame.SavesCountHelp += 10;
                if (numberAchievments == 7) SaveInGame.SavesCountHelp += 20;
                if (numberAchievments == 8) SaveInGame.SavesCountHelp += 30;
                if (numberAchievments == 9) SaveInGame.SavesCountHelp += 50;
                if (numberAchievments == 10) SaveInGame.SavesCountHelp += 60;
                if (numberAchievments == 11) SaveInGame.SavesCountHelp += 75;
                if (numberAchievments == 12) SaveInGame.SavesCountHelp += 500;
                if (numberAchievments == 13) SaveInGame.SavesCountHelp += 5;
                if (numberAchievments == 14) SaveInGame.SavesCountHelp += 10;
                if (numberAchievments == 15) SaveInGame.SavesCountHelp += 20;
                if (numberAchievments == 16) SaveInGame.SavesCountHelp += 30;
                if (numberAchievments == 17) SaveInGame.SavesCountHelp += 40;
                if (numberAchievments == 18) SaveInGame.SavesCountHelp += 50;
                if (numberAchievments == 19) SaveInGame.SavesCountHelp += 5;
                if (numberAchievments == 20) SaveInGame.SavesCountHelp += 10;
                if (numberAchievments == 21) SaveInGame.SavesCountHelp += 30;
                if (numberAchievments == 22) SaveInGame.SavesCountHelp += 40;
                if (numberAchievments == 23) SaveInGame.SavesCountHelp += 60;

                if (numberAchievments == 25) SaveInGame.SavesCountHelp += 5;
                if (numberAchievments == 26) SaveInGame.SavesCountHelp += 10;
                if (numberAchievments == 27) SaveInGame.SavesCountHelp += 10;

                if (numberAchievments == 29) SaveInGame.SavesCountHelp += 1;
                if (numberAchievments == 30) SaveInGame.SavesCountHelp += 25;
                if (numberAchievments == 31) SaveInGame.SavesCountHelp += 50;
                if (numberAchievments == 32) SaveInGame.SavesCountHelp += 500;
                if (numberAchievments == 33) SaveInGame.SavesCountHelp += 1;
                if (numberAchievments == 34) SaveInGame.SavesCountHelp += 2;
                if (numberAchievments == 35) SaveInGame.SavesCountHelp += 4;
                if (numberAchievments == 36) SaveInGame.SavesCountHelp += 5;

            }
        }
        SaveData.Save();
        CountImageHelp.Show();
        PassedGetCountFish();
    }
    /// <summary>
    /// Changes the name of the achievement to the way it was obtained. The achievement method is called anywhere in the game.
    /// </summary>
    /// <param name="numberAchievments">The achievement number for which the text will change.</param>
    /// <param name="tempAchivments">A game object that contains the current achievement that will be destroyed.</param>
    IEnumerator ChangeTextAndGetAchievmentInLevel(int numberAchievments, GameObject tempAchivments)
    {
        GameObject currentAchievments;

        currentAchievments = tempAchivments.transform.GetChild(2).gameObject;

        if (currentAchievments.GetComponent<TextMeshProUGUI>().text == SaveInGame.howGetAchievments[numberAchievments] || currentAchievments.GetComponent<TextMeshProUGUI>().text == SaveInGame.textAchievments[numberAchievments])
        {
            while (currentAchievments.GetComponent<TextMeshProUGUI>().text.Length != 0)
            {
                try
                {
                    currentAchievments.GetComponent<TextMeshProUGUI>().text =
                                    currentAchievments.GetComponent<TextMeshProUGUI>().text.Substring(0, currentAchievments.GetComponent<TextMeshProUGUI>().text.Length - 1);
                }
                catch (ArgumentOutOfRangeException)
                {

                }
                yield return new WaitForSeconds(0.02f);
            }
            int writeNumber = 0;
            if (SaveInGame.switchAchievments[numberAchievments] == false)
            {
                while (currentAchievments.GetComponent<TextMeshProUGUI>().text.Length != SaveInGame.howGetAchievments[numberAchievments].Length)
                {
                    writeNumber++;
                    try
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.howGetAchievments[numberAchievments].Substring(0, writeNumber);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.howGetAchievments[numberAchievments];

                        break;
                    }
                    yield return new WaitForSeconds(0.02f);
                }
            }
            else
            {
                while (currentAchievments.GetComponent<TextMeshProUGUI>().text.Length != SaveInGame.textAchievments[numberAchievments].Length)
                {
                    writeNumber++;
                    try
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[numberAchievments].Substring(0, writeNumber);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        currentAchievments.GetComponent<TextMeshProUGUI>().text = SaveInGame.textAchievments[numberAchievments];

                        break;
                    }
                    yield return new WaitForSeconds(0.02f);
                }
            }
            SaveInGame.switchAchievments[numberAchievments] = !SaveInGame.switchAchievments[numberAchievments];
            if (SaveInGame.isCompleteAchievment[numberAchievments] == true && SaveInGame.isPressCompleteAchievment[numberAchievments] == false)
            {
                GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).GetChild(1).GetChild(0).gameObject.SetActive(false);
                GlobalSceneObjects.achievmentsContent.transform.GetChild(numberAchievments).GetChild(1).GetChild(1).gameObject.SetActive(true);
                tempAchivments.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
                tempAchivments.transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
                if (numberAchievments == 3) SaveInGame.SavesCountHelp++;
                if (numberAchievments == 4)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.08f);
                    }
                }
                if (numberAchievments == 5)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.08f);
                    }
                }
                if (numberAchievments == 6)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.08f);
                    }
                }
                if (numberAchievments == 7)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.08f);
                    }
                }
                if (numberAchievments == 8)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.08f);
                    }
                }
                if (numberAchievments == 9)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.05f);
                    }
                }
                if (numberAchievments == 10)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.05f);
                    }
                }
                if (numberAchievments == 11)
                {
                    for (int i = 0; i < 75; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.03f);
                    }
                }
                if (numberAchievments == 12)
                {
                    for (int i = 0; i < 250; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.01f);
                    }
                }
                if (numberAchievments == 13)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 14)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 15)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.1f);
                    }
                }
                if (numberAchievments == 16)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.08f);
                    }
                }
                if (numberAchievments == 17)
                {
                    for (int i = 0; i < 40; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.06f);
                    }
                }
                if (numberAchievments == 18)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.04f);
                    }
                }
                if (numberAchievments == 19)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 20)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 21)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.09f);
                    }
                }
                if (numberAchievments == 22)
                {
                    for (int i = 0; i < 40; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.8f);
                    }
                }
                if (numberAchievments == 23)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.07f);
                    }
                }
                if (numberAchievments == 25)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 26)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 27)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 29)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.04f);
                    }
                }
                if (numberAchievments == 30)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.1f);
                    }
                }
                if (numberAchievments == 31)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.07f);
                    }
                }
                if (numberAchievments == 32)
                {
                    for (int i = 0; i < 250; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.02f);
                    }
                }
                if (numberAchievments == 33)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.04f);
                    }
                }
                if (numberAchievments == 34)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 35)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                if (numberAchievments == 36)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SaveInGame.SavesCountHelp++;
                        CountImageHelp.Show();
                        yield return new WaitForSeconds(0.2f);
                    }
                }
                SaveInGame.isPressCompleteAchievment[numberAchievments] = true;
                SaveData.Save();
                CountImageHelp.Show();
                yield return new WaitForSeconds(1f);
                tempAchivments.GetComponent<Animator>().Play("Hide");
                yield return new WaitForSeconds(2f);
                Destroy(tempAchivments);
            }
        }
        PassedGetCountFish();
    }
    /// <summary>
    /// Animation of changing the text when changing the cat's house.
    /// </summary>
    /// <param name="word1">Current word.</param>
    /// <param name="word2">The new word to be displayed.</param>
    IEnumerator ChangeTextLevelHouse(string word1, string word2)
    {
        TMP_Text textButton = GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>();

        for (int i = 0; i <= word1.Length; i++)
        {
            if (word1.Length - i - 1 >= 0)
            {
                textButton.text = word1.Remove(word1.Length - i - 1);
            }
            yield return new WaitForSeconds(0.07f);
        }
        for (int i = 0; i < word2.Length; i++)
        {
            textButton.text = word2.Remove(i);
            yield return new WaitForSeconds(0.07f);
        }
    }
    /// <summary>
    /// Animation of hiding text when selecting a level ball.
    /// </summary>
    /// <param name="word">Current word.</param>
    IEnumerator HideTextLevelHouse(string word)
    {
        TMP_Text textButton = GlobalSceneObjects.showNextPage.transform.Find("Text").GetComponent<TextMeshProUGUI>();

        for (int i = 0; i <= word.Length; i++)
        {
            if (word.Length - i - 1 >= 0)
            {
                textButton.text = word.Remove(word.Length - i - 1);
            }
            yield return new WaitForSeconds(0.05f);
        }
    }
    /// <summary>
    /// Hide the current task and enable the joke task.
    /// </summary>
    IEnumerator PressHelp()
    {
        GlobalSounds.pressButton.Play();

        if (SaveInGame.numberLvlClick != 4)
        {
            GameObject taskContent;
            taskContent = GlobalSceneObjects.taskContent;

            GameObject answerButton = GlobalSceneObjects.answerButton;

            GlobalSceneObjects.task.GetComponent<Animator>().SetTrigger("HideTrigger");
            yield return new WaitForSeconds(1.5f);
            GlobalSceneObjects.taskContent.transform.Find("Task").Find("Line1").gameObject.SetActive(false);
            GlobalSceneObjects.taskContent.transform.Find("Task").Find("Line2").gameObject.SetActive(false);
            GlobalSceneObjects.taskContent.transform.Find("Task").Find("Numbers").gameObject.SetActive(false);
            taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "";
            taskContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 500);
            taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().margin = new Vector4(40, 53.3f, 40, 15);
            answerButton.GetComponent<Button>().onClick.RemoveAllListeners();

            if (SaveInGame.numberJokeTask == 0)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Привет!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1000); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Hello!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1000); });
                }
            }
            if (SaveInGame.numberJokeTask == 1)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Кто ты?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1001); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Who are you?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1001); });
                }
            }
            if (SaveInGame.numberJokeTask == 2)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Пароль!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1002); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Password!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1002); });
                }
            }
            if (SaveInGame.numberJokeTask == 3)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Для тебя это проблема?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1003); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Is it a problem for you?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1003); });
                }
            }
            if (SaveInGame.numberJokeTask == 4)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Сколько будет 1+1?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1004); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "What is 1 + 1?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1004); });
                }
            }
            if (SaveInGame.numberJokeTask == 5)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "2+2*2?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1005); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "2+2*2?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1005); });
                }
            }
            if (SaveInGame.numberJokeTask == 6)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "У тебя кот или кошка есть дома?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1006); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Do you have a cat at home?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1006); });
                }
            }
            if (SaveInGame.numberJokeTask == 7)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Как ты думаешь, путешествия во времени возможны?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1007); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Do you think time travel is possible?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1007); });
                }
            }
            if (SaveInGame.numberJokeTask == 8)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Время остановило свой ход, твои действия?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1008); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Time has stopped running, your actions?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1008); });
                }
            }
            if (SaveInGame.numberJokeTask == 9)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Сколько в день ты проходишь километров/миль?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1009); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many kilometers/miles per day do you walk?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1009); });
                }
            }
            if (SaveInGame.numberJokeTask == 10)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Нет времени объяснять! Просто напиши \"да\"!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1010); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "There is no time to explain! Just write \"yes\"!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1010); });
                }
            }
            if (SaveInGame.numberJokeTask == 11)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Сколько зубов у здорового человека? Ммм?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1011); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many teeth does a healthy person have?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1011); });
                }
            }
            if (SaveInGame.numberJokeTask == 12)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "А в русском алфавите сколько букв?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1012); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many letters are there in the English alphabet?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1012); });
                }
            }
            if (SaveInGame.numberJokeTask == 13)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Хочешь послушать про квантовую физику?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1013); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Do you want to hear about quantum physics?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1013); });
                }
            }
            if (SaveInGame.numberJokeTask == 14)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Какого цвета наше Солнце на самом деле?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1014); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "What color is our sun really?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1014); });
                }
            }
            if (SaveInGame.numberJokeTask == 15)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Солнце? Дождь? Снег?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1015); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The sun? Rain? Snow?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1015); });
                }
            }
            if (SaveInGame.numberJokeTask == 16)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Продолжаем! Зима? Весна? Лето? Осень?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1016); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Let's continue! Winter? Spring? Summer? Fall?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1016); });
                }
            }
            if (SaveInGame.numberJokeTask == 17)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Кстати, какой у тебя IQ?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1017); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "By the way, what's your IQ?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1017); });
                }
            }
            if (SaveInGame.numberJokeTask == 18)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "EQ – эмоциональный интеллект?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1018); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "EQ - emotional intelligence?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1018); });
                }
            }
            if (SaveInGame.numberJokeTask == 19)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "LQ – коэффициент любви?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1019); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "LQ - Love Coefficient?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1019); });
                }
            }
            if (SaveInGame.numberJokeTask == 20)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Абсолютный ноль?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1020); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Absolute zero?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1020); });
                }
            }
            if (SaveInGame.numberJokeTask == 21)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Земля круглая или плоская?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1021); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Is the Earth round or flat?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1021); });
                }
            }
            if (SaveInGame.numberJokeTask == 22)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Нравится игра?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1022); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Do you like the game?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1022); });
                }
            }
            if (SaveInGame.numberJokeTask == 23)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Улыбнись! Всё замечательно! Правда?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1023); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Smile! Everything is great! True?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1023); });
                }
            }
            if (SaveInGame.numberJokeTask == 24)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Сколько в одной минуте секунд?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1024); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many seconds are there in one minute?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1024); });
                }
            }
            if (SaveInGame.numberJokeTask == 25)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Первый химический элемент в периодической системе Менделеева?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1025); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The first chemical element in Mendeleev's periodic table?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1025); });
                }
            }
            if (SaveInGame.numberJokeTask == 26)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Что не истинно...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1026); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Bitter...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1026); });
                }
            }
            if (SaveInGame.numberJokeTask == 27)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Самый умный человек в мире по твоему субъективному мнению?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1027); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The smartest person in the world in your subjective opinion?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1027); });
                }
            }
            if (SaveInGame.numberJokeTask == 28)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Что течёт в твоих венах?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1028); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "What's running in your veins?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1028); });
                }
            }
            if (SaveInGame.numberJokeTask == 29)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Если бы ты был(-а) цветом, то каким именно?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1029); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "If you were a color, what color would you be?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1029); });
                }
            }
            if (SaveInGame.numberJokeTask == 30)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Сколько у тебя рук?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1030); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many hands do you have?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1030); });
                }
            }
            if (SaveInGame.numberJokeTask == 31)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "А сколько у тебя ног?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1031); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many legs do you have?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1031); });
                }
            }
            if (SaveInGame.numberJokeTask == 32)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Думаешь тебе по силам решить следующие задачки?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1032); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Do you think you can solve the following tasks?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1032); });
                }
            }
            if (SaveInGame.numberJokeTask == 33)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Минутка свободного творчества! Пиши что хочешь!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1033); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "A minute of free creativity! Write what you want!";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1033); });
                }
            }
            if (SaveInGame.numberJokeTask == 34)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Количество планет в солнечной системе?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1034); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many planets are there in the solar system?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1034); });
                }
            }
            if (SaveInGame.numberJokeTask == 35)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Ближайшая к нам галактика?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1035); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The nearest galaxy to us?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1035); });
                }
            }
            if (SaveInGame.numberJokeTask == 36)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "А как называют нашу планету?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1036); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "And what is our planet called?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1036); });
                }
            }
            if (SaveInGame.numberJokeTask == 37)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Cпутник Земли?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1037); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Satellite of the Earth?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1037); });
                }
            }
            if (SaveInGame.numberJokeTask == 38)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Если смешать красный, синий и зеленый свет, какой в итоге получится?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1038); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "If you mix red, blue and green light, what is the end result?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1038); });
                }
            }
            if (SaveInGame.numberJokeTask == 39)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Столица Великобритании?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1039); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The capital of Great Britain?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1039); });
                }
            }
            if (SaveInGame.numberJokeTask == 40)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Столица Японии?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1040); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Capital of Japan?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1040); });
                }
            }
            if (SaveInGame.numberJokeTask == 41)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Частица света – это...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1041); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "A particle of light is...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1041); });
                }
            }
            if (SaveInGame.numberJokeTask == 42)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Направление движения лифта?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1042); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The direction of movement of the elevator?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1042); });
                }
            }
            if (SaveInGame.numberJokeTask == 43)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Самое сильное существо в мире?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1043); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "The most powerful creature in the world?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1043); });
                }
            }
            if (SaveInGame.numberJokeTask == 44)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Прибор, показывающий температуру на улице?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1044); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "A device showing the temperature outside?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1044); });
                }
            }
            if (SaveInGame.numberJokeTask == 45)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "221";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1045); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "221";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1045); });
                }
            }
            if (SaveInGame.numberJokeTask == 46)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Сколько в пятиугольнике углов?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1046); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "How many angles are in a pentagon?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1046); });
                }
            }
            if (SaveInGame.numberJokeTask == 47)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Япония – это...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1047); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Japan is...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1047); });
                }
            }
            if (SaveInGame.numberJokeTask == 48)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Из чего состоит лес?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1048); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "What is the forest made of?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1048); });
                }
            }
            if (SaveInGame.numberJokeTask == 49)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "На что воют волки?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1049); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "Wolves howl at...";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1049); });
                }
            }
            if (SaveInGame.numberJokeTask == 50)
            {
                if (GlobalVariables.isRussianLanguage == true)
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "На какой свет нужно переходить дорогу?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1050); });
                }
                else
                {
                    taskContent.transform.Find("Task").GetComponent<TextMeshProUGUI>().text = "What light should you cross the road to?";
                    answerButton.GetComponent<Button>().onClick.AddListener(delegate { GetAnswer.Run(1050); });
                }
            }
            if (SaveInGame.numberJokeTask >= 51)
            {

                if (GlobalVariables.isRussianLanguage == true)
                {
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Послушай, уже пройдены все шуточные задачи!\n Мне больше нечего предложить :c";
                }
                else
                {
                    GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Listen, all the comic tasks have already been completed! I have nothing more to offer :c";
                }
            }
            GlobalSceneObjects.task.GetComponent<Animator>().Play("Show");
        }
        else// 4 level
        {
            StartCoroutine(HideDialogue());
            if (GlobalVariables.isRussianLanguage == true)
            {
                GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "В этом уровне я не могу помочь наловить рыбок!";
            }
            else
            {
                GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "In this level, I cannot help catch fish!";
            }
            GlobalSceneObjects.helpButton.transform.Find("CountHelp").Find("PictureHelp").GetComponent<Animator>().Play("PictureHelp");
        }
    }
    /// <summary>
    /// Turn on the cat's dialogue and set a timer, after which the dialogue will be hidden.
    /// </summary>
    IEnumerator HideDialogue()
    {
        if (GlobalSceneObjects.gameLevels.transform.Find("CatContent").Find("Dialogue").localScale.x <= 0.3f)
        {
            GlobalSceneObjects.gameLevels.transform.Find("CatContent").Find("Dialogue").GetComponent<Animator>().SetTrigger("ShowTrigger");
        }

        yield return new WaitForSeconds(3f);
        GlobalSceneObjects.gameLevels.transform.Find("CatContent").Find("Dialogue").GetComponent<Animator>().SetTrigger("HideTrigger");
    }
    /// <summary>
    /// Calls all methods for loading acquired achievements.
    /// </summary>
    public void InvokeStartGameAndLoadAchievments()
    {
        StartCoroutine(LoadAllAchievments());
    }
    /// <summary>
    /// Changes the name of the achievement to the way it was obtained. Method for achievements in the main menu.
    /// </summary>
    /// <param name="numberAchievments">The achievement number for which the text will change.</param>
    public void InvokeChangeTextAndGetAchievment(int numberAchievments)
    {
        StartCoroutine(ChangeTextAndGetAchievment(numberAchievments));
    }
    /// <summary>
    /// Changes the name of the achievement to the way it was obtained. The achievement method is called anywhere in the game.
    /// </summary>
    /// <param name="numberAchievments">The achievement number for which the text will change.</param>
    /// <param name="tempAchivments">A game object that contains the current achievement that will be destroyed.</param>
    public void InvokeChangeTextAndGetAchievmentInLevel(int numberAchievments, GameObject tempAchivments)
    {
        StartCoroutine(ChangeTextAndGetAchievmentInLevel(numberAchievments, tempAchivments));
    }
    /// <summary>
    /// Animation of changing the text when changing the cat's house.
    /// </summary>
    /// <param name="word1">Current word.</param>
    /// <param name="word2">The new word to be displayed.</param>
    public void InvokeChangeTextLevelHouse(string word1, string word2)
    {
        StartCoroutine(ChangeTextLevelHouse(word1, word2));
    }
    /// <summary>
    /// Animation of hiding text when selecting a level ball.
    /// </summary>
    /// <param name="word">Current word.</param>
    public void InvokeHideTextLevelHouse(string word)
    {
        StopAllCoroutines();
        StartCoroutine(HideTextLevelHouse(word));
    }
    /// <summary>
    /// Action when answering a joke task.
    /// </summary>
    /// <param name="howManyGetCountHelp">The number of fish received per answer.</param>
    /// <param name="currentJokeTask">The number of the joke task that was completed.</param>
    /// <param name="userAnswer">The answer given by the player.</param>
    public void InvokeGetJokeAnswer(int howManyGetCountHelp, int currentJokeTask, string userAnswer)
    {
        StopAllCoroutines();
        StartCoroutine(GetJokeAnswer(howManyGetCountHelp, currentJokeTask, userAnswer));
    }
    /// <summary>
    /// Hide the current task and enable the joke task.
    /// </summary>
    public void InvokePressHelp()
    {
        if (GlobalSceneObjects.continueButton.activeInHierarchy == false)
        {
            StartCoroutine(PressHelp());
        }
        else
        {
            GlobalSceneObjects.helpButton.transform.Find("CountHelp").Find("PictureHelp").GetComponent<Animator>().Play("PictureHelp");
        }
    }
    /// <summary>
    /// Turn on the cat's dialogue and set a timer, after which the dialogue will be hidden.
    /// </summary>
    public void InvokeHideDialogue()
    {
        StopAllCoroutines();
        StartCoroutine(HideDialogue());
    }
    /// <summary>
    /// A message for the player that the level has already been completed and cannot be skipped.
    /// </summary>
    public void PassedLevel()
    {
        StopAllCoroutines();
        StartCoroutine(HideDialogue());

        if (GlobalVariables.isRussianLanguage == true)
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "Что за мысль пришла в твою голову? Этот уровень уже пройден!";
        }
        else
        {
            GlobalSceneObjects.dialogue.transform.Find("Text").GetComponent<Text>().text = "What are you talking about? This level has already been completed!";
        }
    }
}
