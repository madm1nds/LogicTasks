using UnityEngine;
/// <summary>
/// A global class that contains all used sprites.
/// </summary>
public static class GlobalSprites
{
    public static Sprite[] spritesStarsLevels = new Sprite[9];

    public static Sprite spriteSoundOn;
    public static Sprite spriteSoundOff;

    public static Sprite spriteLanguageRusOn;
    public static Sprite spriteLanguageRusOff;
    public static Sprite spriteLanguageEngOn;
    public static Sprite spriteLanguageEngOff;
    public static Sprite spriteStartGameRus;
    public static Sprite spriteStartGameEng;
    public static Sprite spriteAboutUsRus;
    public static Sprite spriteAboutUsEng;
    public static Sprite spriteWriteUsRus;
    public static Sprite spriteWriteUsEng;
    public static Sprite spriteExitRus;
    public static Sprite spriteExitEng;

    public static Sprite spriteMainMenuRus;
    public static Sprite spriteMainMenuEng;
    public static Sprite spriteChooseLvlRus;
    public static Sprite spriteChooseLvlEng;

    public static Sprite spriteContinueMenuRus;
    public static Sprite spriteContinueMenuEng;
    public static Sprite spriteHelpLvlRus;
    public static Sprite spriteHelpLvlEng;
    public static Sprite spriteSubmitLvlRus;
    public static Sprite spriteSubmitLvlEng;

    public static Sprite spriteSkipRus;
    public static Sprite spriteSkipEng;
    public static Sprite spriteSkipYesRus;
    public static Sprite spriteSkipYesEng;
    public static Sprite spriteSkipNoRus;
    public static Sprite spriteSkipNoEng;
    public static Sprite spriteRateLaterRus;
    public static Sprite spriteRateLaterEng;

    public static Sprite spriteLevelTextRus;
    public static Sprite spriteLevelTextEng;

    public static Sprite[] spriteNumberLevel = new Sprite[10];
    public static Sprite spriteYourAnswerRus;
    public static Sprite spriteYourAnswerEng;


