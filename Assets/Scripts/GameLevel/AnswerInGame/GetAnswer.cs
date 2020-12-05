using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Checks the answer in the level.
/// </summary>
public static class GetAnswer
{
    /// <summary>
    /// Start checking the answer.
    /// </summary>
    /// <param name="NumberLevelsParams">The number of the level the player is in.</param>
    public static void Run(int NumberLevelsParams)
    {
        Coroutines coroutines = GameObject.FindObjectOfType(typeof(Coroutines)) as Coroutines;

        GlobalSounds.pressButton.Play();
        bool isCorrect = false;
        string userAnswer = GlobalSceneObjects.inputField.GetComponent<InputField>().text;
        userAnswer = userAnswer.ToUpper();
        userAnswer = userAnswer.Replace(" ", "");
        switch (GlobalVariables.activeNameLevel)
        {
            case (int)GlobalVariables.NameAnimation.LightTests:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("ДВАСЛОВА") || userAnswer.Contains("TWOWORDS")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("2")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("МЯТНОЕ") || userAnswer.Contains("MINT")) isCorrect = true; break;
                    
                    case 5: if (userAnswer.Contains("ЭСКАЛАТОР") || userAnswer.Contains("ESCALATOR")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("ЛЁД") || userAnswer.Contains("ЛЕД") || userAnswer.Contains("ЛЬДА") || userAnswer.Contains("ЛЕДЯНАЯ") || userAnswer.Contains("ICE")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("РЮКЗАК") || userAnswer.Contains("BACKPACK")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("5")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("2101")) isCorrect = true; break;
                    case 10: if (userAnswer == "F") isCorrect = true; break;
                    case 11: if (userAnswer.Contains("МИЗИНЕЦ") || userAnswer == "М" || userAnswer == "LITTLEFINGER" || userAnswer == "LF") isCorrect = true; break;
                    case 12: if (userAnswer.Contains("ЗАРАЗА") || userAnswer == "HEART") isCorrect = true; break;
                    case 13: if (userAnswer.Contains("42")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("СПИШЬ") || userAnswer.Contains("ЗАСНУЛ") || userAnswer.Contains("SLEEP")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("ОДИН") || userAnswer.Contains("1") || userAnswer.Contains("ONE")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("НИСКОЛЬКО") || userAnswer.Contains("НОЛЬ") || userAnswer.Contains("ПУСТА") || userAnswer.Contains("NONE") || userAnswer.Contains("EMPTY") || userAnswer.Contains("ZERO")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("ЭВЕРЕСТ") || userAnswer.Contains("EVEREST")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("ИЗМЕРЕНИЕВРЕМЕНИ") || userAnswer.Contains("ЧАСАХ") || userAnswer.Contains("ЧАСЫ") || userAnswer.Contains("TIME") || userAnswer.Contains("CLOCK")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("БРАДОБРЕЙ") || userAnswer.Contains("БАРБЕР") || userAnswer.Contains("ЦИРЮЛЬНИК") || userAnswer.Contains("BARBER")) isCorrect = true; break;
                    case 20: if (userAnswer == "." || userAnswer == "," || userAnswer == "ТОЧК" || userAnswer == "ЗАПЯТ" || userAnswer == "DOT" || userAnswer == "COMMA") isCorrect = true; break;
                    case 21: if (userAnswer.Contains("СНЫ") || userAnswer.Contains("СОН") || userAnswer.Contains("ТЕМНОТ") || userAnswer.Contains("DREAM") || userAnswer.Contains("DARKNESS")) isCorrect = true; break;
                    case 22: if (userAnswer.Contains("ВСЕМЕСЯЦЫ") || userAnswer.Contains("12") || userAnswer.Contains("ДВЕНАДЦАТЬ") || userAnswer.Contains("ALLMONTHS") || userAnswer.Contains("TWELVE")) isCorrect = true; break;
                    case 23: if (userAnswer.Contains("НЕТБИЛЕТ") || userAnswer.Contains("БЕЗБИЛЕТ") || userAnswer.Contains("ОТСУТСТВУЕТ") || userAnswer.Contains("NOTICKET") || userAnswer.Contains("NOLOTTERY") || userAnswer.Contains("WITHOUT")) isCorrect = true; break;

                }
                break;
            case (int)GlobalVariables.NameAnimation.BestPractices:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer == "И" || userAnswer.Contains("AND")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("1") || userAnswer.Contains("ОДНУ") || userAnswer.Contains("ОДНА") || userAnswer.Contains("ONE")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("КОЛЕНЯХ") || userAnswer.Contains("НОГАХ") || userAnswer.Contains("FEET") || userAnswer.Contains("KNEES") || userAnswer.Contains("FOOT")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("БЕСКОНЕЧНОСТ") || userAnswer.Contains("INFINITY")) isCorrect = true; break;
                    case 5: if (userAnswer == "Е" || userAnswer.Contains("R")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("ЧБД") || userAnswer.Contains("WHN")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("НЕТДОЖДЯ") || userAnswer.Contains("ДОЖДЯНЕТ") || userAnswer.Contains("ДОЖДЬОТСУТСТВУЕТ") || userAnswer.Contains("ОТСУТСТВУЕТДОЖДЬ") || userAnswer.Contains("СОЛНЕЧНО") || userAnswer.Contains("СОЛНЦЕ") || userAnswer.Contains("NORAIN") || userAnswer.Contains("RAINISOUT") || userAnswer.Contains("SUN")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("126")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("ЗАПАСНОЕ") || userAnswer.Contains("SPARE") || userAnswer.Contains("STEPNEY")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("БУДИЛЬНИК") || userAnswer.Contains("ALARM")) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("ТРИ") || userAnswer.Contains("ТРОЕ") || userAnswer.Contains("3") || userAnswer.Contains("THREE")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("ИМЯ") || userAnswer.Contains("ФАМИЛИЯ") || userAnswer.Contains("NAME") || userAnswer.Contains("SURNAME") || userAnswer.Contains("SECONDNAME")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("2") || userAnswer.Contains("ДВЕ") || userAnswer.Contains("TWO")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("НИСКОЛЬКО") || userAnswer.Contains("НОЛЬ") || userAnswer.Contains("НИОДНОГО") || userAnswer.Contains("NONE") || userAnswer.Contains("ZERO") || userAnswer.Contains("NOT")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("ЧАС") || userAnswer.Contains("WATCH")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("НИСКОЛЬКО") || userAnswer.Contains("НОЛЬ") || userAnswer.Contains("НИОДНОГО") || userAnswer.Contains("NONE") || userAnswer.Contains("ZERO") || userAnswer.Contains("NOT")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("ДЖОН") || userAnswer.Contains("JOHN")) isCorrect = true; break;
                    case 18: if ((GlobalVariables.isRussianLanguage == true && userAnswer.Contains("8")) || (GlobalVariables.isRussianLanguage == false && userAnswer.Contains("6"))) isCorrect = true; break;
                    case 19: if ((GlobalVariables.isRussianLanguage == true && userAnswer.Contains("2")) || (GlobalVariables.isRussianLanguage == false && userAnswer.Contains("6"))) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("8836")) isCorrect = true; break;
                    case 21: if (userAnswer.Contains("ГУБКА") || userAnswer.Contains("МОЧАЛКА") || userAnswer.Contains("SPONGE") || userAnswer.Contains("WASHCLOTH")) isCorrect = true; break;
                    case 22: if (userAnswer.Contains("ОГОНЬ") || userAnswer.Contains("ПЛАМЯ") || userAnswer.Contains("FIRE") || userAnswer.Contains("FLAME")) isCorrect = true; break;
                    case 23: if (userAnswer.Contains("СЛОВАР") || userAnswer.Contains("DICTIONARY")) isCorrect = true; break;

                }
                break;
            case (int)GlobalVariables.NameAnimation.ScientistsNotes:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("СЕКРЕТ") || userAnswer.Contains("ТАЙНА") || userAnswer.Contains("SECRET")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("МАМА") || userAnswer.Contains("МАТЬ") || userAnswer.Contains("MOM") || userAnswer.Contains("MOTHER") || userAnswer.Contains("MUM")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("ПОДВОДНАЯЛОДКА") || userAnswer.Contains("ПОДВОДНОЙЛОДКЕ") || userAnswer.Contains("SUBMARINE")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("ШАХМАТНЫЙ") || userAnswer.Contains("CHESS") || userAnswer.Contains("KNIGHT")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("АЭРОПОРТ") || userAnswer.Contains("AIRPORT")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("ЯКОРЬ") || userAnswer.Contains("ANCHOR")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("ОСТАНОВ") || userAnswer.Contains("СЛОМА") || userAnswer.Contains("STOP") || userAnswer.Contains("BROKE")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("НОЛЬ") || userAnswer.Contains("0") || userAnswer.Contains("ОТСУТСТВУЕТ") || userAnswer.Contains("НИСКОЛЬКО") || userAnswer.Contains("НЕТЗЕМЛИ") || userAnswer.Contains("ЗЕМЛИНЕТ") || userAnswer.Contains("ПУСТ") || userAnswer.Contains("ZERO") || userAnswer.Contains("NOEARTH") || userAnswer.Contains("NOGROUND") || userAnswer.Contains("NODIRT") || userAnswer.Contains("EMPTY")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("М") || userAnswer.Contains("M")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("0")) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("8") || userAnswer.Contains("УТР") || userAnswer.Contains("НЕНОЧЬ") || userAnswer.Contains("СВЕТЛ") || userAnswer.Contains("MORNIN") || userAnswer.Contains("NOTNIGHT") || userAnswer.Contains("LIGHT")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("ОТВЕРСТИЕ") || userAnswer.Contains("ДЫР") || userAnswer.Contains("HOLE")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("ВЗЕМЛ") || userAnswer.Contains("INGROUND") || userAnswer.Contains("INTHEGROUND")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("И30") || userAnswer.Contains("J30")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("ПОСЛЕДН") || userAnswer.Contains("LAST")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("НИКОГДА") || userAnswer.Contains("НЕВОЗМОЖНО") || userAnswer.Contains("БЕСКОНЕЧН") || userAnswer.Contains("NEVER") || userAnswer.Contains("IMPOSSIBL") || userAnswer.Contains("INFINITY")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("ТЕНЬ") || userAnswer.Contains("SHADOW")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("ЗУБ") || userAnswer.Contains("КУСАЛК") || userAnswer.Contains("TEETH")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("СТАРЕЮТ") || userAnswer.Contains("СТАРШЕ") || userAnswer.Contains("GETSOLD") || userAnswer.Contains("GETTINGOLD")) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("ШАХМАТ") || userAnswer.Contains("CHESS")) isCorrect = true; break;
                    case 21: if (userAnswer.Contains("ДЫХАНИЕ") || userAnswer.Contains("ВОЗДУХ") || userAnswer.Contains("BREATH")) isCorrect = true; break;
                    case 22: if (userAnswer.Contains("ЛОШАДЬ") || userAnswer.Contains("HORSE")) isCorrect = true; break;
                    case 23: if (userAnswer.Contains("СВОЙПРАВЫЙЛОКОТЬ") || userAnswer.Contains("СВОЮПРАВУЮЛОКОТЬ") || userAnswer.Contains("СВОЮПРАВУЮРУКУ") || userAnswer.Contains("YOURRIGHTELBOW") || userAnswer.Contains("YOURRIGHTARM")) isCorrect = true; break;

                }
                break;
            case (int)GlobalVariables.NameAnimation.ExperimentalProcess:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("ЛЫС") || userAnswer.Contains("БЕЗВОЛОС") || userAnswer.Contains("BALD") || userAnswer.Contains("WITHOUTHAIR") || userAnswer.Contains("HAIRLESS")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("ВЫДУМАН") || userAnswer.Contains("ПРИДУМАН") || userAnswer.Contains("ВЫМЫШЛЕН") || userAnswer.Contains("НЕСУЩЕСТВОВАЛ") || userAnswer.Contains("FICTIONAL") || userAnswer.Contains("INVENTED") || userAnswer.Contains("NEVEREXISTED")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("7") || userAnswer.Contains("СЕМ") || userAnswer.Contains("SEVEN")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("МОКРЫЙ") || userAnswer.Contains("ПОДВОДНЫЙ") || userAnswer.Contains("WET") || userAnswer.Contains("UNDERWATER")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("КОЛЕСО") || userAnswer.Contains("ШИНА") || userAnswer.Contains("WHEEL") || userAnswer.Contains("TIRE")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("УПАСТЬ") || userAnswer.Contains("ПОВЕСИТЬ") || userAnswer.Contains("FALL") || userAnswer.Contains("HANG")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("ОТВЕРСТИЕ") || userAnswer.Contains("ДЫР") || userAnswer.Contains("HOLE")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("СЫНМАРИИ") || userAnswer.Contains("МАРИИСЫН") || userAnswer.Contains("SONOFMARY") || userAnswer.Contains("SONMARY") || userAnswer.Contains("DAUGHTEROFMARY") || userAnswer.Contains("DAUGHTERMARY")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("BELL")) isCorrect = true; break;
                    case 10: if ((GlobalVariables.isRussianLanguage == true && (userAnswer.Contains("17131416") || userAnswer.Contains("СЕМНАДЦАТЬТРИНАДЦАТЬЧЕТЫРНАДЦАТЬШЕСТНАДЦАТЬ"))) || (GlobalVariables.isRussianLanguage == false && (userAnswer.Contains("FOURTEENSEVENTEENSIXTEENTHIRTEEN") || userAnswer.Contains("14171613")))) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("1080")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("СОЛЬ") || userAnswer.Contains("SOL") || userAnswer == "G") isCorrect = true; break;
                    case 13: if (userAnswer.Contains("ВТОРНИК") || userAnswer.Contains("ВТОРОЙДЕНЬНЕДЕЛИ") || userAnswer.Contains("TUESDAY") || userAnswer.Contains("SECONDDAY")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("ДОНАШЕЙЭРЫ") || userAnswer.Contains("ДНЭ") || userAnswer.Contains("ДОН.Э") || userAnswer.Contains("ДОНЭ") || userAnswer.Contains("BC") || userAnswer.Contains("B.C") || userAnswer.Contains("BEFOREOURERA")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("ЗАВТРА") || userAnswer.Contains("СЛЕД") || userAnswer.Contains("TOMORROW") || userAnswer.Contains("NEXTDAY")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("НЕЗАРАЗНАЯ") || userAnswer.Contains("НЕПЕРЕДАЁТ") || userAnswer.Contains("NOTCONTAGIOUS") || userAnswer.Contains("NOTACONTAGIOUS") || userAnswer.Contains("NTACONTAGIOUS") || userAnswer.Contains("NTCONTAGIOUS")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("НЕВСЕТИ") || userAnswer.Contains("ОТКЛЮЧЕНА") || userAnswer.Contains("РАЗРЯЖЕН") || userAnswer.Contains("БАТАР") || userAnswer.Contains("НЕПОДКЛЮЧ") || userAnswer.Contains("NOTONLINE") || userAnswer.Contains("DISCONNECTED") || userAnswer.Contains("DISCHARG") || userAnswer.Contains("LOWBATTERY") || userAnswer.Contains("NOTCONNECTED")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("ПОЧТОВАЯМАРКА") || userAnswer.Contains("POSTAGESTAMP")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("276")) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("ПОЛЫЕ") || userAnswer.Contains("ПУСТЫЕ") || userAnswer.Contains("ВОЗДУХ") || userAnswer.Contains("HOLLOW") || userAnswer.Contains("EMPTY") || userAnswer.Contains("WITHAIR")) isCorrect = true; break;
                    case 21: if (userAnswer.Contains("КИТАЙ") || userAnswer.Contains("CHINESE")) isCorrect = true; break;
                    case 22: if (userAnswer.Contains("5556")) isCorrect = true; break;
                    case 23: if (userAnswer.Contains("ЛЮМИНЕСЦЕНТ") || userAnswer.Contains("LUMINESCENT")) isCorrect = true; break;

                }
                break;
            case (int)GlobalVariables.NameAnimation.AcademicDegree:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("ЧЕЛОВЕК") || userAnswer.Contains("ЛЮД") || userAnswer.Contains("MAN") || userAnswer.Contains("HUMAN") || userAnswer.Contains("PEOPLE")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("КАКТУС") || userAnswer.Contains("CACTUS")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("ВЕС") || userAnswer.Contains("WEIGHT")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("КОЛОКОЛ") || userAnswer.Contains("BELL")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("НИКАКИМ") || userAnswer.Contains("ПЕРЕМОЛОТ") || userAnswer.Contains("УЖЕ") || userAnswer.Contains("NONE") || userAnswer.Contains("ALREADY") || userAnswer.Contains("BEENGROUND")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("ОЗОН") || userAnswer.Contains("OZONE")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("17") || userAnswer.Contains("18")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("КЛУБОК") || userAnswer.Contains("НИТК") || userAnswer.Contains("THREAD") || userAnswer.Contains("BALL")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("СТОЯЛ") || userAnswer.Contains("ЗЕМЛ") || userAnswer.Contains("НЕЛЕТЕЛ") || userAnswer.Contains("НЕВЗЛ") || userAnswer.Contains("ONTHEGROUND") || userAnswer.Contains("NOTTAKEOFF")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("7ЧУДЕС") || userAnswer.Contains("7WONDERS") || userAnswer.Contains("SEVENWONDERS")) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("КЕНГУР") || userAnswer.Contains("KANGAROO")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("ВСАДНИК") || userAnswer.Contains("RIDER")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("ВСТРЕЧ") || userAnswer.Contains("ONCOMING") || userAnswer.Contains("MEET")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("ИЗТУННЕЛ") || userAnswer.Contains("OUTOFTHETUNNEL") || userAnswer.Contains("OUTTUNNEL")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("ЭКВАТОР") || userAnswer.Contains("EQUATOR")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("СПИЧК") || userAnswer.Contains("MATCH")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("НЕПРИВЯЗАНА") || userAnswer.Contains("ЗАБЫЛПРИВЯЗАТЬ") || userAnswer.Contains("ПРИВЯЗАНАНЕ") || userAnswer.Contains("NOTTIED") || userAnswer.Contains("NOTATTACH") || userAnswer.Contains("FORGOTTOTIE") || userAnswer.Contains("FORGOTTIE")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("ЛЁД") || userAnswer.Contains("ЛЕД") || userAnswer.Contains("ICE")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("ВКОТОРОЙЛОЖКА") || userAnswer.Contains("ДЕРЖИШЬ") || userAnswer.Contains("INWHICH") || userAnswer.Contains("KEEP")) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("ЭХО") || userAnswer.Contains("ЭХО-ХО") || userAnswer.Contains("ЭХО-ХО-ХО") || userAnswer.Contains("ЭХО-ХО-О") || userAnswer.Contains("ECHO")) isCorrect = true; break;
                    case 21: if (userAnswer.Contains("ТЕМПЕРАТУР") || userAnswer.Contains("ВРЕМ") || userAnswer.Contains("TEMPERATURE") || userAnswer.Contains("TIME")) isCorrect = true; break;
                    case 22: if (userAnswer.Contains("9970") || userAnswer.Contains("99/70")) isCorrect = true; break;
                    case 23: if (userAnswer.Contains("71") || userAnswer.Contains("СЕМЬДЕСЯТЬОДН") || userAnswer.Contains("SEVENTYFOUR")) isCorrect = true; break;
                    case 24: if (userAnswer.Contains("0") || userAnswer.Contains("НОЛЬ") || userAnswer.Contains("ZERO")) isCorrect = true; break;

                }
                break;
            case (int)GlobalVariables.NameAnimation.SimpleLever:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("4") || userAnswer.Contains("ЧЕТЫРЕ") || userAnswer.Contains("FOUR")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("6") || userAnswer.Contains("ШЕСТЬ") || userAnswer.Contains("SIX")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("ОДИНАКОВ") || userAnswer.Contains("ТАКАЯЖЕ") || userAnswer.Contains("РАВНАЯ") || userAnswer.Contains("SAME") || userAnswer.Contains("EQUAL")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("3") || userAnswer.Contains("ТРИ") || userAnswer.Contains("THREE")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("12") || userAnswer.Contains("ДВЕНАДЦАТЬ") || userAnswer.Contains("TWELVE")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("8") || userAnswer.Contains("ВОСЕМЬ") || userAnswer.Contains("EIGHT")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("6") || userAnswer.Contains("ШЕСТЬ") || userAnswer.Contains("SIX")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("11") || userAnswer.Contains("ОДИННАДЦАТЬ") || userAnswer.Contains("ELEVEN")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("91013")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("235")) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("8")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("1")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("52")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("3") || userAnswer.Contains("ТРИ") || userAnswer.Contains("THREE")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("35")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("209")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("3") || userAnswer.Contains("ТРИ") || userAnswer.Contains("THREE")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("4") || userAnswer.Contains("ЧЕТЫРЕ") || userAnswer.Contains("ЧЕТВЕР") || userAnswer.Contains("FOUR")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("9") || userAnswer.Contains("9И2") || userAnswer.Contains("9AND2") || userAnswer.Contains("NINEANDTWO") || userAnswer.Contains("ДЕВЯТЬИДВА")) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("10") || userAnswer.Contains("ДЕСЯТ") || userAnswer.Contains("TEN")) isCorrect = true; break;
                }
                break;
            case (int)GlobalVariables.NameAnimation.ElementaryLaws:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("24") || userAnswer.Contains("ДВАДЦАТЬЧЕТЫРЕ") || userAnswer.Contains("TWENTYFOUR")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("777+77+7+7")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("8") || userAnswer.Contains("ВОСЕМЬ") || userAnswer.Contains("EIGHT")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("20") || userAnswer.Contains("ДВАДЦАТЬ") || userAnswer.Contains("TWENTY")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("20") || userAnswer.Contains("ДВАДЦАТЬ") || userAnswer.Contains("TWENTY")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("30") || userAnswer.Contains("ТРИДЦАТЬ") || userAnswer.Contains("THIRTY")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("ТРИ") || userAnswer.Contains("3") || userAnswer.Contains("THREE")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("1") || userAnswer.Contains("ОДИН") || userAnswer.Contains("ONE")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("14.50") || userAnswer.Contains("14,50") || userAnswer.Contains("1450")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("180") || userAnswer.Contains("СТОВОСЕМ") || userAnswer.Contains("ONEHUNDREDANDEIGHTY")) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("9.9") || userAnswer.Contains("9,9") || userAnswer.Contains("99")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("32") || userAnswer.Contains("ТРИДЦАТЬДВ") || userAnswer.Contains("THIRTYTWO")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("35") || userAnswer.Contains("ТРИДЦАТЬПЯТЬ") || userAnswer.Contains("THIRTYFIVE")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("18") || userAnswer.Contains("ВОСЕМНДАДЦАТЬ") || userAnswer.Contains("EIGHTEEN")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("90") || userAnswer.Contains("ДЕВЯНОСТО") || userAnswer.Contains("NINETY")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("17") || userAnswer.Contains("СЕМНАДЦАТЬ") || userAnswer.Contains("SEVENTEEN")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("14") || userAnswer.Contains("ЧЕТЫРНАДЦАТЬ") || userAnswer.Contains("FOURTEEN")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("ОДИНАКОВО") || userAnswer.Contains("ПОРОВНУ") || userAnswer.Contains("СТОЛЬКОЖЕ") || userAnswer.Contains("SAME") || userAnswer.Contains("EQUAL")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("6") || userAnswer.Contains("ШЕСТЬ") || userAnswer.Contains("SIX")) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("9") || userAnswer.Contains("ДЕВЯТ") || userAnswer.Contains("NINE")) isCorrect = true; break;
                }
                break;
            case (int)GlobalVariables.NameAnimation.Mechanics:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("377") || userAnswer.Contains("ТРИСТАСЕМЬДЕСЯТСЕМ") || userAnswer.Contains("THREEHUNDREDSEVENTYSEVEN")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("100") || userAnswer.Contains("СТО") || userAnswer.Contains("HUNDRED")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("5") || userAnswer.Contains("ПЯТЬ") || userAnswer.Contains("FIVE")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("35") || userAnswer.Contains("ТРИДЦАТЬПЯТЬ") || userAnswer.Contains("THIRTYFIVE")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("6000") || userAnswer.Contains("ШЕСТЬТЫСЯЧ") || userAnswer.Contains("SIXTHOUSAND")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("281") || userAnswer.Contains("ДВЕСТИВОСЕМЬДЕСЯТОДИН") || userAnswer.Contains("TWOHUNDREDEIGHTYONE")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("78890") || userAnswer.Contains("788.90") || userAnswer.Contains("788,90") || userAnswer.Contains("788ДОЛЛАРОВ90") || userAnswer.Contains("788ДОЛЛАРОВИ90") || userAnswer.Contains("788DOLLARS90") || userAnswer.Contains("788DOLLARSAND90")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("2/7") || userAnswer.Contains("ДВЕСЕДЬМЫХ") || userAnswer.Contains("0.2857") || userAnswer.Contains("0,2857") || userAnswer.Contains("TWOSEVENTHS")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("1") || userAnswer.Contains("ОДИН") || userAnswer.Contains("КИЛОГРАММ") || userAnswer.Contains("ONE") || userAnswer.Contains("KILO")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("72") || userAnswer.Contains("СЕМЬДЕСЯТДВА") || userAnswer.Contains("SEVENTYTWO")) isCorrect = true; break;
                    case 11: if ((userAnswer.Contains("1") && userAnswer.Contains("3")) || (userAnswer.Contains("ОДИН") && userAnswer.Contains("ТРИ")) || (userAnswer.Contains("ONE") && userAnswer.Contains("THREE"))) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("10") || userAnswer.Contains("ДЕСЯТ") || userAnswer.Contains("TEN")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("1/4") || userAnswer.Contains("ОДНАЧЕТВЁРТАЯ") || userAnswer.Contains("25") || userAnswer.Contains("ONEQUARTER")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("6,8") || userAnswer.Contains("6.8") || userAnswer.Contains("68")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("1") || userAnswer.Contains("ОДИН") || userAnswer.Contains("ONE")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("87")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("6") || userAnswer.Contains("ШЕСТЬ") || userAnswer.Contains("SIX")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("121")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("8") && (userAnswer.Contains("04") || userAnswer.Contains("4"))) isCorrect = true; break;
                    case 20: if (userAnswer.Contains("22") || userAnswer.Contains("ДВАДЦАТЬДВ") || userAnswer.Contains("TWENTYTWO")) isCorrect = true; break;
                }
                break;
            case (int)GlobalVariables.NameAnimation.LatestDevelopments:
                switch (NumberLevelsParams)
                {
                    case 1: if (userAnswer.Contains("30") || userAnswer.Contains("ТРИДЦАТЬ") || userAnswer.Contains("THIRTY")) isCorrect = true; break;
                    case 2: if (userAnswer.Contains("18") || userAnswer.Contains("ВОСЕМНАДЦАТЬ") || userAnswer.Contains("EIGHTEEN")) isCorrect = true; break;
                    case 3: if (userAnswer.Contains("5") || userAnswer.Contains("ПЯТЬ") || userAnswer.Contains("FIVE")) isCorrect = true; break;
                    case 4: if (userAnswer.Contains("18") || userAnswer.Contains("ВОСЕНМНДАЦАТЬ") || userAnswer.Contains("EIGHTEEN")) isCorrect = true; break;
                    case 5: if (userAnswer.Contains("321") || userAnswer.Contains("ТРИСТАДВАДЦАТЬОД") || userAnswer.Contains("THREEHUNDREDTWENTYONE")) isCorrect = true; break;
                    case 6: if (userAnswer.Contains("400") || userAnswer.Contains("04") || userAnswer.Contains("0.4") || userAnswer.Contains("0,4")) isCorrect = true; break;
                    case 7: if (userAnswer.Contains("38") && userAnswer.Contains("26")) isCorrect = true; break;
                    case 8: if (userAnswer.Contains("40") || userAnswer.Contains("СОРОК") || userAnswer.Contains("FORTY")) isCorrect = true; break;
                    case 9: if (userAnswer.Contains("30")) isCorrect = true; break;
                    case 10: if (userAnswer.Contains("4") && userAnswer.Contains("1")) isCorrect = true; break;
                    case 11: if (userAnswer.Contains("38100")) isCorrect = true; break;
                    case 12: if (userAnswer.Contains("60") || userAnswer.Contains("ШЕСТЬДЕСЯТ") || userAnswer.Contains("SIXTY")) isCorrect = true; break;
                    case 13: if (userAnswer.Contains("4") || userAnswer.Contains("ЧЕТЫРЕ")) isCorrect = true; break;
                    case 14: if (userAnswer.Contains("12")) isCorrect = true; break;
                    case 15: if (userAnswer.Contains("8") && userAnswer.Contains("5")) isCorrect = true; break;
                    case 16: if (userAnswer.Contains("4") || userAnswer.Contains("ЧЕТЫРЕ") || userAnswer.Contains("FOUR")) isCorrect = true; break;
                    case 17: if (userAnswer.Contains("292") || userAnswer.Contains("293")) isCorrect = true; break;
                    case 18: if (userAnswer.Contains("20") || userAnswer.Contains("50")) isCorrect = true; break;
                    case 19: if (userAnswer.Contains("26") || userAnswer.Contains("ДВАДЦАТЬШЕСТЬ") || userAnswer.Contains("TWENTYSIX")) isCorrect = true; break;

                }
                break;
        }

        GlobalSceneObjects.inputField.GetComponent<InputField>().text = "";
        if (isCorrect == true)
        {
            coroutines.InvokeHideDialogue();
            GlobalSounds.transfer.PlayDelayed(0.07f);    
            Victory.Invoke();
            isCorrect = false;
        }
        else
        {
            if (NumberLevelsParams >= 1000)
            {
                if (NumberLevelsParams == 1000)
                {
                    if (userAnswer.Contains("ПРИВ") || userAnswer.Contains("ЗДОРОВ") || userAnswer.Contains("ДОБРО") || userAnswer.Contains("КУ") || userAnswer.Contains("ТУ-Т")
                        || userAnswer.Contains("ТУТ") || userAnswer.Contains("HELLO") || userAnswer.Contains("HI") || userAnswer.Contains("GREETING") || userAnswer.Contains("TUT"))
                    {
                        if (userAnswer.Contains("ТУ-Т") || userAnswer.Contains("ТУТ") || userAnswer.Contains("TUT"))
                        {                            
                            coroutines.InvokeGetJokeAnswer(7, NumberLevelsParams - 1000, userAnswer);
                        }
                        else
                        {
                            coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                        }
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1001)
                {
                    if (userAnswer.Contains("ЧИЖ") || userAnswer.Contains("ХОИН") || userAnswer.Contains("ХООИН") || userAnswer.Contains("КЁМА") || userAnswer.Contains("КЕМА") || userAnswer.Contains("КАМИНА")
                        || userAnswer.Contains("ДИО") || userAnswer.Contains("ПУТЕШЕСТ") || userAnswer.Contains("СТРАН") || userAnswer.Contains("ГЕРО") || userAnswer.Contains("БОГ")
                        || userAnswer.Contains("CCHIZH") || userAnswer.Contains("HOUOUIN") || userAnswer.Contains("KYOUMA") || userAnswer.Contains("KAMINA")
                        || userAnswer.Contains("DIO") || userAnswer.Contains("TRAVELER") || userAnswer.Contains("WANDERER") || userAnswer.Contains("HERO") || userAnswer.Contains("GOD"))
                    {
                        if (userAnswer.Contains("ЧИЖ") || userAnswer.Contains("ХОИН") || userAnswer.Contains("ХООИН") || userAnswer.Contains("КЁМА") || userAnswer.Contains("КЕМА") || userAnswer.Contains("КАМИНА")
                        || userAnswer.Contains("ДИО") || userAnswer.Contains("CCHIZH") || userAnswer.Contains("HOUOUIN") || userAnswer.Contains("KYOUMA") || userAnswer.Contains("KAMINA")
                        || userAnswer.Contains("DIO"))
                        {
                            if (userAnswer.Contains("ЧИЖ") || userAnswer.Contains("CCHIZH"))
                            {
                                coroutines.InvokeGetJokeAnswer(25, NumberLevelsParams - 1000, userAnswer);
                            }
                            else
                            {
                                coroutines.InvokeGetJokeAnswer(7, NumberLevelsParams - 1000, userAnswer);
                            }

                        }
                        else
                        {
                            coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                        }
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1002)
                {
                    if (userAnswer.Contains("ЭЛЬПСАЙКУНГРУ") || userAnswer.Contains("ЭЛЬПСАЙКОНГРУ") || userAnswer.Contains("ELPSYCONGROO") || userAnswer.Contains("CИМСИМОТКРОЙСЯ"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1003)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1004)
                {
                    if (userAnswer.Contains("2") || userAnswer.Contains("ДВ") || userAnswer.Contains("TWO"))
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1005)
                {
                    if (userAnswer.Contains("6") || userAnswer.Contains("ШЕСТ") || userAnswer.Contains("SIX"))
                    {
                        coroutines.InvokeGetJokeAnswer(6, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1006)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(7, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1007)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1008)
                {
                    if (userAnswer.Contains("THEWORLD") || userAnswer.Contains("ЗЕВОРЛД") || userAnswer.Contains("ЗАВАРУДО") || userAnswer.Contains("ZAWARUDO")
                        || userAnswer.Contains("ДИО") || userAnswer.Contains("ДЖО") || userAnswer.Contains("СЕКУНД") || userAnswer.Contains("SECONDS"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1009)
                {
                    if (userAnswer.Contains("1") || userAnswer.Contains("2") || userAnswer.Contains("3") || userAnswer.Contains("4")
                        || userAnswer.Contains("5") || userAnswer.Contains("6") || userAnswer.Contains("7") || userAnswer.Contains("8") || userAnswer.Contains("9") || userAnswer.Contains("0"))
                    {
                        coroutines.InvokeGetJokeAnswer(12, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(6, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1010)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("YES"))
                    {
                        coroutines.InvokeGetJokeAnswer(12, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1011)
                {
                    if (userAnswer.Contains("32") || userAnswer.Contains("ТРИДЦАТЬДВА") || userAnswer.Contains("THIRTYTWO"))
                    {
                        coroutines.InvokeGetJokeAnswer(32, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(20, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1012)
                {
                    if (userAnswer.Contains("33") || userAnswer.Contains("ТРИДЦАТЬТРИ") || userAnswer.Contains("26") || userAnswer.Contains("TWENTYSIX"))
                    {
                        if (userAnswer.Contains("33") || userAnswer.Contains("ТРИДЦАТЬТРИ"))
                            coroutines.InvokeGetJokeAnswer(32, NumberLevelsParams - 1000, userAnswer);
                        if (userAnswer.Contains("26") || userAnswer.Contains("TWENTYSIX"))
                            coroutines.InvokeGetJokeAnswer(26, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1013)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1014)
                {
                    if (userAnswer.Contains("БЕЛЫ") || userAnswer.Contains("БЕЛО") || userAnswer.Contains("WHITE"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1015)
                {
                    if (userAnswer.Contains("СОЛН") || userAnswer.Contains("ДОЖД") || userAnswer.Contains("СНЕ")
                        || userAnswer.Contains("SUN") || userAnswer.Contains("RAIN") || userAnswer.Contains("SNOW"))
                    {
                        if (userAnswer.Contains("СОЛНЦЕ") || userAnswer.Contains("SUN"))
                            coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                        if (userAnswer.Contains("ДОЖДЬ") || userAnswer.Contains("RAIN"))
                            coroutines.InvokeGetJokeAnswer(9, NumberLevelsParams - 1000, userAnswer);
                        if (userAnswer.Contains("СНЕГ") || userAnswer.Contains("SNOW"))
                            coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1016)
                {
                    if (userAnswer.Contains("ВЕСН") || userAnswer.Contains("ЛЕТ") || userAnswer.Contains("ОСЕН") || userAnswer.Contains("ЗИМ")
                        || userAnswer.Contains("SPRING") || userAnswer.Contains("SUMMER") || userAnswer.Contains("FALL") || userAnswer.Contains("AUTUMN") || userAnswer.Contains("WINTER"))
                    {
                        coroutines.InvokeGetJokeAnswer(15, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1017)
                {
                    if (userAnswer.Contains("0") || userAnswer.Contains("1") || userAnswer.Contains("2") || userAnswer.Contains("3")
                        || userAnswer.Contains("4") || userAnswer.Contains("5") || userAnswer.Contains("6") || userAnswer.Contains("7") || userAnswer.Contains("8") || userAnswer.Contains("9"))
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1018)
                {
                    if (userAnswer.Contains("0") || userAnswer.Contains("1") || userAnswer.Contains("2") || userAnswer.Contains("3")
                        || userAnswer.Contains("4") || userAnswer.Contains("5") || userAnswer.Contains("6") || userAnswer.Contains("7") || userAnswer.Contains("8") || userAnswer.Contains("9"))
                    {
                        coroutines.InvokeGetJokeAnswer(9, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1019)
                {
                    if (userAnswer.Contains("0") || userAnswer.Contains("1") || userAnswer.Contains("2") || userAnswer.Contains("3")
                        || userAnswer.Contains("4") || userAnswer.Contains("5") || userAnswer.Contains("6") || userAnswer.Contains("7") || userAnswer.Contains("8") || userAnswer.Contains("9"))
                    {
                        coroutines.InvokeGetJokeAnswer(18, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1020)
                {
                    if (userAnswer.Contains("-273.15") || userAnswer.Contains("-273,15") || userAnswer.Contains("-459,67")
                        || userAnswer.Contains("-459.67"))
                    {
                        if (userAnswer.Contains("-273.15") || userAnswer.Contains("-273,15"))
                            coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                        if (userAnswer.Contains("-459,67") || userAnswer.Contains("-459.67"))
                            coroutines.InvokeGetJokeAnswer(6, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1021)
                {
                    if (userAnswer.Contains("КРУГЛАЯ") || userAnswer.Contains("ПЛОСКАЯ") || userAnswer.Contains("ШАР") || userAnswer.Contains("ГЕОИД")
                        || userAnswer.Contains("ROUND") || userAnswer.Contains("FLAT") || userAnswer.Contains("GEOID"))
                    {
                        if (userAnswer.Contains("КРУГЛАЯ") || userAnswer.Contains("ШАР") || userAnswer.Contains("ROUND"))
                            coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                        if (userAnswer.Contains("ГЕОИД") || userAnswer.Contains("GEOID"))
                            coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                        if (userAnswer.Contains("ПЛОСКАЯ") || userAnswer.Contains("FLAT"))
                            coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1022)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1023)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1024)
                {
                    if (userAnswer.Contains("60") || userAnswer.Contains("ШЕСТЬДЕСЯТ") || userAnswer.Contains("SIXTY"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1025)
                {
                    if (userAnswer.Contains("ВОДОРОД") || userAnswer.Contains("ГИДРОГЕН") || userAnswer.Contains("HYDROGEN"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1026)
                {
                    if (userAnswer.Contains("ВСЁДОЗВОЛЕНО") || userAnswer.Contains("CUCUMBER"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1027)
                {
                    if (userAnswer.Contains("Я") || userAnswer.Contains("I"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1028)
                {
                    if (userAnswer.Contains("МАГМА") || userAnswer.Contains("MAGMA"))
                    {
                        coroutines.InvokeGetJokeAnswer(20, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1029)
                {
                    if (userAnswer.Contains("СИНИ") || userAnswer.Contains("КРАС") || userAnswer.Contains("BLUE") || userAnswer.Contains("RED"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1030)
                {
                    if (userAnswer.Contains("2") || userAnswer.Contains("ДВ") || userAnswer.Contains("TWO"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1031)
                {
                    if (userAnswer.Contains("2") || userAnswer.Contains("ДВ") || userAnswer.Contains("TWO"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1032)
                {
                    if (userAnswer.Contains("ДА") || userAnswer.Contains("КОНЕЧНО") || userAnswer.Contains("ЕСТЕСТВЕННО") || userAnswer.Contains("ОПРЕДЕЛЁННО")
                        || userAnswer.Contains("БЕЗУСЛОВНО") || userAnswer.Contains("YE") || userAnswer.Contains("OFCOURSE"))
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1033)
                {
                    coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                }
                if (NumberLevelsParams == 1034)
                {
                    if (userAnswer.Contains("8") || userAnswer.Contains("ВОСЕМЬ") || userAnswer.Contains("EIGHT"))
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1035)
                {
                    if (userAnswer.Contains("АНДРОМЕД") || userAnswer.Contains("ANDROMEDA"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1036)
                {
                    if (userAnswer.Contains("ЗЕМЛЯ") || userAnswer.Contains("EARTH"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1037)
                {
                    if (userAnswer.Contains("ЛУНА") || userAnswer.Contains("MOON"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1038)
                {
                    if (userAnswer.Contains("БЕЛЫЙ") || userAnswer.Contains("WHITE"))
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1039)
                {
                    if (userAnswer.Contains("ЛОНДОН") || userAnswer.Contains("LONDON"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1040)
                {
                    if (userAnswer.Contains("ТОКИО") || userAnswer.Contains("TOKYO"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1041)
                {
                    if (userAnswer.Contains("ФОТОН") || userAnswer.Contains("PHOTON"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(1, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1042)
                {
                    if (userAnswer.Contains("ВВЕРХ") || userAnswer.Contains("ВНИЗ") || userAnswer.Contains("ВЕРХ")
                        || userAnswer.Contains("UP") || userAnswer.Contains("DOWN"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(4, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1043)
                {
                    if (userAnswer.Contains("МУРАВЕЙ") || userAnswer.Contains("ANT"))
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(3, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1044)
                {
                    if (userAnswer.Contains("ТЕРМОМЕТР") || userAnswer.Contains("THERMOMETR"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1045)
                {
                    if (userAnswer.Contains("B") || userAnswer.Contains("В") || userAnswer.Contains("БЕЙКЕРСТРИТ") || userAnswer.Contains("БЕЙКЕР-СТРИТ") || userAnswer.Contains("BAKERST"))
                    {
                        coroutines.InvokeGetJokeAnswer(7, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(2, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1046)
                {
                    if (userAnswer.Contains("5") || userAnswer.Contains("ПЯТ") || userAnswer.Contains("FIVE"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(15, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1047)
                {
                    if (userAnswer.Contains("АНИМЕ") || userAnswer.Contains("ЛЮБОВЬ") || userAnswer.Contains("КРУТО")
                        || userAnswer.Contains("ANIME") || userAnswer.Contains("LOVE") || userAnswer.Contains("COOL"))
                    {
                        coroutines.InvokeGetJokeAnswer(25, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(8, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1048)
                {
                    if (userAnswer.Contains("ДЕРЕВ"))
                    {
                        coroutines.InvokeGetJokeAnswer(5, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(10, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1049)
                {
                    if (userAnswer.Contains("ЛУН") || userAnswer.Contains("MOON") || userAnswer.Contains("ТУЧ") || userAnswer.Contains("НЕБ") || userAnswer.Contains("SKY"))
                    {
                        coroutines.InvokeGetJokeAnswer(20, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(15, NumberLevelsParams - 1000, userAnswer);
                    }
                }
                if (NumberLevelsParams == 1050)
                {
                    if (userAnswer.Contains("ЗЕЛЁНЫЙ") || userAnswer.Contains("ЗЕЛЕН") || userAnswer.Contains("GREEN"))
                    {
                        coroutines.InvokeGetJokeAnswer(200, NumberLevelsParams - 1000, userAnswer);
                    }
                    else
                    {
                        coroutines.InvokeGetJokeAnswer(200, NumberLevelsParams - 1000, userAnswer);
                    }
                }
            }
            else
            {
                coroutines.InvokeHideDialogue();
                IncorrectAnswer.Invoke();
            }

        }
    }

    
}
