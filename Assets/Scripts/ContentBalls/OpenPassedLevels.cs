using System;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Finds all passed levels. Unlocks access to new levels in each ball.
/// Controls the lighting of the buttons and stars below them.
/// </summary>
public static class OpenPassedLevels
{
    public static void Open()
    {
        CheckPassedLevel.Check();
        int passedTasks = 0;
        int passedInRow = 0;
        int currentLevel = 0;
        Vector4 normalColor = new Vector4(255, 255, 255, 1);
        Vector4 redColor = new Vector4(255, 0, 0, 1);
        
        for (int numberBall = 0; numberBall < GlobalSaves.saveInGame.Length; numberBall++)
        {
            currentLevel = 0;
            passedTasks = 0;
            
            for (int row = 0; row < GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").childCount; row++)
            {
                passedInRow = 0;
                try
                {                    
                    for (int columnInPreviousRow = 0; columnInPreviousRow < GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row - 1).childCount; columnInPreviousRow++)
                    {
                        if (GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row - 1).GetChild(columnInPreviousRow).name.Contains("Level"))
                        {
                            if (GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row - 1).GetChild(columnInPreviousRow).Find("Star").GetComponent<Image>().color == (Color)normalColor
                             || GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row - 1).GetChild(columnInPreviousRow).Find("Star").GetComponent<Image>().color == (Color)redColor)
                            {
                                passedInRow++;
                            }
                        }
                    }
                }
                catch (Exception){}                
                if (GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).name.Contains("Level"))
                {                    
                    for (int column = 0; column < GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).childCount; column++)
                    {                        
                        if (GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).name.Contains("Level"))
                        {
                            currentLevel++;
                            try
                            {
                                //Open 7-9 level when passing 5 levels
                                if ((GlobalSaves.saveInGame[numberBall].isRateLevelsCheck[currentLevel] == true || GlobalSaves.saveInGame[numberBall].isSkipRateLevelsCheck[currentLevel] == true) && currentLevel <= 6) passedTasks++;
                                if (passedTasks >= 5 && (currentLevel == 7 || currentLevel == 8 || currentLevel == 9))
                                {
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Level").GetComponent<Button>().interactable = true;
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Level").Find("mark").gameObject.SetActive(false);
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Level").Find("Image").gameObject.SetActive(true);                                 
                                }
                            }
                            catch (Exception) { }
                            try
                            {
                                //open 10+ levels
                                if (passedInRow >= 2 && GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row - 1).GetChild(column).Find("Level").GetChild(1).name.Contains("mark"))
                                {
                                    for (int currentColumn = 0; currentColumn <= column; currentColumn++)
                                    {

                                        GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column - currentColumn).Find("Level").GetComponent<Button>().interactable = true;
                                        GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column - currentColumn).Find("Level").Find("mark").gameObject.SetActive(false);
                                        GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column - currentColumn).Find("Level").Find("Image").gameObject.SetActive(true);
                                    }  
                                }
                            }
                            catch (Exception) { }

                            try
                            {
                                // If the level is skipped
                                if (GlobalSaves.saveInGame[numberBall].isSkipRateLevelsCheck[currentLevel] == true && GlobalSaves.saveInGame[numberBall].isRateLevelsCheck[currentLevel] == false)
                                {
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Star").GetComponent<Image>().sprite = GlobalSprites.spritesStarsLevels[numberBall];
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Star").GetComponent<Image>().color = new Vector4(255, 0, 0, 1);// red color                                                                                                                                                                                                                          
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Star").Find("Lighting").gameObject.SetActive(true);
                                }
                                //If the level is not skipped
                                if (GlobalSaves.saveInGame[numberBall].isRateLevelsCheck[currentLevel] == true)
                                {
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Star").GetComponent<Image>().sprite = GlobalSprites.spritesStarsLevels[numberBall];
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Star").GetComponent<Image>().color = new Vector4(255, 255, 255, 1);// normal color                                                                                                                                                                                                                              
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("Star").Find("Lighting").gameObject.SetActive(true);
                                    GlobalSceneObjects.contentBalls.transform.GetChild(numberBall).Find("Content").GetChild(row).GetChild(column).Find("ButtonLighting").gameObject.SetActive(true);
                                }
                            }
                            catch (Exception) { }
                        }
                    }
                }
            }
        }
    }
}