    public static void InitializingGlobalSprites()
    {
        spritesStarsLevels[0] = Resources.Load<Sprite>("Sprites/spriteStarsOnSimpleLever");
        spritesStarsLevels[1] = Resources.Load<Sprite>("Sprites/spriteStarsOnBestPractices");
        spritesStarsLevels[2] = Resources.Load<Sprite>("Sprites/spriteStarsOnNotesOfAScient");

        spritesStarsLevels[3] = Resources.Load<Sprite>("Sprites/spriteStarsOnExperimental");
        spritesStarsLevels[4] = Resources.Load<Sprite>("Sprites/spriteStarsOnLastLevels");
        spritesStarsLevels[5] = Resources.Load<Sprite>("Sprites/spriteStarsOnSimpleLever");
        spritesStarsLevels[6] = Resources.Load<Sprite>("Sprites/spriteStarsOnElementaryLaws");
        spritesStarsLevels[7] = Resources.Load<Sprite>("Sprites/spriteStarsOnMechanics");
        spritesStarsLevels[8] = Resources.Load<Sprite>("Sprites/spriteStarsOnLastLevels");

        
        spriteSoundOn = Resources.Load<Sprite>("Sprites/spriteSoundOn");
        spriteSoundOff = Resources.Load<Sprite>("Sprites/spriteSoundOff");

        spriteLanguageRusOn = Resources.Load<Sprite>("Sprites/spriteLanguageRusOn");
        spriteLanguageRusOff = Resources.Load<Sprite>("Sprites/spriteLanguageRusOff");
        spriteLanguageEngOn = Resources.Load<Sprite>("Sprites/spriteLanguageEngOn");
        spriteLanguageEngOff = Resources.Load<Sprite>("Sprites/spriteLanguageEngOff");
        spriteStartGameRus = Resources.Load<Sprite>("Sprites/spriteStartGameRus");
        spriteStartGameEng = Resources.Load<Sprite>("Sprites/spriteStartGameEng");
        spriteAboutUsRus = Resources.Load<Sprite>("Sprites/spriteAboutUsRus");
        spriteAboutUsEng = Resources.Load<Sprite>("Sprites/spriteAboutUsEng");
        spriteWriteUsRus = Resources.Load<Sprite>("Sprites/spriteWriteUsRus");
        spriteWriteUsEng = Resources.Load<Sprite>("Sprites/spriteWriteUsEng");
        spriteExitRus = Resources.Load<Sprite>("Sprites/spriteExitRus");
        spriteExitEng = Resources.Load<Sprite>("Sprites/spriteExitEng");

        spriteMainMenuRus = Resources.Load<Sprite>("Sprites/spriteMainMenuRus");
        spriteMainMenuEng = Resources.Load<Sprite>("Sprites/spriteMainMenuEng");
        spriteChooseLvlRus = Resources.Load<Sprite>("Sprites/spriteChooseLvlRus");
        spriteChooseLvlEng = Resources.Load<Sprite>("Sprites/spriteChooseLvlEng");

        spriteContinueMenuRus = Resources.Load<Sprite>("Sprites/spriteContinueRus");
        spriteContinueMenuEng = Resources.Load<Sprite>("Sprites/spriteContinueEng");
        spriteHelpLvlRus = Resources.Load<Sprite>("Sprites/spriteHelpLvlRus");
        spriteHelpLvlEng = Resources.Load<Sprite>("Sprites/spriteHelpLvlEng");
        spriteSubmitLvlRus = Resources.Load<Sprite>("Sprites/spriteSubmitLvlRus");
        spriteSubmitLvlEng = Resources.Load<Sprite>("Sprites/spriteSubmitLvlEng");

        spriteSkipRus = Resources.Load<Sprite>("Sprites/spriteSkipRus");
        spriteSkipEng = Resources.Load<Sprite>("Sprites/spriteSkipEng");
        spriteSkipYesRus = Resources.Load<Sprite>("Sprites/spriteSkipYesRus");
        spriteSkipYesEng = Resources.Load<Sprite>("Sprites/spriteSkipYesEng");
        spriteSkipNoRus = Resources.Load<Sprite>("Sprites/spriteSkipNoRus");
        spriteSkipNoEng = Resources.Load<Sprite>("Sprites/spriteSkipNoEng");
        spriteRateLaterRus = Resources.Load<Sprite>("Sprites/spriteLaterRus");
        spriteRateLaterEng = Resources.Load<Sprite>("Sprites/spriteLaterEng");

        spriteLevelTextRus = Resources.Load<Sprite>("Sprites/spriteLevelTextRus");
        spriteLevelTextEng = Resources.Load<Sprite>("Sprites/spriteLevelTextEng");

        spriteNumberLevel[0] = Resources.Load<Sprite>("Sprites/0forLevel");
        spriteNumberLevel[1] = Resources.Load<Sprite>("Sprites/1forLevel");
        spriteNumberLevel[2] = Resources.Load<Sprite>("Sprites/2forLevel");
        spriteNumberLevel[3] = Resources.Load<Sprite>("Sprites/3forLevel");
        spriteNumberLevel[4] = Resources.Load<Sprite>("Sprites/4forLevel");
        spriteNumberLevel[5] = Resources.Load<Sprite>("Sprites/5forLevel");
        spriteNumberLevel[6] = Resources.Load<Sprite>("Sprites/6forLevel");
        spriteNumberLevel[7] = Resources.Load<Sprite>("Sprites/7forLevel");
        spriteNumberLevel[8] = Resources.Load<Sprite>("Sprites/8forLevel");
        spriteNumberLevel[9] = Resources.Load<Sprite>("Sprites/9forLevel");

        spriteYourAnswerRus = Resources.Load<Sprite>("Sprites/spriteYourAnswerRus");
        spriteYourAnswerEng = Resources.Load<Sprite>("Sprites/spriteYourAnswerEng");
    }
}